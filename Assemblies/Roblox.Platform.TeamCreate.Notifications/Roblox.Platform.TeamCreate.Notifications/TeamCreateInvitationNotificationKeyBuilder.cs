using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationNotificationKeyBuilder" />.
/// </summary>
public class TeamCreateInvitationNotificationKeyBuilder : ITeamCreateInvitationNotificationKeyBuilder
{
	/// <inheritdoc />
	public string BuildKey(IUser inviter, IUser invitee, IUniverse universe)
	{
		if (inviter == null)
		{
			throw new ArgumentNullException("inviter");
		}
		if (invitee == null)
		{
			throw new ArgumentNullException("invitee");
		}
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		return BuildKey(inviter.Id, invitee.Id, universe.Id);
	}

	/// <inheritdoc />
	public string BuildKey(long inviterUserId, long inviteeUserId, long universeId)
	{
		return $"TeamCreateInviteTo:{inviteeUserId}_InUniverse:{universeId}";
	}
}
