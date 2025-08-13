using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal interface IPersistentEventBasedChatMessageParser
{
	List<KeyValuePair<string, AttributeValue>> GetEventBasedChatMessageAttributes(IEventBasedChatMessageEntity eventBasedChatMessageEntity);

	IEventBasedChatMessageEntity GetEventBasedChatMessageEntityFromDictionary(Dictionary<string, AttributeValue> chatMessageAttributes);
}
