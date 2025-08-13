using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Roblox.Http;

public class HttpRequest : IHttpRequest
{
	private const string _JsonContentType = "application/json";

	public HttpMethod Method { get; set; }

	public Uri Url { get; set; }

	public IHttpRequestHeaders Headers { get; set; }

	[ExcludeFromCodeCoverage]
	public HttpContent Body { get; set; }

	public HttpRequest(HttpMethod method, Uri url)
	{
		Method = method;
		Url = url ?? throw new ArgumentNullException("url");
		Headers = new HttpRequestHeaders();
	}

	public void SetJsonRequestBody(object requestBody)
	{
		if (requestBody == null)
		{
			throw new ArgumentNullException("requestBody");
		}
		string s = JsonConvert.SerializeObject(requestBody);
		Body = new ByteArrayContent(Encoding.UTF8.GetBytes(s));
		Headers.ContentType = "application/json";
	}
}
