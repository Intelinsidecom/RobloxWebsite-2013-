namespace Roblox.Platform.EventStream.WebEvents.Events;

public class ChatConversationUsageEvent : WebEventBase
{
	private const string _Name = "chatconversationusageevent";

	public ChatConversationUsageEvent(EventStreamer streamer, ChatConversationUsageEventArgs args)
		: base(streamer, "chatconversationusageevent", args)
	{
		AddEventArg("eventTime", args.EventTime.ToUniversalTime().ToString("o"));
		AddEventArg("ctx", args.Context);
		AddEventArg("cid", args.ConversationId.ToString());
		AddEventArg("puids", string.Join(",", args.ParticipantUserIds));
	}
}
