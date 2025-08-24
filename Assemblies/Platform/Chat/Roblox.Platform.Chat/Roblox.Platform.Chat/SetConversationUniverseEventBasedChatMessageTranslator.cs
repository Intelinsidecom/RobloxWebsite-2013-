using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal class SetConversationUniverseEventBasedChatMessageTranslator : IEventBasedChatMessageTranslator
{
	public IEventBasedChatMessage Translate(IEventBasedChatMessageEntity eventBasedChatMessageEntity)
	{
		if (eventBasedChatMessageEntity == null)
		{
			return null;
		}
		if (!(eventBasedChatMessageEntity is ISetConversationUniverseEventBasedChatMessageEntity setConversationUniverseEventBasedChatMessageEntity))
		{
			return null;
		}
		return new SetConversationUniverseEventBasedChatMessage
		{
			ActorUserId = setConversationUniverseEventBasedChatMessageEntity.ActorUserId,
			UniverseId = setConversationUniverseEventBasedChatMessageEntity.UniverseId
		};
	}
}
