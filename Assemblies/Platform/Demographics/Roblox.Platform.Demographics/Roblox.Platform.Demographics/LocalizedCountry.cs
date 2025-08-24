namespace Roblox.Platform.Demographics;

internal class LocalizedCountry : Country, ILocalizedCountry, ICountry, ICountryIdentifier
{
	public string LocalizedName { get; }

	public LocalizedCountry(ICountry country, string localizedName)
		: base(country.Id, country.Name, country.Code, country.IsActive)
	{
		LocalizedName = localizedName;
	}
}
