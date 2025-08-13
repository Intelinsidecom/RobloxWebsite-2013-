using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Avatar.Notifications;

internal class AssetOwnershipNotificationMessage : UserNotificationMessageBase
{
	public long AssetId { get; set; }

	public int AssetTypeId { get; set; }

	public override string Type { get; set; }
}
