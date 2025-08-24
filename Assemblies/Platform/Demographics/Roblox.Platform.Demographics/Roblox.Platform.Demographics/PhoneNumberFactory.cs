using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Entities;

namespace Roblox.Platform.Demographics;

internal class PhoneNumberFactory : IPhoneNumberFactory_Internal, IPhoneNumberFactory
{
	internal const int _MaxPhoneNumberLength = 20;

	private readonly DemographicsDomainFactories _DomainFactories;

	public PhoneNumberFactory(DemographicsDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories.AssignOrThrowIfNull("domainFactories");
	}

	public IPhoneNumber Get(IPhoneNumberIdentifier phoneNumberId)
	{
		if (phoneNumberId == null)
		{
			throw new PlatformArgumentNullException("phoneNumberId");
		}
		return GetById(phoneNumberId.Id);
	}

	public ICollection<IPhoneNumber> GetPhoneNumbers(ICollection<int> phoneNumberIds)
	{
		ICollection<IPhoneNumberEntity> entities = _DomainFactories.PhoneNumberEntityFactory.MultiGet(phoneNumberIds);
		IEnumerable<IPhoneNumberInternationalPrefix> prefixes = from x in (from x in entities.Select((IPhoneNumberEntity x) => x.PhoneNumberInternationalPrefixId).Distinct()
				where x.HasValue
				select new PhoneNumberInternationalPrefixIdentifier(x.Value)).ToArray()
			select _DomainFactories.PhoneNumberInternationalPrefixFactory.GetByID(x);
		IEnumerable<PhoneNumber> first = from e in entities
			join p in prefixes on e.PhoneNumberInternationalPrefixId equals p.Id
			select new PhoneNumber(_DomainFactories, e, p);
		IEnumerable<PhoneNumber> phoenumbersWithoutPrefix = from x in entities
			where !x.PhoneNumberInternationalPrefixId.HasValue
			select new PhoneNumber(_DomainFactories, x, null);
		return first.Concat(phoenumbersWithoutPrefix).ToArray();
	}

	public IPhoneNumber GetOrCreate(string internationalPrefixNumber, string nationalPhoneNumber, string countryAbbreviationCode)
	{
		if (string.IsNullOrEmpty(nationalPhoneNumber))
		{
			throw new PlatformArgumentNullException("nationalPhoneNumber");
		}
		if (string.IsNullOrEmpty(internationalPrefixNumber))
		{
			throw new PlatformArgumentNullException("internationalPrefixNumber");
		}
		if (string.IsNullOrEmpty(countryAbbreviationCode))
		{
			throw new PlatformArgumentNullException("countryAbbreviationCode");
		}
		ISanitizedPhoneNumber sanitizedPhone = _DomainFactories.PhoneNumberValidator.GetSanitizedPhoneNumber(internationalPrefixNumber, nationalPhoneNumber, countryAbbreviationCode);
		IPhoneNumberEntity entity = _DomainFactories.PhoneNumberEntityFactory.GetOrCreate(sanitizedPhone.FullNumber);
		if (!entity.PhoneNumberInternationalPrefixId.HasValue)
		{
			MigrateEntity(entity, sanitizedPhone.InternationalPrefix.Id, sanitizedPhone.NationalNumber);
		}
		return new PhoneNumber(_DomainFactories, entity, sanitizedPhone.InternationalPrefix);
	}

	internal void MigrateEntity(IPhoneNumberEntity entity, short prefixId, string nationalNumber)
	{
		entity.PhoneNumberInternationalPrefixId = prefixId;
		entity.NationalPhoneNumber = nationalNumber;
		entity.Update();
	}

	internal string ExtractDigits(string phoneNumber)
	{
		return Regex.Replace(phoneNumber, "\\D+", string.Empty);
	}

	[Obsolete("Use GetOrCreate(prefix, phone number)")]
	public IPhoneNumber GetOrCreate(string phoneNumber)
	{
		if (phoneNumber == null)
		{
			throw new PlatformArgumentNullException("phoneNumber");
		}
		if (!_DomainFactories.PhoneNumberValidator.IsValid(phoneNumber))
		{
			throw new PlatformArgumentException("Invalid phone number");
		}
		IPhoneNumberEntity entity = _DomainFactories.PhoneNumberEntityFactory.GetOrCreate(phoneNumber);
		return GetFromEntity(entity);
	}

	public IPhoneNumber GetById(int id)
	{
		IPhoneNumberEntity entity = _DomainFactories.PhoneNumberEntityFactory.Get(id);
		return GetFromEntity(entity);
	}

	public IPhoneNumber GetByPhoneNumber(string phoneNumber)
	{
		if (string.IsNullOrWhiteSpace(phoneNumber))
		{
			throw new PlatformArgumentException("phoneNumber");
		}
		string formattedPhoneNumber = _DomainFactories.PhoneNumberValidator.GetFormattedPhoneNumber(phoneNumber);
		IPhoneNumberEntity entity = _DomainFactories.PhoneNumberEntityFactory.GetByValue(formattedPhoneNumber);
		return GetFromEntity(entity);
	}

	public IPhoneNumber GetByPhoneNumber(string internationalPrefixNumber, string nationalPhoneNumber, string countryAbbreviationCode)
	{
		if (string.IsNullOrEmpty(nationalPhoneNumber))
		{
			throw new PlatformArgumentNullException("nationalPhoneNumber");
		}
		if (string.IsNullOrEmpty(internationalPrefixNumber))
		{
			throw new PlatformArgumentNullException("internationalPrefixNumber");
		}
		if (string.IsNullOrEmpty(countryAbbreviationCode))
		{
			throw new PlatformArgumentNullException("countryAbbreviationCode");
		}
		ISanitizedPhoneNumber sanitizedPhone = _DomainFactories.PhoneNumberValidator.GetSanitizedPhoneNumber(internationalPrefixNumber, nationalPhoneNumber, countryAbbreviationCode);
		IPhoneNumberEntity entity = _DomainFactories.PhoneNumberEntityFactory.GetByValue(sanitizedPhone.FullNumber);
		return GetFromEntity(entity);
	}

	public ICollection<IPhoneNumber> GetByNationalPhoneNumber(string nationalPhoneNumber, int count, int? exclusiveStartId = null)
	{
		if (string.IsNullOrWhiteSpace(nationalPhoneNumber))
		{
			throw new PlatformArgumentException("'nationalPhoneNumber' can not be null or whitespace");
		}
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return _DomainFactories.PhoneNumberEntityFactory.GetByNationalPhoneNumberEnumerative(nationalPhoneNumber, count, exclusiveStartId).Select(GetFromEntity).ToList();
	}

	private IPhoneNumber GetFromEntity(IPhoneNumberEntity entity)
	{
		if (entity == null)
		{
			return null;
		}
		if (entity.PhoneNumberInternationalPrefixId.HasValue)
		{
			PhoneNumberInternationalPrefixIdentifier prefixIdentifier = new PhoneNumberInternationalPrefixIdentifier(entity.PhoneNumberInternationalPrefixId.Value);
			IPhoneNumberInternationalPrefix prefix = _DomainFactories.PhoneNumberInternationalPrefixFactory.GetByID(prefixIdentifier);
			return new PhoneNumber(_DomainFactories, entity, prefix);
		}
		return new PhoneNumber(_DomainFactories, entity, null);
	}
}
