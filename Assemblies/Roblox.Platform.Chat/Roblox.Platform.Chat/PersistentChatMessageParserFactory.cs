using System.Collections.Concurrent;
using Roblox.EventLog;

namespace Roblox.Platform.Chat;

internal class PersistentChatMessageParserFactory : IPersistentChatMessageParserFactory
{
	private static readonly ConcurrentDictionary<ChatMessageType, IPersistentChatMessageParser> _PersistentChatMessageParserDictionary = new ConcurrentDictionary<ChatMessageType, IPersistentChatMessageParser>();

	private static readonly ConcurrentDictionary<ChatMessageSourceType, IPersistentChatMessageSourceParser> _PersistentChatMessageSourceParserDictionary = new ConcurrentDictionary<ChatMessageSourceType, IPersistentChatMessageSourceParser>();

	private static readonly ConcurrentDictionary<ChatMessageLinkType, IPersistentLinkChatMessageParser> _LinkPersistentChatMessageParserDictionary = new ConcurrentDictionary<ChatMessageLinkType, IPersistentLinkChatMessageParser>();

	private static readonly ConcurrentDictionary<ChatMessageEventType, IPersistentEventBasedChatMessageParser> _EventBasedPersistentChatMessageParserDictionary = new ConcurrentDictionary<ChatMessageEventType, IPersistentEventBasedChatMessageParser>();

	internal PersistentChatMessageParserFactory(ILogger logger)
	{
		_PersistentChatMessageSourceParserDictionary.TryAdd(ChatMessageSourceType.User, new PersistentChatMessageUserSourceParser(logger));
		_LinkPersistentChatMessageParserDictionary.TryAdd(ChatMessageLinkType.GameLink, new PersistentGameLinkChatMessageParser(logger));
		_EventBasedPersistentChatMessageParserDictionary.TryAdd(ChatMessageEventType.SetConversationUniverse, new PersistentSetConversationUniverseEventBasedChatMessageParser(logger));
		_PersistentChatMessageParserDictionary.TryAdd(ChatMessageType.PlainText, new PersistentPlainTextChatMessageParser(GetChatMessageSourceParser, logger));
		_PersistentChatMessageParserDictionary.TryAdd(ChatMessageType.Link, new PersistentLinkChatMessageParser(GetChatMessageSourceParser, GetLinkChatMessageParser, logger));
		_PersistentChatMessageParserDictionary.TryAdd(ChatMessageType.EventBased, new PersistentEventBasedChatMessageParser(GetChatMessageSourceParser, GetEventBasedChatMessageParser, logger));
	}

	public IPersistentChatMessageParser GetChatMessageParser(ChatMessageType type)
	{
		if (!_PersistentChatMessageParserDictionary.TryGetValue(type, out var value))
		{
			return null;
		}
		return value;
	}

	public IPersistentChatMessageSourceParser GetChatMessageSourceParser(ChatMessageSourceType type)
	{
		if (!_PersistentChatMessageSourceParserDictionary.TryGetValue(type, out var value))
		{
			return null;
		}
		return value;
	}

	public IPersistentLinkChatMessageParser GetLinkChatMessageParser(ChatMessageLinkType chatMessageLinkType)
	{
		if (!_LinkPersistentChatMessageParserDictionary.TryGetValue(chatMessageLinkType, out var value))
		{
			return null;
		}
		return value;
	}

	public IPersistentEventBasedChatMessageParser GetEventBasedChatMessageParser(ChatMessageEventType chatMessageEventType)
	{
		if (!_EventBasedPersistentChatMessageParserDictionary.TryGetValue(chatMessageEventType, out var value))
		{
			return null;
		}
		return value;
	}
}
