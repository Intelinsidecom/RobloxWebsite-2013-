using System;

namespace Roblox.Platform.Billing.Properties;

public interface ISettings
{
	decimal EmailChargeLimit_Monthly { get; }

	bool CreditCardNewUnverifiedAccountLimitEnabled { get; }

	int CreditCardTransactionCountLimit_Daily { get; }

	byte NewAccountPeriodInDays { get; }

	int CreditCardChargeLimit_Daily { get; }

	decimal UserChargeLimit_Daily { get; }

	decimal NewAccountPurchaseLimit { get; }

	decimal CreditCardChargeLimit_Monthly { get; }

	decimal UserChargeLimit_Monthly { get; }

	decimal DailyPurchaseLimitVolumePerIP { get; }

	decimal MonthlyPurchaseLimitVolumePerIP { get; }

	decimal CreditCardNewUnverifiedAccountLimit { get; }

	int CreditCardNewUnverifiedAccountLimitPeriodInDays { get; }

	bool LimitCCPurchaseByIP { get; }

	bool SendCCDailyLimitFloodCheckEmail { get; }

	int FraudDetectorAllowIfMonthlyPlusCurrentTransactionLessThan { get; }

	int FraudDetectorDisallowIfMonthlyPlusCurrentTransactionGreaterOrEqualTo { get; }

	bool FraudDetectorEnabled { get; }

	byte FraudDetectorVelocityRuleMaxAllowedTransactions { get; }

	byte FraudDetectorMaxAllowedDeclinedTransactionsByAccountID { get; }

	int FraudDetectorMinAccountAgeInDays { get; }

	double FraudDetectorMaxAllowedRatioOfRefundedTransactionsByAccountID { get; }

	byte FraudDetectorMaxAllowedCreditCardsPerAccountIDInLast6Months { get; }

	bool RemoveSixMonthAndLifetimeBCEnabled { get; }

	bool IsRobuxOption500DollarEnabled { get; }

	TimeSpan DoublePurchaseVerificationTimeSpan { get; }

	bool IsCountryCurrencyBlockEnabled { get; }

	string BlacklistedCountryCurrencies { get; }

	TimeSpan CreditRedemptionLeasedLockTimeSpan { get; }

	int CreditRedemptionFloodCheckLimit { get; }

	TimeSpan CreditRedemptionFloodCheckExpiry { get; }

	string BlacklistedCountriesForAppleAppStore { get; }

	string MidasEncodeExemptedCharacters { get; }

	string MidasAdditionalEncodeCharacters { get; }
}
