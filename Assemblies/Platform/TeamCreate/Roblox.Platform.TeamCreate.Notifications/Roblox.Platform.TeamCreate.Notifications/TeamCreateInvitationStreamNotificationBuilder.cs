using System;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Stream;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// An implementation of the <see cref="T:Roblox.Platform.Notifications.Stream.StreamNotificationBuilderBase`1" />  for the team create invitation event.
/// </summary>
public class TeamCreateInvitationStreamNotificationBuilder : StreamNotificationBuilderBase<TeamCreateInvitationDetail>
{
	private readonly ITeamCreateInvitationEventTargetInterpreter _EventTargetInterpreter;

	/// <inheritdoc />
	public override NotificationSourceType NotificationSourceType => NotificationSourceType.TeamCreateInvite;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationStreamNotificationBuilder" />.
	/// </summary>
	/// <param name="eventTargetInterpreter">An <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationEventTargetInterpreter" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="eventTargetInterpreter" /></exception>
	public TeamCreateInvitationStreamNotificationBuilder(ITeamCreateInvitationEventTargetInterpreter eventTargetInterpreter)
	{
		_EventTargetInterpreter = eventTargetInterpreter ?? throw new ArgumentNullException("eventTargetInterpreter");
	}

	/// <inheritdoc />
	protected override string BuildCategory(TeamCreateInvitationDetail detail)
	{
		return NotificationSourceType.TeamCreateInvite.ToString();
	}

	/// <inheritdoc />
	/// <exception cref="T:System.ArgumentNullException"><paramref name="storedNotification" /></exception>
	protected override TeamCreateInvitationDetail BuildDetail(IStoredStreamNotification storedNotification)
	{
		if (storedNotification == null)
		{
			throw new ArgumentNullException("storedNotification");
		}
		return _EventTargetInterpreter.BuildDetail(storedNotification.EventTargetId, storedNotification.EventDate);
	}
}
