using Newtonsoft.Json;

namespace Roblox.CommunitySift;

/// <summary>
/// Response from the community sift Long Text endpoint
/// </summary>
internal class CommunitySiftLongTextResponseData : CommunitySiftResponseBaseData
{
	/// <summary>
	/// (Always present) List of any queues the text was escalated into
	/// </summary>
	[JsonProperty("escalations")]
	public object Escalations { get; set; }

	/// <summary>
	/// (Always present) Array of fragments of the text that fail the ruleset. Contains fragment start, length, list of hash positions in the fragment as well as topics.
	/// </summary>
	[JsonProperty("failing_fragments")]
	public CommunitySiftLongTextFragment[] FailingFragments { get; set; }

	/// <summary>
	/// (Always present) The general overall risk level identified for the entire text
	/// </summary>
	[JsonProperty("risk")]
	public bool Risk { get; set; }

	/// <summary>
	/// (Always present) Chat and moderation events for the user such as trust changes
	/// </summary>
	[JsonProperty("events")]
	public object Events { get; set; }

	/// <summary>
	/// (May be omitted) Hashed version of the input text. Only returned if Response is false and the text is high risk (4 or higher).
	/// </summary>
	[JsonProperty("hashed")]
	public string Hashed { get; set; }
}
