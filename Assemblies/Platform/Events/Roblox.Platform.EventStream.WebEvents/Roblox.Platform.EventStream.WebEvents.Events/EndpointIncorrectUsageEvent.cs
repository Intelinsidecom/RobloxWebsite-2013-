using System;
using Roblox.Platform.EventStream.WebEvents.EventArgs;

namespace Roblox.Platform.EventStream.WebEvents.Events;

public class EndpointIncorrectUsageEvent : WebEventBase
{
	private const string _Name = "endpointincorrectusage";

	public EndpointIncorrectUsageEvent(IEventStreamer streamer, EndpointIncorrectUsageEventArgs args)
		: base(streamer, "endpointincorrectusage", args)
	{
		if (string.IsNullOrWhiteSpace(args.EndpointName))
		{
			throw new ArgumentException("args.EndpointName is required");
		}
		AddEventArg("epn", args.EndpointName);
		if (!string.IsNullOrWhiteSpace(args.Report))
		{
			AddEventArg("report", args.Report);
		}
	}
}
