using Roblox.Platform.EventStream.WebEvents.EventArgs;

namespace Roblox.Platform.EventStream.WebEvents.Events;

public class LoginFormEvent : WebEventBase
{
	private const string _Name = "loginFormEvent";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.Events.LoginFormEvent" /> class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.IEventStreamer" /> used to stream the event.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.EventArgs.LoginFormEventArgs" /> containing event info.</param>
	public LoginFormEvent(IEventStreamer streamer, LoginFormEventArgs args)
		: base(streamer, "loginFormEvent", args)
	{
		if (!string.IsNullOrWhiteSpace(args.Email))
		{
			AddEventArg("email", args.Email);
		}
		if (!string.IsNullOrWhiteSpace(args.Username))
		{
			AddEventArg("username", args.Username);
		}
		if (!string.IsNullOrWhiteSpace(args.Phone))
		{
			AddEventArg("phone", args.Phone);
		}
		AddEventArg("ctx", args.Context);
	}
}
