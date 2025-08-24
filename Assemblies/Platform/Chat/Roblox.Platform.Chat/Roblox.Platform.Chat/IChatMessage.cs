using System;
using System.Collections.Generic;
using Roblox.Time;

namespace Roblox.Platform.Chat;

/// <summary>
/// Represents an existing chat message
/// </summary>
public interface IChatMessage
{
	/// <summary>
	/// Unique identifier for the message
	/// </summary>
	Guid Id { get; set; }

	/// <summary>
	/// The type of message this is
	/// </summary>
	ChatMessageType MessageType { get; set; }

	/// <summary>
	/// The instant at which the message was sent
	/// </summary>
	UtcInstant Sent { get; set; }

	/// <summary>
	/// Whether or not the message has been read by the viewer requesting this message
	/// </summary>
	bool Read { get; set; }

	/// <summary>
	/// A list of decorators
	/// </summary>
	HashSet<string> Decorators { get; set; }

	/// <summary>
	/// The source who sent the message
	/// </summary>
	IChatMessageSource MessageSource { get; set; }
}
