using Roblox.Amazon.Sns;

namespace Roblox.Platform.Groups.Events;

internal class ClanEventMessage : ISnsMessage
{
	public byte EventType { get; set; }

	public long ClanId { get; set; }

	public long? UserId { get; set; }

	public long? EnemyClanId { get; set; }
}
