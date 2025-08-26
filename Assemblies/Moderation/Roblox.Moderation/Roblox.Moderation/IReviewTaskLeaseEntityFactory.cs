namespace Roblox.Moderationpublic {
    interface IReviewTaskLeaseEntityFactory<out TILeaseEntity> where TILeaseEntity : IReviewTaskLeaseEntity

{
	TILeaseEntity Get(long id);
}


}
