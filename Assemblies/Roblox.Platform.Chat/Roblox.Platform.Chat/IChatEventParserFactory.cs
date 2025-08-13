namespace Roblox.Platform.Chat;

internal interface IChatEventParserFactory
{
	IChatEventParser GetChatMessageParser(ChatMessageType chatMessageType);
}
