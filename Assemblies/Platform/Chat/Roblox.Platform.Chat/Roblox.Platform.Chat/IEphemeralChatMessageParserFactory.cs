namespace Roblox.Platform.Chat;

/// <summary>
/// Factory to provide EphemeralChatMessageParsers
/// </summary>
internal interface IEphemeralChatMessageParserFactory
{
	/// <summary>
	/// Gets the ephemeral chat message parser for the provided message type
	/// </summary>
	/// <param name="chatMessageType"></param>
	/// <returns>Ephemeral parser for the specified chat message type</returns>
	IEphemeralChatMessageParser GetChatMessageParser(ChatMessageType chatMessageType);

	/// <summary>
	/// Gets the ephemeral chat message source parser for the provided chatMessage source type
	/// </summary>
	/// <param name="chatMessageSourceType"></param>
	/// <returns></returns>
	IEphemeralChatMessageSourceParser GetChatMessageSourceParser(ChatMessageSourceType chatMessageSourceType);

	/// <summary>
	/// Gets the epehemeral link chat message parser for the provided chat message link type
	/// </summary>
	/// <param name="chatMessageLinkType"></param>
	/// <returns></returns>
	IEphemeralLinkChatMessageParser GetLinkChatMessageParser(ChatMessageLinkType chatMessageLinkType);

	/// <summary>
	/// Gets the epehemral eventBased chat message parser for the provided chat message event type
	/// </summary>
	/// <param name="chatMessageEventType"></param>
	/// <returns></returns>
	IEphemeralEventBasedChatMessageParser GetEventBasedChatMessageParser(ChatMessageEventType chatMessageEventType);
}
