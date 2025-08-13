using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Http.ServiceClient;

public interface IServiceRequestSender
{
	TResponse SendPostRequest<TRequest, TResponse>(string path, TRequest requestData);

	Task<TResponse> SendPostRequestAsync<TRequest, TResponse>(string path, TRequest requestData, CancellationToken cancellationToken);
}
