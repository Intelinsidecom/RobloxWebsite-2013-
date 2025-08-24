namespace Roblox.Platform.Chat;

/// <summary>
/// The result of an attempt to send a message
/// </summary>
public interface ISentMessageDetails
{
	/// <summary>
	/// If the message sending was successful, this is the message that was sent, otherwise null
	/// </summary>
	IChatMessage SentMessage { get; }

	/// <summary>
	/// Indicates if some recipients of the message will see it more strictly moderated than the
	/// sender of the message
	/// </summary>
	bool IsMoreStrictlyModeratedForSomeRecipients { get; }

	/// <summary>
	/// Enum to describe why sent message failed, Whether or not real time connection is available to send the message,
	/// Whether or not the message was allowed to be sent because it was moderated
	/// </summary>
	SentMessageFailureType SentMessageFailureType { get; }
}
