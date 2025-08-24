using System;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Used to force people to pass in a BufferedEventStreamer if you want to use certain types of high-volume events.
/// Otherwise identical to a <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventBase" />.
/// </summary>
public abstract class BufferedWebEventBase : WebEventBase
{
	protected BufferedWebEventBase(BufferedEventStreamer streamer, string eventName, Func<WebEventArgs> argsConstructor)
		: base(streamer, eventName, streamer.IsIncludedInRollout() ? argsConstructor() : new WebEventArgs
		{
			Target = EventTarget.BlankEvents
		})
	{
	}

	public override void Stream()
	{
		if (_Args.Target != EventTarget.BlankEvents)
		{
			base.Stream();
		}
	}
}
