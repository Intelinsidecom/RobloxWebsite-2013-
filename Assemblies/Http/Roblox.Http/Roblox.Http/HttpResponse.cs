using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Roblox.Http;

public class HttpResponse : IHttpResponse
{
	private const int _MinimumSuccessfulStatusCode = 200;

	private const int _MaximumSuccessfulStatusCode = 299;

	public HttpStatusCode StatusCode { get; set; }

	public string StatusText { get; set; }

	public bool IsSuccessful
	{
		get
		{
			int statusCode = (int)StatusCode;
			if (statusCode >= 200)
			{
				return statusCode <= 299;
			}
			return false;
		}
	}

	public Uri Url { get; set; }

	public IHttpResponseHeaders Headers { get; set; }

	public byte[] Body { get; set; }

	public string GetStringBody(Encoding encoding = null)
	{
		if (encoding == null)
		{
			encoding = Encoding.UTF8;
		}
		return encoding.GetString(Body);
	}

	public T GetJsonBody<T>() where T : class
	{
		return JsonConvert.DeserializeObject<T>(GetStringBody());
	}
}
