using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Presence.Events;

internal class ClientPresenceNotificationMessage : UserNotificationMessageBase
{
	public int UserId { get; set; }

	public long PlaceId { get; set; }

	public override string Type { get; set; }
}
