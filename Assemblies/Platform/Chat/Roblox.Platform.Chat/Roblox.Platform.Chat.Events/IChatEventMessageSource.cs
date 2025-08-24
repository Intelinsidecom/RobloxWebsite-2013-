namespace Roblox.Platform.Chat.Events;

public interface IChatEventMessageSource
{
	ChatMessageSourceType SourceType { get; }

	long SourceUserId { get; }
}
