namespace Roblox.Platform.AssetOwnership;

public enum TransferStatus
{
	Ov1Success = 1,
	Ov2Success,
	DualTransferred,
	Ov1Failure,
	Ov2FailureRolledBackOv1,
	Ov2OutOfSync
}
