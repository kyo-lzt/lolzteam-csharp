using System.Net.Http.Headers;

namespace Lolzteam.Api.Runtime;

public sealed class NotFoundException : HttpException
{
	public NotFoundException(string responseBody, HttpResponseHeaders headers)
		: base(404, responseBody, headers) { }
}
