using System.Net.Http.Headers;

namespace Lolzteam.Api.Runtime;

public sealed class ForbiddenException : HttpException
{
    public ForbiddenException(int statusCode, string responseBody, HttpResponseHeaders headers)
        : base(statusCode, responseBody, headers) { }
}
