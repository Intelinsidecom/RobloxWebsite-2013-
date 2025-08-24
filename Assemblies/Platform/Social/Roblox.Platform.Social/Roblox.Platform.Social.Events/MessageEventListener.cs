using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Platform.Social.Events;

public class MessageEventListener
{
	private readonly MessageEventPublisher _MessageEventPublisher;

	public MessageEventListener(ILogger logger, ICounterRegistry counterRegistry)
	{
		_MessageEventPublisher = new MessageEventPublisher(logger, counterRegistry);
	}

	public void Register()
	{
		Roblox.Message.OnMessageCreated += delegate(long messageId, long recipientUserId)
		{
			OnMessageCreated(messageId, recipientUserId);
		};
		Roblox.Message.OnMessageDeleted += delegate(long messageId, long recipientUserId)
		{
			OnMessageDeleted(messageId, recipientUserId);
		};
	}

	private void OnMessageCreated(long messageId, long recipientUserId)
	{
		_MessageEventPublisher.Publish(MessageEventType.Created, messageId, recipientUserId);
	}

	private void OnMessageDeleted(long messageId, long recipientUserId)
	{
		_MessageEventPublisher.Publish(MessageEventType.Deleted, messageId, recipientUserId);
	}
}
