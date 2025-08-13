using System.ComponentModel;

namespace Roblox.Web.Code;

public enum AccountLocaleInitializerResponse
{
	[Description("Success")]
	Success,
	[Description("Null User")]
	NullUser,
	[Description("Invalid SupportedLocaleCode")]
	InvalidSupportedLocaleCode,
	[Description("User does not fall in rollout percentage")]
	FeatureNotEnableForUser,
	[Description("User is not allowed to make further requests because of flooding")]
	FeatureThrottledForUser
}
