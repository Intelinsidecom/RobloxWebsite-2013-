namespace Roblox.Platform.Chat;

internal interface IChatMessagePostProcessorFactory
{
	IChatMessagePostProcessor GetPostProcessor(ChatMessageType messagType, ChatMessageSourceType sourceType);
}
