using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration for Billing related features
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class Billing : ApplicationSettingsBase
{
	private static Billing defaultInstance = (Billing)SettingsBase.Synchronized(new Billing());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Billing Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PaymentHistoryEnabledForSoothsayers => (bool)this["PaymentHistoryEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PaymentHistoryEnabledForAll => (bool)this["PaymentHistoryEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PaymentHistoryRolloutPercentage => (int)this["PaymentHistoryRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XsollaCreditCardsEnabledForSoothsayers => (bool)this["XsollaCreditCardsEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int XsollaCreditCardsRolloutPercentage => (int)this["XsollaCreditCardsRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://sandbox-secure.xsolla.com/paystation2/?access_token={0}")]
	public string XsollaPaymentUiUrl => (string)this["XsollaPaymentUiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CanadaOnlyAbTestVariation => (int)this["CanadaOnlyAbTestVariation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XsollaDisabledForInGamePurchases => (bool)this["XsollaDisabledForInGamePurchases"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PaymentNewFlowEnabledForSoothsayers => (bool)this["PaymentNewFlowEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PaymentNewFlowRolloutPercentage => (int)this["PaymentNewFlowRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XsollaOxxoEnabledForSoothsayers => (bool)this["XsollaOxxoEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int XsollaOxxoRolloutPercentage => (int)this["XsollaOxxoRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://sandbox-secure.xsolla.com")]
	public string XsollaValidOrigin => (string)this["XsollaValidOrigin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:05")]
	public TimeSpan ShoppingCartLockDuration => (TimeSpan)this["ShoppingCartLockDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XsollaBoletoEnabledForSoothsayers => (bool)this["XsollaBoletoEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int XsollaBoletoRolloutPercentage => (int)this["XsollaBoletoRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XsollaSofortEnabledForSoothsayers => (bool)this["XsollaSofortEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int XsollaSofortRolloutPercentage => (int)this["XsollaSofortRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Arizona,Colorado,Connecticut,Hawaii,Kentucky,Maine,Minnesota,Massachusetts,Mississippi,New Mexico,New York,Pennsylvania,South Carolina,South Dakota,Tennessee,Texas,Utah,Washington,Wisconsin")]
	public string XsollaMandatedStates => (string)this["XsollaMandatedStates"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public string VantivThreatMetrixPageId => (string)this["VantivThreatMetrixPageId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://h.online-metrix.net/fp/tags.js")]
	public string VantivThreatMetrixScriptUrlPrefix => (string)this["VantivThreatMetrixScriptUrlPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://h.online-metrix.net/tags")]
	public string VantivThreatMetrixIframeUrlPrefix => (string)this["VantivThreatMetrixIframeUrlPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivThreatMetrixOrgId => (string)this["VantivThreatMetrixOrgId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVantivThreatMetrixEnabled => (bool)this["IsVantivThreatMetrixEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("roblx-")]
	public string VantivThreatMetrixSessionIdPrefix => (string)this["VantivThreatMetrixSessionIdPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("DE")]
	public string XsollaSofortSupportedCountryCodes => (string)this["XsollaSofortSupportedCountryCodes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int MaxUserAgentLogInputPrefixLength => (int)this["MaxUserAgentLogInputPrefixLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PurchaseSuccess")]
	public string UserAgentCounterNamePrefixWhitelist => (string)this["UserAgentCounterNamePrefixWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://midas.gtimg.cn/midas/minipay_v2/jsapi/cashier.js")]
	public string MidasClientSideScriptUrl => (string)this["MidasClientSideScriptUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CustomerSupportBillingNumber => (string)this["CustomerSupportBillingNumber"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSupportAStarEnabled => (bool)this["IsSupportAStarEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SupportAStarCodesCsv => (string)this["SupportAStarCodesCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SupportAStarNamesCsv => (string)this["SupportAStarNamesCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("600000")]
	public int SupportAStarExpiryInMs => (int)this["SupportAStarExpiryInMs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Have a code to support your favorite star?")]
	public string SupportAStarMainMessage => (string)this["SupportAStarMainMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Enter a star tag:")]
	public string SupportAStarInputHeader => (string)this["SupportAStarInputHeader"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Star Code successfully added!")]
	public string SupportAStarValidCodeMessage => (string)this["SupportAStarValidCodeMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Invalid Star Code")]
	public string SupportAStarInvalidCodeMessage => (string)this["SupportAStarInvalidCodeMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsXsollaPaymentFallbackErrorLogEnabled => (bool)this["IsXsollaPaymentFallbackErrorLogEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPremiumRobuxAbTestEnabledForAll => (bool)this["IsPremiumRobuxAbTestEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsBCOnlyRequirementEnabled => (bool)this["IsBCOnlyRequirementEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MembershipWebAppRolloutPercentage => (int)this["MembershipWebAppRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMembershipWebAppForSoothsayerEnabled => (bool)this["IsMembershipWebAppForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SupportAStarBrowserTrackerIdCsv => (string)this["SupportAStarBrowserTrackerIdCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMembershipMigrationScreenEnabled => (bool)this["IsMembershipMigrationScreenEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMembershipMigrationScreenEnabledForSoothsayers => (bool)this["IsMembershipMigrationScreenEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBenefitRowsDeletedForPremium => (bool)this["IsBenefitRowsDeletedForPremium"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsXsollaSavedCreditCardAbTestEnabledForAll => (bool)this["IsXsollaSavedCreditCardAbTestEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XsollaAmazonPayEnabledForSoothsayers => (bool)this["XsollaAmazonPayEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int XsollaAmazonPayRolloutPercentage => (int)this["XsollaAmazonPayRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("GB")]
	public string XsollaAmazonSupportedCountryCodes => (string)this["XsollaAmazonSupportedCountryCodes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://support.apple.com/en-us/HT202039")]
	public string AppleCancellationDirectionsUrl => (string)this["AppleCancellationDirectionsUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://support.google.com/googleplay/answer/7018481")]
	public string GoogleCancellationDirectionsUrl => (string)this["GoogleCancellationDirectionsUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewCancellationFlowEnabled => (bool)this["IsNewCancellationFlowEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUpgradeGreenButtonForSoothsayerEnabled => (bool)this["IsUpgradeGreenButtonForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UpgradeGreenButtonRolloutPercentage => (int)this["UpgradeGreenButtonRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobuxGreenButtonForSoothsayerEnabled => (bool)this["IsRobuxGreenButtonForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int RobuxGreenButtonRolloutPercentage => (int)this["RobuxGreenButtonRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsClbRobuxGreenButtonForSoothsayerEnabled => (bool)this["IsClbRobuxGreenButtonForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ClbRobuxGreenButtonRolloutPercentage => (int)this["ClbRobuxGreenButtonRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxCreditWebAppEnabled => (bool)this["IsRobloxCreditWebAppEnabled"];

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

	internal Billing()
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
