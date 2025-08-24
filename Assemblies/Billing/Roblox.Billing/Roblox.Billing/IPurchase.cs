using System.Collections.Generic;

namespace Roblox.Billing;

public interface IPurchase
{
	IEnumerable<IPurchaseProduct> PurchaseProducts { get; }
}
