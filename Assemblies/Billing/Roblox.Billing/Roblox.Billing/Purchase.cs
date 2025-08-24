using System.Collections.Generic;

namespace Roblox.Billing;

internal class Purchase : IPurchase
{
	public IEnumerable<IPurchaseProduct> PurchaseProducts { get; private set; }

	internal Purchase(IEnumerable<IPurchaseProduct> purchaseProducts)
	{
		PurchaseProducts = purchaseProducts;
	}
}
