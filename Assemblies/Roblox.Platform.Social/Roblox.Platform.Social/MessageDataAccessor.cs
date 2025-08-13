using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Social;

/// <summary>
/// Provides common methods to access private message data.
/// </summary>
public class MessageDataAccessor : IMessageDataAccessor
{
	/// <summary>
	/// The sort expression to use when getting messages.
	/// </summary>
	private const string _SortExpression = "Created [DESC]";

	/// <summary>
	/// Saves the given <see cref="T:Roblox.Platform.Social.Message" />.
	/// </summary>
	/// <param name="message">The <see cref="T:Roblox.Platform.Social.Message" /> to save.</param>
	public void Save(Message message)
	{
		Roblox.Message entity = Roblox.Message.Get(message.Id) ?? new Roblox.Message();
		entity.AuthorID = message.AuthorId;
		entity.Body = message.Body;
		entity.IsArchived = message.IsArchived;
		entity.IsBroadcastMessage = message.IsBroadcastMessage;
		entity.IsRead = message.IsRead;
		entity.IsSystemMessage = message.IsSystemMessage;
		entity.MessageTypeID = message.MessageTypeId;
		entity.RecipientID = message.RecipientId;
		entity.Subject = message.Subject;
		entity.Save();
		message.Id = entity.ID;
	}

	/// <summary>
	/// Deletes the <see cref="T:Roblox.Platform.Social.Message" /> with the given ID.
	/// </summary>
	/// <param name="messageId">The ID of the <see cref="T:Roblox.Platform.Social.Message" /> to delete.</param>
	public void Delete(long messageId)
	{
		Roblox.Message.Get(messageId)?.Delete();
	}

	/// <summary>
	/// Converts a Server Class Library message entity to a platform message.
	/// </summary>
	/// <param name="entity">The entity to convert.</param>
	/// <returns>The converted message model.</returns>
	private Message ConvertSclMessageToPlatformMessage(Roblox.Message entity)
	{
		return new Message
		{
			AuthorId = entity.AuthorID,
			Body = entity.Body,
			IsArchived = entity.IsArchived,
			IsBroadcastMessage = entity.IsBroadcastMessage,
			IsRead = entity.IsRead,
			IsSystemMessage = entity.IsSystemMessage,
			MessageTypeId = entity.MessageTypeID,
			RecipientId = entity.RecipientID,
			Subject = entity.Subject,
			Created = entity.Created,
			Updated = entity.Updated,
			Id = entity.ID
		};
	}

	/// <summary>
	/// Gets all messages authored by the user with the given user ID that match the given filter set.
	/// </summary>
	/// <param name="authorId">The user ID of the author.</param>
	/// <param name="filterSet">The filter set to match.</param>
	/// <returns>All messages authored by the user with the given user ID that match the given filter set.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is not supported.</exception>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is null.</exception>
	public IEnumerable<Message> GetByAuthorId(long authorId, MessageQueryFilterSet filterSet)
	{
		return GetByAuthorIdPaged(authorId, filterSet, 0, int.MaxValue);
	}

	/// <summary>
	/// Gets all messages received by the user with the given user ID that match the given filter set.
	/// </summary>
	/// <param name="recipientId">The user ID of the recipient.</param>
	/// <param name="filterSet">The filter set to match.</param>
	/// <returns>All messages received by the user with the given user ID that match the given filter set.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is not supported.</exception>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is null.</exception>
	public IEnumerable<Message> GetByRecipientId(long recipientId, MessageQueryFilterSet filterSet)
	{
		return GetByRecipientIdPaged(recipientId, filterSet, 0, int.MaxValue);
	}

	/// <summary>
	/// Gets a page of messages authored by the user with the given user ID that match the given filter set.
	/// </summary>
	/// <param name="authorId">The user ID of the author.</param>
	/// <param name="filterSet">The filter set to match.</param>
	/// <param name="startIndex">The zero-indexed row to start getting messages at.</param>
	/// <param name="pageSize">The number of messages on the page.</param>
	/// <returns>The page of messages authored by the user with the given user ID that match the given filter set. Up 
	/// to pageSize messages will be returned.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is not supported,
	/// if the startIndex is negative, or the page size is less than one.</exception>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is null.</exception>
	public IEnumerable<Message> GetByAuthorIdPaged(long authorId, MessageQueryFilterSet filterSet, int startIndex, int pageSize)
	{
		if (filterSet == null)
		{
			throw new ArgumentNullException("filterSet");
		}
		if (startIndex < 0)
		{
			throw new ArgumentException("startIndex must be non-negative");
		}
		if (pageSize < 1)
		{
			throw new ArgumentException("pageSize must be greater than 0");
		}
		if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.Both && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.Both && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.Both)
		{
			IEnumerable<Roblox.Message> entities = Roblox.Message.GetUserMessageSentPaged(authorId, startIndex, pageSize);
			return entities.Select(ConvertSclMessageToPlatformMessage).ToArray();
		}
		throw new ArgumentException("MessageQueryFilterSet not supported");
	}

	/// <summary>
	/// Gets a page of messages received by the user with the given user ID that match the given filter set.
	/// </summary>
	/// <param name="recipientId">The user ID of the recipient.</param>
	/// <param name="filterSet">The filter set to match.</param>
	/// <param name="startIndex">The zero-indexed row to start getting messages at.</param>
	/// <param name="pageSize">The number of messages on the page.</param>
	/// <returns>The page of messages received by the user with the given user ID that match the given filter set. Up 
	/// to pageSize messages will be returned.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is not supported,
	/// if the startIndex negative, or the page size is less than one.</exception>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is null.</exception>
	public IEnumerable<Message> GetByRecipientIdPaged(long recipientId, MessageQueryFilterSet filterSet, int startIndex, int pageSize)
	{
		if (filterSet == null)
		{
			throw new ArgumentNullException("filterSet");
		}
		if (startIndex < 0)
		{
			throw new ArgumentException("startIndex must be non-negative");
		}
		if (pageSize < 1)
		{
			throw new ArgumentException("pageSize must be greater than 0");
		}
		IEnumerable<Roblox.Message> entities;
		if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.Both)
		{
			entities = Roblox.Message.GetUserMessagesReceivedPagedAndSorted(recipientId, Roblox.Message.MessagesReceivedFilter.Unarchived_ExcludeInvitations, "Created [DESC]", startIndex, pageSize);
		}
		else if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.ArchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.UserOnly)
		{
			entities = Roblox.Message.GetUserMessagesReceivedPagedAndSorted(recipientId, Roblox.Message.MessagesReceivedFilter.Archived_ExcludeInvitationsAndSystem, "Created [DESC]", startIndex, pageSize);
		}
		else
		{
			if (filterSet.ArchiveFilter != MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly || filterSet.ReadFilter != MessageQueryFilterSet.ReadQueryFilter.UnreadOnly || filterSet.InvitationFilter != MessageQueryFilterSet.InvitationQueryFilter.NoInvitations || filterSet.SystemMessageFilter != MessageQueryFilterSet.SystemMessageQueryFilter.Both)
			{
				throw new ArgumentException("MessageQueryFilterSet no supported");
			}
			entities = Roblox.Message.GetUserMessagesReceivedPagedAndSorted(recipientId, Roblox.Message.MessagesReceivedFilter.Unread_Unarchived_ExcludeInvitations, "Created [DESC]", startIndex, pageSize);
		}
		return entities.Select(ConvertSclMessageToPlatformMessage).ToArray();
	}

	/// <summary>
	/// Gets the number of messages authored by the user with the given user ID that match the given filter set.
	/// </summary>
	/// <param name="authorId">The user ID of the author.</param>
	/// <param name="filterSet">The filter set to match.</param>
	/// <returns>The number of messages authored by the user with the given user ID that match the given filter set.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is not supported.</exception>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is null.</exception>
	public int GetCountByAuthorId(long authorId, MessageQueryFilterSet filterSet)
	{
		if (filterSet == null)
		{
			throw new ArgumentNullException("filterSet");
		}
		if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.Both && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.Both && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.Both)
		{
			return Roblox.Message.GetTotalNumberOfSentMessages(authorId);
		}
		throw new ArgumentException("MessageQueryFilterSet not supported");
	}

	/// <summary>
	/// Gets the number of messages received by the user with the given user ID that match the given filter set.
	/// </summary>
	/// <param name="recipientId">The user ID of the recipient.</param>
	/// <param name="filterSet">The filter set to match.</param>
	/// <returns>The number of messages received by the user with the given user ID that match the given filter set.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is not supported.</exception>
	public int GetCountByRecipientId(long recipientId, MessageQueryFilterSet filterSet)
	{
		if (filterSet == null)
		{
			throw new ArgumentNullException("filterSet");
		}
		if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.Both && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.Both)
		{
			return Roblox.Message.GetTotalNumberOfUnarchivedMessages(recipientId);
		}
		if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.ArchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.Both && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.UserOnly)
		{
			return Roblox.Message.GetTotalNumberOfArchivedMessagesExcludingSystem(recipientId);
		}
		if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.UnreadOnly && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.Both && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.Both)
		{
			return Roblox.Message.GetTotalNumberOfUnreadUnarchivedMessages(recipientId);
		}
		throw new ArgumentException("MessageQueryFilterSet not supported");
	}

	/// <summary>
	/// Gets a message by its message ID.
	/// </summary>
	/// <param name="messageId">The message ID of the message to get.</param>
	/// <returns>The message with the given message ID, or null if none exists.</returns>
	public Message GetByMessageId(long messageId)
	{
		Roblox.Message entity = Roblox.Message.Get(messageId);
		if (entity == null)
		{
			return null;
		}
		return ConvertSclMessageToPlatformMessage(entity);
	}

	/// <summary>
	/// Gets a collection of messages by exclusiveStartId and maximumRows
	/// </summary>
	/// <param name="exclusiveStartId">ExclusiveStartId</param>
	/// <param name="maximumRows">MaximumRows</param>
	/// <returns></returns>
	public IEnumerable<Message> GetMessages(long exclusiveStartId, int maximumRows)
	{
		ICollection<Roblox.Message> entities = Roblox.Message.GetMessages(exclusiveStartId, maximumRows);
		if (entities == null)
		{
			return new List<Message>();
		}
		IEnumerable<Message> msg = entities.Where((Roblox.Message m) => m != null).Select(ConvertSclMessageToPlatformMessage);
		if (msg == null)
		{
			return new List<Message>();
		}
		return msg;
	}
}
