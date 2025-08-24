using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Social.Events;

namespace Roblox.Platform.Social;

/// <summary>
/// Provides methods for manipulating an existing message.
/// </summary>
public class MessageManipulator
{
	/// <summary>
	/// The IMessageDataAccessor used to access message data.
	/// </summary>
	private readonly IMessageDataAccessor _MessageDataAccessor;

	/// <summary>
	/// The IMessageEventPublisher used to publish message event to AWS Sns.
	/// </summary>
	private readonly IMessageEventPublisher _MessageEventPublisher;

	/// <summary>
	/// The MessageCounter used to track message count change.
	/// </summary>
	private readonly MessageCounter _MessageCounter;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Social.MessageManipulator" /> class.
	/// </summary>
	/// <param name="messageEventPublisher">The <see cref="T:Roblox.Platform.Social.Events.IMessageEventPublisher" /> to use to publish message events. 
	/// Uses a <see cref="T:Roblox.Platform.Social.Events.MessageEventPublisher" /> if ledt null</param>
	/// <param name="messageDataAccessor">The IMessageDataAccessor used to access message data. Uses 
	/// a <see cref="T:Roblox.Platform.Social.MessageDataAccessor" /> if left null.</param>
	public MessageManipulator(IMessageEventPublisher messageEventPublisher, IMessageDataAccessor messageDataAccessor = null)
	{
		_MessageDataAccessor = messageDataAccessor ?? new MessageDataAccessor();
		_MessageEventPublisher = messageEventPublisher;
		_MessageCounter = new MessageCounter(_MessageDataAccessor);
	}

	/// <summary>
	/// Marks a user's message as read.
	/// </summary>
	/// <param name="userId">The user ID of the user that received the message.</param>
	/// <param name="messageId">The message ID of the message to mark as read.</param>
	public void MarkMessageAsRead(long userId, long messageId)
	{
		Message message = _MessageDataAccessor.GetByMessageId(messageId);
		if (message == null)
		{
			throw new ArgumentException("Invalid message ID");
		}
		if (message.RecipientId != userId)
		{
			throw new UnauthorizedUserOperationException(userId);
		}
		if (!message.IsRead)
		{
			message.IsRead = true;
			_MessageDataAccessor.Save(message);
			if (!message.IsArchived)
			{
				_MessageCounter.DecrementUnreadMessageCountUserCounter(userId);
			}
			_MessageEventPublisher.Publish(MessageEventType.MarkAsRead, messageId, userId);
		}
	}

	/// <summary>
	/// Marks a user's message as unread.
	/// </summary>
	/// <param name="userId">The user ID of the user that received the message.</param>
	/// <param name="messageId">The message ID of the message to mark as unread.</param>
	public void MarkMessageAsUnread(long userId, long messageId)
	{
		Message message = _MessageDataAccessor.GetByMessageId(messageId);
		if (message == null)
		{
			throw new ArgumentException("Invalid message ID");
		}
		if (message.RecipientId != userId)
		{
			throw new UnauthorizedUserOperationException(userId);
		}
		if (message.IsRead)
		{
			message.IsRead = false;
			_MessageDataAccessor.Save(message);
			if (!message.IsArchived)
			{
				_MessageCounter.IncrementUnreadMessageCountUserCounter(userId);
			}
			_MessageEventPublisher.Publish(MessageEventType.MarkAsUnRead, messageId, userId);
		}
	}

	/// <summary>
	/// Marks a user's message as archived.
	/// </summary>
	/// <param name="userId">The user ID of the user that received the message.</param>
	/// <param name="messageId">The message ID of the message to mark as archived.</param>
	public void MarkMessageAsArchived(long userId, long messageId)
	{
		Message message = _MessageDataAccessor.GetByMessageId(messageId);
		if (message == null)
		{
			throw new ArgumentException("Invalid message ID");
		}
		if (message.RecipientId != userId)
		{
			throw new UnauthorizedUserOperationException(userId);
		}
		if (!message.IsArchived)
		{
			message.IsArchived = true;
			_MessageDataAccessor.Save(message);
			if (!message.IsRead)
			{
				_MessageCounter.DecrementUnreadMessageCountUserCounter(userId);
			}
			_MessageEventPublisher.Publish(MessageEventType.Archived, messageId, userId);
		}
	}

	/// <summary>
	/// Marks a user's message as unarchived.
	/// </summary>
	/// <param name="userId">The user ID of the user that received the message.</param>
	/// <param name="messageId">The message ID of the message to mark as unarchived.</param>
	public void MarkMessageAsUnarchived(long userId, long messageId)
	{
		Message message = _MessageDataAccessor.GetByMessageId(messageId);
		if (message == null)
		{
			throw new ArgumentException("Invalid message ID");
		}
		if (message.RecipientId != userId)
		{
			throw new UnauthorizedUserOperationException(userId);
		}
		if (message.IsArchived)
		{
			message.IsArchived = false;
			_MessageDataAccessor.Save(message);
			if (!message.IsRead)
			{
				_MessageCounter.IncrementUnreadMessageCountUserCounter(userId);
			}
			_MessageEventPublisher.Publish(MessageEventType.UnArchived, messageId, userId);
		}
	}
}
