namespace Roblox.Platform.Chat;

internal interface IRawChatMessageUserSource : IRawChatMessageSource
{
	long SourceUserId { get; set; }
}
