using System.Net;
using System.Net.Sockets;
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

		if (config.Timeout is { } timeout)
		{
			_httpClient.Timeout = timeout;
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

	/// <summary>
	/// Send a request and return the raw response body as a string.
	/// Used for endpoints that return non-JSON content (e.g. text/html).
	/// </summary>
	public async Task<string> RequestRawAsync(RequestOptions options, CancellationToken cancellationToken = default)
	{
#if NET7_0_OR_GREATER
		ObjectDisposedException.ThrowIf(_disposed, this);
#else
		if (_disposed) throw new ObjectDisposedException(GetType().FullName);
#endif

		if (_config.Retry is not { } retryConfig)
		{
			await AcquireRateLimitAsync(options, cancellationToken).ConfigureAwait(false);
			return await ExecuteRawAsync(options, cancellationToken).ConfigureAwait(false);
		}

		return await RetryHandler.WithRetryAsync(
				retryConfig,
				async () =>
				{
					await AcquireRateLimitAsync(options, cancellationToken).ConfigureAwait(false);
					return await ExecuteRawAsync(options, cancellationToken).ConfigureAwait(false);
				},
				_config.OnRetry,
				options.Method,
				options.Path)
			.ConfigureAwait(false);
	}

	public async Task<JsonElement> RequestAsync(RequestOptions options, CancellationToken cancellationToken = default)
	{
#if NET7_0_OR_GREATER
		ObjectDisposedException.ThrowIf(_disposed, this);
#else
		if (_disposed) throw new ObjectDisposedException(GetType().FullName);
#endif

		if (_config.Retry is not { } retryConfig)
		{
			await AcquireRateLimitAsync(options, cancellationToken).ConfigureAwait(false);
			return await ExecuteAsync(options, cancellationToken).ConfigureAwait(false);
		}

		return await RetryHandler.WithRetryAsync(
				retryConfig,
				async () =>
				{
					await AcquireRateLimitAsync(options, cancellationToken).ConfigureAwait(false);
					return await ExecuteAsync(options, cancellationToken).ConfigureAwait(false);
				},
				_config.OnRetry,
				options.Method,
				options.Path)
			.ConfigureAwait(false);
	}

	private async Task AcquireRateLimitAsync(RequestOptions options, CancellationToken cancellationToken)
	{
		if (_rateLimiter is not null)
		{
			await _rateLimiter.AcquireAsync(cancellationToken).ConfigureAwait(false);
		}

		if (options.IsSearch && _searchRateLimiter is not null)
		{
			await _searchRateLimiter.AcquireAsync(cancellationToken).ConfigureAwait(false);
		}
	}

	private async Task<string> ExecuteRawAsync(RequestOptions options, CancellationToken cancellationToken)
	{
		try
		{
			var url = BuildUrl(options.Path, options.Query);
			using var request = new HttpRequestMessage(new HttpMethod(options.Method), url);
			SetBody(request, options);

			using var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
#if NET5_0_OR_GREATER
			var responseBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
#else
			var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
#endif

			if (!response.IsSuccessStatusCode)
			{
				throw HttpException.Create((int)response.StatusCode, responseBody, response.Headers);
			}

			return responseBody;
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

	private async Task<JsonElement> ExecuteAsync(RequestOptions options, CancellationToken cancellationToken)
	{
		try
		{
			var url = BuildUrl(options.Path, options.Query);
			using var request = new HttpRequestMessage(new HttpMethod(options.Method), url);
			SetBody(request, options);

			using var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
#if NET5_0_OR_GREATER
			var responseBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
#else
			var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
#endif

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
					foreach (var field in fields)
					{
						var byteContent = new ByteArrayContent(field.Value);
						multipart.Add(byteContent, field.Key, field.Key);
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

#if NET5_0_OR_GREATER
	private static SocketsHttpHandler CreateHandler(ProxyConfig? proxyConfig)
	{
		var handler = new SocketsHttpHandler();

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

		if (scheme is "socks5")
		{
			var proxyHost = proxyUri.Host;
			var proxyPort = proxyUri.Port > 0 ? proxyUri.Port : 1080;
			var userInfo = proxyUri.UserInfo;
			string? username = null;
			string? password = null;

			if (!string.IsNullOrEmpty(userInfo))
			{
				var parts = userInfo.Split(':', 2);
				username = Uri.UnescapeDataString(parts[0]);
				password = parts.Length > 1 ? Uri.UnescapeDataString(parts[1]) : null;
			}

			handler.ConnectCallback = async (context, cancellationToken) =>
			{
				var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
				try
				{
					await socket.ConnectAsync(proxyHost, proxyPort, cancellationToken)
						.ConfigureAwait(false);
					await Socks5Handshake(
							socket,
							context.DnsEndPoint.Host,
							context.DnsEndPoint.Port,
							username,
							password,
							cancellationToken)
						.ConfigureAwait(false);
					return new NetworkStream(socket, ownsSocket: true);
				}
				catch
				{
					socket.Dispose();
					throw;
				}
			};
		}
		else
		{
			handler.Proxy = new WebProxy(proxyUri);
			handler.UseProxy = true;
		}

		return handler;
	}

	private static async Task Socks5Handshake(
		Socket socket,
		string targetHost,
		int targetPort,
		string? username,
		string? password,
		CancellationToken cancellationToken)
	{
		var hasAuth = username is not null && password is not null;

		// Greeting: version, number of methods, methods
		byte[] greeting = hasAuth
			? [0x05, 0x02, 0x00, 0x02] // no auth + username/password
			: [0x05, 0x01, 0x00];       // no auth only

		await socket.SendAsync(greeting, SocketFlags.None, cancellationToken).ConfigureAwait(false);

		var greetingResponse = new byte[2];
		await ReadExactAsync(socket, greetingResponse, cancellationToken).ConfigureAwait(false);

		if (greetingResponse[0] != 0x05)
		{
			throw new NetworkException(
				"SOCKS5 proxy returned invalid version.",
				new InvalidOperationException($"Expected version 0x05, got 0x{greetingResponse[0]:X2}."));
		}

		var chosenMethod = greetingResponse[1];

		if (chosenMethod == 0x02 && hasAuth)
		{
			// Username/password auth (RFC 1929)
			var usernameBytes = Encoding.UTF8.GetBytes(username!);
			var passwordBytes = Encoding.UTF8.GetBytes(password!);

			var authRequest = new byte[3 + usernameBytes.Length + passwordBytes.Length];
			authRequest[0] = 0x01; // sub-negotiation version
			authRequest[1] = (byte)usernameBytes.Length;
			usernameBytes.CopyTo(authRequest, 2);
			authRequest[2 + usernameBytes.Length] = (byte)passwordBytes.Length;
			passwordBytes.CopyTo(authRequest, 3 + usernameBytes.Length);

			await socket.SendAsync(authRequest, SocketFlags.None, cancellationToken)
				.ConfigureAwait(false);

			var authResponse = new byte[2];
			await ReadExactAsync(socket, authResponse, cancellationToken).ConfigureAwait(false);

			if (authResponse[1] != 0x00)
			{
				throw new NetworkException(
					"SOCKS5 proxy authentication failed.",
					new InvalidOperationException($"Auth status: 0x{authResponse[1]:X2}."));
			}
		}
		else if (chosenMethod != 0x00)
		{
			throw new NetworkException(
				"SOCKS5 proxy requires unsupported authentication method.",
				new InvalidOperationException($"Method: 0x{chosenMethod:X2}."));
		}

		// Connect request: version, cmd=connect, reserved, address type=domain, len, host, port
		var hostBytes = Encoding.UTF8.GetBytes(targetHost);
		var connectRequest = new byte[7 + hostBytes.Length];
		connectRequest[0] = 0x05; // version
		connectRequest[1] = 0x01; // connect
		connectRequest[2] = 0x00; // reserved
		connectRequest[3] = 0x03; // domain name
		connectRequest[4] = (byte)hostBytes.Length;
		hostBytes.CopyTo(connectRequest, 5);
		connectRequest[5 + hostBytes.Length] = (byte)(targetPort >> 8);
		connectRequest[6 + hostBytes.Length] = (byte)(targetPort & 0xFF);

		await socket.SendAsync(connectRequest, SocketFlags.None, cancellationToken)
			.ConfigureAwait(false);

		// Read connect response header (4 bytes: version, status, reserved, address type)
		var connectResponse = new byte[4];
		await ReadExactAsync(socket, connectResponse, cancellationToken).ConfigureAwait(false);

		if (connectResponse[0] != 0x05)
		{
			throw new NetworkException(
				"SOCKS5 proxy returned invalid version in connect response.",
				new InvalidOperationException($"Expected 0x05, got 0x{connectResponse[0]:X2}."));
		}

		if (connectResponse[1] != 0x00)
		{
			var reason = connectResponse[1] switch
			{
				0x01 => "general SOCKS server failure",
				0x02 => "connection not allowed by ruleset",
				0x03 => "network unreachable",
				0x04 => "host unreachable",
				0x05 => "connection refused",
				0x06 => "TTL expired",
				0x07 => "command not supported",
				0x08 => "address type not supported",
				_ => $"unknown error 0x{connectResponse[1]:X2}",
			};
			throw new NetworkException(
				$"SOCKS5 connect failed: {reason}.",
				new InvalidOperationException($"Reply code: 0x{connectResponse[1]:X2}."));
		}

		// Consume the bound address so the socket is ready for data
		var skipCount = connectResponse[3] switch
		{
			0x01 => 4 + 2, // IPv4 (4 bytes) + port (2 bytes)
			0x04 => 16 + 2, // IPv6 (16 bytes) + port (2 bytes)
			0x03 => 1,      // domain: need to read length first
			_ => throw new NetworkException(
				"SOCKS5 proxy returned unsupported address type.",
				new InvalidOperationException($"Address type: 0x{connectResponse[3]:X2}.")),
		};

		if (connectResponse[3] == 0x03)
		{
			var domainLen = new byte[1];
			await ReadExactAsync(socket, domainLen, cancellationToken).ConfigureAwait(false);
			skipCount = domainLen[0] + 2; // domain bytes + port (2 bytes)
		}

		var skipBuf = new byte[skipCount];
		await ReadExactAsync(socket, skipBuf, cancellationToken).ConfigureAwait(false);
	}

	private static async Task ReadExactAsync(
		Socket socket,
		Memory<byte> buffer,
		CancellationToken cancellationToken)
	{
		var totalRead = 0;
		while (totalRead < buffer.Length)
		{
			var read = await socket.ReceiveAsync(
					buffer[totalRead..],
					SocketFlags.None,
					cancellationToken)
				.ConfigureAwait(false);

			if (read == 0)
			{
				throw new NetworkException(
					"SOCKS5 proxy closed the connection unexpectedly.",
					new EndOfStreamException());
			}

			totalRead += read;
		}
	}
#else
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
		if (scheme is "socks5")
		{
			throw new NotSupportedException(
				"SOCKS5 proxy is not supported on netstandard2.0. Use net8.0 or later.");
		}

		if (scheme is not ("http" or "https"))
		{
			throw new ConfigException($"Unsupported proxy scheme: {scheme}. Supported: http, https.");
		}

		handler.Proxy = new WebProxy(proxyUri);
		handler.UseProxy = true;

		return handler;
	}
#endif

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
