using Newtonsoft.Json;

namespace Roblox.Platform.Moderation;

/// <summary>
/// A struct responsible for holding <see cref="T:Roblox.Platform.Moderation.SerializableQueueMetrics" />s for a particular locale.
/// IMPORTANT: Please do not update the JsonProperty on any field since it is being used by the frontend.
/// </summary>
public struct SerializableLocaleMetrics
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Moderation.SerializableQueueMetrics" /> for Abuse queue.
	/// </summary>
	[JsonProperty("abuses")]
	public SerializableQueueMetrics Abuses { get; set; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Moderation.SerializableQueueMetrics" /> for Image queue.
	/// </summary>
	[JsonProperty("images")]
	public SerializableQueueMetrics Images { get; set; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Moderation.SerializableQueueMetrics" /> for Video queue.
	/// </summary>
	[JsonProperty("videos")]
	public SerializableQueueMetrics Videos { get; set; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Moderation.SerializableQueueMetrics" /> for Audio queue.
	/// </summary>
	[JsonProperty("audios")]
	public SerializableQueueMetrics Audios { get; set; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Moderation.SerializableQueueMetrics" /> for Mesh queue.
	/// </summary>
	[JsonProperty("meshes")]
	public SerializableQueueMetrics Meshes { get; set; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Moderation.SerializableQueueMetrics" /> for Punishment queue.
	/// </summary>
	[JsonProperty("players")]
	public SerializableQueueMetrics Punishments { get; set; }
}
