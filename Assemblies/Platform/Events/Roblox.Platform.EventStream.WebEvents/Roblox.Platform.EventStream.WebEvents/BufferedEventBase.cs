using System;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Used to force people to pass in a BufferedEventStreamer and delayed event args construction if you want to use certain types of high-volume events.
/// Otherwise identical to a <see cref="T:Roblox.Platform.EventStream.WebEvents.EventBase" />.
/// </summary>
public abstract class BufferedEventBase : EventBase
{
	protected bool _IsEventIncludedInRollout;

	private BasicEventArgs _EventArgs;

	protected BufferedEventBase(BufferedEventStreamer streamer, string eventName, Func<BasicEventArgs> argsConstructor)
		: base(streamer, eventName, streamer.IsIncludedInRollout() ? argsConstructor() : new BasicEventArgs
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
