using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Roblox.Common;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Properties;
using Roblox.Properties;

namespace Roblox.Platform.Social;

/// <summary>
/// Provides methods to get a user's messages.
/// </summary>
public class MessageGetter
{
	/// <summary>
	/// The user ID of the user to get messages for.
	/// </summary>
	private readonly long _UserId;

	/// <summary>
	/// The IMessageDataAccessor used to get message data.
	/// </summary>
	private readonly IMessageDataAccessor _MessageDataAccessor;

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> that represents a query for
	/// the count of unread messages in a user's inbox.
	/// </summary>
	private MessageQueryFilterSet _UnreadInboxMessageCountFilterSet;

	/// <summary>
	/// Gets the user ID of the user to access messages for.
	/// </summary>
	public long UserId => _UserId;

	/// <summary>
	/// Gets whether or not unread message counts should be tracked through user counters.
	/// </summary>
	protected virtual bool UseUnreadMessagesCounter => Roblox.Properties.Settings.Default.UseUnreadMessagesCounter;

	/// <summary>
	/// Gets the chance that the user counter for unread messages should be synced
	/// when getting the unread inbox message count.
	/// </summary>
	protected virtual double UnreadMessagesCounterVerificationPercentage => Roblox.Properties.Settings.Default.UnreadMessagesCounterVerificationPercentage;

	/// <summary>
	/// Gets the number of messages below which the user counter for unread inbox messages
	/// will always be synced.
	/// </summary>
	protected virtual int UnreadMessagesCounterAutoSyncThreshold => Roblox.Properties.Settings.Default.UnreadMessagesCounterAutoSyncThreshold;

	/// <summary>
	/// Gets to user ID of Roblox.
	/// </summary>
	protected virtual int RobloxUserId => Roblox.Platform.Membership.Properties.Settings.Default.RobloxUserId;

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> that represents a query for
	/// the count of unread messages in a user's inbox.
	/// </summary>
	private MessageQueryFilterSet GetUnreadInboxMessageCountFilterSet()
	{
		MessageQueryFilterSet messageQueryFilterSet = _UnreadInboxMessageCountFilterSet;
		if (messageQueryFilterSet == null)
		{
			MessageQueryFilterSet obj = new MessageQueryFilterSet
			{
				ArchiveFilter = MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly,
				InvitationFilter = MessageQueryFilterSet.InvitationQueryFilter.Both,
				ReadFilter = MessageQueryFilterSet.ReadQueryFilter.UnreadOnly,
				SystemMessageFilter = MessageQueryFilterSet.SystemMessageQueryFilter.Both
			};
			MessageQueryFilterSet messageQueryFilterSet2 = obj;
			_UnreadInboxMessageCountFilterSet = obj;
			messageQueryFilterSet = messageQueryFilterSet2;
		}
		return messageQueryFilterSet;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Social.MessageGetter" /> class.
	/// </summary>
	/// <param name="userId">The user ID of the user to get messages for.</param>
	/// <param name="messageDataAccessor">The IMessageDataAccessor used to access message data. Uses 
	/// a <see cref="T:Roblox.Platform.Social.MessageDataAccessor" /> if left null.</param>
	public MessageGetter(long userId, IMessageDataAccessor messageDataAccessor = null)
	{
		_UserId = userId;
		_MessageDataAccessor = messageDataAccessor ?? new MessageDataAccessor();
	}

	/// <summary>
	/// Gets the user's messages in a specified tab.
	/// </summary>
	/// <param name="messageTab">The message tab to get messages for.</param>
	/// <param name="pageNumber">The zero-indexed page of messages to get.</param>
	/// <param name="pageSize">The number of messages on the page.</param>
	/// <returns>The page of the user's messages in the specified tab.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if pageNumber or pageSize is less than one.</exception>
	public IEnumerable<Message> GetMessagesInMessageTab(MessageTabType messageTab, int pageNumber, int pageSize)
	{
		return messageTab switch
		{
			MessageTabType.Archive => GetArchivedMessages(pageNumber, pageSize), 
			MessageTabType.Inbox => GetInboxMessages(pageNumber, pageSize), 
			MessageTabType.Sent => GetSentMessages(pageNumber, pageSize), 
			_ => throw new InvalidEnumArgumentException(), 
		};
	}

	/// <summary>
	/// Gets the count of the user's messages in a specified tab.
	/// </summary>
	/// <param name="messageTab">The message tab to get the count for.</param>
	/// <returns>The number of messages in the tab.</returns>
	public int GetMessageCountInMessageTab(MessageTabType messageTab)
	{
		return messageTab switch
		{
			MessageTabType.Archive => GetArchivedMessagesCount(), 
			MessageTabType.Inbox => GetInboxMessagesCount(), 
			MessageTabType.Sent => GetSentMessagesCount(), 
			_ => throw new InvalidEnumArgumentException(), 
		};
	}

	/// <summary>
	/// Synchronizes the given <see cref="T:Roblox.UserCounter" /> to exactly match the real unread
	/// messages count.
	/// </summary>
	/// <param name="unreadMessagesCounter">The <see cref="T:Roblox.UserCounter" /> to sync.</param>
	private void SynchronizeUnreadMessagesCounter(UserCounter unreadMessagesCounter)
	{
		MessageQueryFilterSet filterSet = GetUnreadInboxMessageCountFilterSet();
		int difference = _MessageDataAccessor.GetCountByRecipientId(_UserId, filterSet) - (int)unreadMessagesCounter.Value;
		if (difference > 0)
		{
			unreadMessagesCounter.Increment(difference);
		}
		else if (difference < 0)
		{
			unreadMessagesCounter.Decrement(-1 * difference);
		}
	}

	/// <summary>
	/// Gets the number of messages in the user's inbox.
	/// </summary>
	/// <returns>The number of messages in the user's inbox.</returns>
	public int GetInboxMessagesCount()
	{
		MessageQueryFilterSet filterSet = new MessageQueryFilterSet
		{
			ArchiveFilter = MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly,
			InvitationFilter = MessageQueryFilterSet.InvitationQueryFilter.Both,
			ReadFilter = MessageQueryFilterSet.ReadQueryFilter.Both,
			SystemMessageFilter = MessageQueryFilterSet.SystemMessageQueryFilter.Both
		};
		return _MessageDataAccessor.GetCountByRecipientId(_UserId, filterSet);
	}

	/// <summary>
	/// Determines whether the given user counter should be synchronized.
	/// </summary>
	/// <param name="unreadMessagesCounter">The <see cref="T:Roblox.UserCounter" /> to check.</param>
	private bool ShouldSynchronizeUnreadMessagesUserCounter(UserCounter unreadMessagesCounter)
	{
		if (Math.Abs(UnreadMessagesCounterVerificationPercentage) < 1E-06 && unreadMessagesCounter.Value > UnreadMessagesCounterAutoSyncThreshold)
		{
			return false;
		}
		if (!(new Random().NextDouble() <= UnreadMessagesCounterVerificationPercentage))
		{
			return unreadMessagesCounter.Value <= UnreadMessagesCounterAutoSyncThreshold;
		}
		return true;
	}

	/// <summary>
	/// Gets the number of messages in the user's sent tab.
	/// </summary>
	/// <returns>The number of messages in the user's sent tab.</returns>
	public int GetSentMessagesCount()
	{
		MessageQueryFilterSet filterSet = new MessageQueryFilterSet();
		filterSet.SystemMessageFilter = MessageQueryFilterSet.SystemMessageQueryFilter.Both;
		filterSet.ReadFilter = MessageQueryFilterSet.ReadQueryFilter.Both;
		filterSet.InvitationFilter = MessageQueryFilterSet.InvitationQueryFilter.Both;
		filterSet.ArchiveFilter = MessageQueryFilterSet.ArchiveQueryFilter.Both;
		return _MessageDataAccessor.GetCountByAuthorId(_UserId, filterSet);
	}

	/// <summary>
	/// Gets the number of messages in the user's archive tab.
	/// </summary>
	/// <returns>The number of messages in the user's archive tab.</returns>
	public int GetArchivedMessagesCount()
	{
		MessageQueryFilterSet filterSet = new MessageQueryFilterSet();
		filterSet.ArchiveFilter = MessageQueryFilterSet.ArchiveQueryFilter.ArchivedOnly;
		filterSet.SystemMessageFilter = MessageQueryFilterSet.SystemMessageQueryFilter.UserOnly;
		filterSet.ReadFilter = MessageQueryFilterSet.ReadQueryFilter.Both;
		filterSet.InvitationFilter = MessageQueryFilterSet.InvitationQueryFilter.Both;
		return _MessageDataAccessor.GetCountByRecipientId(_UserId, filterSet);
	}

	/// <summary>
	/// Gets the user's message by its message ID.
	/// </summary>
	/// <param name="messageId">The message ID of the message to get.</param>
	/// <returns>The message with the given message ID, or null if none existed.</returns>
	/// <exception cref="T:Roblox.Platform.Membership.UnauthorizedUserOperationException">Thrown if the user did not send or receive the message.</exception>
	public Message GetMessageById(long messageId)
	{
		Message message = _MessageDataAccessor.GetByMessageId(messageId);
		if (!new MessagePermission(messageId, _MessageDataAccessor).HasPermissionToAccess(_UserId))
		{
			throw new UnauthorizedUserOperationException(_UserId);
		}
		FilterMessageProblems(message);
		return message;
	}

	/// <summary>
	/// Gets the number of unread messages in the user's inbox.
	/// </summary>
	/// <returns>The number of unread messages in the user's inbox.</returns>
	public int GetUnreadMessagesInInboxCount()
	{
		if (!UseUnreadMessagesCounter)
		{
			MessageQueryFilterSet filterSet = GetUnreadInboxMessageCountFilterSet();
			return _MessageDataAccessor.GetCountByRecipientId(_UserId, filterSet);
		}
		bool wasSynced;
		UserCounter unreadMessagesCounter = UserCounter.GetOrCreate(_UserId, UserCounterType.UnreadMessagesID, SynchronizeUnreadMessagesCounter, out wasSynced);
		if (!wasSynced && ShouldSynchronizeUnreadMessagesUserCounter(unreadMessagesCounter))
		{
			SynchronizeUnreadMessagesCounter(unreadMessagesCounter);
		}
		return (int)unreadMessagesCounter.Value;
	}

	/// <summary>
	/// Gets the messages in the user's inbox.
	/// </summary>
	/// <param name="pageNumber">The zero-indexed page number to get messages for.</param>
	/// <param name="pageSize">The number of messages on each page.</param>
	/// <returns>The messages in the user's inbox.</returns>
	public IEnumerable<Message> GetInboxMessages(int pageNumber, int pageSize)
	{
		MessageQueryFilterSet filterSet = new MessageQueryFilterSet
		{
			ArchiveFilter = MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly,
			InvitationFilter = MessageQueryFilterSet.InvitationQueryFilter.NoInvitations,
			SystemMessageFilter = MessageQueryFilterSet.SystemMessageQueryFilter.Both,
			ReadFilter = MessageQueryFilterSet.ReadQueryFilter.Both
		};
		int startIndex = ConvertPageNumberAndSizeToStartIndex(pageNumber, pageSize);
		return _MessageDataAccessor.GetByRecipientIdPaged(_UserId, filterSet, startIndex, pageSize).Select(FilterMessageProblems);
	}

	/// <summary>
	/// Gets the messages in the user's sent tab.
	/// </summary>
	/// <param name="pageNumber">The zero-indexed page number to get messages for.</param>
	/// <param name="pageSize">The number of messages on each page.</param>
	/// <returns>The messages in the user's sent tab.</returns>
	public IEnumerable<Message> GetSentMessages(int pageNumber, int pageSize)
	{
		MessageQueryFilterSet filterSet = new MessageQueryFilterSet
		{
			SystemMessageFilter = MessageQueryFilterSet.SystemMessageQueryFilter.Both,
			ReadFilter = MessageQueryFilterSet.ReadQueryFilter.Both,
			InvitationFilter = MessageQueryFilterSet.InvitationQueryFilter.Both,
			ArchiveFilter = MessageQueryFilterSet.ArchiveQueryFilter.Both
		};
		int startIndex = ConvertPageNumberAndSizeToStartIndex(pageNumber, pageSize);
		return _MessageDataAccessor.GetByAuthorIdPaged(_UserId, filterSet, startIndex, pageSize).Select(FilterMessageProblems);
	}

	/// <summary>
	/// Gets the messages in the user's archive tab.
	/// </summary>
	/// <param name="pageNumber">The zero-indexed page number to get messages for.</param>
	/// <param name="pageSize">The number of messages on each page.</param>
	/// <returns>The messages in the user's archive tab.</returns>
	public IEnumerable<Message> GetArchivedMessages(int pageNumber, int pageSize)
	{
		MessageQueryFilterSet filterSet = new MessageQueryFilterSet
		{
			ArchiveFilter = MessageQueryFilterSet.ArchiveQueryFilter.ArchivedOnly,
			SystemMessageFilter = MessageQueryFilterSet.SystemMessageQueryFilter.UserOnly,
			InvitationFilter = MessageQueryFilterSet.InvitationQueryFilter.NoInvitations,
			ReadFilter = MessageQueryFilterSet.ReadQueryFilter.Both
		};
		int startIndex = ConvertPageNumberAndSizeToStartIndex(pageNumber, pageSize);
		return _MessageDataAccessor.GetByRecipientIdPaged(_UserId, filterSet, startIndex, pageSize).Select(FilterMessageProblems);
	}

	/// <summary>
	/// Converts the given page number and page size to a start index.
	/// </summary>
	/// <param name="pageNumber">The zero-indexed page number.</param>
	/// <param name="pageSize">The page size.</param>
	/// <returns>The start index.</returns>
	private int ConvertPageNumberAndSizeToStartIndex(int pageNumber, int pageSize)
	{
		return pageNumber * pageSize;
	}

	/// <summary>
	/// Encodes the given string as HTML.
	/// </summary>
	/// <param name="value">The string to encode.</param>
	/// <returns>The string encoded as html.</returns>
	protected virtual string EncodeStringAsHtml(string value)
	{
		return TextTransforms.TransformString(value);
	}

	/// <summary>
	/// Escapes HTML in message body and converts line endings to brs, for non system messages.
	/// </summary>
	/// <param name="message">The message</param>
	/// <returns>The message</returns>
	private Message FilterMessageProblems(Message message)
	{
		if (!message.IsSystemMessage)
		{
			message.Body = EncodeStringAsHtml(message.Body);
		}
		if (message.AuthorId == 0L)
		{
			message.AuthorId = RobloxUserId;
		}
		return message;
	}
}
