using Roblox.Demographics;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents a factory that produces <see cref="T:Roblox.Platform.Demographics.IAddress" />es.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Demographics.IAddressFactory" />
public class AddressFactory : IAddressFactory
{
	private readonly ICountryFactory _CountryFactory;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Demographics.AddressFactory" /> class.
	/// </summary>
	/// <param name="countryFactory">The <see cref="T:Roblox.Platform.Demographics.ICountryFactory" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="countryFactory" />
	/// </exception>
	public AddressFactory(ICountryFactory countryFactory)
	{
		if (countryFactory == null)
		{
			throw new PlatformArgumentNullException("countryFactory");
		}
		_CountryFactory = countryFactory;
	}

	public IAddress Get(int id)
	{
		Roblox.Demographics.Address bll = Roblox.Demographics.Address.Get(id);
		return BllToPlatform(bll);
	}

	public IAddress GetOrCreate(string line1, string line2, string city, string stateProvince, ICountryIdentifier country, string zipPostal)
	{
		if (line1 == null)
		{
			throw new PlatformArgumentNullException("line1");
		}
		if (line2 == null)
		{
			throw new PlatformArgumentNullException("line2");
		}
		if (city == null)
		{
			throw new PlatformArgumentNullException("city");
		}
		if (stateProvince == null)
		{
			throw new PlatformArgumentNullException("stateProvince");
		}
		if (country == null)
		{
			throw new PlatformArgumentNullException("country");
		}
		if (zipPostal == null)
		{
			throw new PlatformArgumentNullException("zipPostal");
		}
		if (country.Id > 255)
		{
			throw new PlatformDataIntegrityException($"Get or create on address referencing country ID '{country.Id}' is greater than a byte's max value. Time to fix the table.");
		}
		Roblox.Demographics.Address bll = Roblox.Demographics.Address.GetOrCreateAddress(line1, line2, city, stateProvince, (byte)country.Id, zipPostal);
		return BllToPlatform(bll);
	}

	private Address BllToPlatform(Roblox.Demographics.Address bll)
	{
		if (bll != null)
		{
			return new Address(bll.ID, bll.AddressLine1, bll.AddressLine2, bll.City, bll.StateProvince, _CountryFactory.Get(new CountryIdentifier(bll.CountryID)), bll.ZipPostal);
		}
		return null;
	}
}
