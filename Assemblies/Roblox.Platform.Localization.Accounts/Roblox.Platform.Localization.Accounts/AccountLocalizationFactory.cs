using System.Diagnostics.CodeAnalysis;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

[ExcludeFromCodeCoverage]
public class AccountLocalizationFactory
{
	private readonly IAccountLocaleEntityFactory _AccountLocaleEntityFactory;

	private readonly ILogger _Logger;

	private readonly ICoreLocalizationBuilder _CoreLocalizationBuilder;

	private readonly ISupportedLocaleAndLanguageMapper _SupportedLocaleAndLanguageMapper;

	private readonly IAccountLocaleFloodCheckerFactory _AccountLocaleFloodCheckerFactory;

	private readonly IAccountLocaleAuditBuilder _AccountLocaleAuditBuilder;

	private readonly ISettings _Settings;

	private readonly IAccountLocalesAuditParameterValidator _AccountLocalesAuditParameterValidator;

	public AccountLocalizationFactory(ICoreLocalizationAccessor coreLocalizationAccessor, ICoreLocalizationBuilder coreLocalizationBuilder, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, IUserFactory userFactory, ILogger logger)
	{
		if (coreLocalizationAccessor == null)
		{
			throw new PlatformArgumentNullException("coreLocalizationAccessor");
		}
		_CoreLocalizationBuilder = coreLocalizationBuilder ?? throw new PlatformArgumentNullException("coreLocalizationBuilder");
		if (floodCheckerFactory == null)
		{
			throw new PlatformArgumentNullException("floodCheckerFactory");
		}
		if (userFactory == null)
		{
			throw new PlatformArgumentNullException("userFactory");
		}
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		ISettings settings = (_Settings = Settings.Default);
		_AccountLocaleEntityFactory = new AccountLocaleEntityFactory();
		_AccountLocaleFloodCheckerFactory = new AccountLocaleFloodCheckerFactory(floodCheckerFactory, settings, logger);
		_SupportedLocaleAndLanguageMapper = new SupportedLocaleAndLanguageMapper(coreLocalizationAccessor, settings);
		AccountLocalesChangeAgentTypeEntityFactory changeAgentTypeEntityFactory = new AccountLocalesChangeAgentTypeEntityFactory();
		AccountLocalesAuditMetadataTypeEntityFactory accountLocalesAuditMetadataTypeEntityFactory = new AccountLocalesAuditMetadataTypeEntityFactory();
		AccountLocalesAutomationTypeEntityFactory accountLocalesAutomationTypeEntityFactory = new AccountLocalesAutomationTypeEntityFactory();
		AccountLocalesChangeAgentTypeConverter accountLocalesChangeAgentTypeConverter = new AccountLocalesChangeAgentTypeConverter(changeAgentTypeEntityFactory);
		AccountLocalesAuditMetadataTypeConverter metadataTypeConverter = new AccountLocalesAuditMetadataTypeConverter(accountLocalesAuditMetadataTypeEntityFactory);
		AccountLocalesAuditEntryEntityFactory accountLocaleAuditEntryEntityFactory = new AccountLocalesAuditEntryEntityFactory();
		AccountLocalesAuditMetadataEntityFactory accountLocaleAuditMetadataEntityFactory = new AccountLocalesAuditMetadataEntityFactory(metadataTypeConverter, accountLocalesChangeAgentTypeConverter);
		_AccountLocaleAuditBuilder = new AccountLocaleAuditBuilder(accountLocaleAuditEntryEntityFactory, accountLocaleAuditMetadataEntityFactory, settings, logger);
		_AccountLocalesAuditParameterValidator = new AccountLocalesAuditParameterValidator(settings, userFactory, accountLocalesAutomationTypeEntityFactory);
	}

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocaleAccessor" />.
	/// </summary>
	/// <returns>An <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocaleAccessor" />.</returns>
	public IAccountLocaleAccessor GetAccountLocaleAccessor()
	{
		return new AccountLocaleAccessor(_AccountLocaleEntityFactory, _SupportedLocaleAndLanguageMapper);
	}

	/// <summary>
	/// Gets <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocaleBuilder" />.
	/// </summary>
	/// <returns>An <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocaleBuilder" /></returns>
	public IAccountLocaleBuilder GetAccountLocaleBuilder()
	{
		return new AccountLocaleBuilder(_AccountLocaleEntityFactory, _SupportedLocaleAndLanguageMapper, _AccountLocaleFloodCheckerFactory, _Settings, _AccountLocaleAuditBuilder, _AccountLocalesAuditParameterValidator, _CoreLocalizationBuilder, _Logger);
	}
}
