using Roblox.Platform.EventStream;
using Roblox.Platform.EventStream.WebEvents;

namespace Roblox.Platform.Communication.Behavior.EventStreaming;

internal class UndesirableCommunicationBehaviorEvent : WebEventBase
{
	private const string _Name = "undesirableCommunicationBehavior";

	/// <summary>
	/// The event that represents a user attempting to send a piece of communication that has been deemed undesirable.
	/// Allows publishing to the EventStream
	/// </summary>
	public UndesirableCommunicationBehaviorEvent(IEventStreamer streamer, UndesirableCommunicationBehaviorEventArgs eventArgs)
		: base(streamer, "undesirableCommunicationBehavior", eventArgs)
	{
		base.IsTrustedSource = true;
		AddEventArg("IsUnder13", eventArgs.IsUnder13.ToString());
		AddEventArg("Source", eventArgs.Source);
		AddEventArg("Reasons", eventArgs.Reasons);
		AddEventArg("IsFullyModerated", eventArgs.IsFullyModerated.ToString());
	}
}
