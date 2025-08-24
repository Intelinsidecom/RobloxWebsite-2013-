namespace Roblox.Platform.Chat;

internal interface IChatMessagePreProcessorFactory
{
	IChatMessagePreProcessor GetPreProcessor(ChatMessageType messagType, ChatMessageSourceType senderType);
}
