using Roblox.EventStream.WebEvents.EventArgs;
using System;
namespace Roblox.EventStream.WebEvents {
    public class ChatEventArgs : WebEventArgs

{
	public DateTime EventTime { get; set; }

	public string Context { get; set; }
}


}






