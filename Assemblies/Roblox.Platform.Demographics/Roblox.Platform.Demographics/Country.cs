using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics;

internal class Country : ICountry, ICountryIdentifier
{
	public int Id { get; }

	public string Name { get; }

	public string Code { get; }

	public bool IsActive { get; }

	public Country(int id, string name, string code, bool isActive)
	{
		if (name == null)
		{
			throw new PlatformArgumentNullException("name");
		}
		if (code == null)
		{
			throw new PlatformArgumentNullException("code");
		}
		Id = id;
		Name = name;
		Code = code;
		IsActive = isActive;
	}
}
