using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.DataModel;
using Roblox.Platform.Chat.Events;

namespace Roblox.Platform.Chat;

[DynamoDBTable("Roblox.Platform.Chat.PersistentChatEventMessage")]
internal class PersistentChatEventMessage : IChatEventMessage
{
	private readonly ChatEventMessageSourceWrapper _ChatEventMessageSourceWrapper;

	[DynamoDBHashKey(AttributeName = "Id")]
	public Guid UniqueId { get; set; }

	[DynamoDBProperty(AttributeName = "ConversationId")]
	public long ConversationId { get; set; }

	[DynamoDBProperty(AttributeName = "MessageType")]
	public ChatMessageType MessageType { get; set; }

	[DynamoDBProperty(AttributeName = "Sent", Converter = typeof(DateTimeConverter))]
	public DateTime Sent { get; set; }

	[DynamoDBProperty(AttributeName = "DecoratorsCsv", Converter = typeof(DecoratorsCsvConverter))]
	public HashSet<string> Decorators { get; set; }

	[DynamoDBProperty(AttributeName = "Content")]
	public string Over13Content { get; set; }

	[DynamoDBProperty(AttributeName = "LinkType", Converter = typeof(NullableEnumConverter<ChatMessageLinkType>))]
	public ChatMessageLinkType? ChatMessageLinkType { get; set; }

	[DynamoDBProperty(AttributeName = "GameLinkUniverseId")]
	public long? GameLinkUniverseId { get; set; }

	[DynamoDBProperty(AttributeName = "SenderTargetId")]
	public long SenderTargetId { get; set; }

	[DynamoDBProperty(AttributeName = "SenderType")]
	public ChatMessageSenderType SenderType { get; set; }

	[DynamoDBProperty(AttributeName = "EventType", Converter = typeof(NullableEnumConverter<ChatMessageEventType>))]
	public ChatMessageEventType? ChatMessageEventType { get; set; }

	public IChatEventMessageSource ChatEventMessageSource => _ChatEventMessageSourceWrapper;

	[DynamoDBProperty(AttributeName = "SetUniverseActorUserId")]
	public long? SetUniverseActorUserId { get; set; }

	[DynamoDBProperty(AttributeName = "SetUniverseId")]
	public long? SetUniverseId { get; set; }

	public string Under13Content { get; }

	public PersistentChatEventMessage()
	{
		_ChatEventMessageSourceWrapper = new ChatEventMessageSourceWrapper(() => (SenderType == ChatMessageSenderType.User) ? ChatMessageSourceType.User : ChatMessageSourceType.System, () => SenderTargetId);
	}
}
