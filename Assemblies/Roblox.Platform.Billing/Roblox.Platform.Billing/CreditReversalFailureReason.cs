namespace Roblox.Platform.Billing;

public enum CreditReversalFailureReason
{
	None = 0,
	CardNotRedeemed = 10,
	InvalidPin = 20,
	NetworkFailure = 30,
	ConfigurationError = 40,
	LeasedLockCollision = 50,
	Unknown = int.MaxValue
}
