using System;
using System.Net;

namespace Roblox.RestClientBase;

public class RequestThrottledException : ApiClientException
{
	public RequestThrottledException(string apiClientName)
		: base(apiClientName)
	{
	}

	public RequestThrottledException(string apiClientName, string message)
		: base(apiClientName, message)
	{
	}

	public RequestThrottledException(string apiClientName, string message, Exception innerException)
		: base(apiClientName, message, innerException)
	{
	}

	public RequestThrottledException(string apiClientName, string message, Exception innerException, HttpStatusCode? httpStatusCode, string statusDescription)
		: base(apiClientName, message, innerException, httpStatusCode, statusDescription)
	{
	}
}
