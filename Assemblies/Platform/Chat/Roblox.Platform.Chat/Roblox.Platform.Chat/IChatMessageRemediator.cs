using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

/// <summary>
/// Remediates to make and save relevant changes to the chat message entity itself
/// </summary>
internal interface IChatMessageRemediator
{
	/// <summary>
	/// Generates and saves the under13 version of the content of the message
	/// </summary>
	/// <param name="message">The PlainText message to generate the under13 content for</param>
	/// <param name="conversationId">ConversationId to which the message belongs to</param>
	/// <returns>The chat message entity with under13 content generated and stored in the db if necessary</returns>
	IChatMessageEntity AddUnder13VersionOfContent(IPlainTextMessageEntity message, long conversationId);
}
