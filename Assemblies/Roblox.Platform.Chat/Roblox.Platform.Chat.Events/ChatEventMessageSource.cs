using Newtonsoft.Json;

namespace Roblox.Platform.Chat.Events;

public class ChatEventMessageSource : IChatEventMessageSource
{
	public ChatMessageSourceType SourceType { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public long SourceUserId { get; set; }
}
