using System;
using System.Collections.Generic;
using Roblox.Platform.Membership.Properties;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Membership;

public static class MembershipCoreExtensions
{
	private static Account GetAccountEntity(this IUserIdentifier user)
	{
		if (user == null)
		{
			return null;
		}
		return Account.MustGet(Roblox.User.MustGet(user.Id).AccountID);
	}

	public static IEnumerable<string> GetNameHistory(this IUserIdentifier user)
	{
		return user.GetAccountEntity().PreviousUsernames;
	}

	public static bool IsInRole(this IUserIdentifier user, string roleSetName)
	{
		Account accountEntity = user.GetAccountEntity();
		if (accountEntity == null)
		{
			return false;
		}
		RoleSet roleSetEntity = RoleSet.GetByName(roleSetName);
		if (roleSetEntity == null)
		{
			return false;
		}
		return accountEntity.IsInRole(roleSetEntity.ID);
	}

	public static bool IsRegularUser(this IUserIdentifier user)
	{
		if (user == null)
		{
			return false;
		}
		return user.GetAccountEntity().GetHighestRoleSet().ID == RoleSet.Member.ID;
	}

	[Obsolete("Use MembershipDomainFactories.RoleSetValidator.IsPrivilegedUser(user) instead.")]
	public static bool IsPrivilegedUser(this IUserIdentifier user)
	{
		if (user == null)
		{
			return false;
		}
		return user.GetAccountEntity().GetHighestRoleSet().Rank >= Settings.Default.PrivilegedUserRolesetRankThreshold;
	}

	public static void VerifyIsNotNull(this IUserIdentifier user, int? id = null)
	{
		if (user == null)
		{
			if (id.HasValue)
			{
				throw new UnknownUserException(id.Value);
			}
			throw new UnknownUserException();
		}
	}

	public static void VerifyIsNotNull(this IVisitorIdentifier visitor)
	{
		if (visitor == null)
		{
			throw new UnknownVisitorException();
		}
	}
}
