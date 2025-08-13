namespace Roblox.Platform.AssetOwnership;

public class DualAwardResult
{
	public long UserAssetId { get; set; }

	public bool AwardedInOv1 { get; set; }

	public bool AwardedInOv2 { get; set; }

	public AwardStatus AwardStatus { get; set; }

	public DualAwardResult(long userAssetId, bool awardedInOv1, bool awardedInOv2, AwardStatus awardStatus)
	{
		UserAssetId = userAssetId;
		AwardedInOv1 = awardedInOv1;
		AwardedInOv2 = awardedInOv2;
		AwardStatus = awardStatus;
	}
}
