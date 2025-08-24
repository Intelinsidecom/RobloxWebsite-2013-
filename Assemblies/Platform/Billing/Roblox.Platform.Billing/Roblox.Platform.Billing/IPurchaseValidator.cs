using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

public interface IPurchaseValidator
{
	/// <summary>
	/// Check If we should give the user BC award (100 ROBUX). It should be granted when a user first purchases BC membership
	/// </summary>
	/// <param name="purchaser">The user purchasing products</param>
	/// <param name="productIds">Product ids is the purchase</param>
	/// <returns>True if we should give the user BC award, otherwise return false</returns>
	bool DeserveFirstTimeBcAward(IUser purchaser, IEnumerable<int> productIds);
}
