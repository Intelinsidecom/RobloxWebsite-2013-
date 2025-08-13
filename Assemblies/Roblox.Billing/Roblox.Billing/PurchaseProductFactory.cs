using System;

namespace Roblox.Billing;

public class PurchaseProductFactory
{
	public static readonly PurchaseProductFactory Singleton = new PurchaseProductFactory();

	public static event Action<int, int> ProductPriceNotFoundForProduct;

	public static void RaiseProductPriceNotFoundForProduct(int productId, int countryCurrencyId)
	{
		if (PurchaseProductFactory.ProductPriceNotFoundForProduct != null)
		{
			PurchaseProductFactory.ProductPriceNotFoundForProduct(productId, countryCurrencyId);
		}
	}

	private PurchaseProductFactory()
	{
	}

	public IPurchaseProduct GetPurchaseProduct(IProduct product)
	{
		return new PurchaseProduct(product);
	}

	public IPurchaseProduct GetPurchaseProduct(IProduct product, int quantity, decimal discountedPrice)
	{
		return new PurchaseProduct(product, quantity, discountedPrice);
	}

	public IPurchaseProduct GetPurchaseProduct(IProduct product, int quantity, PaymentProviderType paymentProviderType, CountryCurrency countryCurrency)
	{
		return new PurchaseProduct(product, quantity, paymentProviderType, countryCurrency);
	}
}
