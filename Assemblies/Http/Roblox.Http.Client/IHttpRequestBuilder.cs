using System.Collections.Generic;

namespace Roblox.Http.Client;

public interface IHttpRequestBuilder
{
	IHttpRequest BuildRequest(HttpMethod httpMethod, string path, IEnumerable<(string Key, string Value)> queryStringParameters = null);

	IHttpRequest BuildRequestWithJsonBody<TRequest>(HttpMethod httpMethod, string path, TRequest requestData, IEnumerable<(string Key, string Value)> queryStringParameters = null);
}
