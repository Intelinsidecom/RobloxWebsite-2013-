using System;
using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.Notifications.Core.INotificationReceiverResolver" />.
/// </summary>
public class TeamCreateInvitationNotificationReceiverResolver : INotificationReceiverResolver
{
	private readonly ITeamCreateInvitationEventTargetInterpreter _EventTargetInterpreter;

	/// <inheritdoc />
	public NotificationSourceType NotificationSourceType => NotificationSourceType.TeamCreateInvite;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationNotificationReceiverResolver" />.
	/// </summary>
	/// <param name="eventTargetInterpreter">An <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationEventTargetInterpreter" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="eventTargetInterpreter" /></exception>
	public TeamCreateInvitationNotificationReceiverResolver(ITeamCreateInvitationEventTargetInterpreter eventTargetInterpreter)
	{
		_EventTargetInterpreter = eventTargetInterpreter ?? throw new ArgumentNullException("eventTargetInterpreter");
	}

	/// <inheritdoc />
	/// <exception cref="T:System.ArgumentNullException"><paramref name="notification" /></exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="notification" /> has an invalid event target id.</exception>
	public ICollection<IReceiver> GetReceiverForMessages(INotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		IUser invitee = _EventTargetInterpreter.GetInvitee(notification.EventTargetId);
		if (invitee == null)
		{
			throw new ArgumentException("INotification does not have a valid EventTargetId.", "notification");
		}
		return new List<IReceiver> { UserToReceiver(invitee) };
	}

	/// <summary>
	/// A helper method replacing the IUser.ToReceiver() extension method.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to convert to an <see cref="T:Roblox.Platform.Notifications.Core.IReceiver" /></param>
	/// <returns><paramref name="user" /> as a <see cref="T:Roblox.Platform.Notifications.Core.IReceiver" /></returns>
	internal virtual IReceiver UserToReceiver(IUser user)
	{
		return Accessors.ReceiverAccessor.GetByReceiverTypeAndTarget(ReceiverType.User, user.Id);
	}
}
