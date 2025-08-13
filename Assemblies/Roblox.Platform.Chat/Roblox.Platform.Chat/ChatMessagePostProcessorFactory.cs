using System;
using System.Collections.Concurrent;

namespace Roblox.Platform.Chat;

internal class ChatMessagePostProcessorFactory : IChatMessagePostProcessorFactory
{
	private static readonly ConcurrentDictionary<Tuple<ChatMessageType, ChatMessageSourceType>, IChatMessagePostProcessor> _ChatMessagePostProcessorDictionary = new ConcurrentDictionary<Tuple<ChatMessageType, ChatMessageSourceType>, IChatMessagePostProcessor>();

	public ChatMessagePostProcessorFactory(IChatMessageRemediator chatMessageRemediator)
	{
		Tuple<ChatMessageType, ChatMessageSourceType> plainTextMessageByUserKey = new Tuple<ChatMessageType, ChatMessageSourceType>(ChatMessageType.PlainText, ChatMessageSourceType.User);
		PlainTextMessageByUserPostProcessor plainTextMessageByUserPostProcessor = new PlainTextMessageByUserPostProcessor(chatMessageRemediator);
		_ChatMessagePostProcessorDictionary.TryAdd(plainTextMessageByUserKey, plainTextMessageByUserPostProcessor);
		Tuple<ChatMessageType, ChatMessageSourceType> linkChatMessageByUserKey = new Tuple<ChatMessageType, ChatMessageSourceType>(ChatMessageType.Link, ChatMessageSourceType.User);
		LinkChatMessageByUserPostProcessor linkChatMessageByUserPostProcessor = new LinkChatMessageByUserPostProcessor();
		_ChatMessagePostProcessorDictionary.TryAdd(linkChatMessageByUserKey, linkChatMessageByUserPostProcessor);
		Tuple<ChatMessageType, ChatMessageSourceType> eventBasedChatMessageBySystemKey = new Tuple<ChatMessageType, ChatMessageSourceType>(ChatMessageType.EventBased, ChatMessageSourceType.System);
		EventBasedChatMessageBySystemPostProcessor eventBasedChatMessageBySystemPostProcessor = new EventBasedChatMessageBySystemPostProcessor();
		_ChatMessagePostProcessorDictionary.TryAdd(eventBasedChatMessageBySystemKey, eventBasedChatMessageBySystemPostProcessor);
	}

	public IChatMessagePostProcessor GetPostProcessor(ChatMessageType messagType, ChatMessageSourceType sourceType)
	{
		Tuple<ChatMessageType, ChatMessageSourceType> key = new Tuple<ChatMessageType, ChatMessageSourceType>(messagType, sourceType);
		if (!_ChatMessagePostProcessorDictionary.TryGetValue(key, out var value))
		{
			return null;
		}
		return value;
	}
}
