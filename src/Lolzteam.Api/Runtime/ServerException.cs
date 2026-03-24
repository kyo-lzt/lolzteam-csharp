using System.Net.Http.Headers;

namespace Lolzteam.Api.Runtime;

public sealed class ServerException : HttpException
{
    public ServerException(int statusCode, string responseBody, HttpResponseHeaders headers)
        : base(statusCode, responseBody, headers) { }
}
