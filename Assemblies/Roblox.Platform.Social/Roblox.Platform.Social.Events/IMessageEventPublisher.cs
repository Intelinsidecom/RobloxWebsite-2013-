namespace Roblox.Platform.Social.Events;

public interface IMessageEventPublisher
{
	/// <summary>
	/// Publish a message event.
	/// </summary>
	/// <param name="type">The type of message event</param>
	/// <param name="messageId">The id of the message</param>
	/// <param name="recipientUserId">The user that will receive the message.</param>
	void Publish(MessageEventType type, long messageId, long recipientUserId);
}
