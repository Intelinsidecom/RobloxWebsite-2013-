using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal interface IPersistentChatMessageSourceParser
{
	Dictionary<string, AttributeValue> GetChatMessageSourceAttributes(IChatMessageSourceEntity chatMessageSourceEntity);

	IChatMessageSourceEntity GetChatMessageSourceEntityFromDictionary(Dictionary<string, AttributeValue> chatMessageAttributes);
}
