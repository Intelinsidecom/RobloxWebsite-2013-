using System;

namespace Roblox.Platform.EventStream.WebEvents.Events;

public class SupportedLocaleChangedByUserEvent : WebEventBase
{
	private const string _EventName = "supportedLocaleChanged";

	private const string _SupportedLocaleChangedTo = "newSupportedLocaleId";

	private const string _SupportedLocaleChangedFrom = "previousSupportedLocaleId";

	private const string _ActorId = "actorId";

	private const string _EventTime = "lt";

	public SupportedLocaleChangedByUserEvent(IEventStreamer streamer, SupportedLocaleChangedByUserEventArgs supportedLocaleChangedByUserEventArgs)
		: base(streamer, "supportedLocaleChanged", supportedLocaleChangedByUserEventArgs)
	{
		if (!supportedLocaleChangedByUserEventArgs.UserId.HasValue)
		{
			throw new ArgumentException(string.Format("{0}.UserId must be defined", "supportedLocaleChangedByUserEventArgs"));
		}
		AddEventArg("lt", supportedLocaleChangedByUserEventArgs.EventTime.ToString());
		if (supportedLocaleChangedByUserEventArgs.NewSupportedLocaleId.HasValue)
		{
			AddEventArg("newSupportedLocaleId", supportedLocaleChangedByUserEventArgs.NewSupportedLocaleId.ToString());
		}
		if (supportedLocaleChangedByUserEventArgs.PreviousSupportedLocaleId.HasValue)
		{
			AddEventArg("previousSupportedLocaleId", supportedLocaleChangedByUserEventArgs.PreviousSupportedLocaleId.Value.ToString());
		}
		AddEventArg("actorId", supportedLocaleChangedByUserEventArgs.ActorId.ToString());
	}
}
