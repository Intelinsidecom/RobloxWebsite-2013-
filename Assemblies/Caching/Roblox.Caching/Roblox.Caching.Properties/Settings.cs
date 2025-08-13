using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Caching.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
internal sealed class Settings : ApplicationSettingsBase, ISettings, INotifyPropertyChanged
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
	public string SharedCacheAddresses => (string)((SettingsBase)this)["SharedCacheAddresses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("dv-")]
	public string SharedCacheKeyPrefix => (string)((SettingsBase)this)["SharedCacheKeyPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public uint MaxPoolSize => (uint)((SettingsBase)this)["MaxPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public uint MinPoolSize => (uint)((SettingsBase)this)["MinPoolSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan RampUpTime => (TimeSpan)((SettingsBase)this)["RampUpTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SharedCacheWebAddresses => (string)((SettingsBase)this)["SharedCacheWebAddresses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RemoteCacheableEntities => (string)((SettingsBase)this)["RemoteCacheableEntities"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan RemoteCacheableExpiration => (TimeSpan)((SettingsBase)this)["RemoteCacheableExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RedisEntityCacheAddresses => (string)((SettingsBase)this)["RedisEntityCacheAddresses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTypeSpecificRampUpEnabledV2 => (bool)((SettingsBase)this)["IsTypeSpecificRampUpEnabledV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2000")]
	public int SampleStackTraceSubstringLength => (int)((SettingsBase)this)["SampleStackTraceSubstringLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:30:00")]
	public TimeSpan MemcachedSocketRecycleAge => (TimeSpan)((SettingsBase)this)["MemcachedSocketRecycleAge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:02")]
	public TimeSpan MemcachedSendReceiveTimeout => (TimeSpan)((SettingsBase)this)["MemcachedSendReceiveTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:10")]
	public TimeSpan DelayBeforeDisposingClientOnAddressesChangeForGroupClients => (TimeSpan)((SettingsBase)this)["DelayBeforeDisposingClientOnAddressesChangeForGroupClients"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.1500000")]
	public TimeSpan MemcachedClientConnectionCircuitBreakerRetryInterval => (TimeSpan)((SettingsBase)this)["MemcachedClientConnectionCircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100000")]
	public int MemcachedMaximumNumberOfSocketsPerPool => (int)((SettingsBase)this)["MemcachedMaximumNumberOfSocketsPerPool"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan MemcachedPooledSocketConstructionSocketConnectTimeout => (TimeSpan)((SettingsBase)this)["MemcachedPooledSocketConstructionSocketConnectTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMemcachedClientExecutionCircuitBreakerEnabled => (bool)((SettingsBase)this)["IsMemcachedClientExecutionCircuitBreakerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.0100000")]
	public TimeSpan MemcachedClientExecutionCircuitBreakerRetryInterval => (TimeSpan)((SettingsBase)this)["MemcachedClientExecutionCircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("TimedOut")]
	public string MemcachedClientExecutionSocketErrorsThatTripCircuitBreakerCsv => (string)((SettingsBase)this)["MemcachedClientExecutionSocketErrorsThatTripCircuitBreakerCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int MemcachedClientExecutionCircuitBreakerExceptionCountForTripping => (int)((SettingsBase)this)["MemcachedClientExecutionCircuitBreakerExceptionCountForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.5000000")]
	public TimeSpan MemcachedClientExecutionCircuitBreakerExceptionIntervalForTripping => (TimeSpan)((SettingsBase)this)["MemcachedClientExecutionCircuitBreakerExceptionIntervalForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MemcachedClientPerHostExpiryOverrides => (string)((SettingsBase)this)["MemcachedClientPerHostExpiryOverrides"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MemcachedClientPerHostExpiryOverridesEnabled => (bool)((SettingsBase)this)["MemcachedClientPerHostExpiryOverridesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MemcachedClientConnectionCircuitBreakerExceptionCountForTripping => (int)((SettingsBase)this)["MemcachedClientConnectionCircuitBreakerExceptionCountForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.0100000")]
	public TimeSpan MemcachedClientConnectionCircuitBreakerExceptionIntervalForTripping => (TimeSpan)((SettingsBase)this)["MemcachedClientConnectionCircuitBreakerExceptionIntervalForTripping"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MemcachedClientExceptionTypeNamesToForceResetBytes => (string)((SettingsBase)this)["MemcachedClientExceptionTypeNamesToForceResetBytes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MemcachedClientForceResetBytesMaxAttempts => (int)((SettingsBase)this)["MemcachedClientForceResetBytesMaxAttempts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("256")]
	public int MemcachedClientForceResetBytesMaxNumberOfBytes => (int)((SettingsBase)this)["MemcachedClientForceResetBytesMaxNumberOfBytes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MemcachedClientLogVerboseExceptions => (bool)((SettingsBase)this)["MemcachedClientLogVerboseExceptions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan DelayBeforeDisposingMemcachedObjectClientOnAddressesChange => (TimeSpan)((SettingsBase)this)["DelayBeforeDisposingMemcachedObjectClientOnAddressesChange"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsMemcachedClientRespectingMaxPoolSizeEnabled => (bool)((SettingsBase)this)["IsMemcachedClientRespectingMaxPoolSizeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MemcachedClientUseRoundRobinSocketPoolSelection => (bool)((SettingsBase)this)["MemcachedClientUseRoundRobinSocketPoolSelection"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MemcachedClientMaximumSelectionAttemptsForRoundRobin => (int)((SettingsBase)this)["MemcachedClientMaximumSelectionAttemptsForRoundRobin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("131072")]
	public uint MemcachedCompressionThreshold => (uint)((SettingsBase)this)["MemcachedCompressionThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsLoggingMigrationConfigurationErrorsEnabled => (bool)((SettingsBase)this)["IsLoggingMigrationConfigurationErrorsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsReadingFromWriteCacheForMigrationInBackground => (bool)((SettingsBase)this)["IsReadingFromWriteCacheForMigrationInBackground"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUpgradedDnsResolvingEnabled => (bool)((SettingsBase)this)["IsUpgradedDnsResolvingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NameserversCsv => (string)((SettingsBase)this)["NameserversCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RedisEntityCacheMigrationState => (string)((SettingsBase)this)["RedisEntityCacheMigrationState"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public uint WriteOnlySourceReadWriteDestinationRolloutPerThousand => (uint)((SettingsBase)this)["WriteOnlySourceReadWriteDestinationRolloutPerThousand"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public uint ReadWriteSourceDeleteOnlyDestinationRolloutPerThousand => (uint)((SettingsBase)this)["ReadWriteSourceDeleteOnlyDestinationRolloutPerThousand"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan EndpointCacheExpiry => (TimeSpan)((SettingsBase)this)["EndpointCacheExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("MemcachedWebMcrouterCacheGroup")]
	public string MemcachedWebMigrationCacheGroupName => (string)((SettingsBase)this)["MemcachedWebMigrationCacheGroupName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("MemcachedObjectMcrouterCacheGroup")]
	public string MemcachedObjectMigrationCacheGroupName => (string)((SettingsBase)this)["MemcachedObjectMigrationCacheGroupName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NoMigration,NoMigration,0")]
	public MigrationStateChange MemcachedWebMigrationState => (MigrationStateChange)((SettingsBase)this)["MemcachedWebMigrationState"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NoMigration,NoMigration,0")]
	public MigrationStateChange MemcachedObjectMigrationState => (MigrationStateChange)((SettingsBase)this)["MemcachedObjectMigrationState"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConnectionCreationRateLimitingEnabled => (bool)((SettingsBase)this)["IsConnectionCreationRateLimitingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan ConnectionCreationRateLimitPeriodLength => (TimeSpan)((SettingsBase)this)["ConnectionCreationRateLimitPeriodLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaximumConnectionCreationsPerPeriod => (int)((SettingsBase)this)["MaximumConnectionCreationsPerPeriod"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:15:00")]
	public TimeSpan CacheSlidingExpiration => (TimeSpan)((SettingsBase)this)["CacheSlidingExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsEntityDeserializationFailureLoggingEnabled => (bool)((SettingsBase)this)["IsEntityDeserializationFailureLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsEntityDeserializationFailureCounterEnabled => (bool)((SettingsBase)this)["IsEntityDeserializationFailureCounterEnabled"];

	internal Settings()
	{
		((ApplicationSettingsBase)this).PropertyChanged += delegate
		{
			_Properties.Clear();
		};
	}

	protected override void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		((ApplicationSettingsBase)this).OnPropertyChanged(sender, e);
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		((ApplicationSettingsBase)this).OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, (ApplicationSettingsBase)(object)this);
	}
}
