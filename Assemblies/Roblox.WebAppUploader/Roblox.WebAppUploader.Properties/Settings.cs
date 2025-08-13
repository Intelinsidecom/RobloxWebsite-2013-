using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.WebAppUploader.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
internal sealed class Settings : ApplicationSettingsBase, IServiceClientSettings, IHttpClientSettings, IDefaultCircuitBreakerPolicyConfig
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly DefaultHttpClientSettings _DefaultHttpClientSettings = new DefaultHttpClientSettings();

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string propName) => base[propName]);
		}
		set
		{
			base[propertyName] = value;
		}
	}

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ApiKey => (string)this["ApiKey"];

	public string Endpoint { get; set; } = RobloxEnvironment.GetApiEndpoint("staticcontent");


	public string ClientName => "StaticContent";

	public string UserAgent => _DefaultHttpClientSettings.UserAgent;

	public int MaxRedirects => _DefaultHttpClientSettings.MaxRedirects;

	public TimeSpan RequestTimeout { get; } = TimeSpan.FromMinutes(2.0);


	public TimeSpan RetryInterval { get; } = TimeSpan.FromSeconds(15.0);


	public int FailuresAllowedBeforeTrip { get; } = 5;


	public event Action<string> SettingChanged;

	internal Settings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}
}
