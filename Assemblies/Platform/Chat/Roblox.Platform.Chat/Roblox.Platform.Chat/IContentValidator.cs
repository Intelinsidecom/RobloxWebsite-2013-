namespace Roblox.Platform.Chat;

internal interface IContentValidator
{
	/// <summary>
	/// Validate the given text against the given set of participants.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="conversation"></param>
	/// <param name="contentType"></param>
	/// <param name="rawContent"></param>
	/// <param name="isRevalidation">are we re-checking existing text?</param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException"></exception>
	IMessageContentValidationResult Validate(IParticipant sender, IConversationWithParticipants conversation, ChatContentType contentType, string rawContent, bool isRevalidation = false);
}
