using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics.Entities;

[ExcludeFromCodeCoverage]
internal class PhoneNumberInternationalPrefixEntityFactory : IPhoneNumberInternationalPrefixEntityFactory, IDomainFactory<DemographicsDomainFactories>, IDomainObject<DemographicsDomainFactories>
{
	public DemographicsDomainFactories DomainFactories { get; }

	public PhoneNumberInternationalPrefixEntityFactory(DemographicsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IPhoneNumberInternationalPrefixEntity Get(short id)
	{
		return CalToCachedMssql(PhoneNumberInternationalPrefixCAL.Get(id));
	}

	public IPhoneNumberInternationalPrefixEntity GetOrCreate(int countryId, string internationalPrefix)
	{
		return CalToCachedMssql(PhoneNumberInternationalPrefixCAL.GetOrCreate(countryId, internationalPrefix));
	}

	public IEnumerable<IPhoneNumberInternationalPrefixEntity> GetByIsActiveEnumerative(bool isActive, int count, short? exclusiveStartPhoneNumberInternationalPrefixId)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return PhoneNumberInternationalPrefixCAL.GetPhoneNumberInternationalPrefixesByIsActive(isActive, count, exclusiveStartPhoneNumberInternationalPrefixId).Select(CalToCachedMssql);
	}

	public IPhoneNumberInternationalPrefixEntity GetByCountryIdAndInternationalPrefix(int countryId, string internationalPrefix)
	{
		return CalToCachedMssql(PhoneNumberInternationalPrefixCAL.GetByCountryIDAndInternationalPrefix(countryId, internationalPrefix));
	}

	public IEnumerable<IPhoneNumberInternationalPrefixEntity> GetByCountryIdEnumerative(int countryId, int count, short? exclusiveStartPhoneNumberInternationalPrefixId)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return PhoneNumberInternationalPrefixCAL.GetPhoneNumberInternationalPrefixesByCountryID(countryId, count, exclusiveStartPhoneNumberInternationalPrefixId).Select(CalToCachedMssql);
	}

	private static IPhoneNumberInternationalPrefixEntity CalToCachedMssql(PhoneNumberInternationalPrefixCAL cal)
	{
		if (cal != null)
		{
			return new PhoneNumberInternationalPrefixCachedMssqlEntity
			{
				Id = cal.ID,
				CountryId = cal.CountryID,
				InternationalPrefix = cal.InternationalPrefix,
				IsActive = cal.IsActive,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}

	public IPhoneNumberInternationalPrefixEntity GetByInternationalPrefixAndCountryId(string internationalPrefix, int countryId)
	{
		return CalToCachedMssql(PhoneNumberInternationalPrefixCAL.GetByCountryIDAndInternationalPrefix(countryId, internationalPrefix));
	}
}
