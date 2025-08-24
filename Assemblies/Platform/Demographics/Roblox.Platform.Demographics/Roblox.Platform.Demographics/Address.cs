using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics;

internal class Address : IAddress
{
	public int Id { get; }

	public string Line1 { get; }

	public string Line2 { get; }

	public string City { get; }

	public string StateProvince { get; }

	public ICountry Country { get; }

	public string ZipPostal { get; }

	public Address(int id, string line1, string line2, string city, string stateProvice, ICountry country, string zipPostal)
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
		if (stateProvice == null)
		{
			throw new PlatformArgumentNullException("stateProvice");
		}
		if (country == null)
		{
			throw new PlatformArgumentNullException("country");
		}
		if (zipPostal == null)
		{
			throw new PlatformArgumentNullException("zipPostal");
		}
		Id = id;
		Line1 = line1;
		Line2 = line2;
		City = city;
		StateProvince = stateProvice;
		Country = country;
		ZipPostal = zipPostal;
	}
}
