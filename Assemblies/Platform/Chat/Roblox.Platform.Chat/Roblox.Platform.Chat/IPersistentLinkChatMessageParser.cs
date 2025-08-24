using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal interface IPersistentLinkChatMessageParser
{
	List<KeyValuePair<string, AttributeValue>> GetLinkChatMessageAttributes(ILinkChatMessageEntity linkChatMessageEntity);

	ILinkChatMessageEntity GetLinkChatMessageEntityFromDictionary(Dictionary<string, AttributeValue> chatMessageAttributes);
}
