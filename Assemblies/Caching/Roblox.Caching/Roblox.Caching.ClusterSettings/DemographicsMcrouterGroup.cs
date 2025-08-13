using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Caching.ClusterSettings;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
internal sealed class DemographicsMcrouterGroup : ApplicationSettingsBase, IExposedMemCachedClientSettings, INotifyPropertyChanged
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static DemographicsMcrouterGroup defaultInstance = (DemographicsMcrouterGroup)(object)SettingsBase.Synchronized((SettingsBase)(object)new ThumbnailsMcrouterGroup());

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

	public static DemographicsMcrouterGroup Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConnectionCreationRateLimitingEnabled => (bool)((SettingsBase)this)["IsConnectionCreationRateLimitingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan ConnectionCreationRateLimitPeriodLength => (TimeSpan)((SettingsBase)this)["ConnectionCreationRateLimitPeriodLength"];

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaximumConnectionCreationsPerPeriod
	{
		get
		{
			return (int)((SettingsBase)this)["MaximumConnectionCreationsPerPeriod"];
		}
		set
		{
			((SettingsBase)this)["MaximumConnectionCreationsPerPeriod"] = value;
		}
	}

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaximumNumberOfSocketsPerPool => (int)((SettingsBase)this)["MaximumNumberOfSocketsPerPool"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.5000000")]
	public TimeSpan PooledSocketConstructionSocketConnectTimeout => (TimeSpan)((SettingsBase)this)["PooledSocketConstructionSocketConnectTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.1500000")]
	public TimeSpan ConnectionCircuitBreakerRetryInterval => (TimeSpan)((SettingsBase)this)["ConnectionCircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsExecutionCircuitBreakerEnabled => (bool)((SettingsBase)this)["IsExecutionCircuitBreakerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.0100000")]
	public TimeSpan ExecutionCircuitBreakerRetryInterval => (TimeSpan)((SettingsBase)this)["ExecutionCircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("TimedOut")]
	public string SocketErrorsThatTripExecutionCircuitBreakerCsv => (string)((SettingsBase)this)["SocketErrorsThatTripExecutionCircuitBreakerCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int ExecutionCircuitBreakerExceptionCountForTripping => (int)((SettingsBase)this)["ExecutionCircuitBreakerExceptionCountForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.5000000")]
	public TimeSpan ExecutionCircuitBreakerExceptionIntervalForTripping => (TimeSpan)((SettingsBase)this)["ExecutionCircuitBreakerExceptionIntervalForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PerHostExpiryOverridesCsv => (string)((SettingsBase)this)["PerHostExpiryOverridesCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PerHostExpiryOverridesEnabled => (bool)((SettingsBase)this)["PerHostExpiryOverridesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int ConnectionCircuitBreakerExceptionCountForTripping => (int)((SettingsBase)this)["ConnectionCircuitBreakerExceptionCountForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.1000000")]
	public TimeSpan ConnectionCircuitBreakerExceptionIntervalForTripping => (TimeSpan)((SettingsBase)this)["ConnectionCircuitBreakerExceptionIntervalForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NotSupportedException")]
	public string ExceptionTypeNamesToForceResetBytesCsv => (string)((SettingsBase)this)["ExceptionTypeNamesToForceResetBytesCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int ForceResetBytesMaxAttempts => (int)((SettingsBase)this)["ForceResetBytesMaxAttempts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("256")]
	public int ForceResetBytesMaxNumberOfBytes => (int)((SettingsBase)this)["ForceResetBytesMaxNumberOfBytes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogVerboseExceptions => (bool)((SettingsBase)this)["LogVerboseExceptions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsRespectingMaxPoolSizeEnabled => (bool)((SettingsBase)this)["IsRespectingMaxPoolSizeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseRoundRobinSocketPoolSelection => (bool)((SettingsBase)this)["UseRoundRobinSocketPoolSelection"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MaximumSelectionAttemptsForRoundRobin => (int)((SettingsBase)this)["MaximumSelectionAttemptsForRoundRobin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public uint MinimumPoolSize => (uint)((SettingsBase)this)["MinimumPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public uint MaximumPoolSize => (uint)((SettingsBase)this)["MaximumPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan SendReceiveTimeout => (TimeSpan)((SettingsBase)this)["SendReceiveTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan SocketRecycleAge => (TimeSpan)((SettingsBase)this)["SocketRecycleAge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("131072")]
	public uint CompressionThreshold => (uint)((SettingsBase)this)["CompressionThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUpgradedDnsResolvingEnabled => (bool)((SettingsBase)this)["IsUpgradedDnsResolvingEnabled"];

	internal DemographicsMcrouterGroup()
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
