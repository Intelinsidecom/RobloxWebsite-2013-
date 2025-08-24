using Newtonsoft.Json;

namespace Roblox.CommunitySift;

internal class CommunitySiftUserNameRequestBody
{
	[JsonProperty("user_id")]
	public string UserId { get; set; }

	[JsonProperty("user_display_name")]
	public string UserName { get; set; }

	[JsonProperty("language")]
	public string Language { get; set; }

	[JsonProperty("primary_rule_id")]
	public string PrimaryRuleId { get; set; }

	[JsonProperty("secondary_rule_id")]
	public string SecondaryRuleId { get; set; }
}
