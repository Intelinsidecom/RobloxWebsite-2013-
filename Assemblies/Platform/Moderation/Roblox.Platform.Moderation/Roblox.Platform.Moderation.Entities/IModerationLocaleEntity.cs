using Roblox.Entities;

namespace Roblox.Platform.Moderation.Entities;

internal interface IModerationLocaleEntity : IUpdateableEntity<int>, IEntity<int>
{
	int SupportedLocaleId { get; set; }

	bool IsActive { get; set; }
}
