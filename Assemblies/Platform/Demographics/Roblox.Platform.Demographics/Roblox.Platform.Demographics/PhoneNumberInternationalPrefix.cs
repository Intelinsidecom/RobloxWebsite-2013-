using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Entities;

namespace Roblox.Platform.Demographics;

public class PhoneNumberInternationalPrefix : DomainObjectBase<DemographicsDomainFactories, short>, IPhoneNumberInternationalPrefix, IPhoneNumberInternationalPrefixIdentifier
{
	public ICountryIdentifier CountryIdentifier { get; }

	/// <summary>
	/// The string representing the prefix.
	/// </summary>
	public string Value { get; }

	/// <summary>
	/// Whether the prefix is active.
	/// </summary>
	public bool IsActive { get; set; }

	internal PhoneNumberInternationalPrefix(DemographicsDomainFactories domainFactories, IPhoneNumberInternationalPrefixEntity entity, CountryIdentifier countryIdentifier)
		: base(domainFactories)
	{
		base.Id = entity.Id;
		if (countryIdentifier.Id != entity.CountryId)
		{
			throw new PlatformArgumentException("countryIdentifier");
		}
		CountryIdentifier = countryIdentifier;
		Value = entity.InternationalPrefix;
		IsActive = entity.IsActive;
	}
}
