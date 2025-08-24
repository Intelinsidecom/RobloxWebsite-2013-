using System.ComponentModel;

namespace Roblox.Platform.Billing;

public enum MobileAppProductValidationFailureReason
{
	[Description("Product not available in the app store.")]
	ProductUnavailable,
	[Description("BC requirements for the product were not met.")]
	InsufficientMembership,
	[Description("Purchasing the product would conflict with the user's existing BC membership.")]
	MembershipConflict,
	[Description("User has exceeded their purchasing limit.")]
	PurchasingLimit,
	[Description("There was an unexpected error.")]
	Error,
	[Description("The country currency combination has been blacklisted")]
	CountryCurrencyBlacklisted,
	[Description("The user from this country is not allowed to purchase yet.")]
	UserDelayedFromCountry,
	[Description("The user with this currency is not allowed to purchase yet.")]
	UserDelayedFromCurrency,
	[Description("The user with this country currency combination is not allowed to purchase yet.")]
	UserDelayedFromCountryCurrency,
	[Description("The user purchase amount rate exceeds daily limit.")]
	UserPurchaseAmountVelocityExceedsDailyLimit,
	[Description("The user purchase amount rate exceeds monthly limit.")]
	UserPurchaseAmountVelocityExceedsMonthlyLimit,
	[Description("The user has already purchased Roblox Premium.")]
	UserIsAlreadyPremium,
	[Description("The user has attempted a rapid succession of purchases of Premium Membership.")]
	UserRapidSuccessionPurchase
}
