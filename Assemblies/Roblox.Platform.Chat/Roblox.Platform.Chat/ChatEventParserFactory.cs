using System.Collections.Concurrent;
using Roblox.EventLog;
using Roblox.Platform.Chat.Events;

namespace Roblox.Platform.Chat;

internal class ChatEventParserFactory : IChatEventParserFactory
{
	private static readonly ConcurrentDictionary<ChatMessageType, IChatEventParser> _ChatEventChatMessageParserDictionary = new ConcurrentDictionary<ChatMessageType, IChatEventParser>();

	private static readonly ConcurrentDictionary<ChatMessageEventType, IChatEventParser> _EventBasedChatMessageChatEventParserDictionary = new ConcurrentDictionary<ChatMessageEventType, IChatEventParser>();

	private static readonly ConcurrentDictionary<ChatMessageLinkType, IChatEventParser> _LinkChatEventParserDictionary = new ConcurrentDictionary<ChatMessageLinkType, IChatEventParser>();

	private static readonly ConcurrentDictionary<ChatMessageSourceType, IChatEventChatMessageSourceParser> _ChatEventChatMessageSourceParserDictionary = new ConcurrentDictionary<ChatMessageSourceType, IChatEventChatMessageSourceParser>();

	public ChatEventParserFactory(ILogger logger)
	{
		_ChatEventChatMessageSourceParserDictionary.TryAdd(ChatMessageSourceType.User, new ChatEventChatMessageUserSourceParser());
		_LinkChatEventParserDictionary.TryAdd(ChatMessageLinkType.GameLink, new GameLinkChatEventParser());
		_EventBasedChatMessageChatEventParserDictionary.TryAdd(ChatMessageEventType.SetConversationUniverse, new SetConversationUniverseEventBasedChatEventParser());
		_ChatEventChatMessageParserDictionary.TryAdd(ChatMessageType.PlainText, new PlainTextChatEventParser(GetChatMessageSourceParser, logger));
		_ChatEventChatMessageParserDictionary.TryAdd(ChatMessageType.Link, new LinkChatEventParser(GetChatMessageSourceParser, GetLinkChatMessageParser, logger));
		_ChatEventChatMessageParserDictionary.TryAdd(ChatMessageType.EventBased, new EventBasedChatEventParser(GetChatMessageSourceParser, GetEventBasedChatMessageParser, logger));
	}

	private IChatEventParser GetEventBasedChatMessageParser(ChatMessageEventType chatMessageEventType)
	{
		if (!_EventBasedChatMessageChatEventParserDictionary.TryGetValue(chatMessageEventType, out var value))
		{
			return null;
		}
		return value;
	}

	private IChatEventParser GetLinkChatMessageParser(ChatMessageLinkType chatMessageLinkType)
	{
		if (!_LinkChatEventParserDictionary.TryGetValue(chatMessageLinkType, out var value))
		{
			return null;
		}
		return value;
	}

	private IChatEventChatMessageSourceParser GetChatMessageSourceParser(ChatMessageSourceType chatMessageSourceType)
	{
		if (!_ChatEventChatMessageSourceParserDictionary.TryGetValue(chatMessageSourceType, out var value))
		{
			return null;
		}
		return value;
	}

	public IChatEventParser GetChatMessageParser(ChatMessageType chatMessageType)
	{
		if (!_ChatEventChatMessageParserDictionary.TryGetValue(chatMessageType, out var value))
		{
			return null;
		}
		return value;
	}
}
