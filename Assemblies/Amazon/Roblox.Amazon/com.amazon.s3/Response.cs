using System;
using System.IO;
using System.Net;

namespace com.amazon.s3;

public class Response : IDisposable
{
	private byte[] message;

	protected WebResponse response;

	public WebResponse Connection => response;

	public HttpStatusCode Status => (response as HttpWebResponse).StatusCode;

	public string XAmzId => response.Headers.Get("x-amz-id-2");

	public string XAmzRequestId => response.Headers.Get("x-amz-request-id");

	protected Response()
	{
	}

	protected virtual void Process(WebRequest request)
	{
		try
		{
			response = request.GetResponse();
		}
		catch (WebException ex)
		{
			using Stream stream = ex.Response.GetResponseStream();
			throw new WebException((ex.Response != null) ? Utils.slurpInputStreamAsString(stream) : ex.Message, ex, ex.Status, ex.Response);
		}
	}

	public byte[] getResponseMessage()
	{
		if (message == null)
		{
			using Stream stream = response.GetResponseStream();
			message = Utils.slurpInputStream(stream);
			stream.Close();
		}
		return message;
	}

	public static Response Get(WebRequest request)
	{
		Response obj = new Response();
		obj.Process(request);
		return obj;
	}

	public void Dispose()
	{
		if (response != null)
		{
			response.Close();
		}
	}
}
