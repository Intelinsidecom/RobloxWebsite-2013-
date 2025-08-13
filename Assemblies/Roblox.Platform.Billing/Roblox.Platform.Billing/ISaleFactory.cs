using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

public interface ISaleFactory : IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Billing.ISale" /> with the given ID.
	/// </summary>
	/// <param name="id">The ID of the <see cref="T:Roblox.Platform.Billing.ISale" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Billing.ISale" /> with the given ID, or null if none exists.</returns>
	ISale Get(int id);

	/// <summary>
	/// Gets the IDs of any sales that are up for renewal.
	/// </summary>
	/// <returns>The IDs of any sales that are up for renewal.</returns>
	IEnumerable<int> GetSaleIdsWhereUpForRenewal();
}
