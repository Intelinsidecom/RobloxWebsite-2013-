using System;
using System.Net.Http;

namespace Roblox.Http;

public interface IHttpRequest
{
	HttpMethod Method { get; set; }

	Uri Url { get; set; }

	IHttpRequestHeaders Headers { get; }

	HttpContent Body { get; set; }

	void SetJsonRequestBody(object requestBody);
}
