using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;
using Roblox.CommunitySift.Properties;
using Roblox.Configuration;
using Roblox.RestClientBase;

namespace Roblox.CommunitySift;

/// <summary>
/// Base client for making calls to CommunitySift.
/// Provides CircuitBreaker features by default.
/// </summary>
[ExcludeFromCodeCoverage]
public class CommunitySiftRestClient : GuardedRestClientBase, ICommunitySiftRestClient
{
	private readonly ICommunitySiftSettings _Settings;

	private Dictionary<string, string> _RequestHeaders;

	/// <summary>
	/// Base url for calls into CommunitySift.
	/// </summary>
	protected override string Endpoint => _Settings.CommunitySiftApiEndpoint;

	/// <summary>
	/// Timeout for the bodyData
	/// </summary>
	protected override TimeSpan Timeout => _Settings.CommunitySiftClientTimeoutInterval;

	/// <summary>
	/// An override for the <see cref="!:RestClientBase.Properties.Settings.Default.DefaultCircuitBreakerRetryInterval" /> setting
	/// </summary>
	protected override TimeSpan RetryInterval => _Settings.CommunitySiftCircuitBreakerRetryInterval;

	/// <summary>
	/// An override for Settings.Default.DefaultCircuitBreakerTimeoutsBeforeTrip
	/// </summary>
	protected override int TimeoutCountBeforeTripping => _Settings.CommunitySiftCircuitBreakerTimeoutsBeforeTrip;

	/// <summary>
	/// An override for Settings.Default.DefaultCircuitBreakerTimeoutInterval
	/// </summary>
	protected override TimeSpan TimeoutIntervalForTripping => _Settings.CommunitySiftCircuitBreakerTimeoutInterval;

	/// <summary>
	/// Default client Name.
	/// </summary>
	public override string Name => "CommunitySiftClient";

	/// <summary>
	/// Default constructor.
	/// </summary>
	public CommunitySiftRestClient()
		: this(Settings.Default)
	{
	}

	/// <summary>
	/// Special constructor. Requires settings for Endpoint, Timeout, ApiKey
	/// </summary>
	/// <param name="settings"></param>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	public CommunitySiftRestClient(ICommunitySiftSettings settings)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Settings.ReadValueAndMonitorChanges((ICommunitySiftSettings s) => s.CommunitySiftApiKey, ResetHeaders);
	}

	private void ResetHeaders()
	{
		_RequestHeaders = new Dictionary<string, string>
		{
			{
				HttpRequestHeader.ContentType.ToString(),
				"application/json"
			},
			{
				HttpRequestHeader.Authorization.ToString(),
				string.Format("Basic {0}", Convert.ToBase64String(Encoding.ASCII.GetBytes(":" + _Settings.CommunitySiftApiKey)))
			}
		};
	}

	/// <summary>
	/// Execute the given HttpRequest against CommunitySift.
	/// Environment-level configurations for CommunitySift are handled within.
	/// </summary>
	/// <typeparam name="T">Object type into which the response will be deserialized from JSON.</typeparam>
	/// <param name="actionPath">Path to the API endpoint.</param>
	/// <param name="method">The HttpMethod used by this call.</param>
	/// <param name="queryStringParameters">List of parameters fokr the query string.</param>
	/// <param name="bodyData">Object containing the data to be POSTed. This data will be serialized into JSON.</param>
	/// <exception cref="T:Roblox.Sentinels.CircuitBreakerException"></exception>
	/// <exception cref="T:Roblox.RestClientBase.RequestThrottledException"></exception>
	/// <exception cref="T:Roblox.RestClientBase.ApiClientException"></exception>
	/// <exception cref="T:Newtonsoft.Json.JsonSerializationException"></exception>
	/// <returns>An object of type T containing the successful response</returns>
	public T ExecuteHttpRequest<T>(string actionPath, HttpMethod method, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, object bodyData = null)
	{
		string bodyString = SerializeSendData(bodyData);
		string responseString = ExecuteHttpRequest(actionPath, method, queryStringParameters, bodyString, _RequestHeaders, Encoding.UTF8);
		return DeserializeResponseData<T>(responseString);
	}
}
