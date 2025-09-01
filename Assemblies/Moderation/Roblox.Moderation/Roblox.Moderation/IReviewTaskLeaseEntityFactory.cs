namespace Roblox.Moderation {
    interface IReviewTaskLeaseEntityFactory<out TILeaseEntity> where TILeaseEntity : IReviewTaskLeaseEntity

{
	TILeaseEntity Get(long id);
}


}
