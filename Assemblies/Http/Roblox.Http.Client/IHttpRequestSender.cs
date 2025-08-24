using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Http.Client;

public interface IHttpRequestSender
{
	void SendRequest(HttpMethod httpMethod, string path, IEnumerable<(string Key, string Value)> queryStringParameters = null);

	Task SendRequestAsync(HttpMethod httpMethod, string path, CancellationToken cancellationToken, IEnumerable<(string Key, string Value)> queryStringParameters = null);

	TResponse SendRequest<TResponse>(HttpMethod httpMethod, string path, IEnumerable<(string Key, string Value)> queryStringParameters = null) where TResponse : class;

	Task<TResponse> SendRequestAsync<TResponse>(HttpMethod httpMethod, string path, CancellationToken cancellationToken, IEnumerable<(string Key, string Value)> queryStringParameters = null) where TResponse : class;

	void SendRequestWithJsonBody<TRequest>(HttpMethod httpMethod, string path, TRequest requestData, IEnumerable<(string Key, string Value)> queryStringParameters = null);

	Task SendRequestWithJsonBodyAsync<TRequest>(HttpMethod httpMethod, string path, TRequest requestData, CancellationToken cancellationToken, IEnumerable<(string Key, string Value)> queryStringParameters = null);

	TResponse SendRequestWithJsonBody<TRequest, TResponse>(HttpMethod httpMethod, string path, TRequest requestData, IEnumerable<(string Key, string Value)> queryStringParameters = null) where TResponse : class;

	Task<TResponse> SendRequestWithJsonBodyAsync<TRequest, TResponse>(HttpMethod httpMethod, string path, TRequest requestData, CancellationToken cancellationToken, IEnumerable<(string Key, string Value)> queryStringParameters = null) where TResponse : class;
}
