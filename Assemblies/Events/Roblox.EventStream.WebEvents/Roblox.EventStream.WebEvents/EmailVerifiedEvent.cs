using Roblox.EventStream.WebEvents.EventArgs;
namespace Roblox.EventStream.WebEvents {
    /// <summary>

/// Event triggered when a user completes the email verification flow
/// </summary>
public class EmailVerifiedEvent : WebEventBase
{
	private const string _Name = "emailVerified";

	/// <summary>
	/// Constructs a <see cref="T:Roblox.Platform.EventStream.WebEvents.EmailVerifiedEvent" /> with the given <see cref="T:Roblox.Platform.EventStream.IEventStreamer" /> and <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventArgs" />
	/// </summary>
	/// <param name="IEventStreamer">The streamer to send the event</param>
	/// <param name="eventArgs">The arguments for this event</param>
	public EmailVerifiedEvent(IEventStreamer IEventStreamer, WebEventArgs eventArgs)
		: base(IEventStreamer, "emailVerified", eventArgs)
	{
	}
}


}






