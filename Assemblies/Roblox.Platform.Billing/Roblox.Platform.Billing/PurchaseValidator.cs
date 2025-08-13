using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Platform.Membership;
using Roblox.PremiumFeatures;

namespace Roblox.Platform.Billing;

/// <summary>
/// Perform validation while user making purchase
/// </summary>
public class PurchaseValidator : IPurchaseValidator
{
	public bool DeserveFirstTimeBcAward(IUser purchaser, IEnumerable<int> productIds)
	{
		if (purchaser == null || productIds == null)
		{
			return false;
		}
		bool num = productIds.Any((int id) => Product.Get(id).ProductGroupID == ProductGroup.BC.ID);
		bool isBcBefore = AccountAddOn.GetBuildersClubMembershipAccountAddOn(purchaser.AccountId) != null;
		if (num)
		{
			return !isBcBefore;
		}
		return false;
	}
}
