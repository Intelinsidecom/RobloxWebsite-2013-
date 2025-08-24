using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class PersistentSetConversationUniverseEventBasedChatMessageParser : IPersistentEventBasedChatMessageParser
{
	protected const string _UniverseIdKey = "SetUniverseId";

	protected const string _ActorUserIdKey = "SetUniverseActorUserId";

	private readonly ILogger _Logger;

	public PersistentSetConversationUniverseEventBasedChatMessageParser(ILogger logger)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public List<KeyValuePair<string, AttributeValue>> GetEventBasedChatMessageAttributes(IEventBasedChatMessageEntity eventBasedChatMessageEntity)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (eventBasedChatMessageEntity == null)
		{
			throw new PlatformArgumentNullException("eventBasedChatMessageEntity");
		}
		if (!(eventBasedChatMessageEntity is ISetConversationUniverseEventBasedChatMessageEntity setConversationUniverseEventBasedChatMessageEntity))
		{
			throw new PlatformArgumentException($"EventBased Chat message parser cannot parse eventBased chat message with type: {eventBasedChatMessageEntity.ChatMessageEventType}");
		}
		return new List<KeyValuePair<string, AttributeValue>>
		{
			new KeyValuePair<string, AttributeValue>("SetUniverseActorUserId", new AttributeValue
			{
				N = setConversationUniverseEventBasedChatMessageEntity.ActorUserId.ToString()
			}),
			new KeyValuePair<string, AttributeValue>("SetUniverseId", new AttributeValue
			{
				N = setConversationUniverseEventBasedChatMessageEntity.UniverseId.ToString()
			})
		};
	}

	public IEventBasedChatMessageEntity GetEventBasedChatMessageEntityFromDictionary(Dictionary<string, AttributeValue> chatMessageAttributes)
	{
		if (chatMessageAttributes == null)
		{
			return null;
		}
		if (!chatMessageAttributes.TryGetValue("SetUniverseActorUserId", out var actorUserIdString) || !long.TryParse(actorUserIdString.N, out var actorUserId))
		{
			_Logger.Error($"The actorUserId could not be parsed from the chat message dictionary -> ActorUserId : {actorUserIdString}");
			return null;
		}
		if (!chatMessageAttributes.TryGetValue("SetUniverseId", out var universeIdString) || !long.TryParse(universeIdString.N, out var universeId))
		{
			_Logger.Error($"The universeId could not be parsed from the chat message dictionary -> UniverseId : {universeIdString}");
			return null;
		}
		return new SetConversationUniverseEventBasedChatMessageEntity
		{
			ActorUserId = actorUserId,
			UniverseId = universeId
		};
	}
}
