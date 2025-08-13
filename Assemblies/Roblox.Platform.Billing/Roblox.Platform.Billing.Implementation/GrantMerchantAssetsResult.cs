using System.Collections.Generic;
using Roblox.Platform.Billing.Interface;

namespace Roblox.Platform.Billing.Implementation;

public class GrantMerchantAssetsResult : IGrantMerchantAssetsResult, IFailableResult<CreditRedemptionFailureReason>
{
	public CreditRedemptionFailureReason FailureReason { get; set; }

	public bool IsSuccess { get; set; }

	public IEnumerable<long> GrantedAssets { get; set; }
}
