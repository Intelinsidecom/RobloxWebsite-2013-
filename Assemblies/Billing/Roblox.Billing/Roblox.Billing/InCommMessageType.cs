using System.ComponentModel;

namespace Roblox.Billing;

internal enum InCommMessageType
{
	[Description("StatInq")]
	BalanceInquiry,
	[Description("Redeem")]
	PurchaseRequest,
	[Description("Reverse")]
	ReversalRequest
}
