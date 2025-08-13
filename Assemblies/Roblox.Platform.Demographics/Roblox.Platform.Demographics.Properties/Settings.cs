using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Demographics.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
public sealed class Settings : ApplicationSettingsBase, IAccountPhoneNumberFactorySettings, IAccountPhoneNumberDisconnectorSettings, ILocalizedCountryProviderSettings, ICountryNameTranslationCacheSettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

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
	[DefaultSettingValue("60.00:00:00")]
	public TimeSpan IPAddressLookupRefreshInterval => (TimeSpan)this["IPAddressLookupRefreshInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUsersConnectionString => (string)this["RobloxUsersConnectionString"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableGeoposition => (bool)this["EnableGeoposition"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountPhoneNumberTableAuditingEnabled => (bool)this["IsAccountPhoneNumberTableAuditingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/login/revertAccount?ticket=")]
	public string AccountSecurityTicketRevertUrl => (string)this["AccountSecurityTicketRevertUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ArePhoneNumberEphemeralCountersEnabled => (bool)this["ArePhoneNumberEphemeralCountersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsContactUpsellForSoothsayersEnabled => (bool)this["IsContactUpsellForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsContactUpsellForBetaTestersEnabled => (bool)this["IsContactUpsellForBetaTestersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ContactUpsellRolloutPercentage => (int)this["ContactUpsellRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsContactUpsellPostFriendFinderEnabled => (bool)this["IsContactUpsellPostFriendFinderEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int UserFloodCheckerLimit => (int)this["UserFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan UserFloodCheckerWindowPeriod => (TimeSpan)this["UserFloodCheckerWindowPeriod"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserFloodCheckerEnabled => (bool)this["UserFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserFloodCheckerRecordFloodedEvents => (bool)this["UserFloodCheckerRecordFloodedEvents"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int IpFloodCheckerLimit => (int)this["IpFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan IpFloodCheckerWindowPeriod => (TimeSpan)this["IpFloodCheckerWindowPeriod"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IpFloodCheckerEnabled => (bool)this["IpFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IpFloodCheckerRecordFloodedEvents => (bool)this["IpFloodCheckerRecordFloodedEvents"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GeopositionLookupByIpFloodcheckEnabled => (bool)this["GeopositionLookupByIpFloodcheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int GeopositionLookupByIpFloodcheckLimit => (int)this["GeopositionLookupByIpFloodcheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan GeopositionLookupByIpFloodcheckExpiry => (TimeSpan)this["GeopositionLookupByIpFloodcheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int AccountPhoneNumbersPageSize => (int)this["AccountPhoneNumbersPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int PhoneNumbersAuditMetadataPageSize => (int)this["PhoneNumbersAuditMetadataPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCountryNameTranslationEnabled => (bool)this["IsCountryNameTranslationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsCountryNameTranslationCachingEnabled => (bool)this["IsCountryNameTranslationCachingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2.00:00:00")]
	public TimeSpan CountryNameTranslationCachingExpiration => (TimeSpan)this["CountryNameTranslationCachingExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBypassPromptUsersWithUnknownGenderEnabled => (bool)this["IsBypassPromptUsersWithUnknownGenderEnabled"];

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
