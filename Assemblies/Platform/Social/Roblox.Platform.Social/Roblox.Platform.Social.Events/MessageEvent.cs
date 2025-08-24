using Roblox.Amazon.Sns;

namespace Roblox.Platform.Social.Events;

public class MessageEvent : ISnsMessage
{
	public MessageEventType Type { get; }

	public long MessageId { get; }

	public MessageEvent(MessageEventType type, long messageId)
	{
		Type = type;
		MessageId = messageId;
	}
}
