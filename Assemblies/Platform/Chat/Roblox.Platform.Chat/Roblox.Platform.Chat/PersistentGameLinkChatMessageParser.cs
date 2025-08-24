using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class PersistentGameLinkChatMessageParser : IPersistentLinkChatMessageParser
{
	protected const string _UniverseIdKey = "GameLinkUniverseId";

	private readonly ILogger _Logger;

	public PersistentGameLinkChatMessageParser(ILogger logger)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public List<KeyValuePair<string, AttributeValue>> GetLinkChatMessageAttributes(ILinkChatMessageEntity linkChatMessageEntity)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		if (linkChatMessageEntity == null)
		{
			throw new PlatformArgumentNullException("linkChatMessageEntity");
		}
		if (!(linkChatMessageEntity is IGameLinkChatMessageEntity gameLinkChatMessageEntity))
		{
			throw new PlatformArgumentException($"Link Chat message parser cannot parse link chat message with type: {linkChatMessageEntity.ChatMessageLinkType}");
		}
		return new List<KeyValuePair<string, AttributeValue>>
		{
			new KeyValuePair<string, AttributeValue>("GameLinkUniverseId", new AttributeValue
			{
				N = gameLinkChatMessageEntity.UniverseId.ToString()
			})
		};
	}

	public ILinkChatMessageEntity GetLinkChatMessageEntityFromDictionary(Dictionary<string, AttributeValue> chatMessageAttributes)
	{
		if (chatMessageAttributes == null)
		{
			return null;
		}
		if (!chatMessageAttributes.TryGetValue("GameLinkUniverseId", out var universeIdString) || !long.TryParse(universeIdString.N, out var universeId))
		{
			_Logger.Error($"The universeId could not be parsed from the chat message dictionary -> UniverseId : {universeIdString}");
			return null;
		}
		return new GameLinkChatMessageEntity
		{
			UniverseId = universeId
		};
	}
}
