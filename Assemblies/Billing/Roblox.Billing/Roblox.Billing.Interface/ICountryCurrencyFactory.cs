using System.Collections.Generic;

namespace Roblox.Billing.Interface;

/// <summary>
/// This is the interface for a wrapper for <see cref="T:Roblox.Billing.Interface.ICountryCurrencyModel" /> so we can abstract away the entity implementation and to make this unit testable
/// </summary>
public interface ICountryCurrencyFactory
{
	ICountryCurrencyModel CreateNew(byte countryTypeID, byte currencyTypeID);

	ICountryCurrencyModel Get(int id);

	ICountryCurrencyModel GetByCountryTypeIDAndCurrencyTypeID(int countryTypeID, byte currencyTypeID);

	ICountryCurrencyModel GetOrCreateCountryCurrency(int countryTypeID, byte currencyTypeID);

	ICollection<ICountryCurrencyModel> GetCountryCurrencies_Paged(int startIndex, int maxRows);

	ICollection<ICountryCurrencyModel> GetCountryCurrenciesByCountryID_Paged(int startIndex, int maxRows, int countryTypeID);

	ICollection<ICountryCurrencyModel> GetAllCountryCurrencies();
}
