using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Billing.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal EmailChargeLimit_Monthly => (decimal)this["EmailChargeLimit_Monthly"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CreditCardNewUnverifiedAccountLimitEnabled => (bool)this["CreditCardNewUnverifiedAccountLimitEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CreditCardTransactionCountLimit_Daily => (int)this["CreditCardTransactionCountLimit_Daily"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public byte NewAccountPeriodInDays => (byte)this["NewAccountPeriodInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CreditCardChargeLimit_Daily => (int)this["CreditCardChargeLimit_Daily"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal UserChargeLimit_Daily => (decimal)this["UserChargeLimit_Daily"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal NewAccountPurchaseLimit => (decimal)this["NewAccountPurchaseLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal CreditCardChargeLimit_Monthly => (decimal)this["CreditCardChargeLimit_Monthly"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal UserChargeLimit_Monthly => (decimal)this["UserChargeLimit_Monthly"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal DailyPurchaseLimitVolumePerIP => (decimal)this["DailyPurchaseLimitVolumePerIP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal MonthlyPurchaseLimitVolumePerIP => (decimal)this["MonthlyPurchaseLimitVolumePerIP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal CreditCardNewUnverifiedAccountLimit => (decimal)this["CreditCardNewUnverifiedAccountLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CreditCardNewUnverifiedAccountLimitPeriodInDays => (int)this["CreditCardNewUnverifiedAccountLimitPeriodInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LimitCCPurchaseByIP => (bool)this["LimitCCPurchaseByIP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendCCDailyLimitFloodCheckEmail => (bool)this["SendCCDailyLimitFloodCheckEmail"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("400")]
	public int FraudDetectorAllowIfMonthlyPlusCurrentTransactionLessThan => (int)this["FraudDetectorAllowIfMonthlyPlusCurrentTransactionLessThan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public int FraudDetectorDisallowIfMonthlyPlusCurrentTransactionGreaterOrEqualTo => (int)this["FraudDetectorDisallowIfMonthlyPlusCurrentTransactionGreaterOrEqualTo"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FraudDetectorEnabled => (bool)this["FraudDetectorEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public byte FraudDetectorVelocityRuleMaxAllowedTransactions => (byte)this["FraudDetectorVelocityRuleMaxAllowedTransactions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public byte FraudDetectorMaxAllowedDeclinedTransactionsByAccountID => (byte)this["FraudDetectorMaxAllowedDeclinedTransactionsByAccountID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("14")]
	public int FraudDetectorMinAccountAgeInDays => (int)this["FraudDetectorMinAccountAgeInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.2")]
	public double FraudDetectorMaxAllowedRatioOfRefundedTransactionsByAccountID => (double)this["FraudDetectorMaxAllowedRatioOfRefundedTransactionsByAccountID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public byte FraudDetectorMaxAllowedCreditCardsPerAccountIDInLast6Months => (byte)this["FraudDetectorMaxAllowedCreditCardsPerAccountIDInLast6Months"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RemoveSixMonthAndLifetimeBCEnabled => (bool)this["RemoveSixMonthAndLifetimeBCEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobuxOption500DollarEnabled => (bool)this["IsRobuxOption500DollarEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan DoublePurchaseVerificationTimeSpan => (TimeSpan)this["DoublePurchaseVerificationTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCountryCurrencyBlockEnabled => (bool)this["IsCountryCurrencyBlockEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("VN|PHP")]
	public string BlacklistedCountryCurrencies => (string)this["BlacklistedCountryCurrencies"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int AccountLimitPeriodInDays => (int)this["AccountLimitPeriodInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("VN")]
	public string BlacklistedCountriesBasedOnUserAccountAge => (string)this["BlacklistedCountriesBasedOnUserAccountAge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserDelayedFromCountryBlockEnabled => (bool)this["IsUserDelayedFromCountryBlockEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:05")]
	public TimeSpan CreditRedemptionLeasedLockTimeSpan => (TimeSpan)this["CreditRedemptionLeasedLockTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int CreditRedemptionFloodCheckLimit => (int)this["CreditRedemptionFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan CreditRedemptionFloodCheckExpiry => (TimeSpan)this["CreditRedemptionFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserDelayedFromCurrencyBlockEnabled => (bool)this["IsUserDelayedFromCurrencyBlockEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PHP")]
	public string BlacklistedCurrenciesBasedOnUserAccountAge => (string)this["BlacklistedCurrenciesBasedOnUserAccountAge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserDelayedFromCountryCurrencyBlockEnabled => (bool)this["IsUserDelayedFromCountryCurrencyBlockEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("KW|USD,OM|USD")]
	public string BlacklistedCountryCurrenciesBasedOnUserAccountAge => (string)this["BlacklistedCountryCurrenciesBasedOnUserAccountAge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BlacklistedCountriesForAppleAppStore => (string)this["BlacklistedCountriesForAppleAppStore"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMobilePurchaseVelocityFilterEnabled => (bool)this["IsMobilePurchaseVelocityFilterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("800")]
	public decimal UserPurchaseAmountVelocityDailyLimit_AppleStore => (decimal)this["UserPurchaseAmountVelocityDailyLimit_AppleStore"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("800")]
	public decimal UserPurchaseAmountVelocityDailyLimit_AmazonStore => (decimal)this["UserPurchaseAmountVelocityDailyLimit_AmazonStore"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("800")]
	public decimal UserPurchaseAmountVelocityDailyLimit_GooglePlayStore => (decimal)this["UserPurchaseAmountVelocityDailyLimit_GooglePlayStore"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public decimal UserPurchaseAmountVelocityMonthlyLimit_AppleStore => (decimal)this["UserPurchaseAmountVelocityMonthlyLimit_AppleStore"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public decimal UserPurchaseAmountVelocityMonthlyLimit_AmazonStore => (decimal)this["UserPurchaseAmountVelocityMonthlyLimit_AmazonStore"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public decimal UserPurchaseAmountVelocityMonthlyLimit_GooglePlayStore => (decimal)this["UserPurchaseAmountVelocityMonthlyLimit_GooglePlayStore"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("800")]
	public decimal UserPurchaseAmountVelocityDailyLimit => (decimal)this["UserPurchaseAmountVelocityDailyLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public decimal UserPurchaseAmountVelocityMonthlyLimit => (decimal)this["UserPurchaseAmountVelocityMonthlyLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("!*()")]
	public string MidasEncodeExemptedCharacters => (string)this["MidasEncodeExemptedCharacters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue(".-_")]
	public string MidasAdditionalEncodeCharacters => (string)this["MidasAdditionalEncodeCharacters"];

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
