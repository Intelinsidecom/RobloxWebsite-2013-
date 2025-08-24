using System.Net;
using Newtonsoft.Json;

namespace Roblox.CommunitySift;

/// <summary>
/// Details on Fragments of text returned from calls that can span multiple paragraphs.
/// </summary>
public class CommunitySiftLongTextFragment
{
	/// <summary>
	/// (Always present) The risk level.
	/// </summary>
	[JsonProperty("risk_level")]
	public int RiskLevel { get; set; }

	/// <summary>
	/// (Always present) Whether the text passed the selected ruleset.
	/// </summary>
	[JsonProperty("response")]
	public bool Response { get; set; }

	/// <summary>
	/// (Always present) If the processing timed out.
	/// </summary>
	[JsonProperty("timeout")]
	public bool Timeout { get; set; }

	/// <summary>
	/// (May be omitted) Hashed version of the input text. Only returned if response is false and the text is high risk (4 or higher).
	/// </summary>
	[JsonProperty("hashed")]
	public string Hashed { get; set; }

	/// <summary>
	/// (Always present) The length of the fragment.
	/// </summary>
	[JsonProperty("fragment_length")]
	public int FragmentLength { get; set; }

	/// <summary>
	/// (Always present) The start of the fragment in the overall text.
	/// </summary>
	[JsonProperty("fragment_start")]
	public int FragmentStart { get; set; }

	/// <summary>
	/// (May be omitted) The topic risk levels identified for the text.
	/// </summary>
	[JsonProperty("topics")]
	public object Topics { get; set; }

	/// <summary>
	/// (May be omitted) Where hashes were placed in the text.
	/// </summary>
	[JsonProperty("hashes")]
	public object Hashes { get; set; }

	/// <summary>
	/// Status Code for Internal Use
	/// </summary>
	public HttpStatusCode StatusCode { get; set; }

	/// <summary>
	/// Custom Error Message for Internal Use
	/// </summary>
	public string ErrorMessage { get; set; }
}
