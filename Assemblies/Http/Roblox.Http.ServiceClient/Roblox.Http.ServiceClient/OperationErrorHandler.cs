using System.Net;
using Roblox.Http.Client;

namespace Roblox.Http.ServiceClient;

public class OperationErrorHandler : RequestFailureThrowsHandler
{
	private const HttpStatusCode _ServiceFailureStatusCode = HttpStatusCode.Conflict;

	private const string _JsonContentType = "application/json";

	protected override void CheckResponse(IHttpResponse httpResponse, IHttpRequest httpRequest)
	{
		if (httpResponse == null || httpRequest == null)
		{
			return;
		}
		if (IsOperationError(httpResponse))
		{
			Payload<object> jsonBody = httpResponse.GetJsonBody<Payload<object>>();
			if (jsonBody?.Error != null)
			{
				throw new ServiceOperationErrorException(httpResponse, httpRequest, jsonBody.Error);
			}
		}
		base.CheckResponse(httpResponse, httpRequest);
	}

	private bool IsOperationError(IHttpResponse httpResponse)
	{
		if (httpResponse == null || httpResponse.StatusCode != HttpStatusCode.Conflict)
		{
			return false;
		}
		if (httpResponse.Headers.ContentType == null)
		{
			return false;
		}
		return httpResponse.Headers.ContentType.StartsWith("application/json");
	}
}
