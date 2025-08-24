using Newtonsoft.Json;

namespace Roblox.Platform.Moderation;

/// <summary>
/// A struct responsible for holding metrics for a particular 
/// moderation queue.
/// </summary>
public struct SerializableQueueMetrics
{
	/// <summary>
	/// The number of open tasks.
	/// </summary>
	[JsonProperty("unmoderatedCount")]
	public long UnmoderatedCount { get; set; }

	/// <summary>
	/// The number of active moderators.
	/// </summary>
	[JsonProperty("activeModerators")]
	public long ActiveAndRecentlyActiveModerators { get; set; }

	/// <summary>
	/// The oldest open task in the queue in minutes.
	/// </summary>
	[JsonProperty("oldestUnmoderated")]
	public int OldestUnmoderated { get; set; }
}
