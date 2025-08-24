using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Interface;

namespace Roblox.Billing.Implementation;

/// <summary>
/// This is a wrapper for <see cref="T:Roblox.Billing.CountryCurrency" /> so we can abstract away the entity implementation and to make this unit testable
/// </summary>
public class CountryCurrencyFactory : ICountryCurrencyFactory
{
	public ICountryCurrencyModel CreateNew(byte countryTypeID, byte currencyTypeID)
	{
		CountryCurrency countryCurrency = CountryCurrency.CreateNew(countryTypeID, currencyTypeID);
		return EntityToModel(countryCurrency);
	}

	public ICountryCurrencyModel Get(int id)
	{
		CountryCurrency countryCurrency = CountryCurrency.Get(id);
		return EntityToModel(countryCurrency);
	}

	public ICountryCurrencyModel GetByCountryTypeIDAndCurrencyTypeID(int countryTypeID, byte currencyTypeID)
	{
		CountryCurrency countryCurrency = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(countryTypeID, currencyTypeID);
		return EntityToModel(countryCurrency);
	}

	public ICountryCurrencyModel GetOrCreateCountryCurrency(int countryTypeID, byte currencyTypeID)
	{
		CountryCurrency countryCurrency = CountryCurrency.GetOrCreateCountryCurrency(countryTypeID, currencyTypeID);
		return EntityToModel(countryCurrency);
	}

	public ICollection<ICountryCurrencyModel> GetCountryCurrencies_Paged(int startIndex, int maxRows)
	{
		return CountryCurrency.GetCountryCurrencies_Paged(startIndex, maxRows).Select(EntityToModel).ToList();
	}

	public ICollection<ICountryCurrencyModel> GetCountryCurrenciesByCountryID_Paged(int startIndex, int maxRows, int countryTypeID)
	{
		return CountryCurrency.GetCountryCurrenciesByCountryID_Paged(startIndex, maxRows, countryTypeID).Select(EntityToModel).ToList();
	}

	public ICollection<ICountryCurrencyModel> GetAllCountryCurrencies()
	{
		return CountryCurrency.GetAllCountryCurrencies().Select(EntityToModel).ToList();
	}

	private ICountryCurrencyModel EntityToModel(CountryCurrency countryCurrency)
	{
		if (countryCurrency != null)
		{
			return new CountryCurrencyModel(countryCurrency.ID, countryCurrency.CountryTypeID, countryCurrency.CurrencyTypeID, countryCurrency.Created, countryCurrency.Updated);
		}
		return null;
	}
}
