using System;
using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using Roblox.Time;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

/// <summary>
/// Parser for Chat message type 'PlainText' that helps converting to and from -&gt; ephemeral entries to Plaintext message entity
/// </summary>
internal class EphemeralPlainTextChatMessageParser : EphemeralChatMessageParserBase, IEphemeralChatMessageParser
{
	private const string _HashField_Content = "Content";

	private const string _HashField_Under13Content = "Under13Content";

	private readonly IInstantProvider _InstantProvider;

	private readonly Func<ChatMessageSourceType, IEphemeralChatMessageSourceParser> _EphemeralChatMessageSourceParserGetter;

	internal EphemeralPlainTextChatMessageParser(Func<ChatMessageSourceType, IEphemeralChatMessageSourceParser> ephemeralChatMessageSourceParserGetter, IInstantProvider instantProvider)
	{
		_InstantProvider = instantProvider ?? throw new PlatformArgumentNullException("instantProvider");
		_EphemeralChatMessageSourceParserGetter = ephemeralChatMessageSourceParserGetter ?? throw new PlatformArgumentNullException("ephemeralChatMessageSourceParserGetter");
	}

	protected override IEphemeralChatMessageSourceParser GetEphemeralChatMessageSourceParser(ChatMessageSourceType sourceType)
	{
		return _EphemeralChatMessageSourceParserGetter(sourceType);
	}

	public HashEntry[] GetHashEntries(IChatMessageEntity message)
	{
		if (!(message is IPlainTextMessageEntity plainTextMessage))
		{
			return null;
		}
		IChatMessageSourceEntity chatMessageSourceEntity = plainTextMessage.ChatMessageSourceEntity;
		if (chatMessageSourceEntity == null)
		{
			return null;
		}
		List<HashEntry> chatMessageSourceEntries = GetChatMessageSourceHashEntries(chatMessageSourceEntity);
		if (chatMessageSourceEntries == null)
		{
			return null;
		}
		chatMessageSourceEntries.Add(new HashEntry("Content", plainTextMessage.Over13Content));
		chatMessageSourceEntries.Add(new HashEntry("Under13Content", plainTextMessage.Under13Content ?? string.Empty));
		return chatMessageSourceEntries.ToArray();
	}

	public IChatMessageEntity GetMessageFromHashEntries(HashEntry[] hashEntries)
	{
		if (hashEntries == null || hashEntries.Length == 0)
		{
			return null;
		}
		Dictionary<RedisValue, RedisValue> dictionary = hashEntries.ToDictionary();
		string content = null;
		if (dictionary.TryGetValue("Content", out var contentValue))
		{
			content = contentValue;
		}
		string under13Content = null;
		if (dictionary.TryGetValue("Under13Content", out var under13ContentValue))
		{
			under13Content = under13ContentValue;
		}
		IChatMessageSourceEntity chatMessageSourceEntity = GetChatMessageSourceEntityFromHashEntries(hashEntries);
		if (chatMessageSourceEntity == null)
		{
			return null;
		}
		return new PlainTextMessageEntity
		{
			ChatMessageSourceEntity = chatMessageSourceEntity,
			Over13Content = content,
			Under13Content = under13Content
		};
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
		if (!(rawChatMessage is IRawPlainTextMessage plaintextSendMessage))
		{
			throw new PlatformArgumentException($"rawChatMessage was not of type IRawPlainTextMessage -> MessageType : {rawChatMessage.MessageType}, classType : {rawChatMessage.GetType()}");
		}
		if (rawChatMessage.MessageType != ChatMessageType.PlainText)
		{
			throw new PlatformArgumentException($"ChatMessagType was not plainText -> ChatMessageType : {rawChatMessage.MessageType}");
		}
		IChatMessageSourceEntity chatMessageSourceEntity = Translate(messageSource);
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentException("ChatMessageSourceEntity could not be created");
		}
		return new PlainTextMessageEntity
		{
			MessageType = plaintextSendMessage.MessageType,
			Over13Content = plaintextSendMessage.Over13Content,
			ChatMessageSourceEntity = chatMessageSourceEntity,
			Sent = _InstantProvider.GetCurrentUtcInstant(),
			Under13Content = plaintextSendMessage.Under13Content,
			Decorators = new HashSet<string>(rawChatMessage.Decorators, StringComparer.OrdinalIgnoreCase),
			UniqueId = Guid.NewGuid()
		};
	}
}
