using System.Collections.Generic;

namespace Roblox.Platform.Billing.Interface;

/// <summary>
/// Grant asset for card redemption
/// </summary>
public interface IGrantMerchantAssetsResult : IFailableResult<CreditRedemptionFailureReason>
{
	/// <summary>
	/// Assets that we did successfully manage to grant
	/// </summary>
	IEnumerable<long> GrantedAssets { get; set; }
}
