using System;
using System.CodeDom.Compiler;
using System.Net.Http;
using Roblox.Http.Client.Monitoring;
using Roblox.Instrumentation;

namespace Roblox.IpGeolocation.Client;

/// <summary>
/// Factory to create a Roblox.Instrumentation monitored REST client.
/// </summary>
/// <remarks>
/// HttpClient on BEDEV1 (.NET Framework) systems should set
/// ServicePointManager.FindServicePoint(baseUri).ConnectionLeaseTimeout to
/// re-use and manage sockets.
///
/// HttpClients are not pooled in .NET Framework by default.
///
/// Advanced usage: It is possible to use the client directly by injecting a
/// properly configured HttpClient (and not use this factory class).
/// </remarks>
[GeneratedCode("Roblox.Nswag.Augmentor", "3.0.0.0")]
public class IpLookupClientFactory : IIpLookupClientFactory
{
	/// <summary>
	/// Name used to register a "named" HTTP client.
	/// </summary>
	public const string ClientName = "Roblox.Roblox.Ip.Geolocation.Service.Client";

	private readonly ClientRequestsMonitor _Monitor;

	private readonly HttpMessageHandler _HttpMessageHandler;

	private readonly Action<HttpClient> _HttpClientConfigureAction;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="counterRegistry"><see cref="T:Roblox.Instrumentation.ICounterRegistry" /></param>
	/// <param name="configureClient"><see cref="T:System.Action`1" /> allows you to configure the <seealso cref="T:System.Net.Http.HttpClient" />'s properties like BaseAddress.</param>
	/// <param name="httpMessageHandler"><see cref="T:System.Net.Http.HttpMessageHandler" /> for things like circuit breaking, etc.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - Throws when <paramref name="counterRegistry" /> is null
	/// </exception>
	public IpLookupClientFactory(ICounterRegistry counterRegistry, Action<HttpClient> configureClient, HttpMessageHandler httpMessageHandler = null)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_Monitor = ClientRequestsMonitor.GetOrCreate(counterRegistry, "Roblox.ApiClient", "MonitoredIpLookupClient");
		_HttpMessageHandler = httpMessageHandler;
		_HttpClientConfigureAction = configureClient;
	}

	/// <inheritdoc cref="T:Roblox.IpGeolocation.Client.IIpLookupClientFactory" />
	public IIpLookupClient Create()
	{
		HttpClient httpClient = ((_HttpMessageHandler != null) ? new HttpClient(_HttpMessageHandler) : new HttpClient());
		if (_HttpClientConfigureAction != null)
		{
			_HttpClientConfigureAction(httpClient);
		}
		return new MonitoredIpLookupClient(httpClient, _Monitor);
	}
}
