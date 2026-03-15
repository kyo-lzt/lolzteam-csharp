using System.Net.Http.Headers;

namespace Lolzteam.Api.Runtime;

public sealed class AuthException : HttpException
{
	public AuthException(int statusCode, string responseBody, HttpResponseHeaders headers)
		: base(statusCode, responseBody, headers) { }
}
