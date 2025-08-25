using System.Collections.Generic;

namespace Roblox.Platform.EventStream;

/// <summary>
/// Common interface for streaming events.
/// </summary>
public interface IEventStreamer
{
	/// <summary>
	/// Streams an event.
	/// </summary>
	/// <param name="target">The event's target.</param>
	/// <param name="eventType">The type of event.</param>
	/// <param name="eventParameters">Additional parameters for this event.</param>
	/// <param name="clientIp">The client ip that triggered this event.</param>
	/// <param name="isTrustedSource">Is the event source trusted?</param>
	/// <param name="partitionKey"></param>
	void StreamEvent(string target, string eventType, IReadOnlyCollection<KeyValuePair<string, string>> eventParameters, string clientIp, bool isTrustedSource, string partitionKey = null);
}
