using Roblox.Billing.Interface;

namespace Roblox.Billing.Implementation;

public class ProductPriceFactory : IProductPriceFactory
{
	public IProductPriceModel CreateNew(int productPaymentProviderTypeId, int countryCurrencyId, decimal price, bool? isActive)
	{
		ProductPrice productPrice = ProductPrice.CreateNew(productPaymentProviderTypeId, countryCurrencyId, price, isActive);
		return EntityToModel(productPrice);
	}

	public IProductPriceModel Get(int id)
	{
		ProductPrice productPrice = ProductPrice.Get(id);
		return EntityToModel(productPrice);
	}

	public IProductPriceModel GetByProductPaymentProviderTypeIDAndCountryCurrencyID(int productPaymentProviderTypeID, int countryCurrencyID)
	{
		ProductPrice productPrice = ProductPrice.GetByProductPaymentProviderTypeIDAndCountryCurrencyID(productPaymentProviderTypeID, countryCurrencyID);
		return EntityToModel(productPrice);
	}

	public int GetTotalNumberOfProductPricesByProductPaymentProviderID(int productPaymentProviderTypeID)
	{
		return ProductPrice.GetTotalNumberOfProductPricesByProductPaymentProviderID(productPaymentProviderTypeID);
	}

	private IProductPriceModel EntityToModel(ProductPrice productPrice)
	{
		if (productPrice != null)
		{
			return new ProductPriceModel(productPrice.ID, productPrice.ProductPaymentProviderTypeID, productPrice.CountryCurrencyID, productPrice.Price, productPrice.Created, productPrice.Updated, productPrice.IsActive);
		}
		return null;
	}
}
