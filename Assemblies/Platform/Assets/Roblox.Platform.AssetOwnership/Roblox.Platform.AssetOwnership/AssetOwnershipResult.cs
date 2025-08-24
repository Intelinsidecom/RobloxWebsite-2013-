namespace Roblox.Platform.AssetOwnership;

public class AssetOwnershipResult : IAssetOwnershipResult
{
	public bool IsSuccess { get; }

	public string Message { get; }

	public AssetOwnershipResult(bool isSuccess, string message)
	{
		IsSuccess = isSuccess;
		Message = message;
	}
}
