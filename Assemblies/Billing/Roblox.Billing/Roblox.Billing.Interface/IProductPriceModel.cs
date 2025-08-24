using System;

namespace Roblox.Billing.Interface;

/// <summary>
/// Interface for ProductPriceModel
/// </summary>
public interface IProductPriceModel
{
	int ID { get; }

	int ProductPaymentProviderTypeID { get; }

	int CountryCurrencyID { get; }

	decimal Price { get; }

	DateTime Created { get; }

	DateTime Updated { get; }

	bool? IsActive { get; }
}
