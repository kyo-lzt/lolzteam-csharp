using System.Net;
using System.Text;
using System.Text.Json;

namespace Lolzteam.Api.Runtime;

public sealed class LolzteamHttpClient : IDisposable
{
	private readonly ClientConfig _config;
	private readonly HttpClient _httpClient;
	private readonly bool _ownsHttpClient;
	private readonly RateLimiter? _rateLimiter;
	private readonly RateLimiter? _searchRateLimiter;
	private bool _disposed;

	public LolzteamHttpClient(ClientConfig config, HttpClient? httpClient = null)
	{
		if (string.IsNullOrEmpty(config.BaseUrl))
		{
			throw new ConfigException("BaseUrl must not be null or empty.");
		}

		_config = config;

		if (httpClient is not null)
		{
			_httpClient = httpClient;
			_ownsHttpClient = false;
		}
		else
		{
			var handler = CreateHandler(config.Proxy);
			_httpClient = new HttpClient(handler, disposeHandler: true);
			_ownsHttpClient = true;
		}

		_httpClient.DefaultRequestHeaders.Authorization =
			new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", config.Token);

		if (config.RateLimit is { } rl)
		{
			_rateLimiter = new RateLimiter(rl.RequestsPerMinute);
		}

		if (config.SearchRateLimit is { } srl)
		{
			_searchRateLimiter = new RateLimiter(srl.RequestsPerMinute);
		}
	}

	public async Task<JsonElement> RequestAsync(RequestOptions options, CancellationToken cancellationToken = default)
	{
		ObjectDisposedException.ThrowIf(_disposed, this);

		if (_rateLimiter is not null)
		{
			await _rateLimiter.AcquireAsync(cancellationToken).ConfigureAwait(false);
		}

		if (options.IsSearch && _searchRateLimiter is not null)
		{
			await _searchRateLimiter.AcquireAsync(cancellationToken).ConfigureAwait(false);
		}

		return await RetryHandler.WithRetryAsync(_config.Retry, () => ExecuteAsync(options, cancellationToken))
			.ConfigureAwait(false);
	}

	private async Task<JsonElement> ExecuteAsync(RequestOptions options, CancellationToken cancellationToken)
	{
		try
		{
			var url = BuildUrl(options.Path, options.Query);
			using var request = new HttpRequestMessage(new HttpMethod(options.Method), url);
			SetBody(request, options);

			using var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
			var responseBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

			if (!response.IsSuccessStatusCode)
			{
				throw HttpException.Create((int)response.StatusCode, responseBody, response.Headers);
			}

			if (string.IsNullOrEmpty(responseBody))
			{
				return default;
			}

			using var document = JsonDocument.Parse(responseBody);
			return document.RootElement.Clone();
		}
		catch (LolzteamException)
		{
			throw;
		}
		catch (HttpRequestException ex)
		{
			throw new NetworkException("HTTP request failed.", ex);
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			throw new NetworkException("Request timed out.", ex);
		}
		catch (TaskCanceledException)
		{
			throw;
		}
	}

	private string BuildUrl(string path, JsonElement? query)
	{
		var sb = new StringBuilder(_config.BaseUrl!.TrimEnd('/'));
		sb.Append(path);

		if (query is { ValueKind: JsonValueKind.Object } q)
		{
			var separator = '?';
			foreach (var prop in q.EnumerateObject())
			{
				if (prop.Value.ValueKind == JsonValueKind.Null)
				{
					continue;
				}

				if (prop.Value.ValueKind == JsonValueKind.Array)
				{
					foreach (var item in prop.Value.EnumerateArray())
					{
						sb.Append(separator);
						sb.Append(Uri.EscapeDataString(prop.Name));
						sb.Append('=');
						sb.Append(Uri.EscapeDataString(FormatValue(item)));
						separator = '&';
					}
				}
				else
				{
					sb.Append(separator);
					sb.Append(Uri.EscapeDataString(prop.Name));
					sb.Append('=');
					sb.Append(Uri.EscapeDataString(FormatValue(prop.Value)));
					separator = '&';
				}
			}
		}

		return sb.ToString();
	}

	private static void SetBody(HttpRequestMessage request, RequestOptions options)
	{
		if (options.Body is not { ValueKind: JsonValueKind.Object } body
			&& options.ByteArrayFields is not { Count: > 0 })
		{
			return;
		}

		switch (options.BodyEncoding)
		{
			case BodyEncoding.Json:
				var json = options.Body is { } b
					? JsonSerializer.Serialize(b)
					: "{}";
				request.Content = new StringContent(json, Encoding.UTF8, "application/json");
				break;

			case BodyEncoding.Multipart:
				var multipart = new MultipartFormDataContent();
				if (options.Body is { ValueKind: JsonValueKind.Object } mb)
				{
					foreach (var prop in mb.EnumerateObject())
					{
						if (prop.Value.ValueKind == JsonValueKind.Null) continue;
						multipart.Add(new StringContent(FormatValue(prop.Value)), prop.Name);
					}
				}
				if (options.ByteArrayFields is { } fields)
				{
					foreach (var (name, data) in fields)
					{
						var byteContent = new ByteArrayContent(data);
						multipart.Add(byteContent, name, name);
					}
				}
				request.Content = multipart;
				break;

			case BodyEncoding.Form:
			default:
				if (options.Body is { ValueKind: JsonValueKind.Object } fb)
				{
					var pairs = new List<KeyValuePair<string, string>>();
					foreach (var prop in fb.EnumerateObject())
					{
						if (prop.Value.ValueKind == JsonValueKind.Null) continue;
						if (prop.Value.ValueKind == JsonValueKind.Array)
						{
							foreach (var item in prop.Value.EnumerateArray())
							{
								pairs.Add(new KeyValuePair<string, string>(prop.Name, FormatValue(item)));
							}
						}
						else
						{
							pairs.Add(new KeyValuePair<string, string>(prop.Name, FormatValue(prop.Value)));
						}
					}
					request.Content = new FormUrlEncodedContent(pairs);
				}
				break;
		}
	}

	private static string FormatValue(JsonElement element) => element.ValueKind switch
	{
		JsonValueKind.True => "1",
		JsonValueKind.False => "0",
		JsonValueKind.Number => element.GetRawText(),
		JsonValueKind.String => element.GetString() ?? "",
		_ => element.GetRawText(),
	};

	private static HttpClientHandler CreateHandler(ProxyConfig? proxyConfig)
	{
		var handler = new HttpClientHandler();

		if (proxyConfig is null)
		{
			return handler;
		}

		if (!Uri.TryCreate(proxyConfig.Url, UriKind.Absolute, out var proxyUri))
		{
			throw new ConfigException($"Invalid proxy URL: {proxyConfig.Url}");
		}

		var scheme = proxyUri.Scheme.ToLowerInvariant();
		if (scheme is not ("http" or "https" or "socks5"))
		{
			throw new ConfigException($"Unsupported proxy scheme: {scheme}. Supported: http, https, socks5.");
		}

		handler.Proxy = new WebProxy(proxyUri);
		handler.UseProxy = true;

		return handler;
	}

	public void Dispose()
	{
		if (_disposed) return;
		_disposed = true;
		_rateLimiter?.Dispose();
		_searchRateLimiter?.Dispose();
		if (_ownsHttpClient)
		{
			_httpClient.Dispose();
		}
	}
}
