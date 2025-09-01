using Roblox.Entities;
namespace Roblox.Moderation.Entities {
    interface IModerationLocaleEntity : IUpdateableEntity<int>, IEntity<int>

{
	int SupportedLocaleId { get; set; }

	bool IsActive { get; set; }
}


}
