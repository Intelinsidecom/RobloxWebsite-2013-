using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Groups;

public interface IPrimaryGroupFactory
{
	IGroup GetPrimaryGroupByUser(IUserIdentifier user);
}
