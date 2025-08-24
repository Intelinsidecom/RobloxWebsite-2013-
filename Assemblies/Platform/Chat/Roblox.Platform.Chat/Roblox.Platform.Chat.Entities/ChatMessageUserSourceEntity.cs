namespace Roblox.Platform.Chat.Entities;

internal class ChatMessageUserSourceEntity : IChatMessageUserSourceEntity, IChatMessageSourceEntity
{
	public long SourceUserId { get; set; }

	public ChatMessageSourceType SourceType { get; set; }
}
