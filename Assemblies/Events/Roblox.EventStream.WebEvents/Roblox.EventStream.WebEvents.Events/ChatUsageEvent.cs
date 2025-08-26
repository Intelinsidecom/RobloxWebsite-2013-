using Roblox.EventStream.WebEvents.EventArgs;
namespace Roblox.EventStream.WebEvents.Events {
    public class ChatUsageEvent : WebEventBase

{
	private const string _Name = "chatusageevent";

	public ChatUsageEvent(IEventStreamer streamer, ChatEventArgs args)
		: base(streamer, "chatusageevent", args)
	{
		AddEventArg("eventTime", args.EventTime.ToUniversalTime().ToString("o"));
		AddEventArg("ctx", args.Context);
	}
}


}






