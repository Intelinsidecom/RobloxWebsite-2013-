using System.Threading;
using System.Threading.Tasks;
using Roblox.Http.Client;

namespace Roblox.Http.ServiceClient;

public class ServiceRequestSender : HttpRequestSender, IServiceRequestSender
{
	public ServiceRequestSender(IHttpClient httpClient, IHttpRequestBuilder httpRequestBuilder)
		: base(httpClient, httpRequestBuilder)
	{
	}

	public TResponse SendPostRequest<TRequest, TResponse>(string path, TRequest requestData)
	{
		return SendRequestWithJsonBody<TRequest, Payload<TResponse>>(HttpMethod.Post, path, requestData).Data;
	}

	public async Task<TResponse> SendPostRequestAsync<TRequest, TResponse>(string path, TRequest requestData, CancellationToken cancellationToken)
	{
		return (await SendRequestWithJsonBodyAsync<TRequest, Payload<TResponse>>(HttpMethod.Post, path, requestData, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Data;
	}
}
