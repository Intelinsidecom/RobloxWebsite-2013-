using Roblox.Platform.Chat.Exceptions;
using Roblox.Platform.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Chat;

internal class GameLinkChatMessageValidator : ILinkChatMessageValidator
{
	private readonly IUniverseFactory _UniverseFactory;

	public GameLinkChatMessageValidator(IUniverseFactory universeFactory)
	{
		_UniverseFactory = universeFactory ?? throw new PlatformArgumentNullException("universeFactory");
	}

	public IChatMessageValidationData ValidateLinkChatMessage(IRawLinkChatMessage rawLinkChatMessage)
	{
		if (rawLinkChatMessage == null)
		{
			throw new PlatformArgumentNullException("rawLinkChatMessage");
		}
		if (!(rawLinkChatMessage is IRawGameLinkChatMessage rawGameLinkChatMessage))
		{
			throw new PlatformArgumentException(string.Format("Link chat message of type : {0} could not be casted to {1}", rawLinkChatMessage.ChatMessageLinkType, "IRawGameLinkChatMessage"));
		}
		if (_UniverseFactory.GetUniverse(rawGameLinkChatMessage.UniverseId) == null)
		{
			throw new InvalidUniverseException($"Universe Id could not be associated with any universe, UniverseId : {rawGameLinkChatMessage.UniverseId}");
		}
		return new ChatMessageValidationData
		{
			IsAllowedToBeSent = true
		};
	}
}
