using Newtonsoft.Json;

namespace Roblox.CommunitySift;

/// <summary>
/// CommunitySift Request Body
/// </summary>
internal class CommunitySiftLongTextRequestBody : CommunitySiftRequestBase
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
	/// Optional. Your message identifier. This is provided in case you need a way to associate responses with your messages independent of requestBase/response semantics
	/// </summary>
	[JsonProperty("content_id")]
	public string MessageId { get; set; }
}
