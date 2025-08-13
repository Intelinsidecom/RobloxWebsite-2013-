namespace Roblox.Platform.Chat;

internal interface IChatMessagePreProcessor
{
	IRawChatMessage ValidateChatMessage(IRawChatMessage rawChatMessage, long conversationId, out IChatMessageValidationData validationResults);
}
