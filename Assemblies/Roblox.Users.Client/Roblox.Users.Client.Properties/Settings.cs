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

namespace Roblox.Users.Client.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
internal sealed class Settings : ApplicationSettingsBase, IServiceClientSettings, IHttpClientSettings, IDefaultCircuitBreakerPolicyConfig, ISettings, INotifyPropertyChanged
{
	private readonly DefaultHttpClientSettings _DefaultHttpClientSettings = new DefaultHttpClientSettings();

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public string Endpoint => RobloxEnvironment.GetApiEndpoint("users");

	public string ClientName => "Users";

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

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:15:00")]
	public TimeSpan AgentLocalCacheExpiry => (TimeSpan)((SettingsBase)this)["AgentLocalCacheExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan UserLocalCacheExpiry => (TimeSpan)((SettingsBase)this)["UserLocalCacheExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:10:00")]
	public TimeSpan UsernameHistoryCacheExpiry => (TimeSpan)((SettingsBase)this)["UsernameHistoryCacheExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan GetRecentlyUpdatedUsersInterval => (TimeSpan)((SettingsBase)this)["GetRecentlyUpdatedUsersInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:15")]
	public TimeSpan UserLocalCachePurgeLeeway => (TimeSpan)((SettingsBase)this)["UserLocalCachePurgeLeeway"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int MaxCheckFailuresBeforeClearLocalCache => (int)((SettingsBase)this)["MaxCheckFailuresBeforeClearLocalCache"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UsersClientLocalCacheEnabled => (bool)((SettingsBase)this)["UsersClientLocalCacheEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PerEndpointCircuitBreakerEnabled => (bool)((SettingsBase)this)["PerEndpointCircuitBreakerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ApiKeyViaHeaderEnabled => (bool)((SettingsBase)this)["ApiKeyViaHeaderEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:45")]
	public TimeSpan UserCreatedCacheThreshold => (TimeSpan)((SettingsBase)this)["UserCreatedCacheThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("64")]
	public int DatabaseMaxUsernameLength => (int)((SettingsBase)this)["DatabaseMaxUsernameLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:10:00")]
	public TimeSpan DisplayNameHistoryCacheExpiry => (TimeSpan)((SettingsBase)this)["DisplayNameHistoryCacheExpiry"];

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
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, (ApplicationSettingsBase)(object)this);
	}
}
