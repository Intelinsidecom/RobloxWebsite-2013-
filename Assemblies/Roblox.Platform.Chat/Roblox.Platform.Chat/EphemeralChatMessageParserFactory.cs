using System.Collections.Concurrent;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class EphemeralChatMessageParserFactory : IEphemeralChatMessageParserFactory
{
	private static readonly ConcurrentDictionary<ChatMessageType, IEphemeralChatMessageParser> _EphemeralChatMessageParserDictionary = new ConcurrentDictionary<ChatMessageType, IEphemeralChatMessageParser>();

	private static readonly ConcurrentDictionary<ChatMessageSourceType, IEphemeralChatMessageSourceParser> _EphemeralChatMessageSourceParserDictionary = new ConcurrentDictionary<ChatMessageSourceType, IEphemeralChatMessageSourceParser>();

	private static readonly ConcurrentDictionary<ChatMessageLinkType, IEphemeralLinkChatMessageParser> _EphemeralLinkChatMessageParserDictionary = new ConcurrentDictionary<ChatMessageLinkType, IEphemeralLinkChatMessageParser>();

	private static readonly ConcurrentDictionary<ChatMessageEventType, IEphemeralEventBasedChatMessageParser> _EphemeralEventBasedChatMessageParserDictionary = new ConcurrentDictionary<ChatMessageEventType, IEphemeralEventBasedChatMessageParser>();

	internal EphemeralChatMessageParserFactory(IInstantProvider instantProvider)
	{
		_EphemeralChatMessageSourceParserDictionary.TryAdd(ChatMessageSourceType.User, new EphemeralChatMessageUserSourceParser());
		_EphemeralLinkChatMessageParserDictionary.TryAdd(ChatMessageLinkType.GameLink, new EphemeralGameLinkChatMessageParser());
		_EphemeralEventBasedChatMessageParserDictionary.TryAdd(ChatMessageEventType.SetConversationUniverse, new EphemeralSetConversationUniverseEventBasedChatMessageParser());
		_EphemeralChatMessageParserDictionary.TryAdd(ChatMessageType.PlainText, new EphemeralPlainTextChatMessageParser(GetChatMessageSourceParser, instantProvider));
		_EphemeralChatMessageParserDictionary.TryAdd(ChatMessageType.Link, new EphemeralLinkChatMessageParser(GetChatMessageSourceParser, GetLinkChatMessageParser, instantProvider));
		_EphemeralChatMessageParserDictionary.TryAdd(ChatMessageType.EventBased, new EphemeralEventBasedChatMessageParser(GetChatMessageSourceParser, GetEventBasedChatMessageParser, instantProvider));
	}

	public IEphemeralChatMessageSourceParser GetChatMessageSourceParser(ChatMessageSourceType sourceType)
	{
		if (!_EphemeralChatMessageSourceParserDictionary.TryGetValue(sourceType, out var value))
		{
			return null;
		}
		return value;
	}

	public IEphemeralLinkChatMessageParser GetLinkChatMessageParser(ChatMessageLinkType linkType)
	{
		if (!_EphemeralLinkChatMessageParserDictionary.TryGetValue(linkType, out var value))
		{
			return null;
		}
		return value;
	}

	public IEphemeralEventBasedChatMessageParser GetEventBasedChatMessageParser(ChatMessageEventType eventType)
	{
		if (!_EphemeralEventBasedChatMessageParserDictionary.TryGetValue(eventType, out var value))
		{
			return null;
		}
		return value;
	}

	public IEphemeralChatMessageParser GetChatMessageParser(ChatMessageType chatMessageType)
	{
		if (!_EphemeralChatMessageParserDictionary.TryGetValue(chatMessageType, out var value))
		{
			return null;
		}
		return value;
	}
}
