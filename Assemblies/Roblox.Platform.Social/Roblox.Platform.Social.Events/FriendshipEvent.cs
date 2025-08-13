using Roblox.Platform.EventStream;
using Roblox.Platform.EventStream.WebEvents;

namespace Roblox.Platform.Social.Events;

internal class FriendshipEvent : WebEventBase
{
	public FriendshipEvent(IEventStreamer streamer, string eventName, FriendshipEventArgs args)
		: base(streamer, eventName, args)
	{
		AddEventArg("senderId", args.SenderId.ToString());
		AddEventArg("recipientId", args.RecipientId.ToString());
		AddEventArg("fromInApp", args.FromInApp.ToString());
		AddEventArg("fromInGame", args.FromInGame.ToString());
		AddEventArg("ctx", args.Context);
	}
}
