using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups.Interfaces;

public interface IClanMemberFactory
{
	IGroup GetClanMembership(IUser user);

	IGroup GetClanMembershipByUserId(long userId);

	int GetTotalClanMembers(IGroup group);

	IEnumerable<IUser> GetClanMembersByGroup(IGroup group, int startRowIndex, int maxRows);
}
