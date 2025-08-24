using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class FunCaptchaEvent : WebEventBase
{
	private const string _Name = "funCaptcha";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.FunCaptchaEvent" />  class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.IEventStreamer" /> used to stream the event.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.BasicEventArgs" /> containing event info.</param>
	/// <exception cref="!:PlatformArgumentException">Thrown if <paramref name="args" /> has invalid field.</exception>
	/// <exception cref="!:PlatformArgumentException">Thrown if <paramref name="args" /> has invalid context.</exception>
	public FunCaptchaEvent(IEventStreamer streamer, FunCaptchaEventArgs args)
		: base(streamer, "funCaptcha", args)
	{
		if (!args.Solved.HasValue)
		{
			throw new ArgumentException("args.Solved is required");
		}
		if (args.FunCaptchaSession == null)
		{
			throw new ArgumentException("args.FunCaptchaSession is required");
		}
		if (!args.Suppressed.HasValue)
		{
			throw new ArgumentException("args.Suppressed is required");
		}
		AddEventArg("solved", args.Solved.ToString());
		AddEventArg("ctx", args.Context);
		AddEventArg("score", args.Score.ToString() ?? "");
		AddEventArg("userIp", args.UserIp ?? "");
		AddEventArg("funCaptchaSession", args.FunCaptchaSession);
		AddEventArg("timeVerified", args.TimeVerified.ToString() ?? "");
		AddEventArg("attempted", args.Attempted.ToString() ?? "");
		AddEventArg("previouslyVerified", args.PreviouslyVerified.ToString() ?? "");
		AddEventArg("sessionTimedOut", args.SessionTimedOut.ToString() ?? "");
		AddEventArg("suppressed", args.Suppressed.ToString() ?? "");
		AddEventArg("suppressLimited", args.SuppressLimited.ToString() ?? "");
		AddEventArg("verificationTimeElapsed", args.VerificationTimeElapsed.ToString() ?? "");
		AddEventArg("verificationBlocked", args.VerificationBlocked.ToString());
	}
}
