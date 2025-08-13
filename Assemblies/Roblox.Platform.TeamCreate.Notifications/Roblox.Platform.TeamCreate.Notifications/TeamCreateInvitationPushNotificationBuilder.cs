using System;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// An <see cref="T:Roblox.Platform.Notifications.Push.PushNotificationContentBuilderBase`2" /> implementation for the team create invitation notification.
/// </summary>
public class TeamCreateInvitationPushNotificationBuilder : PushNotificationContentBuilderBase<TeamCreateInvitationNotification, TeamCreateInvitationDetail>
{
	private readonly ITeamCreateInvitationEventTargetInterpreter _EventTargetInterpreter;

	/// <inheritdoc />
	public override NotificationSourceType NotificationSourceType => NotificationSourceType.TeamCreateInvite;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationPushNotificationBuilder" />.
	/// </summary>
	/// <param name="eventTargetInterpreter">An <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationEventTargetInterpreter" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="eventTargetInterpreter" /></exception>
	public TeamCreateInvitationPushNotificationBuilder(ITeamCreateInvitationEventTargetInterpreter eventTargetInterpreter, ILocalizationResourceProvider localizationResourceProvider)
		: base(localizationResourceProvider)
	{
		_EventTargetInterpreter = eventTargetInterpreter ?? throw new ArgumentNullException("eventTargetInterpreter");
	}

	/// <inheritdoc />
	protected override string BuildCategory(TeamCreateInvitationDetail detail)
	{
		return NotificationSourceType.TeamCreateInvite.ToString();
	}

	/// <inheritdoc />
	/// <exception cref="T:System.ArgumentNullException"><paramref name="notification" /> is null</exception>
	protected override TeamCreateInvitationDetail BuildDetail(TeamCreateInvitationNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		return _EventTargetInterpreter.BuildDetail(notification.EventTargetId, notification.EventDate);
	}

	/// <inheritdoc />
	/// <exception cref="T:System.ArgumentNullException"><paramref name="detail" /> is null</exception>
	protected override string BuildBody(TeamCreateInvitationDetail detail)
	{
		if (detail == null)
		{
			throw new ArgumentNullException("detail");
		}
		return $"{detail.ActingUsername} invited you to edit the game: {detail.UniverseName}";
	}

	/// <inheritdoc />
	/// <exception cref="T:System.ArgumentNullException"><paramref name="detail" /> is null</exception>
	protected override string BuildLocalizedBody(IUser user, TeamCreateInvitationDetail detail)
	{
		if (detail == null)
		{
			throw new ArgumentNullException("detail");
		}
		return GetLocalizationResourcesFromUser(user).Notifications.PushNotifications.MessageTeamCreateInvitation(detail.ActingUsername, detail.UniverseName);
	}
}
