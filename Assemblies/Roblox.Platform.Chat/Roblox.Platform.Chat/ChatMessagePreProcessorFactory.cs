using System;
using System.Collections.Concurrent;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.Redis;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Chat;

internal class ChatMessagePreProcessorFactory : IChatMessagePreProcessorFactory
{
	private static readonly ConcurrentDictionary<Tuple<ChatMessageType, ChatMessageSourceType>, IChatMessagePreProcessor> _ChatMessagePreProcessorDictionary = new ConcurrentDictionary<Tuple<ChatMessageType, ChatMessageSourceType>, IChatMessagePreProcessor>();

	public ChatMessagePreProcessorFactory(ILogger logger, IRedisClient chatConversationRedisClient, IUniverseFactory universeFactory, Predicate<long> userHasConnectedToRealTimeRecentlyGetter, IUserFactory userFactory, ITextFilterClientV2 textFilterClientV2)
	{
		Tuple<ChatMessageType, ChatMessageSourceType> plainTextMessageByUserKey = new Tuple<ChatMessageType, ChatMessageSourceType>(ChatMessageType.PlainText, ChatMessageSourceType.User);
		PlainTextMessageByUserPreProcessor plainTextMessageByUserPreProcessor = new PlainTextMessageByUserPreProcessor(logger, chatConversationRedisClient, universeFactory, userHasConnectedToRealTimeRecentlyGetter, userFactory, textFilterClientV2);
		_ChatMessagePreProcessorDictionary.TryAdd(plainTextMessageByUserKey, plainTextMessageByUserPreProcessor);
		Tuple<ChatMessageType, ChatMessageSourceType> linkMessageByUserKey = new Tuple<ChatMessageType, ChatMessageSourceType>(ChatMessageType.Link, ChatMessageSourceType.User);
		LinkChatMessageByUserPreProcessor linkMessageByUserPreProcessor = new LinkChatMessageByUserPreProcessor(userFactory, universeFactory, logger, chatConversationRedisClient, userHasConnectedToRealTimeRecentlyGetter);
		_ChatMessagePreProcessorDictionary.TryAdd(linkMessageByUserKey, linkMessageByUserPreProcessor);
	}

	public IChatMessagePreProcessor GetPreProcessor(ChatMessageType messagType, ChatMessageSourceType sourceType)
	{
		Tuple<ChatMessageType, ChatMessageSourceType> key = new Tuple<ChatMessageType, ChatMessageSourceType>(messagType, sourceType);
		if (!_ChatMessagePreProcessorDictionary.TryGetValue(key, out var value))
		{
			return null;
		}
		return value;
	}
}
