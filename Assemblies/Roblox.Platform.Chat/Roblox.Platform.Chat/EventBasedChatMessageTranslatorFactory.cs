using System.Collections.Concurrent;

namespace Roblox.Platform.Chat;

internal class EventBasedChatMessageTranslatorFactory : IEventBasedChatMessageTranslatorFactory
{
	private readonly ConcurrentDictionary<ChatMessageEventType, IEventBasedChatMessageTranslator> _EventBasedChatMessageTranslatorDictionary = new ConcurrentDictionary<ChatMessageEventType, IEventBasedChatMessageTranslator>();

	public EventBasedChatMessageTranslatorFactory()
	{
		_EventBasedChatMessageTranslatorDictionary.TryAdd(ChatMessageEventType.SetConversationUniverse, new SetConversationUniverseEventBasedChatMessageTranslator());
	}

	public IEventBasedChatMessageTranslator GetTranslator(ChatMessageEventType eventType)
	{
		if (!_EventBasedChatMessageTranslatorDictionary.TryGetValue(eventType, out var value))
		{
			return null;
		}
		return value;
	}
}
