namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an event for when a new user is signed up.
/// </summary>
public class UserCreatedEvent : WebEventBase
{
	private const string _Name = "userCreated";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.UserCreatedEvent" />  class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.EventStreamer" /> used to stream the event.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.BasicEventArgs" /> containing event info.</param>
	public UserCreatedEvent(IEventStreamer streamer, UserCreatedEventArgs args)
		: base(streamer, "userCreated", args)
	{
		AddEventArg("captcha", args.Captcha.ToString());
		AddEventArg("etag", args.ETagCountOverLimit.ToString());
		AddEventArg("ipf", args.IpAddressCountOverLimit.ToString());
		AddEventArg("ctx", args.Context);
		AddEventArg("username", args.Username);
		if (args.PlaceId.HasValue)
		{
			AddEventArg("pid", args.PlaceId.Value.ToString());
		}
		if (!string.IsNullOrWhiteSpace(args.VerificationMethod))
		{
			AddEventArg("vmethod", args.VerificationMethod);
		}
	}
}
