namespace Roblox.Platform.Chat;

public class ChatMessageUserSource : IChatMessageUserSource, IChatMessageSource
{
	public long SourceUserId { get; set; }

	public ChatMessageSourceType SourceType { get; set; }
}
