namespace Roblox.Platform.AssetOwnership;

public class RemediationRequest
{
	public long UserAssetId { get; }

	public string Message { get; }

	public RemediationRequest(long userAssetId, string message)
	{
		Message = message;
		UserAssetId = userAssetId;
	}
}
