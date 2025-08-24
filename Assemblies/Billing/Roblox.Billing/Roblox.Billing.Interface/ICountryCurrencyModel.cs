using System;

namespace Roblox.Billing.Interface;

/// <summary>
/// Interface for CountryCurrencyModel
/// </summary>
public interface ICountryCurrencyModel
{
	int ID { get; }

	byte CountryTypeID { get; }

	byte CurrencyTypeID { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
