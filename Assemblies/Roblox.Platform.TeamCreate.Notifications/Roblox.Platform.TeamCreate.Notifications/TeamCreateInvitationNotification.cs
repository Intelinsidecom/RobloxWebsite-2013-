using System;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Stream;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// A notification for a team create invitation.
/// </summary>
public class TeamCreateInvitationNotification : IStoredStreamNotification, INotification
{
	private readonly ITeamCreateInvitationNotificationKeyBuilder _NotificationKeyBuilder;

	private readonly ITeamCreateInvitationEventTargetBuilder _EventTargetBuilder;

	/// <inheritdoc cref="P:Roblox.Platform.Notifications.Core.INotification.EventDate" />
	/// <remarks>
	/// The date when the user was invited.
	/// </remarks>
	public DateTime EventDate { get; set; }

	/// <summary>
	/// The invited user's id.
	/// </summary>
	public long AddedUserId { get; set; }

	/// <summary>
	/// The id of the universe the user is being invited to.
	/// </summary>
	public long UniverseId { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Notifications.Core.INotification.Generator" />
	/// <remarks>
	/// For this notification, the generator is the user inviting someone to a team create.
	/// </remarks>
	public NotificationGenerator Generator { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Notifications.Core.INotification.SourceType" />
	public NotificationSourceType SourceType => NotificationSourceType.TeamCreateInvite;

	/// <inheritdoc cref="P:Roblox.Platform.Notifications.Core.INotification.EventTargetId" />
	public EventTarget EventTargetId => _EventTargetBuilder.BuildEventTarget(this);

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationNotification" />.
	/// Exists because the notification class is deseralized by JSON.NET which requires a constructor without parameters.
	/// </summary>
	public TeamCreateInvitationNotification()
	{
		_NotificationKeyBuilder = new TeamCreateInvitationNotificationKeyBuilder();
		_EventTargetBuilder = new TeamCreateInvitationEventTargetBuilder();
	}

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationNotification" />.
	/// </summary>
	/// <param name="keyBuilder">An <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationNotificationKeyBuilder" />.</param>
	/// <param name="eventTargetBuilder">An <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationEventTargetBuilder" /></param>
	public TeamCreateInvitationNotification(ITeamCreateInvitationNotificationKeyBuilder keyBuilder, ITeamCreateInvitationEventTargetBuilder eventTargetBuilder)
	{
		_NotificationKeyBuilder = keyBuilder ?? throw new ArgumentNullException("keyBuilder");
		_EventTargetBuilder = eventTargetBuilder ?? throw new ArgumentNullException("eventTargetBuilder");
	}

	/// <inheritdoc />
	public string GetMessageSpecificNotificationKey()
	{
		if (Generator == null)
		{
			throw new InvalidOperationException("Generator is null.");
		}
		return _NotificationKeyBuilder.BuildKey(Generator.GeneratorId, AddedUserId, UniverseId);
	}
}
