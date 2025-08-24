using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.CommunitySift.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase, ICommunitySiftSettings, INotifyPropertyChanged, ICommunitySiftTopicTranslatorSettings
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
	[DefaultSettingValue("00:00:30")]
	public TimeSpan CommunitySiftCircuitBreakerRetryInterval => (TimeSpan)this["CommunitySiftCircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CommunitySiftApiKey => (string)this["CommunitySiftApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CommunitySiftApiEndpoint => (string)this["CommunitySiftApiEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:10")]
	public TimeSpan CommunitySiftClientTimeoutInterval => (TimeSpan)this["CommunitySiftClientTimeoutInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double CommunitySiftTextFilterPercentage => (double)this["CommunitySiftTextFilterPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDetailedCommunitySiftErrorLoggingEnabled => (bool)this["IsDetailedCommunitySiftErrorLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftTextFiltering13AndOverRule => (int)this["CommunitySiftTextFiltering13AndOverRule"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftTextFilteringUnder13Rule => (int)this["CommunitySiftTextFilteringUnder13Rule"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CommunitySiftForSoothsayersEnabled => (bool)this["CommunitySiftForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("chat")]
	public string CommunitySiftChatEndpoint => (string)this["CommunitySiftChatEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("workflow/call/fp_check_long_text")]
	public string CommunitySiftLongTextEndpoint => (string)this["CommunitySiftLongTextEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("workflow/call/fp_check_chat_extra_hash")]
	public string CommunitySiftDoubleChatEndpoint => (string)this["CommunitySiftDoubleChatEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("workflow/call/fp_check_username")]
	public string CommunitySiftUserNameEndpoint => (string)this["CommunitySiftUserNameEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftUserNameFiltering13AndOverRule => (int)this["CommunitySiftUserNameFiltering13AndOverRule"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftUserNameFilteringUnder13Rule => (int)this["CommunitySiftUserNameFilteringUnder13Rule"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftGeneralRiskThreshold13AndOver => (int)this["CommunitySiftGeneralRiskThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftBullyingThreshold13AndOver => (int)this["CommunitySiftBullyingThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftFightingThreshold13AndOver => (int)this["CommunitySiftFightingThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftPIIThreshold13AndOver => (int)this["CommunitySiftPIIThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftDatingAndSextingThreshold13AndOver => (int)this["CommunitySiftDatingAndSextingThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftVulgarThreshold13AndOver => (int)this["CommunitySiftVulgarThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftDrugsAndAlcoholThreshold13AndOver => (int)this["CommunitySiftDrugsAndAlcoholThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftInGameThreshold13AndOver => (int)this["CommunitySiftInGameThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftAlarmThreshold13AndOver => (int)this["CommunitySiftAlarmThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftFraudThreshold13AndOver => (int)this["CommunitySiftFraudThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftRacistThreshold13AndOver => (int)this["CommunitySiftRacistThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftReligionThreshold13AndOver => (int)this["CommunitySiftReligionThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftJunkThreshold13AndOver => (int)this["CommunitySiftJunkThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftWebsiteThreshold13AndOver => (int)this["CommunitySiftWebsiteThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftGroomingThreshold13AndOver => (int)this["CommunitySiftGroomingThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftPublicThreatsThreshold13AndOver => (int)this["CommunitySiftPublicThreatsThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftRealNameThreshold13AndOver => (int)this["CommunitySiftRealNameThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftRadicalizationThreshold13AndOver => (int)this["CommunitySiftRadicalizationThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftSubversiveThreshold13AndOver => (int)this["CommunitySiftSubversiveThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftSentimentThreshold13AndOver => (int)this["CommunitySiftSentimentThreshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftCustom1Threshold13AndOver => (int)this["CommunitySiftCustom1Threshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftCustom2Threshold13AndOver => (int)this["CommunitySiftCustom2Threshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftCustom3Threshold13AndOver => (int)this["CommunitySiftCustom3Threshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftCustom4Threshold13AndOver => (int)this["CommunitySiftCustom4Threshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftCustom5Threshold13AndOver => (int)this["CommunitySiftCustom5Threshold13AndOver"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftGeneralRiskThresholdUnder13 => (int)this["CommunitySiftGeneralRiskThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftBullyingThresholdUnder13 => (int)this["CommunitySiftBullyingThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftFightingThresholdUnder13 => (int)this["CommunitySiftFightingThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftPIIThresholdUnder13 => (int)this["CommunitySiftPIIThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftDatingAndSextingThresholdUnder13 => (int)this["CommunitySiftDatingAndSextingThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftVulgarThresholdUnder13 => (int)this["CommunitySiftVulgarThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftDrugsAndAlcoholThresholdUnder13 => (int)this["CommunitySiftDrugsAndAlcoholThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftInGameThresholdUnder13 => (int)this["CommunitySiftInGameThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftAlarmThresholdUnder13 => (int)this["CommunitySiftAlarmThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftFraudThresholdUnder13 => (int)this["CommunitySiftFraudThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftRacistThresholdUnder13 => (int)this["CommunitySiftRacistThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftReligionThresholdUnder13 => (int)this["CommunitySiftReligionThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftJunkThresholdUnder13 => (int)this["CommunitySiftJunkThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftWebsiteThresholdUnder13 => (int)this["CommunitySiftWebsiteThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftGroomingThresholdUnder13 => (int)this["CommunitySiftGroomingThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftPublicThreatsThresholdUnder13 => (int)this["CommunitySiftPublicThreatsThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftRealNameThresholdUnder13 => (int)this["CommunitySiftRealNameThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftRadicalizationThresholdUnder13 => (int)this["CommunitySiftRadicalizationThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftSubversiveThresholdUnder13 => (int)this["CommunitySiftSubversiveThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftSentimentThresholdUnder13 => (int)this["CommunitySiftSentimentThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftCustom1ThresholdUnder13 => (int)this["CommunitySiftCustom1ThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftCustom2ThresholdUnder13 => (int)this["CommunitySiftCustom2ThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftCustom3ThresholdUnder13 => (int)this["CommunitySiftCustom3ThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftCustom4ThresholdUnder13 => (int)this["CommunitySiftCustom4ThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CommunitySiftCustom5ThresholdUnder13 => (int)this["CommunitySiftCustom5ThresholdUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("workflow/call/fp_check_short_text")]
	public string CommunitySiftChatNoContextEndpoint => (string)this["CommunitySiftChatNoContextEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int CommunitySiftCircuitBreakerTimeoutsBeforeTrip => (int)this["CommunitySiftCircuitBreakerTimeoutsBeforeTrip"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:02")]
	public TimeSpan CommunitySiftCircuitBreakerTimeoutInterval => (TimeSpan)this["CommunitySiftCircuitBreakerTimeoutInterval"];

	internal Settings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}
