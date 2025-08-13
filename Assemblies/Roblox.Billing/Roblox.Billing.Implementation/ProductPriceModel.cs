using System;
using Roblox.Billing.Interface;

namespace Roblox.Billing.Implementation;

public class ProductPriceModel : IProductPriceModel
{
	public int ID { get; }

	public int ProductPaymentProviderTypeID { get; }

	public int CountryCurrencyID { get; }

	public decimal Price { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	public bool? IsActive { get; }

	public ProductPriceModel(int id, int productPaymentProviderTypeId, int countryCurrencyId, decimal price, DateTime created, DateTime updated, bool? isActive)
	{
		ID = id;
		ProductPaymentProviderTypeID = productPaymentProviderTypeId;
		CountryCurrencyID = countryCurrencyId;
		Price = price;
		Created = created;
		Updated = updated;
		IsActive = isActive;
	}
}
