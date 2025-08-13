using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class GameCounterEventArgs : WebEventArgs
{
	public string CounterKey { get; set; }

	public long CounterValue { get; set; }

	public DateTime TimeStamp { get; set; }
}
