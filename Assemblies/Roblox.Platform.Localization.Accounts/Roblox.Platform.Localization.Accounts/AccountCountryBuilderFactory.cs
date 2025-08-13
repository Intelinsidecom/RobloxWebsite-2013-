using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

public class AccountCountryBuilderFactory
{
	private IUserFactory _UserFactory;

	private IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private ILogger _Logger;

	public AccountCountryBuilderFactory(IUserFactory userFactory, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, ILogger logger)
	{
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
		_FloodCheckerFactory = floodCheckerFactory.AssignOrThrowIfNull("floodCheckerFactory");
		_Logger = logger.AssignOrThrowIfNull("logger");
	}

	public IAccountCountryBuilder GetAccountCountryBuilder()
	{
		AccountCountriesAuditMetadataTypeConverter metadataTypeConverter = new AccountCountriesAuditMetadataTypeConverter(new AccountCountriesAuditMetadataTypeEntityFactory());
		AccountCountriesChangeAgentTypeConverter changeAgentTypeConverter = new AccountCountriesChangeAgentTypeConverter(new AccountCountriesChangeAgentTypeEntityFactory());
		return new AccountCountryBuilder(new AccountCountryEntityFactory(), new CountryFactory(), Settings.Default, new AccountCountriesAuditEntryEntityFactory(), new AccountCountriesAuditMetadataEntityFactory(metadataTypeConverter, changeAgentTypeConverter), new AccountCountriesAutomationTypeEntityFactory(), _UserFactory, new AccountCountryFloodCheckerFactory(_FloodCheckerFactory, Settings.Default, _Logger));
	}
}
