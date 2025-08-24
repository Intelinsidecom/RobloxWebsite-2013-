using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Billing.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
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
	[DefaultSettingValue("300.00")]
	public decimal CreditCardChargeLimit_Daily => (decimal)this["CreditCardChargeLimit_Daily"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("400.00")]
	public decimal CreditCardChargeLimit_Monthly => (decimal)this["CreditCardChargeLimit_Monthly"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("300.00")]
	public decimal UserChargeLimit_Daily => (decimal)this["UserChargeLimit_Daily"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("400.00")]
	public decimal UserChargeLimit_Monthly => (decimal)this["UserChargeLimit_Monthly"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX")]
	public string PayPal_UserName => (string)this["PayPal_UserName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AYXsv6lh73F7qz8f0kFXzX1WS3yHVFSk")]
	public string PayPal_Password => (string)this["PayPal_Password"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX Corporation")]
	public string PayPal_MerchantName => (string)this["PayPal_MerchantName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("pilot-payflowpro.paypal.com")]
	public string PayPal_Connection => (string)this["PayPal_Connection"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PayPal")]
	public string PayPal_Partner => (string)this["PayPal_Partner"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("images/Logo/roblox_logo_188x47_03132019.png")]
	public string PayPal_RobloxLogo => (string)this["PayPal_RobloxLogo"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://www.sandbox.paypal.com/cgi-bin/webscr?cmd=_express-checkout&useraction=commit&token=")]
	public string ExpressCheckoutURL => (string)this["ExpressCheckoutURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Upgrades/PayPal.aspx?Billing=new&ap={0}")]
	public string PayPal_CancelPage => (string)this["PayPal_CancelPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Upgrades/PayPalPayment.aspx?Billing=new&Order={0}")]
	public string PayPal_ReturnPage => (string)this["PayPal_ReturnPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://localhost:3966/")]
	public string WebSiteBaseUrl => (string)this["WebSiteBaseUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("info@roblox.com")]
	public string PayPal_MerchantInformation => (string)this["PayPal_MerchantInformation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7")]
	public byte DarkOrdersWindowInDays => (byte)this["DarkOrdersWindowInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MonitorSleepTimeInMinutes => (int)this["MonitorSleepTimeInMinutes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool PayPal_UseTestMode => (bool)this["PayPal_UseTestMode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool BillingIsParallel => (bool)this["BillingIsParallel"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int PercentToUseNewBillingSystem => (int)this["PercentToUseNewBillingSystem"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public float TBCToBCConversionFactor => (float)this["TBCToBCConversionFactor"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public float OBCtoBCConversionFactor => (float)this["OBCtoBCConversionFactor"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.5")]
	public float OBCtoTBCConversionFactor => (float)this["OBCtoTBCConversionFactor"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaxCancellationsPerDay => (int)this["MaxCancellationsPerDay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("roblox")]
	public string RixtyUser => (string)this["RixtyUser"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ef0df6ed074300")]
	public string RixtyPassword => (string)this["RixtyPassword"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("72d79836-d4c8-4570-9e31-75c9c25a499a")]
	public string RixtySignature => (string)this["RixtySignature"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://sandbox.rixty.com/rixtyapi/nvp")]
	public string RixtyURL => (string)this["RixtyURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://staging.roblox.com/upgrades/rixtycomplete.aspx")]
	public string RixtyReturnURL => (string)this["RixtyReturnURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://staging.roblox.com/upgrades/rixtycancel.aspx")]
	public string RixtyCancelURL => (string)this["RixtyCancelURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("80")]
	public int RobuxPerDollar => (int)this["RobuxPerDollar"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("40")]
	public int RixtyTopupProductID => (int)this["RixtyTopupProductID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RixtyIsEnabled => (bool)this["RixtyIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Data Source=192.168.100.87;Initial Catalog=RobloxAccountManagement;User ID=Roblox;Password=To0Big2F@il")]
	public string AccountManagementConnectionString => (string)this["AccountManagementConnectionString"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BillingAutoMigrationEnabled => (bool)this["BillingAutoMigrationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string InCommURL => (string)this["InCommURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EmailAlertsEnabled => (bool)this["EmailAlertsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CreditIsEnabled => (bool)this["CreditIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseTestMode => (bool)this["UseTestMode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1b72069f76bf3474daba16b0")]
	public string BokuServiceID => (string)this["BokuServiceID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("98765432100")]
	public string BokuTestNumber => (string)this["BokuTestNumber"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ToysRUsCardsAvailable => (bool)this["ToysRUsCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SevenElevenCardsAvailable => (bool)this["SevenElevenCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BestBuyCardsAvailable => (bool)this["BestBuyCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameStopCardsAvailable => (bool)this["GameStopCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int PayPal_NumDaysToRetry => (int)this["PayPal_NumDaysToRetry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WalmartCardsAvailable => (bool)this["WalmartCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InCommAssetAwardsEnabled => (bool)this["InCommAssetAwardsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PayPalRecurringIsEnabled => (bool)this["PayPalRecurringIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://staging.roblox.com/upgrades/rixtypinreturn.ashx")]
	public string RixtyPinPostbackUrl => (string)this["RixtyPinPostbackUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("174.129.253.141")]
	public string RixtyCallbackIP => (string)this["RixtyCallbackIP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("R0BL0X_R1XTY")]
	public string RixtyCallbackPassword => (string)this["RixtyCallbackPassword"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RixtyPinEnabled => (bool)this["RixtyPinEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int CreditCardTransactionCountLimit_Daily => (int)this["CreditCardTransactionCountLimit_Daily"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FutureShopCardsAvailable => (bool)this["FutureShopCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendCCDailyLimitFloodCheckEmail => (bool)this["SendCCDailyLimitFloodCheckEmail"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long GameStop40DollarAssetID => (long)this["GameStop40DollarAssetID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InCommProductRedemptionEnabled => (bool)this["InCommProductRedemptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TargetCardsAvailable => (bool)this["TargetCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CVSCardsAvailable => (bool)this["CVSCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SainsburyCardsAvailable => (bool)this["SainsburyCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GuestShoppingCartEnabled => (bool)this["GuestShoppingCartEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewShoppingCartSchemeEnabled => (bool)this["NewShoppingCartSchemeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GiftCardsEnabled => (bool)this["GiftCardsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5.00")]
	public decimal GiftCardMinValue => (decimal)this["GiftCardMinValue"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500.00")]
	public decimal GiftCardMaxValue => (decimal)this["GiftCardMaxValue"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendGiftCardPurchaseConfirmationEmailEnabled => (bool)this["SendGiftCardPurchaseConfirmationEmailEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FYECardsAvailable => (bool)this["FYECardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GiftCardAssetAwardEnabled => (bool)this["GiftCardAssetAwardEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long GiftCardAssetAwardID => (long)this["GiftCardAssetAwardID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EBCardsEnabled => (bool)this["EBCardsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TransactionLogCachingEnabled => (bool)this["TransactionLogCachingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NewPaypalRenewalModulus => (int)this["NewPaypalRenewalModulus"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PayPal_ThrottleEnabled => (bool)this["PayPal_ThrottleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PayPal_ThrottleMaxPerMinute => (int)this["PayPal_ThrottleMaxPerMinute"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20000")]
	public int PayPal_ThrottleMaxWaitInMsBeforeException => (int)this["PayPal_ThrottleMaxWaitInMsBeforeException"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("03:00:00")]
	public TimeSpan NewPaypalSanityOffsetLimit => (TimeSpan)this["NewPaypalSanityOffsetLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GiftCardNewThemesEnabled => (bool)this["GiftCardNewThemesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2012-06-25")]
	public DateTime GameStop2CardPromoStartDate => (DateTime)this["GameStop2CardPromoStartDate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2012-07-14")]
	public DateTime GameStop2CardPromoEndDate => (DateTime)this["GameStop2CardPromoEndDate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InCommRedeemForCredit => (bool)this["InCommRedeemForCredit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PurchaseConfirmationEmailEnabled => (bool)this["PurchaseConfirmationEmailEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LondonDrugsCardsAvailable => (bool)this["LondonDrugsCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameUKCardsAvailable => (bool)this["GameUKCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShoppersDrugMartCardsAvailable => (bool)this["ShoppersDrugMartCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ASDACardsAvailable => (bool)this["ASDACardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CurrysCardsAvailable => (bool)this["CurrysCardsAvailable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AppleAppStoreVerificationEndpoint => (string)this["AppleAppStoreVerificationEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AppleAppStoreSandboxVerificationEndpoint => (string)this["AppleAppStoreSandboxVerificationEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AppleAppStoreSandboxFallbackEnabled => (bool)this["AppleAppStoreSandboxFallbackEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AppleAppStoreSandboxValidAccountIDs => (string)this["AppleAppStoreSandboxValidAccountIDs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AppleAppStoreSandboxEmailAlert => (string)this["AppleAppStoreSandboxEmailAlert"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long Walmart25DollarAssetID => (long)this["Walmart25DollarAssetID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2012-12-01")]
	public DateTime Walmart2CardPromoStartDate => (DateTime)this["Walmart2CardPromoStartDate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2012-12-31")]
	public DateTime Walmart2CardPromoEndDate => (DateTime)this["Walmart2CardPromoEndDate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BillingLibraryApiKey => (string)this["BillingLibraryApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UseNewPricingTableModulus => (int)this["UseNewPricingTableModulus"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("650.00")]
	public decimal EmailChargeLimit_Monthly => (decimal)this["EmailChargeLimit_Monthly"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AppleAppStoreLogReceiptOnVerifyFailure => (bool)this["AppleAppStoreLogReceiptOnVerifyFailure"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AppleAppStoreUseProductPrice => (bool)this["AppleAppStoreUseProductPrice"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int NewAccountPurchaseLimit => (int)this["NewAccountPurchaseLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public byte NewAccountPeriodInDays => (byte)this["NewAccountPeriodInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("400")]
	public decimal DailyPurchaseLimitVolumePerIP => (decimal)this["DailyPurchaseLimitVolumePerIP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("400")]
	public decimal MonthlyPurchaseLimitVolumePerIP => (decimal)this["MonthlyPurchaseLimitVolumePerIP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CreditCardNewUnverifiedAccountLimitEnabled => (bool)this["CreditCardNewUnverifiedAccountLimitEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int CreditCardNewUnverifiedAccountLimitPeriodInDays => (int)this["CreditCardNewUnverifiedAccountLimitPeriodInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public decimal CreditCardNewUnverifiedAccountLimit => (decimal)this["CreditCardNewUnverifiedAccountLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int InCommFailedFloodCheckPerHour => (int)this["InCommFailedFloodCheckPerHour"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan ProcessorMinSleepTime => (TimeSpan)this["ProcessorMinSleepTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan ProcessorMaxSleepTime => (TimeSpan)this["ProcessorMaxSleepTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:01")]
	public TimeSpan ProcessorSleepTimeDecay => (TimeSpan)this["ProcessorSleepTimeDecay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int ProcessorLeaseDurationInMinutes => (int)this["ProcessorLeaseDurationInMinutes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int ProcessorNumberOfTasks => (int)this["ProcessorNumberOfTasks"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseConfigurablePayPalConnectionValues => (bool)this["UseConfigurablePayPalConnectionValues"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PayPalDelayedCapturePercentageRollout => (int)this["PayPalDelayedCapturePercentageRollout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PayPalDelayedCaptureEnabledForSoothsayers => (bool)this["PayPalDelayedCaptureEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PayPalDeplyedCaptureEnabledForRecurringPayments => (bool)this["PayPalDeplyedCaptureEnabledForRecurringPayments"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int KountForPayPalPaymentPercentageRollout => (int)this["KountForPayPalPaymentPercentageRollout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://appstore-sdk.amazon.com/version/1.0/verifyReceiptId/developer/{0}/user/{1}/receiptId/{2}")]
	public string AmazonVerificationUrl => (string)this["AmazonVerificationUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonDeveloperSecret => (string)this["AmazonDeveloperSecret"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long Walmart50DollarAssetID => (long)this["Walmart50DollarAssetID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Bogus")]
	public string BogusPurchaseResponseString => (string)this["BogusPurchaseResponseString"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DebounceApplePurchasesByTransactionId => (bool)this["DebounceApplePurchasesByTransactionId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("300")]
	public decimal PayPalExpressUserChargeLimit_Daily => (decimal)this["PayPalExpressUserChargeLimit_Daily"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("400")]
	public decimal PayPalExpressUserChargeLimit_Monthly => (decimal)this["PayPalExpressUserChargeLimit_Monthly"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DedupeAttemptCounterEnbled => (bool)this["DedupeAttemptCounterEnbled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DedupeErrorCounterEnabled => (bool)this["DedupeErrorCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool EnableInAppPurchases => (bool)this["EnableInAppPurchases"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonStoreTestAccountIDs => (string)this["AmazonStoreTestAccountIDs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonStoreTestAccountEmailAlert => (string)this["AmazonStoreTestAccountEmailAlert"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool AmazonStoreTestAccountFallbackEnabled => (bool)this["AmazonStoreTestAccountFallbackEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsKountPreauthEnabledForPayPal => (bool)this["IsKountPreauthEnabledForPayPal"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XboxStorePurchaseEnabled => (bool)this["XboxStorePurchaseEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan XboxLiveServiceTimeout => (TimeSpan)this["XboxLiveServiceTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("70c2075d-5e2f-4ffd-8de5-8a6d2f5e65ad")]
	public string XboxStore400RobuxProductId => (string)this["XboxStore400RobuxProductId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("e6bff9a8-d5e3-462a-aa34-67d76d407e46")]
	public string XboxStore800RobuxProductId => (string)this["XboxStore800RobuxProductId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1491cd70-e1fe-4288-bdef-cdc83ab19637")]
	public string XboxStore1700RobuxProductId => (string)this["XboxStore1700RobuxProductId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3f53e0b1-f2e3-47b1-98a4-370cf685c4b7")]
	public string XboxStore4500RobuxProductId => (string)this["XboxStore4500RobuxProductId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ee8baadf-9b43-453c-840d-cea0f1e094b5")]
	public string XboxStore10000RobuxProductId => (string)this["XboxStore10000RobuxProductId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("210d1d69-5189-40f4-a59b-ecfb4f849847")]
	public string XboxStore22500RobuxProductId => (string)this["XboxStore22500RobuxProductId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PayPalRecurringGetTransactionInformationEnabled => (bool)this["PayPalRecurringGetTransactionInformationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsWindowsStoreReceiptSignatureValidationEnabled => (bool)this["IsWindowsStoreReceiptSignatureValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://go.microsoft.com/fwlink/?LinkId=246509&cid={0}")]
	public string WindowsStoreCertificateLinkFormat => (string)this["WindowsStoreCertificateLinkFormat"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int WindowsStoreNumberOfTransactionIdsToProcessLimit => (int)this["WindowsStoreNumberOfTransactionIdsToProcessLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.bc1month")]
	public string WindowsStoreProductName1MonthBc => (string)this["WindowsStoreProductName1MonthBc"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.tbc1month")]
	public string WindowsStoreProductName1MonthTbc => (string)this["WindowsStoreProductName1MonthTbc"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.obc1month")]
	public string WindowsStoreProductName1MonthObc => (string)this["WindowsStoreProductName1MonthObc"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.bc3month")]
	public string WindowsStoreProductName3MonthsBc => (string)this["WindowsStoreProductName3MonthsBc"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.tbc3month")]
	public string WindowsStoreProductName3MonthsTbc => (string)this["WindowsStoreProductName3MonthsTbc"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.obc3month")]
	public string WindowsStoreProductName3MonthsObc => (string)this["WindowsStoreProductName3MonthsObc"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux80")]
	public string WindowsStoreProductName80Robux => (string)this["WindowsStoreProductName80Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux90")]
	public string WindowsStoreProductName90Robux => (string)this["WindowsStoreProductName90Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux160")]
	public string WindowsStoreProductName160Robux => (string)this["WindowsStoreProductName160Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux180bc")]
	public string WindowsStoreProductName180Robux => (string)this["WindowsStoreProductName180Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux240")]
	public string WindowsStoreProductName240Robux => (string)this["WindowsStoreProductName240Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux270bc")]
	public string WindowsStoreProductName270Robux => (string)this["WindowsStoreProductName270Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux320")]
	public string WindowsStoreProductName320Robux => (string)this["WindowsStoreProductName320Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux360bc")]
	public string WindowsStoreProductName360Robux => (string)this["WindowsStoreProductName360Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux400")]
	public string WindowsStoreProductName400Robux => (string)this["WindowsStoreProductName400Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux450bc")]
	public string WindowsStoreProductName450Robux => (string)this["WindowsStoreProductName450Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux800")]
	public string WindowsStoreProductName800Robux => (string)this["WindowsStoreProductName800Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux1000")]
	public string WindowsStoreProductName1000Robux => (string)this["WindowsStoreProductName1000Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux2000")]
	public string WindowsStoreProductName2000Robux => (string)this["WindowsStoreProductName2000Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client.robux2750bc")]
	public string WindowsStoreProductName2750Robux => (string)this["WindowsStoreProductName2750Robux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableIncommReversalOnException => (bool)this["EnableIncommReversalOnException"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableIncommResponseLoggingOnException => (bool)this["EnableIncommResponseLoggingOnException"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("RobloxBilling")]
	public string BillingEventLogSource => (string)this["BillingEventLogSource"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Information")]
	public string BillingEventLogLevel => (string)this["BillingEventLogLevel"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WindowsStoreAppIdForValidation => (string)this["WindowsStoreAppIdForValidation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsReceiptAppIdValidationEnabled => (bool)this["IsReceiptAppIdValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GrantProductOnRecurringProfileCreationFailureEnabled => (bool)this["GrantProductOnRecurringProfileCreationFailureEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IncrementCounterOnPayPalFailureEnabled => (bool)this["IncrementCounterOnPayPalFailureEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool HandlePaypalRecurringErrorCodeEnabled => (bool)this["HandlePaypalRecurringErrorCodeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RetryPaypalOn10486ErrorEnabled => (bool)this["RetryPaypalOn10486ErrorEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DoNotProceedOnPaypalError11607Enabled => (bool)this["DoNotProceedOnPaypalError11607Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:35:00")]
	public TimeSpan MonitorLeasedLockDuration => (TimeSpan)this["MonitorLeasedLockDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConsumedProductMustBeGrantedWhenPaymentNotExistsEnabled => (bool)this["IsConsumedProductMustBeGrantedWhenPaymentNotExistsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBillingV2FindAndCancelPurchasesEnabled => (bool)this["IsBillingV2FindAndCancelPurchasesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan GooglePlayStorePaymentProviderLeaseLockTimeSpan => (TimeSpan)this["GooglePlayStorePaymentProviderLeaseLockTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBillingDelegateLoggerForGooglePlayEnabled => (bool)this["IsBillingDelegateLoggerForGooglePlayEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBillingDelegateLoggerForAmazonEnabled => (bool)this["IsBillingDelegateLoggerForAmazonEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoggingInCommToCheckoutSessionEnabled => (bool)this["IsLoggingInCommToCheckoutSessionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRollbackOnExceptionEnabled => (bool)this["IsRollbackOnExceptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AmazonStorePurchaseProcessWithLeaseLockEnabled => (bool)this["AmazonStorePurchaseProcessWithLeaseLockEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:10")]
	public TimeSpan AmazonStorePurchaseLeaseLockDuration => (TimeSpan)this["AmazonStorePurchaseLeaseLockDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("images/Logo/roblox_logo_188x47_03132019.png")]
	public string RobloxEmailLogo => (string)this["RobloxEmailLogo"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("463ba584-773e-4bc3-967d-4c5a358612ed")]
	public string XboxStoreStarterPack1MaleProductId => (string)this["XboxStoreStarterPack1MaleProductId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0263b8a7-a9dc-48f5-a9dc-006be30a6ca6")]
	public string XboxStoreStarterPack1FemaleProductId => (string)this["XboxStoreStarterPack1FemaleProductId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5d43eede-3534-4e8c-b734-4ba6a61b01df")]
	public string XboxStore200RobuxProductId => (string)this["XboxStore200RobuxProductId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBillingDelegateLoggerForAppleEnabled => (bool)this["IsBillingDelegateLoggerForAppleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobuxTextCaseInsensitiveEnabled => (bool)this["IsRobuxTextCaseInsensitiveEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string XsollaSecretKey => (string)this["XsollaSecretKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Xbox Starter Pack 1 - Male")]
	public string XboxStoreStarterPack1MaleBillingProductName => (string)this["XboxStoreStarterPack1MaleBillingProductName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Xbox Starter Pack 1 - Female")]
	public string XboxStoreStarterPack1FemaleBillingProductName => (string)this["XboxStoreStarterPack1FemaleBillingProductName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:10")]
	public TimeSpan IncommPinLeaseLockTimeSpan => (TimeSpan)this["IncommPinLeaseLockTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("62s5PW83")]
	public string XsollaProductId1MonthBc => (string)this["XsollaProductId1MonthBc"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("62s5PW83")]
	public string XsollaBcPlanId => (string)this["XsollaBcPlanId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameCardTestPin => (string)this["GameCardTestPin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string XsollaTbcPlanId => (string)this["XsollaTbcPlanId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string XsollaObcPlanId => (string)this["XsollaObcPlanId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RixtyTestPin => (string)this["RixtyTestPin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BillingTransactionEventForAppPaymentEnabled => (bool)this["BillingTransactionEventForAppPaymentEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDesktopLocalPricingForAllEnabled => (bool)this["IsDesktopLocalPricingForAllEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDesktopLocalPricingForSoothSayerEnabled => (bool)this["IsDesktopLocalPricingForSoothSayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("209")]
	public int SpainCountryId => (int)this["SpainCountryId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLocalPricingEnabled => (bool)this["IsLocalPricingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("USD,MXN")]
	public string MobileLocalPricingSupportedCurrencies => (string)this["MobileLocalPricingSupportedCurrencies"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEmptySaleProductCheckEnabled => (bool)this["IsEmptySaleProductCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("USD,EUR")]
	public string DesktopLocalPricingSupportedCurrencies => (string)this["DesktopLocalPricingSupportedCurrencies"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("CZK,DKK,HUF,ILS,JPY,NOK,PHP,PLN,RUB,SGD,SEK,CHF,THB,USD,AUD,GBP,CAD,EUR,HKD,MXN,NZD")]
	public string PayPalSupportedCurrencyCode => (string)this["PayPalSupportedCurrencyCode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int InCommFailedIPFloodCheckPerHour => (int)this["InCommFailedIPFloodCheckPerHour"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int InCommFailedPartialIPFloodCheckPerHour => (int)this["InCommFailedPartialIPFloodCheckPerHour"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsInCommFailedPartialIPFloodCheckPerHourEnabled => (bool)this["IsInCommFailedPartialIPFloodCheckPerHourEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsInCommFailedIPFloodCheckPerHourEnabled => (bool)this["IsInCommFailedIPFloodCheckPerHourEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IncommFloodCheckerForCaptchaAttemptEnabled => (bool)this["IncommFloodCheckerForCaptchaAttemptEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsChinaPaymentEnabled => (bool)this["IsChinaPaymentEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPaypalRequestErrorRetryEnabled => (bool)this["IsPaypalRequestErrorRetryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long GameStop40DollarBundleID => (long)this["GameStop40DollarBundleID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long Walmart25DollarBundleID => (long)this["Walmart25DollarBundleID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long Walmart50DollarBundleID => (long)this["Walmart50DollarBundleID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsBCSigningBonusEnabled => (bool)this["IsBCSigningBonusEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAmazonStoreLocalPricingEnabled => (bool)this["IsAmazonStoreLocalPricingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("USD,EUR,AUD,CAD,GBP")]
	public string AmazonStoreLocalPricingSupportedCurrencies => (string)this["AmazonStoreLocalPricingSupportedCurrencies"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAppleAppStoreLocalPricingEnabled => (bool)this["IsAppleAppStoreLocalPricingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("USD,MXN,EUR,HKD,TWD,CLP,COP,AUD,NZD,CAD,GBP")]
	public string AppleAppStoreLocalPricingSupportedCurrencies => (string)this["AppleAppStoreLocalPricingSupportedCurrencies"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGooglePlayStoreLocalPricingEnabled => (bool)this["IsGooglePlayStoreLocalPricingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("USD,MXN,EUR,HKD,TWD,CLP,COP,AUD,NZD,CAD,GBP")]
	public string GooglePlayStoreLocalPricingSupportedCurrencies => (string)this["GooglePlayStoreLocalPricingSupportedCurrencies"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsBCSigningBonusEnabledForMobile => (bool)this["IsBCSigningBonusEnabledForMobile"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan MembershipMigrationRobuxStipendLeaseDuration => (TimeSpan)this["MembershipMigrationRobuxStipendLeaseDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan MembershipMigrationAccountAddOnLeaseDuration => (TimeSpan)this["MembershipMigrationAccountAddOnLeaseDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("12,14,16,18,20,22")]
	public string DeprecatedProductIDs => (string)this["DeprecatedProductIDs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxPremiumSubscriptionDuplicatePurchaseValidationEnabled => (bool)this["IsRobloxPremiumSubscriptionDuplicatePurchaseValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxPremiumSubscriptionRapidPurchaseValidationEnabled => (bool)this["IsRobloxPremiumSubscriptionRapidPurchaseValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan PremiumPurchaseLeasedLockDuration => (TimeSpan)this["PremiumPurchaseLeasedLockDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.012")]
	public decimal CreditToRobuxConversionExchangeRate => (decimal)this["CreditToRobuxConversionExchangeRate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4.99")]
	public decimal MinimumProductPurchase => (decimal)this["MinimumProductPurchase"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBillingDelegateLoggerForCreditRedemptionEnabled => (bool)this["IsBillingDelegateLoggerForCreditRedemptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PremiumSubscriptionPurchaseDuplicateCheck-UserId:{0}")]
	public string PremiumPurchaseLeasedLockKey => (string)this["PremiumPurchaseLeasedLockKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFirstTimePurchaseForAndroidPackageEnabled => (bool)this["IsFirstTimePurchaseForAndroidPackageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00000000-0000-0000-0000-000000000000")]
	public Guid PremiumPurchaseLeasedLockGuid => (Guid)this["PremiumPurchaseLeasedLockGuid"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxPremiumSubscriptionDuplicatePurchaseValidationWebEnabled => (bool)this["IsRobloxPremiumSubscriptionDuplicatePurchaseValidationWebEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("RobloxCreditRedeemRobux-UserId:{0}")]
	public string RobuxGrantLeaseLockPrefix => (string)this["RobuxGrantLeaseLockPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan RobuxGrantLeaseLockDuration => (TimeSpan)this["RobuxGrantLeaseLockDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLocalPricingFixForPremiumEnabled => (bool)this["IsLocalPricingFixForPremiumEnabled"];

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
