using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Amazon.DynamoDb.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
internal sealed class DaxClusterClientSettings : ApplicationSettingsBase, IDaxClusterClientSettings, INotifyPropertyChanged
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static DaxClusterClientSettings defaultInstance = (DaxClusterClientSettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new DaxClusterClientSettings());

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

	public static DaxClusterClientSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsCircuitBreakerEnabled => (bool)((SettingsBase)this)["IsCircuitBreakerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsAsyncRequestTimeoutEnabled => (bool)((SettingsBase)this)["IsAsyncRequestTimeoutEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:05")]
	public TimeSpan RequestTimeout => (TimeSpan)((SettingsBase)this)["RequestTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int FailuresAllowedBeforeCircuitBreakerTrip => (int)((SettingsBase)this)["FailuresAllowedBeforeCircuitBreakerTrip"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.2500000")]
	public TimeSpan CircuitBreakerRetryInterval => (TimeSpan)((SettingsBase)this)["CircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFailuresToTripOnExtendedModeEnabled => (bool)((SettingsBase)this)["IsFailuresToTripOnExtendedModeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaxPendingConnections => (int)((SettingsBase)this)["MaxPendingConnections"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan HealthCheckTimeout => (TimeSpan)((SettingsBase)this)["HealthCheckTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:05")]
	public TimeSpan HealthCheckInterval => (TimeSpan)((SettingsBase)this)["HealthCheckInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:03")]
	public TimeSpan ConnectTimeout => (TimeSpan)((SettingsBase)this)["ConnectTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("us-east-1")]
	public string RegionEndpointSystemName => (string)((SettingsBase)this)["RegionEndpointSystemName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int WriteRetryCount => (int)((SettingsBase)this)["WriteRetryCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int ReadRetryCount => (int)((SettingsBase)this)["ReadRetryCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan ClusterUpdateInterval => (TimeSpan)((SettingsBase)this)["ClusterUpdateInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.1250000")]
	public TimeSpan ClusterUpdateThresholdTime => (TimeSpan)((SettingsBase)this)["ClusterUpdateThresholdTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:05")]
	public TimeSpan MaxRetryDelayTime => (TimeSpan)((SettingsBase)this)["MaxRetryDelayTime"];

	internal DaxClusterClientSettings()
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
