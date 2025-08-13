using Roblox.RealTimeNotifications;

namespace Roblox.Platform.CloudEdit.Permissions;

/// <summary>
/// CloudEdit update message
/// </summary>
internal class CloudEditUpdateNotificationMessage : UserNotificationMessageBase
{
	/// <summary>
	/// Gets or sets the initiator user identifier.
	/// </summary>
	/// <value>
	/// The initiator user identifier.
	/// </value>
	public long InitiatorUserId { get; set; }

	/// <summary>
	/// Gets or sets the universe identifier.
	/// </summary>
	/// <value>
	/// The universe identifier.
	/// </value>
	public long UniverseId { get; set; }

	/// <summary>
	/// Gets or sets the type of notification.
	/// </summary>
	/// <value>
	/// The type of notification.
	/// </value>
	public override string Type { get; set; }

	public CloudEditUpdateNotificationMessage()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CloudEdit.Permissions.CloudEditUpdateNotificationMessage" /> class.
	/// </summary>
	/// <param name="initiatorUserId">The initiator user identifier.</param>
	/// <param name="universeId">The universe identifier.</param>
	/// <param name="type">The type of notification.</param>
	public CloudEditUpdateNotificationMessage(long initiatorUserId, long universeId, CloudEditUpdateNotificationType type)
	{
		UniverseId = universeId;
		InitiatorUserId = initiatorUserId;
		Type = type.ToString();
	}
}
