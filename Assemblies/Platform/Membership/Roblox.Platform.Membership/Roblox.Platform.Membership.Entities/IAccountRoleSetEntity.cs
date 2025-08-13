using Roblox.Entities;

namespace Roblox.Platform.Membership.Entities;

internal interface IAccountRoleSetEntity : IEntity<int>
{
	long AccountId { get; }

	int RoleSetId { get; }
}
