using System.Collections.Generic;

namespace Roblox.Platform.Social;

/// <summary>
/// Provides common methods to access private message data.
/// </summary>
public interface IMessageDataAccessor
{
	/// <summary>
	/// Saves the given <see cref="T:Roblox.Platform.Social.Message" />.
	/// </summary>
	/// <param name="message">The <see cref="T:Roblox.Platform.Social.Message" /> to save.</param>
	void Save(Message message);

	/// <summary>
	/// Deletes the <see cref="T:Roblox.Platform.Social.Message" /> with the given ID.
	/// </summary>
	/// <param name="messageId">The ID of the <see cref="T:Roblox.Platform.Social.Message" /> to delete.</param>
	void Delete(long messageId);

	/// <summary>
	/// Gets all messages authored by the user with the given user ID that match the given filter set.
	/// </summary>
	/// <param name="authorId">The user ID of the author.</param>
	/// <param name="filterSet">The filter set to match.</param>
	/// <returns>All messages authored by the user with the given user ID that match the given filter set.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is not supported.</exception>
	IEnumerable<Message> GetByAuthorId(long authorId, MessageQueryFilterSet filterSet);

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
	IEnumerable<Message> GetByAuthorIdPaged(long authorId, MessageQueryFilterSet filterSet, int startIndex, int pageSize);

	/// <summary>
	/// Gets all messages received by the user with the given user ID that match the given filter set.
	/// </summary>
	/// <param name="recipientId">The user ID of the recipient.</param>
	/// <param name="filterSet">The filter set to match.</param>
	/// <returns>All messages received by the user with the given user ID that match the given filter set.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is not supported.</exception>
	IEnumerable<Message> GetByRecipientId(long recipientId, MessageQueryFilterSet filterSet);

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
	/// if the startIndex is negative, or the page size is less than one.</exception>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is null.</exception>
	IEnumerable<Message> GetByRecipientIdPaged(long recipientId, MessageQueryFilterSet filterSet, int startIndex, int pageSize);

	/// <summary>
	/// Gets the number of messages authored by the user with the given user ID that match the given filter set.
	/// </summary>
	/// <param name="authorId">The user ID of the author.</param>
	/// <param name="filterSet">The filter set to match.</param>
	/// <returns>The number of messages authored by the user with the given user ID that match the given filter set.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is not supported.</exception>
	int GetCountByAuthorId(long authorId, MessageQueryFilterSet filterSet);

	/// <summary>
	/// Gets the number of messages received by the user with the given user ID that match the given filter set.
	/// </summary>
	/// <param name="recipientId">The user ID of the recipient.</param>
	/// <param name="filterSet">The filter set to match.</param>
	/// <returns>The number of messages received by the user with the given user ID that match the given filter set.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the given <see cref="T:Roblox.Platform.Social.MessageQueryFilterSet" /> is not supported.</exception>
	int GetCountByRecipientId(long recipientId, MessageQueryFilterSet filterSet);

	/// <summary>
	/// Gets a message by its message ID.
	/// </summary>
	/// <param name="messageId">The message ID of the message to get.</param>
	/// <returns>The message with the given message ID, or null if none exists.</returns>
	Message GetByMessageId(long messageId);

	/// <summary>
	/// Gets a collection of messages by exclusiveStartId and maximumRows
	/// </summary>
	/// <param name="exclusiveStartId">ExclusiveStartId</param>
	/// <param name="maximumRows">MaximumRows</param>
	/// <returns></returns>
	IEnumerable<Message> GetMessages(long exclusiveStartId, int maximumRows);
}
