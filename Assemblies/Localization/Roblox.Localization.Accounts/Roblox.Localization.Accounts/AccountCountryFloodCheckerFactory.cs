using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountCountryFloodCheckerFactory : IAccountCountryFloodCheckerFactory
{
	private const string _AccountCountryBuilderFullName = "Roblox.Platform.Localization.Accounts.AccountLocaleBuilder";

	private const string _AccountCountrypdateFloodCheckerKeyPrefix = "AccountCountryUpdateFloodChecker_AccountId";

	private const string _AccountLocaleAccessorFullName = "Roblox.Platform.Localization.Accounts.AccountCountryAccessor";

	private readonly IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	internal AccountCountryFloodCheckerFactory(IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, ISettings settings, ILogger logger)
	{
		_FloodCheckerFactory = floodCheckerFactory ?? throw new PlatformArgumentNullException("floodCheckerFactory");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public IFloodChecker GetAccountCountryUpdateFloodChecker(long accountId)
	{
		return _FloodCheckerFactory.GetFloodChecker("Roblox.Platform.Localization.Accounts.AccountCountryAccessor", string.Format("{0}:{1}", "AccountCountryUpdateFloodChecker_AccountId", accountId), () => _Settings.AccountCountryUpdateForUserFloodCheckerLimit, () => _Settings.AccountCountryUpdateForUserFloodCheckerExpiry, () => true, () => false, _Logger);
	}
}
