using Roblox.Amazon.Sns;

namespace Roblox.Platform.Groups.Events;

public class GroupEvent : ISnsMessage
{
	public long GroupId { get; set; }

	public long? UserId { get; set; }

	public GroupEventType GroupEventType { get; set; }
}
