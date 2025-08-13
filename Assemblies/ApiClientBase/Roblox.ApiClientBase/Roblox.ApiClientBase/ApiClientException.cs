using System;
using System.Net;

namespace Roblox.ApiClientBase;

public class ApiClientException : Exception
{
	public string StatusDescription { get; }

	public HttpStatusCode? StatusCode { get; }

	protected string ApiClientName { get; }

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
