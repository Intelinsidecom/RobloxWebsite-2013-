namespace Roblox.Platform.Chat;

public interface IChatMessageUserSource : IChatMessageSource
{
	long SourceUserId { get; set; }
}
