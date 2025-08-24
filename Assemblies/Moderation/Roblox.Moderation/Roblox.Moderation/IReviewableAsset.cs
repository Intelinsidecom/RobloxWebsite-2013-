namespace Roblox.Moderation;

public interface IReviewableAsset
{
	long CreatorID { get; }

	long HashID { get; }

	int TypeID { get; }

	void SetApproval(bool isApproved, bool isReviewed);
}
