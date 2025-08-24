using System;
using System.Net;

namespace Roblox.RestClientBase;

public class ApiClientException : Exception
{
	protected string ApiClientName { get; private set; }

	public string StatusDescription { get; private set; }

	public HttpStatusCode? StatusCode { get; private set; }

	public ApiClientException(string apiClientName)
	{
		ApiClientName = apiClientName;
	}

	public ApiClientException(string apiClientName, string message)
		: base(message)
	{
		ApiClientName = apiClientName;
	}

	public ApiClientException(string apiClientName, string message, Exception innerException)
		: base(message, innerException)
	{
		ApiClientName = apiClientName;
	}

	public ApiClientException(string apiClientName, string message, Exception innerException, HttpStatusCode? httpStatusCode, string statusDescription)
		: base(message, innerException)
	{
		ApiClientName = apiClientName;
		StatusCode = httpStatusCode;
		StatusDescription = statusDescription;
	}
}
