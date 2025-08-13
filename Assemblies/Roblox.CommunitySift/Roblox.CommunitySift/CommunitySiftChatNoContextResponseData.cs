using Newtonsoft.Json;

namespace Roblox.CommunitySift;

internal class CommunitySiftChatNoContextResponseData : CommunitySiftResponseBaseData
{
	/// <summary>
	/// (Always present) Either the language from the input or the auto-detected language.
	/// </summary>
	[JsonProperty("language")]
	public string Language { get; set; }

	/// <summary>
	/// (May be omitted) RedactedText version of the input text. Only returned if Response is false and the text is high risk (4 or higher).
	/// </summary>
	[JsonProperty("hashed")]
	public string RedactedText { get; set; }

	[JsonProperty("risk")]
	public int Risk { get; set; }
}
