namespace Roblox.Platform.Chat.Entities;

internal interface IGameLinkChatMessageEntity : ILinkChatMessageEntity, IChatMessageEntity
{
	long UniverseId { get; set; }
}
