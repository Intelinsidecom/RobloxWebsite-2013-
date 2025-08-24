namespace Roblox.Platform.AssetOwnership;

public enum AwardStatus
{
	/// <summary>
	/// Just ov1
	/// </summary>
	Ov1Success = 1,
	/// <summary>
	/// Just ov2
	/// </summary>
	Ov2Success,
	/// <summary>
	/// Awarded in both.
	/// </summary>
	DualAwarded,
	/// <summary>
	/// when you write to ov1, then fail to write to ov2, then fail to rollback ov1
	/// </summary>
	Ov2OutOfSync,
	/// <summary>
	/// when the initial write to ov1 fails
	/// </summary>
	Ov1Failure,
	/// <summary>
	/// when you write to ov1, then ov2 fails, then successfully rollback ov1
	/// </summary>
	Ov2FailureRolledBackOv1,
	/// <summary>
	/// previously AwardAsset(userId, assetId, out bool awardedNewAsset) would soft fail with awardedNewAsset==false when the user owned it already.  Some consumers still need that information.  For our case, we can't just fail early - we have to notice it and copy that data to ov2, and then return this status so that the consumer knows.
	/// </summary>
	AlreadyOwnedInOv1ButGrantedInOv2,
	AlreadyOwnedInOv1NothingDone,
	/// <summary>
	/// When ov2 fails.
	/// </summary>
	AlreadyOwnedInOv1AndOv2GrantFailed,
	AlreadyOwnedInOv2ButGrantedInOv1,
	AlreadyOwnedInOv1AndOv2
}
