namespace Roblox.Platform.Chat;

internal class RawChatMessageUserSource : IRawChatMessageUserSource, IRawChatMessageSource
{
	public ChatMessageSourceType SourceType { get; set; }

	public long SourceUserId { get; set; }
}
