using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Http.Client;

public interface IHttpClient
{
	IHttpResponse Send(IHttpRequest request);

	Task<IHttpResponse> SendAsync(IHttpRequest request, CancellationToken cancellationToken);
}
