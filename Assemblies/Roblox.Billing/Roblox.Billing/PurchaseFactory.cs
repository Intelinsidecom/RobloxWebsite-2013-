using System;
using System.Collections.Generic;

namespace Roblox.Billing;

public class PurchaseFactory
{
	public static readonly PurchaseFactory Singleton = new PurchaseFactory();

	private PurchaseFactory()
	{
	}

	[Obsolete("Use overload instead")]
	public IPurchase GetPurchase(IProduct product)
	{
		ICollection<IProduct> products = new List<IProduct>();
		products.Add(product);
		return GetPurchase(products);
	}

	public IPurchase GetPurchase(IEnumerable<IProduct> products)
	{
		ICollection<IPurchaseProduct> purchaseProducts = new List<IPurchaseProduct>();
		foreach (IProduct product in products)
		{
			IPurchaseProduct purchaseProduct = PurchaseProductFactory.Singleton.GetPurchaseProduct(product);
			purchaseProducts.Add(purchaseProduct);
		}
		return GetPurchase(purchaseProducts);
	}

	public IPurchase GetPurchase(IProduct product, PaymentProviderType paymentProviderType, CountryCurrency countryCurrency)
	{
		ICollection<IProduct> products = new List<IProduct>();
		products.Add(product);
		return GetPurchase(products, paymentProviderType, countryCurrency);
	}

	public IPurchase GetPurchase(IEnumerable<IProduct> products, PaymentProviderType paymentProviderType, CountryCurrency countryCurrency)
	{
		ICollection<IPurchaseProduct> purchaseProducts = new List<IPurchaseProduct>();
		foreach (IProduct product in products)
		{
			IPurchaseProduct purchaseProduct = PurchaseProductFactory.Singleton.GetPurchaseProduct(product, 1, paymentProviderType, countryCurrency);
			purchaseProducts.Add(purchaseProduct);
		}
		return GetPurchase(purchaseProducts);
	}

	public IPurchase GetPurchase(IEnumerable<IPurchaseProduct> purchaseProducts)
	{
		return new Purchase(purchaseProducts);
	}
}
