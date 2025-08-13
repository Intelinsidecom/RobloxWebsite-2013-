using Newtonsoft.Json;

namespace Roblox.CommunitySift;

internal class CommunitySiftDoubleChatRequestBody
{
	[JsonProperty("player")]
	public string UserId { get; set; }

	[JsonProperty("player_display_name")]
	public string UserName { get; set; }

	[JsonProperty("text")]
	public string Text { get; set; }

	[JsonProperty("server")]
	public string Server { get; set; }

	[JsonProperty("room")]
	public string Room { get; set; }

	[JsonProperty("primary_rule_id")]
	public string PrimaryRuleId { get; set; }

	[JsonProperty("secondary_rule_id")]
	public string SecondaryRuleId { get; set; }
}
