using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

internal interface IGroupRoleSetEntity : IUpdateableEntity<long>, IEntity<long>
{
	string Name { get; set; }

	string Description { get; set; }

	byte Rank { get; set; }

	long GroupId { get; set; }
}
