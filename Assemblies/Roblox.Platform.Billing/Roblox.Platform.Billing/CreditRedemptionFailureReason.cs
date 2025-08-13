namespace Roblox.Platform.Billing;

public enum CreditRedemptionFailureReason
{
	None = 0,
	CardAlreadyRedeemed = 1,
	InvalidPin = 2,
	NetworkFailure = 3,
	ConfigurationError = 4,
	FloodcheckFailed = 5,
	AddCreditFailed = 6,
	CreditLogFailed = 7,
	LeasedLockCollision = 8,
	UnableToGrantAllAssets = 9,
	Unknown = int.MaxValue
}
