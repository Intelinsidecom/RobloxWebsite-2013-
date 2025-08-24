using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Interface;

namespace Roblox.Billing.Implementation;

public class ProductPaymentProviderTypeFactory : IProductPaymentProviderTypeFactory
{
	public IProductPaymentProviderTypeModel CreateNew(int productId, byte paymentProviderTypeId)
	{
		ProductPaymentProviderType productPaymentProviderType = ProductPaymentProviderType.CreateNew(productId, paymentProviderTypeId);
		return EntityToModel(productPaymentProviderType);
	}

	public IProductPaymentProviderTypeModel Get(int id)
	{
		ProductPaymentProviderType productPaymentProviderType = ProductPaymentProviderType.Get(id);
		return EntityToModel(productPaymentProviderType);
	}

	public bool IsValidPaymentProviderType(int productId, int paymentProviderTypeId)
	{
		return ProductPaymentProviderType.IsValidPaymentProviderType(productId, paymentProviderTypeId);
	}

	public IProductPaymentProviderTypeModel GetByProductIDAndPaymentProviderTypeID(int productId, int paymentProviderTypeId)
	{
		ProductPaymentProviderType productPaymentProviderType = ProductPaymentProviderType.GetByProductIDAndPaymentProviderTypeID(productId, paymentProviderTypeId);
		return EntityToModel(productPaymentProviderType);
	}

	public ICollection<IProductPaymentProviderTypeModel> GetProductPaymentProviderTypesByPaymentProviderTypeID(byte paymentProviderTypeId)
	{
		return ProductPaymentProviderType.GetProductPaymentProviderTypesByPaymentProviderTypeID(paymentProviderTypeId).Select(EntityToModel).ToList();
	}

	public ICollection<IProductPaymentProviderTypeModel> GetProductPaymentProviderTypesByProductID(int productId)
	{
		return ProductPaymentProviderType.GetProductPaymentProviderTypesByProductID(productId).Select(EntityToModel).ToList();
	}

	private IProductPaymentProviderTypeModel EntityToModel(ProductPaymentProviderType productPaymentProviderType)
	{
		if (productPaymentProviderType != null)
		{
			return new ProductPaymentProviderTypeModel(productPaymentProviderType.ID, productPaymentProviderType.ProductID, productPaymentProviderType.PaymentProviderTypeID, productPaymentProviderType.Created, productPaymentProviderType.Updated);
		}
		return null;
	}
}
