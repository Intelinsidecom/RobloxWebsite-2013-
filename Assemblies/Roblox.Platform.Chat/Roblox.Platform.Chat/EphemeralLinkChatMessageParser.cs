using System;
using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using Roblox.Time;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal class EphemeralLinkChatMessageParser : EphemeralChatMessageParserBase, IEphemeralChatMessageParser
{
	private const string _HashField_LinkType = "LinkType";

	private readonly IInstantProvider _InstantProvider;

	private readonly Func<ChatMessageLinkType, IEphemeralLinkChatMessageParser> _EphemeralLinkChatMessageParserGetter;

	private readonly Func<ChatMessageSourceType, IEphemeralChatMessageSourceParser> _EphemeralChatMessageSourceParserGetter;

	internal EphemeralLinkChatMessageParser(Func<ChatMessageSourceType, IEphemeralChatMessageSourceParser> ephemeralChatMessageSourceParserGetter, Func<ChatMessageLinkType, IEphemeralLinkChatMessageParser> ephemeralLinkChatMessageParserGetter, IInstantProvider instantProvider)
	{
		_EphemeralLinkChatMessageParserGetter = ephemeralLinkChatMessageParserGetter ?? throw new PlatformArgumentNullException("instantProvider");
		_InstantProvider = instantProvider ?? throw new PlatformArgumentNullException("instantProvider");
		_EphemeralChatMessageSourceParserGetter = ephemeralChatMessageSourceParserGetter ?? throw new PlatformArgumentNullException("ephemeralChatMessageSourceParserGetter");
	}

	protected override IEphemeralChatMessageSourceParser GetEphemeralChatMessageSourceParser(ChatMessageSourceType sourceType)
	{
		return _EphemeralChatMessageSourceParserGetter(sourceType);
	}

	public HashEntry[] GetHashEntries(IChatMessageEntity message)
	{
		if (!(message is ILinkChatMessageEntity linkChatMessageEntity))
		{
			return null;
		}
		IChatMessageSourceEntity chatMessageSourceEntity = linkChatMessageEntity.ChatMessageSourceEntity;
		if (chatMessageSourceEntity == null)
		{
			return null;
		}
		List<HashEntry> chatMessageHashEntries = GetChatMessageSourceHashEntries(chatMessageSourceEntity);
		if (chatMessageHashEntries == null)
		{
			return null;
		}
		ChatMessageLinkType chatMessageLinkType = linkChatMessageEntity.ChatMessageLinkType;
		chatMessageHashEntries.Add(new HashEntry("LinkType", (int)chatMessageLinkType));
		List<HashEntry> linkChatMessageHashEntries = _EphemeralLinkChatMessageParserGetter(chatMessageLinkType)?.GetLinkChatMessageHashEntries(linkChatMessageEntity);
		if (linkChatMessageHashEntries != null)
		{
			chatMessageHashEntries.AddRange(linkChatMessageHashEntries);
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
		ChatMessageLinkType chatMessageLinkType = (ChatMessageLinkType)0;
		if (dictionary.TryGetValue("LinkType", out var chatMessageLinkTypeValue))
		{
			chatMessageLinkType = (ChatMessageLinkType)(int)chatMessageLinkTypeValue;
		}
		ILinkChatMessageEntity obj = _EphemeralLinkChatMessageParserGetter(chatMessageLinkType)?.GetLinkChatMessageFromHashEntries(hashEntries) ?? new LinkChatMessageEntity();
		obj.ChatMessageLinkType = chatMessageLinkType;
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
		if (!(rawChatMessage is IRawLinkChatMessage rawLinkChatMessage))
		{
			throw new PlatformArgumentException($"rawChatMessage was not of type IRawLinkChatMessage -> MessageType : {rawChatMessage.MessageType}, classType : {rawChatMessage.GetType()}");
		}
		if (rawChatMessage.MessageType != ChatMessageType.Link)
		{
			throw new PlatformArgumentException($"ChatMessagType was not LinkChatMessage -> ChatMessageType : {rawChatMessage.MessageType}");
		}
		IChatMessageSourceEntity chatMessageSourceEntity = Translate(messageSource);
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentException("ChatMessageSourceEntity could not be created");
		}
		ILinkChatMessageEntity obj = _EphemeralLinkChatMessageParserGetter(rawLinkChatMessage.ChatMessageLinkType)?.Translate(rawLinkChatMessage) ?? new LinkChatMessageEntity();
		obj.ChatMessageLinkType = rawLinkChatMessage.ChatMessageLinkType;
		obj.MessageType = rawLinkChatMessage.MessageType;
		obj.ChatMessageSourceEntity = chatMessageSourceEntity;
		obj.Sent = _InstantProvider.GetCurrentUtcInstant();
		obj.Decorators = new HashSet<string>(rawChatMessage.Decorators, StringComparer.OrdinalIgnoreCase);
		obj.UniqueId = Guid.NewGuid();
		return obj;
	}
}
