using Roblox.Entities;
namespace Roblox.Moderation.Entitiesinternal {
    interface IModerationLocaleEntity : IUpdateableEntity<int>, IEntity<int>

{
	int SupportedLocaleId { get; set; }

	bool IsActive { get; set; }
}


}
