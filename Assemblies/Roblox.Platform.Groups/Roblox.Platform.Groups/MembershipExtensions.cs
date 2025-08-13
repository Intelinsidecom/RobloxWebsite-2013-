using System;
using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

public static class MembershipExtensions
{
	public static IEnumerable<IGroupMembership> GetGroupMemberships(this IUser user, GroupDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		if (user == null)
		{
			return new List<IGroupMembership>();
		}
		return domainFactories.GroupMembershipFactory.GetGroupMembershipsByUser(user);
	}

	public static IGroup GetClan(this IUser user, GroupDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		return domainFactories.ClanMemberFactory.GetClanMembership(user);
	}

	public static IGroup GetPrimaryGroup(this IUser user, IGroupFactory groupFactory)
	{
		if (groupFactory == null)
		{
			throw new ArgumentNullException("groupFactory");
		}
		user.VerifyIsNotNull();
		UserGroup primaryGroup = PrimaryUserGroup.GetByUserID(user.Id);
		if (primaryGroup != null)
		{
			return groupFactory.CheckedGetById(primaryGroup.GroupID);
		}
		return null;
	}
}
