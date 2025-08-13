using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Common.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://localhost:3966/RobloxWebSite")]
	public string ApplicationURL => (string)this["ApplicationURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReplicateLocalCache => (bool)this["ReplicateLocalCache"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.05")]
	public string CacheReplicatorWaitTime => (string)this["CacheReplicatorWaitTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("224.168.100.2")]
	public string CacheReplicatorAddress => (string)this["CacheReplicatorAddress"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("11000")]
	public int CacheReplicatorPort => (int)this["CacheReplicatorPort"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("60000")]
	public int CacheReplicatorBatchSize => (int)this["CacheReplicatorBatchSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.1")]
	public string CacheReplicatorSendTimeout => (string)this["CacheReplicatorSendTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("192.168")]
	public string CacheReplicatorNicPrefix => (string)this["CacheReplicatorNicPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public uint PgmWindowSizeInMB => (uint)this["PgmWindowSizeInMB"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:10")]
	public TimeSpan PgmWindowSizeTimeSpan => (TimeSpan)this["PgmWindowSizeTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string BillingConnectionString => (string)this["BillingConnectionString"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("300")]
	public int ClientPresenceUpdateIntervalInSeconds => (int)this["ClientPresenceUpdateIntervalInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("!0x5f3759df")]
	public string AccessKey => (string)this["AccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FacebookUploadEnabled => (bool)this["FacebookUploadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FacebookDescriptionEnabled => (bool)this["FacebookDescriptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("256")]
	public int MaxMemorySizeForImageUploadingInMB => (int)this["MaxMemorySizeForImageUploadingInMB"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClientVersion => (string)this["ClientVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BetaFeaturePlaceIds => (string)this["BetaFeaturePlaceIds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClientMacInstallUrl => (string)this["ClientMacInstallUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Slurp|slurp|ask|Ask|Teoma|teoma|Scooter|Mercator|MSNBOT|Gulliver|Spider|spider|Archiver|archiver|Crawler|crawler|Bot |Bot\\-|Bot\\/|bot |bot\\-|bot\\/|Mediapartners-Google")]
	public string CrawlerUserAgentRegex => (string)this["CrawlerUserAgentRegex"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReuseCrawlerUserAgentRegex => (bool)this["ReuseCrawlerUserAgentRegex"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AlternateAccessKey => (string)this["AlternateAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VerifyBothGameServerIpAndAccessKey => (bool)this["VerifyBothGameServerIpAndAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int EnvironmentId => (int)this["EnvironmentId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int DatabaseBulkQueryLimit => (int)this["DatabaseBulkQueryLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool EnableXForwardedForOriginIp => (bool)this["EnableXForwardedForOriginIp"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IncludeTestEmailIdentifiers => (bool)this["IncludeTestEmailIdentifiers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string EnvironmentIdentifier => (string)this["EnvironmentIdentifier"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PlaceVisitAccessKey => (string)this["PlaceVisitAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableDosArrestRealIpHeaderForOriginIP => (bool)this["EnableDosArrestRealIpHeaderForOriginIP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableXForwardedProtoOriginProtocol => (bool)this["EnableXForwardedProtoOriginProtocol"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableSecureIpHeadersForOriginIp => (bool)this["EnableSecureIpHeadersForOriginIp"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SecureIpEdgeProxySecretKey => (string)this["SecureIpEdgeProxySecretKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableProxyUrlDetection => (bool)this["EnableProxyUrlDetection"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ProxyUrlDomainsCsv => (string)this["ProxyUrlDomainsCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SecureIpCnProxySecretKey => (string)this["SecureIpCnProxySecretKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableWhitelistProxiedIpHeadersForOriginIp => (bool)this["EnableWhitelistProxiedIpHeadersForOriginIp"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SecureIpCnProxySecretKey2 => (string)this["SecureIpCnProxySecretKey2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableSecureIpHeadersHashCheck => (bool)this["EnableSecureIpHeadersHashCheck"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EntityHelperUsesCacheMultigetV4 => (bool)this["EntityHelperUsesCacheMultigetV4"];

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
