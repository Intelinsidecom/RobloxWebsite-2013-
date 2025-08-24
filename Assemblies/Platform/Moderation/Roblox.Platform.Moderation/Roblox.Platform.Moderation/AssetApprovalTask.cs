namespace Roblox.Moderation;

internal class AssetApprovalTask
{
	private readonly bool _IsApproved;

	private readonly long _ModeratorID = 1L;

	private readonly IReviewableAsset _ReviewableAsset;

	internal bool IsApproved => _IsApproved;

	internal long ModeratorID => _ModeratorID;

	internal IReviewableAsset ReviewableAsset => _ReviewableAsset;

	internal AssetApprovalTask(long moderatorId, IReviewableAsset reviewableAsset, bool isApproved)
	{
		_IsApproved = isApproved;
		_ModeratorID = moderatorId;
		_ReviewableAsset = reviewableAsset;
	}
}
