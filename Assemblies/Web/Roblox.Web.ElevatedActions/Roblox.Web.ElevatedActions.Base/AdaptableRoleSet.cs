using System;
using Roblox.Platform.Membership;

namespace Roblox.Web.ElevatedActions.Base;

public class AdaptableRoleSet : IRoleset
{
	public int Id { get; }

	public string Name { get; }

	public int Rank { get; }

	public AdaptableRoleSet(RoleSet roleSet)
	{
		if (roleSet == null)
		{
			throw new ArgumentNullException("roleSet");
		}
		Id = roleSet.ID;
		Name = roleSet.Name;
		Rank = roleSet.Rank;
	}
}
