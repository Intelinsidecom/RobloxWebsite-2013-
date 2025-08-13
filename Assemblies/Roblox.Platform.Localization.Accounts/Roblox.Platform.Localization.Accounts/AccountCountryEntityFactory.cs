using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.Localization.Accounts;

[ExcludeFromCodeCoverage]
internal class AccountCountryEntityFactory : IAccountCountryEntityFactory
{
	public IAccountCountryEntity Get(long id)
	{
		if (id <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "id"));
		}
		return CalToCachedMssql(AccountCountry.Get(id));
	}

	public IAccountCountryEntity GetByAccountId(long accountId)
	{
		if (accountId <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "accountId"));
		}
		return CalToCachedMssql(AccountCountry.GetByAccountID(accountId));
	}

	public IAccountCountryEntity GetOrCreate(long accountId, out bool entityWasCreated)
	{
		if (accountId <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "accountId"));
		}
		return CalToCachedMssql(AccountCountry.GetOrCreate(accountId, out entityWasCreated));
	}

	private static IAccountCountryEntity CalToCachedMssql(AccountCountry cal)
	{
		if (cal != null)
		{
			return new AccountCountryCachedMssqlEntity
			{
				Id = cal.ID,
				AccountId = cal.AccountId,
				CountryId = cal.CountryId,
				IsVerified = cal.IsVerified,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
