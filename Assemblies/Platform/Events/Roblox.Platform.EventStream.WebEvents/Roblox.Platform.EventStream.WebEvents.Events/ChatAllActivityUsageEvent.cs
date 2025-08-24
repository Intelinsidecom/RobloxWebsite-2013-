namespace Roblox.Platform.EventStream.WebEvents.Events;

public class ChatAllActivityUsageEvent : WebEventBase
{
	private const string _Name = "chatallactivityusageevent";

	public ChatAllActivityUsageEvent(EventStreamer streamer, ChatAllActivityUsageEventArgs args)
		: base(streamer, "chatallactivityusageevent", args)
	{
		AddEventArg("eventTime", args.EventTime.ToDateTime().ToUniversalTime().ToString("o"));
		AddEventArg("ctx", args.Context);
		AddEventArg("dt", args.DeviceType);
		AddEventArg("cid", args.ConversationId.ToString());
		AddEventArg("puids", string.Join(",", args.ParticipantUserIds));
	}
}
