using Newtonsoft.Json;

namespace Roblox.CommunitySift;

internal class CommunitySiftChatNoContextRequestBody
{
	/// <summary>
	/// Optional. Your unique identifier for the player (ROBLOX UserId)
	/// </summary>
	[JsonProperty("user_id")]
	public string UserId { get; set; }

	/// <summary>
	/// Optional. Identifier of the ruleset to use, along with the topic-risks of text and our history of player, to determine the pass/fail result (See Administration -&gt; Rulesets)
	/// Example Value: 1
	/// </summary>
	[JsonProperty("rule_id")]
	public string RuleSet { get; set; }

	/// <summary>
	/// Optional. A past filtering result you want to provide for auditing purposes. 
	/// By adding a value here you are asking it to report on what has changed since this text was last filtered. 
	/// false = not filtered, true = was filtered previously
	/// </summary>
	[JsonProperty("filtered")]
	public bool Filtered { get; set; }

	/// <summary>
	/// Optional. Your message identifier. This is provided in case you need a way to associate responses with your messages independent of requestBase/response semantics
	/// length(msg_id) ≤ 255
	/// </summary>
	[JsonProperty("content_id")]
	public string MessageId { get; set; }

	/// <summary>
	/// Required. What the player would like to say
	/// </summary>
	[JsonProperty("text")]
	public string Text { get; set; }

	/// <summary>
	/// Optional. A friendly name for the user that will be used for display purposes. (ROBLOX Username)
	/// Helpful when using a numeric identifier in player field. We also accept user_display_name for backwards compatibility 
	/// </summary>
	[JsonProperty("user_display_name")]
	public string Username { get; set; }

	/// <summary>
	/// Optional. The server that the chat came from, if you want to identify it for searching/filtering.
	/// For our case, it's PlaceID / "web_chat" / "web_post" / "web_asset" / "web_pm"
	/// Reference: https://docs.google.com/document/d/1jHMlnHeGcvhyG5j_p067j1xw5bHZrwdJS7qJeifBUMk/edit#
	/// </summary>
	[JsonProperty("category")]
	public string Server { get; set; }

	/// <summary>
	/// Optional. The chat room that the chat came from, if you want to identify it for searching/filtering.
	/// For our case, it's GameInstanceId or ConversationId.
	/// In cases where this is not provided a "random" GUID should be delivered as per our 2016-09-15 conversations with them.
	/// </summary>
	[JsonProperty("subcategory")]
	public string Room { get; set; }

	/// <summary>
	/// Optional. Expected language of the text, if known, as a two letter ISO language code for a supported language
	/// Default Value: "*" (Language detection. Added 03/07/2016)
	/// Example Value: "en"
	/// </summary>
	[JsonProperty("language")]
	public string Language { get; set; }

	/// <summary>
	/// Convert this object to a JSON string representing the current object.
	/// </summary>
	/// <returns>JSON representation of the object.</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.None, new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore
		});
	}
}
