using Roblox.Platform.Core;
using Roblox.Platform.Demographics;

namespace Roblox.Platform.Localization.Accounts;

public class AccountCountryInitializer : IAccountCountryInitializer
{
	private readonly IGeolocationFactory _GeolocationFactory;

	private readonly IAccountCountryAccessor _AccountCountryAccessor;

	private readonly IAccountCountryBuilder _AccountCountryBuilder;

	public AccountCountryInitializer(IGeolocationFactory getGeolocationFactory, IAccountCountryAccessor accountCountryAccessor, IAccountCountryBuilder accountCountryBuilder)
	{
		_GeolocationFactory = getGeolocationFactory;
		_AccountCountryAccessor = accountCountryAccessor;
		_AccountCountryBuilder = accountCountryBuilder.AssignOrThrowIfNull("accountCountryBuilder");
	}

	public void SetDerivedCountryForAccountByIpAddress(long accountId, string ipAddress, bool overwriteExistingCountry, IAccountCountriesChangeAgent changeAgent)
	{
		if (accountId <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "accountId"));
		}
		if (string.IsNullOrWhiteSpace(ipAddress))
		{
			throw new PlatformArgumentNullException(string.Format("'{0}' cannot be null or empty", "ipAddress"));
		}
		IAccountCountry accountCountry = _AccountCountryAccessor.GetAccountCountry(accountId);
		if ((accountCountry == null || !accountCountry.IsVerified) && (accountCountry == null || overwriteExistingCountry))
		{
			ICountryIdentifier countryIdentifier = GetCountryByIpAddress(ipAddress);
			_AccountCountryBuilder.SetDerivedCountry(accountId, countryIdentifier, changeAgent);
		}
	}

	private ICountryIdentifier GetCountryByIpAddress(string ipAddress)
	{
		IGeolocation geolocation = _GeolocationFactory.GetOrCreateGeolocation(ipAddress);
		if (geolocation == null || !geolocation.CountryId.HasValue)
		{
			return null;
		}
		return new CountryIdentifier(geolocation.CountryId.Value);
	}
}
