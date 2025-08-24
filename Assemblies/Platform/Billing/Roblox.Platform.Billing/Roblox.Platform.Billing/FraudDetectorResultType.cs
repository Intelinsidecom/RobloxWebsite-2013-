namespace Roblox.Platform.Billing;

public enum FraudDetectorResultType
{
	NoRulesChecked,
	NoFraudDetected,
	AmountTooSmall,
	AmountTooLarge,
	AccountAndCardAssociatedWithGoodPayments,
	BillingEmailAssociatedWithDisputes,
	BillingAddressAssociatedWithDisputes,
	VelocityByAccountIDExceedsThreshold,
	VelocityByCCNumberExceedsThreshold,
	VelocityByBillingEmailExceedsThreshold,
	NumberOfDeclinesByAccountIDExceedsThreshold,
	AccountTooNew,
	LifetimeRefundRatioExceedsThreshold,
	NumberOfCCsUsedExceedsThreshold
}
