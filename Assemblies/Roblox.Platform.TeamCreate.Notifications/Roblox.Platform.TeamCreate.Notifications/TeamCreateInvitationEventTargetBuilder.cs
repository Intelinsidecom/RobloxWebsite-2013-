using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationEventTargetBuilder" />.
/// Compatible with the <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationEventTargetInterpreter" />.
/// </summary>
public class TeamCreateInvitationEventTargetBuilder : ITeamCreateInvitationEventTargetBuilder
{
	/// <inheritdoc />
	public EventTarget BuildEventTarget(TeamCreateInvitationNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (notification.Generator == null)
		{
			throw new ArgumentNullException("notification");
		}
		return $"{notification.Generator.GeneratorId}_{notification.AddedUserId}_{notification.UniverseId}";
	}
}
