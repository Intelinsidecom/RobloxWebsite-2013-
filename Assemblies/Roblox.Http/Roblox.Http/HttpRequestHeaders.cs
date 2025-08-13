using System.Net.Http;
using System.Net.Http.Headers;

namespace Roblox.Http;

public class HttpRequestHeaders : HttpHeaders, IHttpRequestHeaders, IHttpHeaders
{
	public HttpRequestHeaders()
		: this(BuildEmptyHttpRequestMessage())
	{
	}

	public HttpRequestHeaders(System.Net.Http.Headers.HttpRequestHeaders httpHeaders, HttpContentHeaders contentHeaders)
		: base(httpHeaders, contentHeaders)
	{
	}

	public HttpRequestHeaders(HttpRequestMessage request)
		: this(request.Headers, request.Content?.Headers)
	{
	}

	private static HttpRequestMessage BuildEmptyHttpRequestMessage()
	{
		return new HttpRequestMessage
		{
			Content = new ByteArrayContent(new byte[0])
		};
	}
}
