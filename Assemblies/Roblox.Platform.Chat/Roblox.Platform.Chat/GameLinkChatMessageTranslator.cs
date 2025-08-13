using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal class GameLinkChatMessageTranslator : ILinkChatMessageTranslator
{
	public ILinkChatMessage Translate(ILinkChatMessageEntity linkChatMessageEntity)
	{
		if (linkChatMessageEntity == null)
		{
			return null;
		}
		if (!(linkChatMessageEntity is IGameLinkChatMessageEntity gameLinkChatMessageEntity))
		{
			return null;
		}
		return new GameLinkChatMessage
		{
			UniverseId = gameLinkChatMessageEntity.UniverseId
		};
	}
}
