using System.Collections.Generic;
using Roblox.RestClientBase;

namespace Roblox.Kickbox;

/// <summary>
/// Base client for making calls to Kickbox.
/// </summary>
public interface IKickboxRestClient
{
	/// <summary>
	/// Execute the given HttpRequest against Kickbox.
	/// Environment-level configurations for Kickbox are handled within.
	/// </summary>
	/// <typeparam name="T">Object type into which the response will be deserialized from JSON.</typeparam>
	/// <param name="actionPath">Path to the API endpoint.</param>
	/// <param name="method">The HttpMethod used by this call.</param>
	/// <param name="queryStringParameters">List of parameters fokr the query string.</param>
	/// <returns>An object of type T containing the successful response</returns>
	/// <exception cref="T:Roblox.Sentinels.CircuitBreakerException"></exception>
	/// <exception cref="T:Roblox.RestClientBase.RequestThrottledException"></exception>
	/// <exception cref="T:Roblox.RestClientBase.ApiClientException"></exception>
	/// <exception cref="T:Newtonsoft.Json.JsonSerializationException"></exception>
	T ExecuteHttpRequest<T>(string actionPath, Roblox.RestClientBase.RestClientBase.HttpMethod method, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null);
}
