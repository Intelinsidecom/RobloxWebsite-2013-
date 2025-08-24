namespace Roblox.Platform.Moderation;

public interface IReviewTaskLeaseEntityFactory<out TILeaseEntity> where TILeaseEntity : IReviewTaskLeaseEntity
{
	TILeaseEntity Get(long id);
}
