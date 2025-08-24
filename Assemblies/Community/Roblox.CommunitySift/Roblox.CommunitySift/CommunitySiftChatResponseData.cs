using Newtonsoft.Json;

namespace Roblox.CommunitySift;

/// <summary>
/// Response from the community sift chat endpoint
/// </summary>
internal class CommunitySiftChatResponseData : CommunitySiftResponseBaseData
{
	/// <summary>
	/// (Always present) Either the language from the input or the auto-detected language.
	/// </summary>
	[JsonProperty("language")]
	public string Language { get; set; }

	/// <summary>
	/// (May be omitted) Hashed version of the input text. Only returned if Response is false and the text is high risk (4 or higher).
	/// </summary>
	[JsonProperty("hashed")]
	public string Hashed { get; set; }

	/// <summary>
	/// (May be omitted) The msg_id from the input. Only returned if non-empty msg_id was in input.
	/// </summary>
	[JsonProperty("msg_id")]
	public string MessageId { get; set; }

	/// <summary>
	/// The text response from CommunitySift. Only valid if Response is false and the text is high risk (4 or higher).
	/// </summary>
	public override string Text
	{
		get
		{
			return Hashed;
		}
		set
		{
			Hashed = value;
		}
	}
}
