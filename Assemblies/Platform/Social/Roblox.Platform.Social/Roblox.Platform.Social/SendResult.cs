namespace Roblox.Platform.Social;

/// <summary>
/// Represents the result of a message send operation.
/// </summary>
public enum SendResult
{
	/// <summary>
	/// The message being replied to does not exist or was not sent to the user sending the reply.
	/// </summary>
	UnauthorizedReply,
	/// <summary>
	/// The sender has send too many messages and has reached the flood checker limit.
	/// </summary>
	SenderFlooded,
	/// <summary>
	/// The recipient has received too many messages and has reached the flood checker limit.
	/// </summary>
	RecipientFlooded,
	/// <summary>
	/// The body of the messages is too long.
	/// </summary>
	BodyTooLong,
	/// <summary>
	/// The body of the message is null or empty.
	/// </summary>
	BodyIsBlank,
	/// <summary>
	/// The subject of the message is null or empty.
	/// </summary>
	SubjectIsBlank,
	/// <summary>
	/// The sender is not logged in.
	/// </summary>
	Login,
	/// <summary>
	/// The recipient does not exist.
	/// </summary>
	BadRecipient,
	/// <summary>
	/// The sender does not exist.
	/// </summary>
	BadSender,
	/// <summary>
	/// The sender attempted to send the message to himself/herself.
	/// </summary>
	SentToSelf,
	/// <summary>
	/// The recipient's privacy settings are too high.
	/// </summary>
	RecipientPrivacySettingsTooHigh,
	/// <summary>
	/// The sender's privacy settings are too high.
	/// </summary>
	SenderPrivacySettingsTooHigh,
	/// <summary>
	/// The sender must verify his/her email.
	/// </summary>
	VerifySenderEmail,
	/// <summary>
	/// And unknown error occured.
	/// </summary>
	UnknownError,
	/// <summary>
	/// The message did not pass moderation.
	/// </summary>
	Moderated,
	/// <summary>
	/// The message was sent successfully.
	/// </summary>
	Success
}
