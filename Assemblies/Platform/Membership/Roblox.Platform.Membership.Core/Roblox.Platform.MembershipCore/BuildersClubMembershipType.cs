using System.ComponentModel;

namespace Roblox.Platform.MembershipCore;

public enum BuildersClubMembershipType
{
	[Description("No builders club membership.")]
	None,
	[Description("Minimum builders club membership.")]
	BC,
	[Description("Turbo builders club membership.")]
	TBC,
	[Description("Outrageous builders club membership.")]
	OBC,
	[Description("Roblox Premium membership.")]
	RobloxPremium
}
