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

namespace Roblox.StaticContent.Client.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
internal sealed class Settings : ApplicationSettingsBase, IServiceClientSettings, IHttpClientSettings, IDefaultCircuitBreakerPolicyConfig
{
	private readonly DefaultHttpClientSettings _DefaultHttpClientSettings = new DefaultHttpClientSettings();

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public string Endpoint => RobloxEnvironment.GetApiEndpoint("staticcontent");

	public string ClientName => "StaticContent";

	public string UserAgent => _DefaultHttpClientSettings.UserAgent;

	public int MaxRedirects => _DefaultHttpClientSettings.MaxRedirects;

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string propName) => ((ApplicationSettingsBase)this)[propName]);
		}
		set
		{
			((ApplicationSettingsBase)this)[propertyName] = value;
		}
	}

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.5000000")]
	public TimeSpan RequestTimeout => (TimeSpan)((SettingsBase)this)["RequestTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.2500000")]
	public TimeSpan RetryInterval => (TimeSpan)((SettingsBase)this)["RetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int FailuresAllowedBeforeTrip => (int)((SettingsBase)this)["FailuresAllowedBeforeTrip"];

	public event Action<string> SettingChanged;

	internal Settings()
	{
		((ApplicationSettingsBase)this).PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
		((ApplicationSettingsBase)this).PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			this.SettingChanged?.Invoke(args.PropertyName);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		((ApplicationSettingsBase)this).OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, (ApplicationSettingsBase)(object)this);
	}
}
