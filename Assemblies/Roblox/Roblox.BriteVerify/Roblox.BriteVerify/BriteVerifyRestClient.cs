using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;
using Roblox.BriteVerify.Properties;
using Roblox.RestClientBase;

namespace Roblox.BriteVerify;

/// <summary>
/// Base client for making calls to BriteVerify.
/// Provides CircuitBreaker features by default.
/// </summary>
[ExcludeFromCodeCoverage]
internal class BriteVerifyRestClient : GuardedRestClientBase, IBriteVerifyRestClient
{
	private readonly IBriteVerifySettings _Settings;

	private readonly IDictionary<string, string> _RequestHeaders;

	/// <summary>
	/// Base url for calls into BriteVerify.
	/// </summary>
	protected override string Endpoint => _Settings.BriteVerifyApiEndpoint;

	/// <summary>
	/// Timeout for the bodyData
	/// </summary>
	protected override TimeSpan Timeout => _Settings.BriteVerifyClientTimeoutInterval;

	/// <summary>
	/// An override for the <see cref="!:RestClientBase.Properties.Settings.Default.DefaultCircuitBreakerRetryInterval" /> setting
	/// </summary>
	protected override TimeSpan RetryInterval => _Settings.BriteVerifyCircuitBreakerRetryInterval;

	/// <summary>
	/// Default client Name.
	/// </summary>
	public override string Name => "BriteVerifyClient";

	/// <summary>
	/// Default constructor.
	/// </summary>
	public BriteVerifyRestClient()
		: this(Settings.Default)
	{
	}

	/// <summary>
	/// Special constructor. Requires settings for Endpoint, Timeout, ApiKey
	/// </summary>
	/// <param name="settings"></param>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	public BriteVerifyRestClient(IBriteVerifySettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		_Settings = settings;
		_RequestHeaders = new Dictionary<string, string> { 
		{
			HttpRequestHeader.ContentType.ToString(),
			"application/json"
		} };
	}

	/// <summary>
	/// Execute the given HttpRequest against BriteVerify.
	/// Environment-level configurations for BriteVerify are handled within.
	/// </summary>
	/// <typeparam name="T">Object type into which the response will be deserialized from JSON.</typeparam>
	/// <param name="actionPath">Path to the API endpoint.</param>
	/// <param name="method">The HttpMethod used by this call.</param>
	/// <param name="queryStringParameters">List of parameters fokr the query string.</param>
	/// <exception cref="T:Roblox.Sentinels.CircuitBreakerException"></exception>
	/// <exception cref="T:Roblox.RestClientBase.RequestThrottledException"></exception>
	/// <exception cref="T:Roblox.RestClientBase.ApiClientException"></exception>
	/// <exception cref="T:Newtonsoft.Json.JsonSerializationException"></exception>
	/// <returns>An object of type T containing the successful response</returns>
	public T ExecuteHttpRequest<T>(string actionPath, HttpMethod method, IEnumerable<KeyValuePair<string, object>> queryStringParameters)
	{
		string responseString = ExecuteHttpRequest(actionPath, method, queryStringParameters, null, _RequestHeaders, Encoding.UTF8);
		return DeserializeResponseData<T>(responseString);
	}
}
