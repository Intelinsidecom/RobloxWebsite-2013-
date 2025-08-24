using Roblox.Platform.EventStream;
using Roblox.Platform.EventStream.WebEvents;

namespace Roblox.Platform.Social.Events;

internal class CaptchaActionEvent : WebEventBase
{
	public CaptchaActionEvent(IEventStreamer streamer, string eventName, CaptchaActionEventArgs args)
		: base(streamer, eventName, args)
	{
		AddEventArg("senderId", args.SenderId.ToString());
		AddEventArg("recipientId", args.RecipientId.ToString());
		AddEventArg("fromInApp", args.FromInApp.ToString());
		AddEventArg("fromInGame", args.FromInGame.ToString());
	}
}
