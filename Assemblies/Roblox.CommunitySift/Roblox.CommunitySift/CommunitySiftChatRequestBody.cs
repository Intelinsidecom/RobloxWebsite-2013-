using Newtonsoft.Json;

namespace Roblox.CommunitySift;

/// <summary>
/// CommunitySift Request Body
/// </summary>
internal class CommunitySiftChatRequestBody : CommunitySiftRequestBase
{
	/// <summary>
	/// Optional. Your unique identifier for the player (ROBLOX UserId)
	/// </summary>
	[JsonProperty("player")]
	public long UserId { get; set; }

	/// <summary>
	/// Optional. Identifier of the ruleset to use, along with the topic-risks of text and our history of player, to determine the pass/fail result (See Administration -&gt; Rulesets)
	/// Example Value: 1
	/// </summary>
	[JsonProperty("rule")]
	public int RuleSet { get; set; }

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
	[JsonProperty("msg_id")]
	public string MessageId { get; set; }
}
