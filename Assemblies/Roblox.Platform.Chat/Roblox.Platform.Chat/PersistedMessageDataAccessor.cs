using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2.Model;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class PersistedMessageDataAccessor
{
	protected const string _ConversationIdKey = "ConversationId";

	protected const string _IdKey = "Id";

	protected const string _MessageTypeKey = "MessageType";

	protected const string _SentKey = "Sent";

	protected const string _SortOrderKey = "SortOrder";

	protected const string _DecoratorsKey = "DecoratorsCsv";

	private readonly ILogger _Logger;

	private readonly IPersistentChatMessageParserFactory _PersistentChatMessageParserFactory;

	private readonly IChatEventParserFactory _ChatEventParserFactory;

	public PersistedMessageDataAccessor(ILogger logger)
		: this(ChatMessageParserFactoryCreator.GetPersistentChatMessageParserFactory(logger), logger, ChatMessageParserFactoryCreator.GetChatEventParserFactory(logger))
	{
	}

	public PersistedMessageDataAccessor(IPersistentChatMessageParserFactory persistentChatMessageParserFactory, ILogger logger, IChatEventParserFactory chatEventParserFactory)
	{
		_PersistentChatMessageParserFactory = persistentChatMessageParserFactory ?? throw new ArgumentNullException("persistentChatMessageParserFactory");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_ChatEventParserFactory = chatEventParserFactory ?? throw new ArgumentNullException("chatEventParserFactory");
	}

	public Dictionary<string, AttributeValue> GetChatMessageAttributes(long conversationId, ChatEventMessage chatEventMessage)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		if (chatEventMessage == null)
		{
			return null;
		}
		IChatEventParser chatEventChatMessageParser = _ChatEventParserFactory.GetChatMessageParser(chatEventMessage.MessageType);
		if (chatEventChatMessageParser == null)
		{
			_Logger.Error($"Cannot get chatEvent chat message parser for messageType: {chatEventMessage.MessageType}");
			return null;
		}
		IPersistentChatMessageParser persistentChatMessageParser = _PersistentChatMessageParserFactory.GetChatMessageParser(chatEventMessage.MessageType);
		if (persistentChatMessageParser == null)
		{
			_Logger.Error($"Cannot get chat message persistent parser for messageType: {chatEventMessage.MessageType}");
			return null;
		}
		IChatMessageEntity chatMessageEntity = chatEventChatMessageParser.Translate(chatEventMessage);
		Dictionary<string, AttributeValue> chatMessageAttributes = persistentChatMessageParser.GetChatMessageAttributes(chatMessageEntity);
		if (chatMessageAttributes == null)
		{
			_Logger.Error($"Cannot get chat message attributes for messageType: {chatEventMessage.MessageType}");
			return null;
		}
		chatMessageAttributes.Add("ConversationId", new AttributeValue
		{
			N = conversationId.ToString()
		});
		chatMessageAttributes.Add("Id", new AttributeValue
		{
			S = chatMessageEntity.UniqueId.ToString()
		});
		chatMessageAttributes.Add("MessageType", new AttributeValue
		{
			N = ((int)chatMessageEntity.MessageType).ToString()
		});
		AddDecoratorsAttribute(chatMessageAttributes, chatMessageEntity);
		long sentAt = chatMessageEntity.Sent.Ticks;
		string sortOrder = GetSortOrder(chatMessageEntity.Sent.Ticks, chatMessageEntity.UniqueId);
		chatMessageAttributes.Add("Sent", new AttributeValue
		{
			N = sentAt.ToString()
		});
		chatMessageAttributes.Add("SortOrder", new AttributeValue
		{
			S = sortOrder
		});
		return chatMessageAttributes;
	}

	protected string GetSortOrder(long ticks, Guid id)
	{
		return ticks.ToString("D19") + "_" + id;
	}

	protected IReadOnlyCollection<IChatMessageEntity> GetChatMessageFromDictionary(IReadOnlyCollection<Dictionary<string, AttributeValue>> results)
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		List<IChatMessageEntity> chatMessages = new List<IChatMessageEntity>();
		if (results == null || results.Count == 0)
		{
			return chatMessages;
		}
		foreach (Dictionary<string, AttributeValue> result in results)
		{
			if (!result.TryGetValue("MessageType", out var messageTypeString) || !int.TryParse(messageTypeString.N, out var messageType))
			{
				_Logger.Error($"The message type could not be parsed from the chat message dictionary -> MessageType : {messageTypeString}");
				continue;
			}
			ChatMessageType chatMessageType = (ChatMessageType)messageType;
			IChatMessageEntity chatMessageEntity = _PersistentChatMessageParserFactory.GetChatMessageParser(chatMessageType)?.GetChatMessageFromDictionary(result);
			if (chatMessageEntity == null)
			{
				continue;
			}
			chatMessageEntity.MessageType = chatMessageType;
			if (!result.TryGetValue("Id", out var uniqueIdString) || !Guid.TryParse(uniqueIdString.S, out var uniqueId))
			{
				_Logger.Error($"The uniqueId could not be parsed from the chat message dictionary -> UniqueId : {uniqueIdString}");
				continue;
			}
			chatMessageEntity.UniqueId = uniqueId;
			if (!result.TryGetValue("Sent", out var sentAtString) || !long.TryParse(sentAtString.N, out var sentAtTicks))
			{
				_Logger.Error($"The sent ticks could not be parsed from the chat message dictionary -> Sent : {sentAtString}");
				continue;
			}
			chatMessageEntity.Sent = new UtcInstant(sentAtTicks);
			if (!result.TryGetValue("DecoratorsCsv", out var serializedDecorators))
			{
				serializedDecorators = new AttributeValue(string.Empty);
			}
			chatMessageEntity.Decorators = new HashSet<string>(serializedDecorators.S.Split(','), StringComparer.OrdinalIgnoreCase);
			chatMessages.Add(chatMessageEntity);
		}
		return chatMessages;
	}

	protected IChatMessageEntity Translate(IChatEventMessage chatEventMessage)
	{
		if (chatEventMessage != null)
		{
			return _ChatEventParserFactory.GetChatMessageParser(chatEventMessage.MessageType)?.Translate(chatEventMessage);
		}
		return null;
	}

	private void AddDecoratorsAttribute(Dictionary<string, AttributeValue> chatMessageAttributes, IChatMessageEntity chatMessageEntity)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		if (chatMessageEntity.Decorators == null || chatMessageEntity.Decorators.Count == 0)
		{
			return;
		}
		List<string> acceptedDecorators = new List<string>();
		string[] array = chatMessageEntity.Decorators.ToArray();
		foreach (string decorator in array)
		{
			if (!string.IsNullOrWhiteSpace(decorator))
			{
				acceptedDecorators.Add(decorator);
			}
		}
		if (acceptedDecorators.Any())
		{
			chatMessageAttributes.Add("DecoratorsCsv", new AttributeValue
			{
				S = string.Join(",", acceptedDecorators)
			});
		}
	}
}
