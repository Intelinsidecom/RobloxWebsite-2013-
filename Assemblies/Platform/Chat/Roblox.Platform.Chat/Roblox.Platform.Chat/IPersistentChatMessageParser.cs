using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal interface IPersistentChatMessageParser
{
	Dictionary<string, AttributeValue> GetChatMessageAttributes(IChatMessageEntity chatMessageEntity);

	IChatMessageEntity GetChatMessageFromDictionary(Dictionary<string, AttributeValue> chatMessageAttributes);
}
