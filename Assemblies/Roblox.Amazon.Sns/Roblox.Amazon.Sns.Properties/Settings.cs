using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Amazon.Sns.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
internal sealed class Settings : ApplicationSettingsBase
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
	[DefaultSettingValue("")]
	public string BackupRegionEndpointsCSV => (string)((SettingsBase)this)["BackupRegionEndpointsCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan SnsClientDefaultRequestTimeout => (TimeSpan)((SettingsBase)this)["SnsClientDefaultRequestTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:02:00")]
	public TimeSpan SnsClientDefaultReadWriteTimeout => (TimeSpan)((SettingsBase)this)["SnsClientDefaultReadWriteTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int SnsClientDefaultFailuresAllowedBeforeCircuitBreakerTrip => (int)((SettingsBase)this)["SnsClientDefaultFailuresAllowedBeforeCircuitBreakerTrip"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.2500000")]
	public TimeSpan SnsClientDefaultCircuitBreakerRetryInterval => (TimeSpan)((SettingsBase)this)["SnsClientDefaultCircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SnsClientDefaultMaxErrorRetry => (int)((SettingsBase)this)["SnsClientDefaultMaxErrorRetry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSnsClientThrottleRetriesEnabled => (bool)((SettingsBase)this)["IsSnsClientThrottleRetriesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsSnsClientCircuitBreakerEnabledByDefault => (bool)((SettingsBase)this)["IsSnsClientCircuitBreakerEnabledByDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsSnsClientAsyncRequestTimeoutEnabledByDefault => (bool)((SettingsBase)this)["IsSnsClientAsyncRequestTimeoutEnabledByDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int TotalNumberOfRetryAttemptsPerRegion => (int)((SettingsBase)this)["TotalNumberOfRetryAttemptsPerRegion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:10")]
	public TimeSpan PercentileCounterUpdateInterval => (TimeSpan)((SettingsBase)this)["PercentileCounterUpdateInterval"];

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
