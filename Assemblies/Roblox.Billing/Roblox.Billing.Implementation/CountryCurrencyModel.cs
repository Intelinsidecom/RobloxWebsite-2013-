using System;
using Roblox.Billing.Interface;

namespace Roblox.Billing.Implementation;

public class CountryCurrencyModel : ICountryCurrencyModel
{
	public int ID { get; }

	public byte CountryTypeID { get; }

	public byte CurrencyTypeID { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	public CountryCurrencyModel(int id, byte countryTypeId, byte currencyTypeId, DateTime created, DateTime updated)
	{
		ID = id;
		CountryTypeID = countryTypeId;
		CurrencyTypeID = currencyTypeId;
		Created = created;
		Updated = updated;
	}
}
