using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics.Entities;

[ExcludeFromCodeCoverage]
internal class PhoneNumberEntityFactory : IPhoneNumberEntityFactory, IDomainFactory<DemographicsDomainFactories>, IDomainObject<DemographicsDomainFactories>
{
	public DemographicsDomainFactories DomainFactories { get; }

	public PhoneNumberEntityFactory(DemographicsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IPhoneNumberEntity Get(int id)
	{
		return CalToCachedMssql(PhoneNumberCAL.Get(id));
	}

	public IPhoneNumberEntity GetByValue(string value)
	{
		return CalToCachedMssql(PhoneNumberCAL.GetByValue(value));
	}

	public IPhoneNumberEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(PhoneNumberCAL.GetOrCreate(value));
	}

	private static IPhoneNumberEntity CalToCachedMssql(PhoneNumberCAL cal)
	{
		if (cal != null)
		{
			return new PhoneNumberCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated,
				PhoneNumberInternationalPrefixId = cal.PhoneNumberInternationalPrefixID,
				NationalPhoneNumber = cal.NationalPhoneNumber,
				IsBlacklisted = cal.IsBlacklisted
			};
		}
		return null;
	}

	public IPhoneNumberEntity GetOrCreate(string value, short prefixId, string nationalNumber)
	{
		PhoneNumberCAL cal = PhoneNumberCAL.GetOrCreate(value);
		if (!cal.PhoneNumberInternationalPrefixID.HasValue)
		{
			MigrateCal(cal, prefixId, nationalNumber);
		}
		return CalToCachedMssql(cal);
	}

	internal void MigrateCal(PhoneNumberCAL cal, short prefixId, string nationalNumber)
	{
		cal.PhoneNumberInternationalPrefixID = prefixId;
		cal.NationalPhoneNumber = nationalNumber;
		cal.Save();
	}

	public ICollection<IPhoneNumberEntity> MultiGet(ICollection<int> ids)
	{
		return PhoneNumberCAL.MultiGet(ids).Select(CalToCachedMssql).ToArray();
	}

	/// <inheritdoc />
	public ICollection<IPhoneNumberEntity> GetByNationalPhoneNumberEnumerative(string nationalPhoneNumber, int count, int? exclusiveStartId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "count"));
		}
		if (string.IsNullOrWhiteSpace(nationalPhoneNumber))
		{
			throw new PlatformArgumentException(string.Format("'{0}' can not be null or whitespace", "nationalPhoneNumber"));
		}
		return PhoneNumberCAL.GetPhoneNumbersByNationalPhoneNumber(nationalPhoneNumber, count, exclusiveStartId).Select(CalToCachedMssql).ToArray();
	}
}
