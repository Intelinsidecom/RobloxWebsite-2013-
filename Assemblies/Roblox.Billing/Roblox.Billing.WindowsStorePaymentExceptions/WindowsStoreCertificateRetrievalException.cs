using System;
using System.Net;

namespace Roblox.Billing.WindowsStorePaymentExceptions;

public class WindowsStoreCertificateRetrievalException : ApplicationException
{
	public WindowsStoreCertificateRetrievalException(HttpStatusCode statusCode)
		: base($"Failed to retrieve security certificate from Microsoft: HTTP status code {(int)statusCode}")
	{
	}
}
