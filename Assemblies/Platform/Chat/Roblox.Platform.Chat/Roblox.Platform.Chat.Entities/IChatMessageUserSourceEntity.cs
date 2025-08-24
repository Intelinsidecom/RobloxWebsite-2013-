namespace Roblox.Platform.Chat.Entities;

internal interface IChatMessageUserSourceEntity : IChatMessageSourceEntity
{
	long SourceUserId { get; set; }
}
