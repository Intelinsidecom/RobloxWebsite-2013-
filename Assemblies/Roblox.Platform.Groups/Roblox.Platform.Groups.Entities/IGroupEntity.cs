using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities;

internal interface IGroupEntity : IUpdateableEntity<long>, IEntity<long>
{
	long AgentId { get; set; }

	bool BCOnly { get; set; }

	string Description { get; set; }

	long EmblemId { get; set; }

	string Name { get; set; }

	long? OwnerUserId { get; set; }

	long PreviousOwnerUserId { get; set; }

	bool PublicEntryAllowed { get; set; }
}
