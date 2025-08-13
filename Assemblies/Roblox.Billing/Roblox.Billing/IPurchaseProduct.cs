namespace Roblox.Billing;

public interface IPurchaseProduct
{
	decimal DiscountedPrice { get; }

	IProduct Product { get; }

	int Quantity { get; }
}
