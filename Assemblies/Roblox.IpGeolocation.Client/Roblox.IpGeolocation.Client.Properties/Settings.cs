using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.IpGeolocation.Client.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

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
	[DefaultSettingValue("http://apis.simulpong.com/ip-geolocation-service/")]
	public string IpGeolocationServiceUrl => (string)((SettingsBase)this)["IpGeolocationServiceUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.1")]
	public double IpGeolocationServiceCircuitBreakerThreshold => (double)((SettingsBase)this)["IpGeolocationServiceCircuitBreakerThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan IpGeolocationServiceCircuitBreakerSamplingPeriod => (TimeSpan)((SettingsBase)this)["IpGeolocationServiceCircuitBreakerSamplingPeriod"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int IpGeolocationServiceCircuitBreakerMinimumInvocations => (int)((SettingsBase)this)["IpGeolocationServiceCircuitBreakerMinimumInvocations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan IpGeolocationServiceCircuitBreakerTripDuration => (TimeSpan)((SettingsBase)this)["IpGeolocationServiceCircuitBreakerTripDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.5000000")]
	public TimeSpan IpGeolocationClientDefaultTimeout => (TimeSpan)((SettingsBase)this)["IpGeolocationClientDefaultTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:02:00")]
	public TimeSpan IpGeolocationClientLocalCacheDefaultEntryTTL => (TimeSpan)((SettingsBase)this)["IpGeolocationClientLocalCacheDefaultEntryTTL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan IpGeolocationClientLocalCacheDefaultTraversalInterval => (TimeSpan)((SettingsBase)this)["IpGeolocationClientLocalCacheDefaultTraversalInterval"];

	internal Settings()
	{
		((ApplicationSettingsBase)this).PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		((ApplicationSettingsBase)this).OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, (ApplicationSettingsBase)(object)this);
	}
}
