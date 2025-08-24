namespace Roblox.Platform.Chat;

internal interface IPersistentChatMessageParserFactory
{
	/// <summary>
	/// Gets the chat message parser given the chat message type
	/// </summary>
	/// <param name="chatMessageType"></param>
	/// <returns></returns>
	IPersistentChatMessageParser GetChatMessageParser(ChatMessageType chatMessageType);

	/// <summary>
	/// Gets the chat message source parser for the given chat message source type
	/// </summary>
	/// <param name="chatMessageSourceType"></param>
	/// <returns></returns>
	IPersistentChatMessageSourceParser GetChatMessageSourceParser(ChatMessageSourceType chatMessageSourceType);

	/// <summary>
	/// Gets the Link chat message parser given the chat message link type
	/// </summary>
	/// <param name="chatMessageLinkType"></param>
	/// <returns></returns>
	IPersistentLinkChatMessageParser GetLinkChatMessageParser(ChatMessageLinkType chatMessageLinkType);

	/// <summary>
	/// Gets the eventBased chat message parser given the chat message event type
	/// </summary>
	/// <param name="chatMessageEventType"></param>
	/// <returns></returns>
	IPersistentEventBasedChatMessageParser GetEventBasedChatMessageParser(ChatMessageEventType chatMessageEventType);
}
