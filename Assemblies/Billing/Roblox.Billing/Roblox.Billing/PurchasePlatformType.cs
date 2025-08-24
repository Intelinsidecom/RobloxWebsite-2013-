using System.ComponentModel;

namespace Roblox.Billing;

public enum PurchasePlatformType
{
	[Description("isIosApp")]
	IsIosApp,
	[Description("isAndroidApp")]
	IsAndroidApp,
	[Description("isAmazonApp")]
	IsAmazonApp,
	[Description("isXboxApp")]
	IsXboxApp,
	[Description("isUwpApp")]
	IsUwpApp,
	[Description("isDesktop")]
	IsDesktop
}
