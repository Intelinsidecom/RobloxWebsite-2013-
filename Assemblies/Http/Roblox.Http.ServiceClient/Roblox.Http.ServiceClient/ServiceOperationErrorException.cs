using Roblox.Http.Client;

namespace Roblox.Http.ServiceClient;

public class ServiceOperationErrorException : HttpRequestFailedException
{
	public string Code { get; set; }

	public ServiceOperationErrorException(IHttpResponse response, IHttpRequest request, PayloadError payloadError)
		: base(response, GetExceptionMessage(response, payloadError))
	{
		Code = payloadError?.Code;
	}

	private static string GetExceptionMessage(IHttpResponse response, PayloadError payloadError)
	{
		return $"{HttpRequestFailedException.BuildExceptionMessage(response)}\n\tError code: {payloadError?.Code}";
	}
}
