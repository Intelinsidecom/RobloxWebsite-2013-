namespace Roblox.Billing.Interface;

/// <summary>
/// This is the interface for a factory for <see cref="T:Roblox.Billing.Interface.IProductPriceModel" /> so we can abstract away the entity implementation and to make this unit testable
/// </summary>
public interface IProductPriceFactory
{
	IProductPriceModel CreateNew(int productPaymentProviderTypeId, int countryCurrencyId, decimal price, bool? isActive = false);

	IProductPriceModel Get(int id);

	IProductPriceModel GetByProductPaymentProviderTypeIDAndCountryCurrencyID(int productPaymentProviderTypeID, int countryCurrencyID);

	int GetTotalNumberOfProductPricesByProductPaymentProviderID(int productPaymentProviderTypeID);
}
