using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocaleFloodCheckerFactory : IAccountLocaleFloodCheckerFactory
{
	private const string _AccountLocaleBuilderFullName = "Roblox.Platform.Localization.Accounts.AccountLocaleBuilder";

	private const string _AccountLocaleUpdateFloodCheckerKeyPrefix = "AccountLocaleUpdateFloodChecker_AccountId";

	private const string _AccountLocaleAccessorFullName = "Roblox.Platform.Localization.Accounts.AccountLocaleAccessor";

	private const string _AccountLocaleObservedLocaleUpdateFloodCheckerKeyPrefix = "AccountLocaleUpdateFloodCheckerOnObservedLocaleUpdate_AccountId";

	private readonly IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	internal AccountLocaleFloodCheckerFactory(IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, ISettings settings, ILogger logger)
	{
		_FloodCheckerFactory = floodCheckerFactory ?? throw new PlatformArgumentNullException("floodCheckerFactory");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public IFloodChecker GetSupportedLocaleUpdateFloodChecker(long accountId)
	{
		return _FloodCheckerFactory.GetFloodChecker("Roblox.Platform.Localization.Accounts.AccountLocaleBuilder", string.Format("{0}:{1}", "AccountLocaleUpdateFloodChecker_AccountId", accountId), () => _Settings.AccountLocaleUpdateUserIdFloodCheckerLimit, () => _Settings.AccountLocaleUpdateUserIdFloodCheckerExpiry, () => true, () => false, _Logger);
	}

	public IFloodChecker GetObservedLocaleUpdateFloodChecker(long accountId)
	{
		return _FloodCheckerFactory.GetFloodChecker("Roblox.Platform.Localization.Accounts.AccountLocaleAccessor", string.Format("{0}:{1}", "AccountLocaleUpdateFloodCheckerOnObservedLocaleUpdate_AccountId", accountId), () => _Settings.AccountLocaleUpdateForObservedLocaleFloodCheckerLimit, () => _Settings.AccountLocaleUpdateForObservedLocaleFloodCheckerExpiry, () => true, () => false, _Logger);
	}
}
