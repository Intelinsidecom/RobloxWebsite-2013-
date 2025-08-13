namespace Roblox.Platform.AssetOwnership;

/// <summary>
/// During rollout we have to decide which of ov1 and ov2 we should save data to.
/// </summary>
public enum OwnershipWriteStrategy
{
	Ov1 = 1,
	Ov2,
	DoubleWriteAtPercentage
}
