using Newtonsoft.Json;

namespace Roblox.Platform.Moderation;

/// <summary>
/// An struct object that uniquely identify an open task in the task queue.
/// </summary>
public struct OpenTaskIdentifier
{
	/// <summary>
	/// The Sqs receipt handle associated with the task.
	/// </summary>
	[JsonProperty("receipt_handle")]
	public string ReceiptHandle { get; set; }

	/// <summary>
	/// The Sqs region name associated with the task.
	/// </summary>
	[JsonProperty("receipt_region_name")]
	public string ReceiptRegionName { get; set; }
}
