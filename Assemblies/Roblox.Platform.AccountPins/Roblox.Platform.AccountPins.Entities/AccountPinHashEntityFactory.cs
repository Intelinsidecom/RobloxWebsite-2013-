using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.AccountPins.Entities;

[ExcludeFromCodeCoverage]
internal class AccountPinHashEntityFactory : IAccountPinHashEntityFactory, IDomainFactory<AccountPinsDomainFactories>, IDomainObject<AccountPinsDomainFactories>
{
	public AccountPinsDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.Entities.AccountPinHashEntityFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="domainFactories" /> is null.</exception>
	public AccountPinHashEntityFactory(AccountPinsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAccountPinHashEntity Get(long id)
	{
		return CalToCachedMssql(AccountPinHashCAL.Get(id));
	}

	public IEnumerable<IAccountPinHashEntity> GetByAccountIdAndIsValidEnumerative(long accountId, bool isValid, int count, long? exclusiveStartId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountPinHashCAL.GetAccountPinHashesByAccountIDAndIsValid(accountId, isValid, count, exclusiveStartId).Select(CalToCachedMssql);
	}

	private static IAccountPinHashEntity CalToCachedMssql(AccountPinHashCAL cal)
	{
		if (cal != null)
		{
			return new AccountPinHashCachedMssqlEntity
			{
				Id = cal.ID,
				AccountId = cal.AccountID,
				PinHash = cal.PinHash,
				IsValid = cal.IsValid,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}

	public IAccountPinHashEntity CreateNew(long accountId, string hash)
	{
		AccountPinHashCAL accountPinHashCAL = new AccountPinHashCAL();
		accountPinHashCAL.AccountID = accountId;
		accountPinHashCAL.PinHash = hash;
		accountPinHashCAL.IsValid = true;
		accountPinHashCAL.Save();
		return CalToCachedMssql(accountPinHashCAL);
	}

	public IAccountPinHashEntity GetValid(long accountId)
	{
		return GetByAccountIdAndIsValidEnumerative(accountId, isValid: true, 1).FirstOrDefault();
	}
}
