using System;
using System.Linq.Expressions;
using System.Net.Http;
using Polly;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.IpGeolocation.Client.Properties;

namespace Roblox.IpGeolocation.Client;

/// <inheritdoc cref="T:Roblox.IpGeolocation.Client.IIpLookupClientFactoryProvider" />
public class IpLookupClientFactoryProvider : IIpLookupClientFactoryProvider
{
	private readonly ILogger _Logger;

	private readonly ICounterRegistry _CounterRegistry;

	private readonly Func<TimeSpan> _CacheTimeToLiveGetter;

	private readonly TimeSpan _CacheTraversalInterval;

	/// <inheritdoc cref="T:Roblox.IpGeolocation.Client.IIpLookupClientFactoryProvider" />
	public IIpLookupClientFactory IpLookupClientFactoryInstance { get; private set; }

	public IpLookupClientFactoryProvider(ILogger logger, ICounterRegistry counterRegistry)
		: this(logger, counterRegistry, () => Settings.Default.IpGeolocationClientLocalCacheDefaultEntryTTL, Settings.Default.IpGeolocationClientLocalCacheDefaultTraversalInterval)
	{
	}

	/// <summary>
	/// Constructor with parameters used to initialize caching handler.
	/// </summary>
	/// <param name="logger"></param>
	/// <param name="counterRegistry"></param>
	/// <param name="cacheTimeToLiveGetter"></param>
	/// <param name="cacheTraversalInterval"></param>
	public IpLookupClientFactoryProvider(ILogger logger, ICounterRegistry counterRegistry, Func<TimeSpan> cacheTimeToLiveGetter, TimeSpan cacheTraversalInterval)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_CacheTimeToLiveGetter = cacheTimeToLiveGetter ?? throw new ArgumentNullException("cacheTimeToLiveGetter");
		_CacheTraversalInterval = cacheTraversalInterval;
		SetIpLookupClientFactoryInstance();
		Settings.Default.MonitorChanges<Settings, double>((Expression<Func<Settings, double>>)((Settings s) => s.IpGeolocationServiceCircuitBreakerThreshold), (Action)SetIpLookupClientFactoryInstance);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.IpGeolocationServiceCircuitBreakerSamplingPeriod), (Action)SetIpLookupClientFactoryInstance);
		Settings.Default.MonitorChanges<Settings, int>((Expression<Func<Settings, int>>)((Settings s) => s.IpGeolocationServiceCircuitBreakerMinimumInvocations), (Action)SetIpLookupClientFactoryInstance);
		Settings.Default.MonitorChanges<Settings, TimeSpan>((Expression<Func<Settings, TimeSpan>>)((Settings s) => s.IpGeolocationServiceCircuitBreakerTripDuration), (Action)SetIpLookupClientFactoryInstance);
	}

	/// <summary>
	/// Sets IpLookupClientFactoryInstance to a <see cref="T:Roblox.IpGeolocation.Client.IIpLookupClientFactory" /> initialized to build
	/// <see cref="T:Roblox.IpGeolocation.Client.IIpLookupClient" /> with local caching handler and circuit breaker handler.
	/// </summary>
	private void SetIpLookupClientFactoryInstance()
	{
		PollyPolicyDelegatingHandler innerHandler = new PollyPolicyDelegatingHandler((Policy)(object)AdvancedCircuitBreakerSyntax.AdvancedCircuitBreaker(Policy.Handle<HttpRequestException>(), Settings.Default.IpGeolocationServiceCircuitBreakerThreshold, Settings.Default.IpGeolocationServiceCircuitBreakerSamplingPeriod, Settings.Default.IpGeolocationServiceCircuitBreakerMinimumInvocations, Settings.Default.IpGeolocationServiceCircuitBreakerTripDuration, (Action<Exception, TimeSpan>)delegate(Exception exception, TimeSpan timespan)
		{
			_Logger.Error(exception);
		}, (Action)delegate
		{
			_Logger.Info("IpLookupClient Polly CircuitBreaker reset.");
		}))
		{
			InnerHandler = new HttpClientHandler()
		};
		LocalCacheGetRequestsClientHandler httpMessageHandler = new LocalCacheGetRequestsClientHandler(_CacheTimeToLiveGetter, _CacheTraversalInterval)
		{
			InnerHandler = innerHandler
		};
		IpLookupClientFactoryInstance = new IpLookupClientFactory(_CounterRegistry, ConfigureClient, httpMessageHandler);
	}

	private void ConfigureClient(HttpClient client)
	{
		client.BaseAddress = new Uri(Settings.Default.IpGeolocationServiceUrl);
		client.Timeout = Settings.Default.IpGeolocationClientDefaultTimeout;
	}
}
