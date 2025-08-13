using System;

namespace Roblox.Billing.Properties;

public interface ISettings
{
	decimal CreditCardChargeLimit_Daily { get; }

	decimal CreditCardChargeLimit_Monthly { get; }

	decimal UserChargeLimit_Daily { get; }

	decimal UserChargeLimit_Monthly { get; }

	string PayPal_UserName { get; }

	string PayPal_Password { get; }

	string PayPal_MerchantName { get; }

	string PayPal_Connection { get; }

	string PayPal_Partner { get; }

	string PayPal_RobloxLogo { get; }

	string ExpressCheckoutURL { get; }

	string PayPal_CancelPage { get; }

	string PayPal_ReturnPage { get; }

	string WebSiteBaseUrl { get; }

	string PayPal_MerchantInformation { get; }

	byte DarkOrdersWindowInDays { get; }

	int MonitorSleepTimeInMinutes { get; }

	bool PayPal_UseTestMode { get; }

	bool BillingIsParallel { get; }

	int PercentToUseNewBillingSystem { get; }

	float TBCToBCConversionFactor { get; }

	float OBCtoBCConversionFactor { get; }

	float OBCtoTBCConversionFactor { get; }

	int MaxCancellationsPerDay { get; }

	string RixtyUser { get; }

	string RixtyPassword { get; }

	string RixtySignature { get; }

	string RixtyURL { get; }

	string RixtyReturnURL { get; }

	string RixtyCancelURL { get; }

	int RobuxPerDollar { get; }

	int RixtyTopupProductID { get; }

	bool RixtyIsEnabled { get; }

	string AccountManagementConnectionString { get; }

	bool BillingAutoMigrationEnabled { get; }

	string InCommURL { get; }

	bool EmailAlertsEnabled { get; }

	bool CreditIsEnabled { get; }

	bool UseTestMode { get; }

	string BokuServiceID { get; }

	string BokuTestNumber { get; }

	bool ToysRUsCardsAvailable { get; }

	bool SevenElevenCardsAvailable { get; }

	bool BestBuyCardsAvailable { get; }

	bool GameStopCardsAvailable { get; }

	int PayPal_NumDaysToRetry { get; }

	bool WalmartCardsAvailable { get; }

	bool InCommAssetAwardsEnabled { get; }

	bool PayPalRecurringIsEnabled { get; }

	string RixtyPinPostbackUrl { get; }

	string RixtyCallbackIP { get; }

	string RixtyCallbackPassword { get; }

	bool RixtyPinEnabled { get; }

	int CreditCardTransactionCountLimit_Daily { get; }

	bool FutureShopCardsAvailable { get; }

	bool SendCCDailyLimitFloodCheckEmail { get; }

	long GameStop40DollarAssetID { get; }

	bool InCommProductRedemptionEnabled { get; }

	bool TargetCardsAvailable { get; }

	bool CVSCardsAvailable { get; }

	bool SainsburyCardsAvailable { get; }

	bool GuestShoppingCartEnabled { get; }

	bool NewShoppingCartSchemeEnabled { get; }

	bool GiftCardsEnabled { get; }

	decimal GiftCardMinValue { get; }

	decimal GiftCardMaxValue { get; }

	bool SendGiftCardPurchaseConfirmationEmailEnabled { get; }

	bool FYECardsAvailable { get; }

	bool GiftCardAssetAwardEnabled { get; }

	long GiftCardAssetAwardID { get; }

	bool EBCardsEnabled { get; }

	bool TransactionLogCachingEnabled { get; }

	int NewPaypalRenewalModulus { get; }

	bool PayPal_ThrottleEnabled { get; }

	int PayPal_ThrottleMaxPerMinute { get; }

	int PayPal_ThrottleMaxWaitInMsBeforeException { get; }

	TimeSpan NewPaypalSanityOffsetLimit { get; }

	bool GiftCardNewThemesEnabled { get; }

	DateTime GameStop2CardPromoStartDate { get; }

	DateTime GameStop2CardPromoEndDate { get; }

	bool InCommRedeemForCredit { get; }

	bool PurchaseConfirmationEmailEnabled { get; }

	bool LondonDrugsCardsAvailable { get; }

	bool GameUKCardsAvailable { get; }

	bool ShoppersDrugMartCardsAvailable { get; }

	bool ASDACardsAvailable { get; }

	bool CurrysCardsAvailable { get; }

	string AppleAppStoreVerificationEndpoint { get; }

	string AppleAppStoreSandboxVerificationEndpoint { get; }

	bool AppleAppStoreSandboxFallbackEnabled { get; }

	string AppleAppStoreSandboxValidAccountIDs { get; }

	string AppleAppStoreSandboxEmailAlert { get; }

	long Walmart25DollarAssetID { get; }

	DateTime Walmart2CardPromoStartDate { get; }

	DateTime Walmart2CardPromoEndDate { get; }

	string BillingLibraryApiKey { get; }

	int UseNewPricingTableModulus { get; }

	decimal EmailChargeLimit_Monthly { get; }

	bool AppleAppStoreLogReceiptOnVerifyFailure { get; }

	bool AppleAppStoreUseProductPrice { get; }

	int NewAccountPurchaseLimit { get; }

	byte NewAccountPeriodInDays { get; }

	decimal DailyPurchaseLimitVolumePerIP { get; }

	decimal MonthlyPurchaseLimitVolumePerIP { get; }

	bool CreditCardNewUnverifiedAccountLimitEnabled { get; }

	int CreditCardNewUnverifiedAccountLimitPeriodInDays { get; }

	decimal CreditCardNewUnverifiedAccountLimit { get; }

	int InCommFailedFloodCheckPerHour { get; }

	TimeSpan ProcessorMinSleepTime { get; }

	TimeSpan ProcessorMaxSleepTime { get; }

	TimeSpan ProcessorSleepTimeDecay { get; }

	int ProcessorLeaseDurationInMinutes { get; }

	int ProcessorNumberOfTasks { get; }

	bool UseConfigurablePayPalConnectionValues { get; }

	int PayPalDelayedCapturePercentageRollout { get; }

	bool PayPalDelayedCaptureEnabledForSoothsayers { get; }

	bool PayPalDeplyedCaptureEnabledForRecurringPayments { get; }

	int KountForPayPalPaymentPercentageRollout { get; }

	string AmazonVerificationUrl { get; }

	string AmazonDeveloperSecret { get; }

	long Walmart50DollarAssetID { get; }

	string BogusPurchaseResponseString { get; }

	bool DebounceApplePurchasesByTransactionId { get; }

	decimal PayPalExpressUserChargeLimit_Daily { get; }

	decimal PayPalExpressUserChargeLimit_Monthly { get; }

	bool DedupeAttemptCounterEnbled { get; }

	bool DedupeErrorCounterEnabled { get; }

	bool EnableInAppPurchases { get; }

	string AmazonStoreTestAccountIDs { get; }

	string AmazonStoreTestAccountEmailAlert { get; }

	bool AmazonStoreTestAccountFallbackEnabled { get; }

	bool IsKountPreauthEnabledForPayPal { get; }

	bool XboxStorePurchaseEnabled { get; }

	TimeSpan XboxLiveServiceTimeout { get; }

	string XboxStore400RobuxProductId { get; }

	string XboxStore800RobuxProductId { get; }

	string XboxStore1700RobuxProductId { get; }

	string XboxStore4500RobuxProductId { get; }

	string XboxStore10000RobuxProductId { get; }

	string XboxStore22500RobuxProductId { get; }

	bool PayPalRecurringGetTransactionInformationEnabled { get; }

	bool IsWindowsStoreReceiptSignatureValidationEnabled { get; }

	string WindowsStoreCertificateLinkFormat { get; }

	int WindowsStoreNumberOfTransactionIdsToProcessLimit { get; }

	string WindowsStoreProductName1MonthBc { get; }

	string WindowsStoreProductName1MonthTbc { get; }

	string WindowsStoreProductName1MonthObc { get; }

	string WindowsStoreProductName3MonthsBc { get; }

	string WindowsStoreProductName3MonthsTbc { get; }

	string WindowsStoreProductName3MonthsObc { get; }

	string WindowsStoreProductName80Robux { get; }

	string WindowsStoreProductName90Robux { get; }

	string WindowsStoreProductName160Robux { get; }

	string WindowsStoreProductName180Robux { get; }

	string WindowsStoreProductName240Robux { get; }

	string WindowsStoreProductName270Robux { get; }

	string WindowsStoreProductName320Robux { get; }

	string WindowsStoreProductName360Robux { get; }

	string WindowsStoreProductName400Robux { get; }

	string WindowsStoreProductName450Robux { get; }

	string WindowsStoreProductName800Robux { get; }

	string WindowsStoreProductName1000Robux { get; }

	string WindowsStoreProductName2000Robux { get; }

	string WindowsStoreProductName2750Robux { get; }

	bool EnableIncommReversalOnException { get; }

	bool EnableIncommResponseLoggingOnException { get; }

	string BillingEventLogSource { get; }

	string BillingEventLogLevel { get; }

	string WindowsStoreAppIdForValidation { get; }

	bool IsReceiptAppIdValidationEnabled { get; }

	bool GrantProductOnRecurringProfileCreationFailureEnabled { get; }

	bool IncrementCounterOnPayPalFailureEnabled { get; }

	bool HandlePaypalRecurringErrorCodeEnabled { get; }

	bool RetryPaypalOn10486ErrorEnabled { get; }

	bool DoNotProceedOnPaypalError11607Enabled { get; }

	TimeSpan MonitorLeasedLockDuration { get; }

	bool IsConsumedProductMustBeGrantedWhenPaymentNotExistsEnabled { get; }

	bool IsBillingV2FindAndCancelPurchasesEnabled { get; }

	TimeSpan GooglePlayStorePaymentProviderLeaseLockTimeSpan { get; }

	bool IsBillingDelegateLoggerForGooglePlayEnabled { get; }

	bool IsBillingDelegateLoggerForAmazonEnabled { get; }

	bool IsLoggingInCommToCheckoutSessionEnabled { get; }

	bool IsRollbackOnExceptionEnabled { get; }

	bool AmazonStorePurchaseProcessWithLeaseLockEnabled { get; }

	TimeSpan AmazonStorePurchaseLeaseLockDuration { get; }

	string RobloxEmailLogo { get; }

	string XboxStoreStarterPack1MaleProductId { get; }

	string XboxStoreStarterPack1FemaleProductId { get; }

	string XboxStore200RobuxProductId { get; }

	bool IsBillingDelegateLoggerForAppleEnabled { get; }

	bool IsRobuxTextCaseInsensitiveEnabled { get; }

	string XsollaSecretKey { get; }

	string XboxStoreStarterPack1MaleBillingProductName { get; }

	string XboxStoreStarterPack1FemaleBillingProductName { get; }

	TimeSpan IncommPinLeaseLockTimeSpan { get; }

	string XsollaProductId1MonthBc { get; }

	string XsollaBcPlanId { get; }

	string GameCardTestPin { get; }

	string XsollaTbcPlanId { get; }

	string XsollaObcPlanId { get; }

	string RixtyTestPin { get; }

	bool BillingTransactionEventForAppPaymentEnabled { get; }

	bool IsDesktopLocalPricingForAllEnabled { get; }

	bool IsDesktopLocalPricingForSoothSayerEnabled { get; }

	int SpainCountryId { get; }

	bool IsLocalPricingEnabled { get; }

	string MobileLocalPricingSupportedCurrencies { get; }

	bool IsAmazonStoreLocalPricingEnabled { get; }

	string AmazonStoreLocalPricingSupportedCurrencies { get; }

	bool IsAppleAppStoreLocalPricingEnabled { get; }

	string AppleAppStoreLocalPricingSupportedCurrencies { get; }

	bool IsGooglePlayStoreLocalPricingEnabled { get; }

	string GooglePlayStoreLocalPricingSupportedCurrencies { get; }

	bool IsEmptySaleProductCheckEnabled { get; }

	string DesktopLocalPricingSupportedCurrencies { get; }

	string PayPalSupportedCurrencyCode { get; }

	int InCommFailedIPFloodCheckPerHour { get; }

	int InCommFailedPartialIPFloodCheckPerHour { get; }

	bool IsInCommFailedIPFloodCheckPerHourEnabled { get; }

	bool IsInCommFailedPartialIPFloodCheckPerHourEnabled { get; }

	long GameStop40DollarBundleID { get; }

	long Walmart25DollarBundleID { get; }

	long Walmart50DollarBundleID { get; }

	bool IsBCSigningBonusEnabled { get; }

	string DeprecatedProductIDs { get; }
}
