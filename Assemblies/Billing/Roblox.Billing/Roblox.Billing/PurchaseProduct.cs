using System;
using Roblox.Billing.Business_Logic_Layer;

namespace Roblox.Billing;

internal class PurchaseProduct : IPurchaseProduct
{
	public decimal DiscountedPrice { get; private set; }

	public string CurrencyCode { get; private set; }

	public IProduct Product { get; private set; }

	public int Quantity { get; private set; }

	internal PurchaseProduct(IProduct product)
		: this(product, 1, product.Price)
	{
	}

	internal PurchaseProduct(IProduct product, int quantity, decimal discountedPrice, string currencyCode = "USD")
	{
		Product = product;
		Quantity = quantity;
		DiscountedPrice = discountedPrice;
		CurrencyCode = "USD";
	}

	internal PurchaseProduct(IProduct product, int quantity, PaymentProviderType paymentProviderType, CountryCurrency countryCurrency)
	{
		Product = product;
		Quantity = quantity;
		ProductPrice productPrice = ProductPrice.GetByProductPaymentProviderTypeIDAndCountryCurrencyID((ProductPaymentProviderType.GetByProductIDAndPaymentProviderTypeID(product.Id, paymentProviderType.ID) ?? throw new ApplicationException("Product " + Product.Name + " is not for sale by payment provider " + paymentProviderType.Value)).ID, countryCurrency.ID);
		if (productPrice == null)
		{
			PurchaseProductFactory.RaiseProductPriceNotFoundForProduct(Product.Id, countryCurrency.ID);
			DiscountedPrice = Product.Price;
			CurrencyCode = "USD";
		}
		else
		{
			CurrencyCode = CurrencyType.Get(countryCurrency.CurrencyTypeID).Code;
			DiscountedPrice = productPrice.Price;
		}
	}
}
