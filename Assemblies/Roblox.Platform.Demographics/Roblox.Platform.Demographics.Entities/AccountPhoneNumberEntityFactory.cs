using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics.Entities;

/// <summary>
/// AccountPhoneNumberEntityFactory is split into two partial classes:
/// * AccountPhoneNumberEntityFactory.cs contains generated code with minimal editing
/// * AccountPhoneNumberEntityFactory.Partial.cs contains manually written code
/// </summary>
[ExcludeFromCodeCoverage]
internal class AccountPhoneNumberEntityFactory : IAccountPhoneNumberEntityFactory, IDomainFactory<DemographicsDomainFactories>, IDomainObject<DemographicsDomainFactories>
{
	public DemographicsDomainFactories DomainFactories { get; }

	public AccountPhoneNumberEntityFactory(DemographicsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAccountPhoneNumberEntity Get(int id)
	{
		return CalToCachedMssql(AccountPhoneNumberCAL.Get(id));
	}

	public IEnumerable<IAccountPhoneNumberEntity> GetByPhoneNumberIDIsVerifiedAndIsActiveEnumerative(int phoneNumberId, bool? isVerified, bool? isActive, int count, int? exclusiveStartAccountPhoneNumberId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountPhoneNumberCAL.GetAccountPhoneNumberIDsByPhoneNumberIDIsVerifiedAndIsActive(phoneNumberId, isVerified, isActive, count, exclusiveStartAccountPhoneNumberId).Select(CalToCachedMssql);
	}

	public IEnumerable<IAccountPhoneNumberEntity> GetByAccountIdAndIsVerifiedEnumerative(long accountId, bool? isVerified, int count, int? exclusiveStartAccountPhoneNumberId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountPhoneNumberCAL.GetAccountPhoneNumbersByAccountIDAndIsVerified(accountId, isVerified, count, exclusiveStartAccountPhoneNumberId).Select(CalToCachedMssql);
	}

	public IEnumerable<IAccountPhoneNumberEntity> GetByAccountIdIsVerifiedAndIsActiveEnumerative(long accountId, bool? isVerified, bool? isActive, int count, int? exclusiveStartAccountPhoneNumberId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountPhoneNumberCAL.GetAccountPhoneNumbersByAccountIDIsVerifiedAndIsActive(accountId, isVerified, isActive, count, exclusiveStartAccountPhoneNumberId).Select(CalToCachedMssql);
	}

	public IEnumerable<IAccountPhoneNumberEntity> GetByAccountIdEnumerative(long accountId, int count, long? exclusiveStartAccountPhoneNumberId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountPhoneNumberCAL.GetAccountPhoneNumbersByAccountID(accountId, count, (int?)exclusiveStartAccountPhoneNumberId).Select(CalToCachedMssql);
	}

	private static IAccountPhoneNumberEntity CalToCachedMssql(AccountPhoneNumberCAL cal)
	{
		if (cal != null)
		{
			return new AccountPhoneNumberCachedMssqlEntity
			{
				Id = cal.ID,
				AccountId = cal.AccountID,
				Phone = cal.Phone,
				Created = cal.Created,
				Updated = cal.Updated,
				PhoneNumberId = cal.PhoneNumberID,
				IsVerified = cal.IsVerified,
				IsActive = cal.IsActive
			};
		}
		return null;
	}

	public IAccountPhoneNumberEntity CreateNew(long accountId, IPhoneNumber phoneNumber)
	{
		AccountPhoneNumberCAL accountPhoneNumberCAL = new AccountPhoneNumberCAL();
		accountPhoneNumberCAL.AccountID = accountId;
		accountPhoneNumberCAL.PhoneNumberID = phoneNumber.Id;
		accountPhoneNumberCAL.Phone = phoneNumber.FullPhoneNumber;
		accountPhoneNumberCAL.IsVerified = false;
		accountPhoneNumberCAL.Save();
		return CalToCachedMssql(accountPhoneNumberCAL);
	}
}
