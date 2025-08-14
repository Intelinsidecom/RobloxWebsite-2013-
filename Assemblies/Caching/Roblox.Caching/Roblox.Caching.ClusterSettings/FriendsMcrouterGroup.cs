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
internal sealed class FriendsMcrouterGroup : ApplicationSettingsBase, IExposedMemCachedClientSettings, INotifyPropertyChanged
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static FriendsMcrouterGroup defaultInstance = (FriendsMcrouterGroup)(object)SettingsBase.Synchronized((SettingsBase)(object)new FriendsMcrouterGroup());

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string propName) => base[propertyName]);
		}
		set
		{
			base[propertyName] = value;
		}
	}

	public static FriendsMcrouterGroup Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConnectionCreationRateLimitingEnabled => (bool)base["IsConnectionCreationRateLimitingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan ConnectionCreationRateLimitPeriodLength => (TimeSpan)base["ConnectionCreationRateLimitPeriodLength"];

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaximumConnectionCreationsPerPeriod
	{
		get
		{
			return (int)base["MaximumConnectionCreationsPerPeriod"];
		}
		set
		{
			base["MaximumConnectionCreationsPerPeriod"] = value;
		}
	}

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaximumNumberOfSocketsPerPool => (int)base["MaximumNumberOfSocketsPerPool"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.5000000")]
	public TimeSpan PooledSocketConstructionSocketConnectTimeout => (TimeSpan)base["PooledSocketConstructionSocketConnectTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.1500000")]
	public TimeSpan ConnectionCircuitBreakerRetryInterval => (TimeSpan)base["ConnectionCircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsExecutionCircuitBreakerEnabled => (bool)base["IsExecutionCircuitBreakerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.0100000")]
	public TimeSpan ExecutionCircuitBreakerRetryInterval => (TimeSpan)base["ExecutionCircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("TimedOut")]
	public string SocketErrorsThatTripExecutionCircuitBreakerCsv => (string)base["SocketErrorsThatTripExecutionCircuitBreakerCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int ExecutionCircuitBreakerExceptionCountForTripping => (int)base["ExecutionCircuitBreakerExceptionCountForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.5000000")]
	public TimeSpan ExecutionCircuitBreakerExceptionIntervalForTripping => (TimeSpan)base["ExecutionCircuitBreakerExceptionIntervalForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PerHostExpiryOverridesCsv => (string)base["PerHostExpiryOverridesCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PerHostExpiryOverridesEnabled => (bool)base["PerHostExpiryOverridesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int ConnectionCircuitBreakerExceptionCountForTripping => (int)base["ConnectionCircuitBreakerExceptionCountForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.1000000")]
	public TimeSpan ConnectionCircuitBreakerExceptionIntervalForTripping => (TimeSpan)base["ConnectionCircuitBreakerExceptionIntervalForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NotSupportedException")]
	public string ExceptionTypeNamesToForceResetBytesCsv => (string)base["ExceptionTypeNamesToForceResetBytesCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int ForceResetBytesMaxAttempts => (int)base["ForceResetBytesMaxAttempts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("256")]
	public int ForceResetBytesMaxNumberOfBytes => (int)base["ForceResetBytesMaxNumberOfBytes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogVerboseExceptions => (bool)base["LogVerboseExceptions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsRespectingMaxPoolSizeEnabled => (bool)base["IsRespectingMaxPoolSizeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseRoundRobinSocketPoolSelection => (bool)base["UseRoundRobinSocketPoolSelection"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int MaximumSelectionAttemptsForRoundRobin => (int)base["MaximumSelectionAttemptsForRoundRobin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public uint MinimumPoolSize => (uint)base["MinimumPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public uint MaximumPoolSize => (uint)base["MaximumPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan SendReceiveTimeout => (TimeSpan)base["SendReceiveTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan SocketRecycleAge => (TimeSpan)base["SocketRecycleAge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("131072")]
	public uint CompressionThreshold => (uint)base["CompressionThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUpgradedDnsResolvingEnabled => (bool)base["IsUpgradedDnsResolvingEnabled"];

	internal FriendsMcrouterGroup()
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
