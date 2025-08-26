using Roblox.EventStream.WebEvents.EventArgs;
using System;
namespace Roblox.EventStream.WebEvents {
    public class GameCounterEventArgs : WebEventArgs

{
	public string CounterKey { get; set; }

	public long CounterValue { get; set; }

	public DateTime TimeStamp { get; set; }
}


}






