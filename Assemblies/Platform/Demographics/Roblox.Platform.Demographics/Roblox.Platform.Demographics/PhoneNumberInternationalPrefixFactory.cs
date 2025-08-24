using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Entities;

namespace Roblox.Platform.Demographics;

public class PhoneNumberInternationalPrefixFactory : IPhoneNumberInternationalPrefixFactory
{
	private readonly DemographicsDomainFactories _DomainFactories;

	public PhoneNumberInternationalPrefixFactory(DemographicsDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories;
	}

	private IPhoneNumberInternationalPrefix GetFromEntity(IPhoneNumberInternationalPrefixEntity entity)
	{
		return new PhoneNumberInternationalPrefix(_DomainFactories, entity, new CountryIdentifier(entity.CountryId));
	}

	public IPhoneNumberInternationalPrefix GetByID(IPhoneNumberInternationalPrefixIdentifier id)
	{
		if (id == null)
		{
			throw new PlatformArgumentNullException("id");
		}
		IPhoneNumberInternationalPrefixEntity entity = _DomainFactories.PhoneNumberInternationalPrefixEntityFactory.Get(id.Id);
		return GetFromEntity(entity);
	}

	public IPhoneNumberInternationalPrefix GetByCountryAndPrefix(string twoLetterCode, string prefix)
	{
		if (string.IsNullOrEmpty(twoLetterCode) || string.IsNullOrEmpty(prefix))
		{
			return null;
		}
		ICountry country = _DomainFactories.CountryFactory.GetByCode(twoLetterCode);
		if (country == null)
		{
			return null;
		}
		IPhoneNumberInternationalPrefixEntity entity = _DomainFactories.PhoneNumberInternationalPrefixEntityFactory.GetByCountryIdAndInternationalPrefix(country.Id, prefix);
		if (entity == null)
		{
			return null;
		}
		return GetFromEntity(entity);
	}

	public IPhoneNumberInternationalPrefix GetOrCreate(string twoLetterCode, string prefix)
	{
		if (string.IsNullOrEmpty(twoLetterCode) || string.IsNullOrEmpty(prefix))
		{
			return null;
		}
		int countryId = _DomainFactories.CountryFactory.GetByCode(twoLetterCode).Id;
		IPhoneNumberInternationalPrefixEntity entity = _DomainFactories.PhoneNumberInternationalPrefixEntityFactory.GetOrCreate(countryId, prefix);
		return GetFromEntity(entity);
	}

	public ICollection<IPhoneNumberInternationalPrefix> GetAllActivePrefixes()
	{
		return _DomainFactories.PhoneNumberInternationalPrefixEntityFactory.GetByIsActiveEnumerative(isActive: true, 2147483646, 0).Select(GetFromEntity).ToArray();
	}
}
