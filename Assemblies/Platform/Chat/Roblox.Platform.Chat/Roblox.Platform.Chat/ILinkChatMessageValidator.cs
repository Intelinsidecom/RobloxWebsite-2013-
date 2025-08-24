namespace Roblox.Platform.Chat;

internal interface ILinkChatMessageValidator
{
	IChatMessageValidationData ValidateLinkChatMessage(IRawLinkChatMessage rawLinkChatMessage);
}
