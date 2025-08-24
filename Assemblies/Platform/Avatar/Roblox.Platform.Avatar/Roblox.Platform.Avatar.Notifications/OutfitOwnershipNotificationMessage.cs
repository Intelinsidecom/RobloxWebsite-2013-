using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Avatar.Notifications;

internal class OutfitOwnershipNotificationMessage : UserNotificationMessageBase
{
	public long UserOutfitId { get; set; }

	public override string Type { get; set; }
}
