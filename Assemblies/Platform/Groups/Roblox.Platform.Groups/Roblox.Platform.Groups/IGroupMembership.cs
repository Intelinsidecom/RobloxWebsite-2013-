using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

public interface IGroupMembership
{
	IUser User { get; }

	IGroup Group { get; }

	IGroupRoleSet RoleSet { get; }

	GroupDomainFactories DomainFactories { get; }

	bool IsInClan();

	void LeaveClan();
}
