using System;

namespace Roblox.Platform.Social;

/// <summary>
/// Represents a private message that can be sent between users.
/// </summary>
public class Message
{
	/// <summary>
	/// Gets or sets the message's unique ID.
	/// </summary>
	public long Id { get; set; }

	/// <summary>
	/// Gets or sets the ID of the message's MessageType.
	/// </summary>
	public int MessageTypeId { get; set; }

	/// <summary>
	/// Gets or sets the message's body.
	/// </summary>
	public string Body { get; set; }

	/// <summary>
	/// Gets or sets the message's subject.
	/// </summary>
	public string Subject { get; set; }

	/// <summary>
	/// Gets or sets the ID of the message's author.
	/// </summary>
	public long AuthorId { get; set; }

	/// <summary>
	/// Gets or sets the ID of the message's recipient.
	/// </summary>
	public long RecipientId { get; set; }

	/// <summary>
	/// Gets or sets whether or not the message has been read by the recipient.
	/// </summary>
	public bool IsRead { get; set; }

	/// <summary>
	/// Gets or sets whether or not the message has been archived.
	/// </summary>
	public bool IsArchived { get; set; }

	/// <summary>
	/// Gets or sets whether or not the message is a broadcast message.
	/// </summary>
	public bool IsBroadcastMessage { get; set; }

	/// <summary>
	/// Gets or sets whether or not the message is a system message.
	/// </summary>
	public bool IsSystemMessage { get; set; }

	/// <summary>
	/// Gets or sets the DateTime at which the message was created.
	/// </summary>
	public DateTime Created { get; set; }

	/// <summary>
	/// Gets or sets the DateTime at which the message was last updated.
	/// </summary>
	public DateTime Updated { get; set; }
}
