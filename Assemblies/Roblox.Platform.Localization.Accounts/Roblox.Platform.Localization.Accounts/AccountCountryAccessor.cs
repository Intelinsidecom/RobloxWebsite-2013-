using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Localization.Accounts.Implementations;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountCountryAccessor : IAccountCountryAccessor
{
	private readonly IAccountCountryEntityFactory _AccountCountryEntityFactory;

	private readonly ICountryFactory _CountryFactory;

	public AccountCountryAccessor(IAccountCountryEntityFactory accountCountryEntityFactory, ICountryFactory countryFactory)
	{
		_AccountCountryEntityFactory = accountCountryEntityFactory ?? throw new PlatformArgumentNullException("accountCountryEntityFactory");
		_CountryFactory = countryFactory ?? throw new PlatformArgumentNullException("countryFactory");
	}

	public IAccountCountry GetAccountCountry(long accountId)
	{
		return ConvertToPlatform(_AccountCountryEntityFactory.GetByAccountId(accountId));
	}

	public ICountry GetUserCountry(IUser user, bool onlyIfExplicitlySetByUser = false)
	{
		if (user == null)
		{
			return null;
		}
		IAccountCountry accountCountry = GetAccountCountry(user.AccountId);
		if (accountCountry?.CountryId == null)
		{
			return null;
		}
		if (onlyIfExplicitlySetByUser && !accountCountry.IsVerified)
		{
			return null;
		}
		return _CountryFactory.Get(accountCountry.CountryId);
	}

	private static IAccountCountry ConvertToPlatform(IAccountCountryEntity accountCountryEntity)
	{
		if (accountCountryEntity != null)
		{
			return new Roblox.Platform.Localization.Accounts.Implementations.AccountCountry
			{
				AccountId = accountCountryEntity.AccountId,
				CountryId = ((!accountCountryEntity.CountryId.HasValue) ? null : new CountryIdentifier(accountCountryEntity.CountryId.Value)),
				IsVerified = accountCountryEntity.IsVerified
			};
		}
		return null;
	}
}
