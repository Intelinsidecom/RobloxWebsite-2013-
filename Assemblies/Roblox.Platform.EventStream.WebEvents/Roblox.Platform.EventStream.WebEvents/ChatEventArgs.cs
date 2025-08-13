using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class ChatEventArgs : WebEventArgs
{
	public DateTime EventTime { get; set; }

	public string Context { get; set; }
}
