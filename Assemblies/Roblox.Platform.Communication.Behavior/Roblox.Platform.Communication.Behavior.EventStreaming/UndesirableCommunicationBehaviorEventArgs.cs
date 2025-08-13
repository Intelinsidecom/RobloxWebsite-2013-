using Roblox.Platform.EventStream.WebEvents;

namespace Roblox.Platform.Communication.Behavior.EventStreaming;

/// <summary>
/// EventArgs class to provide Additional information when sending an <see cref="T:Roblox.Platform.Communication.Behavior.EventStreaming.UndesirableCommunicationBehaviorEvent" /> event to the EventStream
/// </summary>
internal class UndesirableCommunicationBehaviorEventArgs : WebEventArgs
{
	public bool IsUnder13 { get; set; }

	public string Source { get; set; }

	public string Reasons { get; set; }

	public bool IsFullyModerated { get; set; }
}
