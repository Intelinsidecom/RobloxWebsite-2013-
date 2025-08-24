using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

public class AccountCountriesAuditCompositeEntryAccessorFactory
{
	private readonly IUserFactory _UserFactory;

	private readonly IAccountCountriesAuditMetadataTypeConverter _MetadataTypeConverter;

	private readonly IAccountCountriesChangeAgentTypeConverter _ChangeAgentTypeConverter;

	private readonly IAccountCountriesAuditCompositeEntryFactory _AuditCompositeEntryFactory;

	/// <summary>
	/// Initializes a factory to get an <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesAuditCompositeEntryAccessor" />.
	/// </summary>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" /> needed for <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesAuditCompositeEntryAccessor" />.</param>
	public AccountCountriesAuditCompositeEntryAccessorFactory(IUserFactory userFactory)
	{
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
		AccountCountriesChangeAgentTypeEntityFactory changeAgentTypeEntityFactory = new AccountCountriesChangeAgentTypeEntityFactory();
		AccountCountriesAuditMetadataTypeEntityFactory metadataTypeEntityFactory = new AccountCountriesAuditMetadataTypeEntityFactory();
		AccountCountriesAutomationTypeEntityFactory automationTypeEntityFactory = new AccountCountriesAutomationTypeEntityFactory();
		_MetadataTypeConverter = new AccountCountriesAuditMetadataTypeConverter(metadataTypeEntityFactory);
		_ChangeAgentTypeConverter = new AccountCountriesChangeAgentTypeConverter(changeAgentTypeEntityFactory);
		_AuditCompositeEntryFactory = new AccountCountriesAuditCompositeEntryFactory(changeAgentTypeEntityFactory, metadataTypeEntityFactory, automationTypeEntityFactory, _ChangeAgentTypeConverter, _MetadataTypeConverter, _UserFactory);
	}

	/// <summary>
	/// An accessor for <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesAuditCompositeEntryAccessor" />.
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"></exception>
	/// <returns>An <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesAuditCompositeEntryAccessor" />.</returns>
	public IAccountCountriesAuditCompositeEntryAccessor GetAccountCountriesAuditCompositeEntryAccessor()
	{
		return new AccountCountriesAuditCompositeEntryAccessor(new AccountCountriesAuditMetadataEntityFactory(_MetadataTypeConverter, _ChangeAgentTypeConverter), new AccountCountriesAuditEntryEntityFactory(), new AccountCountryEntityFactory(), new Settings(), _AuditCompositeEntryFactory, _MetadataTypeConverter);
	}
}
