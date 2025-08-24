using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.Localization.Accounts;

[ExcludeFromCodeCoverage]
internal class AccountLocaleEntityFactory : IAccountLocaleEntityFactory
{
	public IAccountLocaleEntity Get(long id)
	{
		if (id <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "id"));
		}
		return CalToCachedMssql(AccountLocale.Get(id));
	}

	public IAccountLocaleEntity GetByAccountId(long accountId)
	{
		ValidateAccountId(accountId);
		return CalToCachedMssql(AccountLocale.GetByAccountID(accountId));
	}

	public IAccountLocaleEntity Create(long accountId, int observedLocaleId, int? supportedLocaleId = null)
	{
		ValidateAccountId(accountId);
		if (observedLocaleId <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "observedLocaleId"));
		}
		if (supportedLocaleId.HasValue && supportedLocaleId <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "supportedLocaleId"));
		}
		return CalToCachedMssql(AccountLocale.Create(accountId, observedLocaleId, supportedLocaleId));
	}

	private static IAccountLocaleEntity CalToCachedMssql(AccountLocale cal)
	{
		if (cal != null)
		{
			return new AccountLocaleCachedMssqlEntity
			{
				Id = cal.ID,
				AccountId = cal.AccountID,
				ObservedLocaleId = cal.ObservedLocaleID,
				SupportedLocaleId = cal.SupportedLocaleID,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}

	private void ValidateAccountId(long accountId)
	{
		if (accountId <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "accountId"));
		}
	}
}
