namespace Roblox.Platform.AssetOwnership;

/// <summary>
/// For use queries that may hit ov1 or ov2 depending on rollout status.
/// For lock-related items, it's always ov1.
/// </summary>
public interface IAssetOwnershipResult
{
	bool IsSuccess { get; }

	string Message { get; }
}
