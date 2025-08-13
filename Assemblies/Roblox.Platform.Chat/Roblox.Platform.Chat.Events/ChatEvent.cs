using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roblox.Platform.Devices;

namespace Roblox.Platform.Chat.Events;

/// <summary>
/// Events triggered on conversation receiving messages, being read etc.
/// mainly to maintain consistency across multiple persistence stores for the chat conversation 
/// </summary>
internal class ChatEvent : IChatEvent
{
	public ChatEventType ChatEventType { get; set; }

	public long ConversationId { get; set; }

	public long? AffectedUserId { get; set; }

	public ChatEventMessage Message { get; set; }

	public ConversationsMissingInCache ConversationsMissingInCacheMessage { get; set; }

	/// <summary>
	/// The sender's platform type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public PlatformType? SenderPlatformType { get; set; }
}
