using System.Net.Http.Headers;

namespace Lolzteam.Api.Runtime;

public class HttpException : LolzteamException
{
    public int StatusCode { get; }
    public string ResponseBody { get; }
    public HttpResponseHeaders Headers { get; }

    public HttpException(int statusCode, string responseBody, HttpResponseHeaders headers)
        : base($"HTTP {statusCode}: {responseBody}")
    {
        StatusCode = statusCode;
        ResponseBody = responseBody;
        Headers = headers;
    }

    public static HttpException Create(int statusCode, string responseBody, HttpResponseHeaders headers)
    {
        return statusCode switch
        {
            429 => new RateLimitException(responseBody, headers),
            401 => new AuthException(statusCode, responseBody, headers),
            403 => new ForbiddenException(statusCode, responseBody, headers),
            404 => new NotFoundException(responseBody, headers),
            >= 500 and <= 503 or 504 => new ServerException(statusCode, responseBody, headers),
            _ => new HttpException(statusCode, responseBody, headers),
        };
    }
}
