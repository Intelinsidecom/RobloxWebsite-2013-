using System.Net.Http;
using System.Net.Http.Headers;

namespace Roblox.Http;

public class HttpResponseHeaders : HttpHeaders, IHttpResponseHeaders, IHttpHeaders
{
	public HttpResponseHeaders()
		: this(new HttpResponseMessage())
	{
	}

	public HttpResponseHeaders(System.Net.Http.Headers.HttpResponseHeaders httpHeaders, HttpContentHeaders contentHeaders)
		: base(httpHeaders, contentHeaders)
	{
	}

	public HttpResponseHeaders(HttpResponseMessage response)
		: this(response.Headers, response.Content?.Headers)
	{
	}
}
