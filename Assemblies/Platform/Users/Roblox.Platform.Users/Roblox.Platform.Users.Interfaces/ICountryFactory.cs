using System.Collections.Generic;

namespace Roblox.Users.Interfaces;

public interface ICountryFactory
{
	ICountryModel CreateNew(string value, string code, bool active);

	ICountryModel Get(byte id);

	ICountryModel GetUSACountry();

	ICollection<ICountryModel> GetAllCountries();

	ICollection<ICountryModel> GetAllActiveCountries();

	ICollection<ICountryModel> GetCountriesPaged(byte startRowIndex, byte maximumRows);

	ICountryModel GetByCode(string code);
}
