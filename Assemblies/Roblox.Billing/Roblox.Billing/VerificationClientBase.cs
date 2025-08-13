using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Demographics;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

public abstract class VerificationClientBase
{
	/// <summary>
	/// Gets a string value from a key safely, returning either the string value or an empty string.
	/// </summary>
	/// <param name="dictionary">The dictionary to get the value from.</param>
	/// <param name="key">The key to the value to get.</param>
	/// <returns>The string value that the key corresponds to or an empty string.</returns>
	protected string SafeGet(IDictionary<string, object> dictionary, string key)
	{
		if (!dictionary.ContainsKey(key))
		{
			return string.Empty;
		}
		return dictionary[key] as string;
	}

	/// <summary>
	/// Gets the <see cref="T:Roblox.Billing.CountryCurrency" /> for a purchaser from a list of enabled currencies
	/// </summary>
	/// <param name="purchaserId"></param>
	/// <param name="localPricingEnabledCurrencies"></param>
	/// <param name="userFactory"></param>
	/// <returns></returns>
	protected CountryCurrency GetCountryCurrencyForPurchaser(long purchaserId, HashSet<string> localPricingEnabledCurrencies, IUserFactory userFactory)
	{
		CountryCurrency countryCurrency = null;
		try
		{
			IAccountCountry accountCountry = AccountCountryAccessorFactory.GetAccountCountryAccessor(userFactory).GetAccountCountry(purchaserId);
			if (accountCountry?.CountryId != null)
			{
				int maxRows = 1;
				ICollection<CountryCurrency> countryCurrenciesByCountryID_Paged = CountryCurrency.GetCountryCurrenciesByCountryID_Paged(0, maxRows, accountCountry.CountryId.Id);
				HashSet<byte> enabledCurrencyTypeIds = new HashSet<byte>(from ct in CurrencyType.GetAllCurrencyTypes()
					where localPricingEnabledCurrencies.Contains(ct.Code)
					select ct.ID);
				countryCurrency = countryCurrenciesByCountryID_Paged?.FirstOrDefault((CountryCurrency cc) => enabledCurrencyTypeIds.Contains(cc.CurrencyTypeID));
			}
			return countryCurrency ?? CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID);
		}
		catch
		{
			return CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID);
		}
	}
}
