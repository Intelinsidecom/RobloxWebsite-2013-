using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate;

public class TeamCreateMembership : ITeamCreateMembership
{
	public IUser User { get; set; }

	public IUniverse Universe { get; set; }

	public DateTime GrantDate { get; set; }
}
