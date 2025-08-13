using System;
using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using Roblox.Time;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal class EphemeralEventBasedChatMessageParser : EphemeralChatMessageParserBase, IEphemeralChatMessageParser
{
	private const string _HashField_EventType = "EventType";

	private readonly IInstantProvider _InstantProvider;

	private readonly Func<ChatMessageEventType, IEphemeralEventBasedChatMessageParser> _EphemeralEventBasedChatMessageParserGetter;

	private readonly Func<ChatMessageSourceType, IEphemeralChatMessageSourceParser> _EphemeralChatMessageSourceParserGetter;

	internal EphemeralEventBasedChatMessageParser(Func<ChatMessageSourceType, IEphemeralChatMessageSourceParser> ephemeralChatMessageSourceParserGetter, Func<ChatMessageEventType, IEphemeralEventBasedChatMessageParser> ephemeralEventBasedChatMessageParserGetter, IInstantProvider instantProvider)
	{
		_InstantProvider = instantProvider ?? throw new PlatformArgumentNullException("instantProvider");
		_EphemeralEventBasedChatMessageParserGetter = ephemeralEventBasedChatMessageParserGetter ?? throw new PlatformArgumentNullException("ephemeralEventBasedChatMessageParserGetter");
		_EphemeralChatMessageSourceParserGetter = ephemeralChatMessageSourceParserGetter ?? throw new PlatformArgumentNullException("ephemeralChatMessageSourceParserGetter");
	}

	protected override IEphemeralChatMessageSourceParser GetEphemeralChatMessageSourceParser(ChatMessageSourceType sourceType)
	{
		return _EphemeralChatMessageSourceParserGetter(sourceType);
	}

	public HashEntry[] GetHashEntries(IChatMessageEntity message)
	{
		if (message == null)
		{
			return null;
		}
		if (!(message is IEventBasedChatMessageEntity eventChatMessageEntity))
		{
			return null;
		}
		IChatMessageSourceEntity chatMessageSourceEntity = eventChatMessageEntity.ChatMessageSourceEntity;
		if (chatMessageSourceEntity == null)
		{
			return null;
		}
		List<HashEntry> chatMessageHashEntries = GetChatMessageSourceHashEntries(chatMessageSourceEntity);
		if (chatMessageHashEntries == null)
		{
			return null;
		}
		ChatMessageEventType chatMessageEventType = eventChatMessageEntity.ChatMessageEventType;
		chatMessageHashEntries.Add(new HashEntry("EventType", (int)chatMessageEventType));
		IReadOnlyCollection<HashEntry> eventSpecificHashEntries = _EphemeralEventBasedChatMessageParserGetter(chatMessageEventType)?.GetEventBasedChatMessageHashEntries(eventChatMessageEntity);
		if (eventSpecificHashEntries != null)
		{
			chatMessageHashEntries.AddRange(eventSpecificHashEntries);
		}
		return chatMessageHashEntries.ToArray();
	}

	public IChatMessageEntity GetMessageFromHashEntries(HashEntry[] hashEntries)
	{
		if (hashEntries == null || hashEntries.Length == 0)
		{
			return null;
		}
		IChatMessageSourceEntity chatMessageSourceEntity = GetChatMessageSourceEntityFromHashEntries(hashEntries);
		if (chatMessageSourceEntity == null)
		{
			return null;
		}
		Dictionary<RedisValue, RedisValue> dictionary = hashEntries.ToDictionary();
		ChatMessageEventType chatMessageEventType = (ChatMessageEventType)0;
		if (dictionary.TryGetValue("EventType", out var chatMessageEventTypeValue))
		{
			chatMessageEventType = (ChatMessageEventType)(int)chatMessageEventTypeValue;
		}
		IEventBasedChatMessageEntity obj = _EphemeralEventBasedChatMessageParserGetter(chatMessageEventType)?.GetEventBasedChatMessageEntityFromHashEntries(hashEntries) ?? new EventBasedChatMessageEntity();
		obj.ChatMessageEventType = chatMessageEventType;
		obj.ChatMessageSourceEntity = chatMessageSourceEntity;
		return obj;
	}

	public IChatMessageEntity Translate(IRawChatMessage rawChatMessage)
	{
		if (rawChatMessage == null)
		{
			throw new PlatformArgumentNullException("rawChatMessage");
		}
		IRawChatMessageSource messageSource = rawChatMessage.MessageSource;
		if (messageSource == null)
		{
			throw new PlatformArgumentNullException("messageSource");
		}
		if (!(rawChatMessage is IRawEventBasedChatMessage rawEventBasedChatMessage))
		{
			throw new PlatformArgumentException($"rawChatMessage was not of type IRawEventBasedChatMessage -> MessageType : {rawChatMessage.MessageType}, classType : {rawChatMessage.GetType()}");
		}
		if (rawChatMessage.MessageType != ChatMessageType.EventBased)
		{
			throw new PlatformArgumentException($"ChatMessagType was not EventBasedChatMessage -> ChatMessageType : {rawChatMessage.MessageType}");
		}
		IChatMessageSourceEntity chatMessageSourceEntity = Translate(messageSource);
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentException("ChatMessageSourceEntity could not be created");
		}
		IEventBasedChatMessageEntity obj = _EphemeralEventBasedChatMessageParserGetter(rawEventBasedChatMessage.ChatMessageEventType)?.Translate(rawEventBasedChatMessage) ?? new EventBasedChatMessageEntity();
		obj.ChatMessageEventType = rawEventBasedChatMessage.ChatMessageEventType;
		obj.MessageType = rawEventBasedChatMessage.MessageType;
		obj.ChatMessageSourceEntity = chatMessageSourceEntity;
		obj.Sent = _InstantProvider.GetCurrentUtcInstant();
		obj.Decorators = new HashSet<string>(rawChatMessage.Decorators, StringComparer.OrdinalIgnoreCase);
		obj.UniqueId = Guid.NewGuid();
		return obj;
	}
}
