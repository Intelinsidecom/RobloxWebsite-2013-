using System;
using System.Net;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Configuration.Client.Properties;

internal class ConfigurationClientSettings : IServiceClientSettings, IHttpClientSettings, IDefaultCircuitBreakerPolicyConfig
{
	private readonly Func<string> _EndpointGetter;

	private readonly Func<TimeSpan> _TimeoutGetter;

	private readonly IHttpClientSettings _DefaultHttpClientSettings = new DefaultHttpClientSettings();

	public string UserAgent => _DefaultHttpClientSettings.UserAgent;

	public int MaxRedirects => _DefaultHttpClientSettings.MaxRedirects;

	public TimeSpan RequestTimeout => _TimeoutGetter();

	public TimeSpan RetryInterval { get; } = TimeSpan.FromMilliseconds(100.0);


	public int FailuresAllowedBeforeTrip { get; } = 10;


	public string Endpoint => _EndpointGetter();

	public string ClientName { get; } = "ConfigurationApiClient";


	public DecompressionMethods AutomaticDecompression => DecompressionMethods.None;

	public event Action<string> SettingChanged;

	public ConfigurationClientSettings(Func<string> endpointGetter, Func<TimeSpan> timeoutGetter)
	{
		_EndpointGetter = endpointGetter ?? throw new ArgumentNullException("endpointGetter");
		_TimeoutGetter = timeoutGetter ?? throw new ArgumentNullException("timeoutGetter");
	}
}
