namespace Roblox.Platform.Chat;

internal interface IEventBasedChatMessageTranslatorFactory
{
	IEventBasedChatMessageTranslator GetTranslator(ChatMessageEventType eventType);
}
