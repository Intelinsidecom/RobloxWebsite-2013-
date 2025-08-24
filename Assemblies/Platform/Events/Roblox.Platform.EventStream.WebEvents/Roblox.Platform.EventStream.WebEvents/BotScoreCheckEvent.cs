using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class BotScoreCheckEvent : WebEventBase
{
	private const string _Name = "botScoreCheck";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.BotScoreCheckEvent" />  class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.IEventStreamer" /> used to stream the event.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.BasicEventArgs" /> containing event info.</param>
	/// <exception cref="!:PlatformArgumentException">Thrown if <paramref name="args" /> has invalid field.</exception>
	/// <exception cref="!:PlatformArgumentException">Thrown if <paramref name="args" /> has invalid context.</exception>
	public BotScoreCheckEvent(IEventStreamer streamer, BotScoreCheckEventArgs args)
		: base(streamer, "botScoreCheck", args)
	{
		if (!args.Score.HasValue)
		{
			throw new ArgumentException("args.Score is required");
		}
		AddEventArg("score", args.Score.ToString());
		AddEventArg("ctx", args.Context);
		AddEventArg("reason", args.Reason ?? "");
	}
}
