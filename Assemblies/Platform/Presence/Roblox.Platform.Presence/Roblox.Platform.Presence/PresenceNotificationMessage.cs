using Roblox.Platform.Presence.Properties;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Presence;

internal class PresenceNotificationMessage : UserNotificationMessageBase
{
	public long UserId { get; set; }

	public override string Type { get; set; }

	public override bool IsIncrementSequenceNumberEnabled { get; } = Settings.Default.IsNameSpaceSequenceNumberForPresenceNotificationEnabled;

}
