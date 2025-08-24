using System.Collections.Generic;

namespace Roblox.Billing.Interface;

/// <summary>
/// This is the interface for a factory for <see cref="T:Roblox.Billing.Interface.IProductPaymentProviderTypeModel" /> so we can abstract away the entity implementation and to make this unit testable
/// </summary>
public interface IProductPaymentProviderTypeFactory
{
	IProductPaymentProviderTypeModel CreateNew(int productId, byte paymentProviderTypeId);

	IProductPaymentProviderTypeModel Get(int id);

	bool IsValidPaymentProviderType(int productId, int paymentProviderTypeId);

	IProductPaymentProviderTypeModel GetByProductIDAndPaymentProviderTypeID(int productId, int paymentProviderTypeId);

	ICollection<IProductPaymentProviderTypeModel> GetProductPaymentProviderTypesByPaymentProviderTypeID(byte paymentProviderTypeId);

	ICollection<IProductPaymentProviderTypeModel> GetProductPaymentProviderTypesByProductID(int productId);
}
