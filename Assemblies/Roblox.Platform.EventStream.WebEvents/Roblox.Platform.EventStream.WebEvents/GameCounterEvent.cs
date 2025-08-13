using System;
using Roblox.Common;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an event reporting when a game counter has changed.
/// </summary>
public class GameCounterEvent : WebEventBase
{
	private const string _Name = "gameCounter";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.GameCounterEvent" /> class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.EventStreamer" />.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.BasicEventArgs" /> instance containing the event data.</param>
	/// <exception cref="!:PlatformArgumentNullException">
	/// <paramref name="streamer" />
	/// or
	/// <paramref name="args" />
	/// </exception>
	/// <exception cref="!:PlatformArgumentException">Thrown if the <see cref="P:Roblox.Platform.EventStream.WebEvents.GameCounterEventArgs.CounterKey" /> property of <paramref name="args" /> is null, or if the <see cref="P:Roblox.Platform.EventStream.WebEvents.BasicEventArgs.Target" /> property of <paramref name="args" /> is not supported.</exception>
	public GameCounterEvent(EventStreamer streamer, GameCounterEventArgs args)
		: base(streamer, "gameCounter", args)
	{
		if (args.CounterKey == null)
		{
			throw new ArgumentException("args.CounterKey cannot be null");
		}
		AddEventArg("counterKey", args.CounterKey);
		AddEventArg("counterValue", args.CounterValue.ToString());
		AddEventArg("timestamp", args.TimeStamp.ToUnixEpochTime().TotalMilliseconds.ToString());
	}
}
