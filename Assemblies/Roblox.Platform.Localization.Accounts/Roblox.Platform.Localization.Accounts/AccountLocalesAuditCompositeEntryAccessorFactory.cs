using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

public class AccountLocalesAuditCompositeEntryAccessorFactory
{
	private readonly IUserFactory _UserFactory;

	private readonly IAccountLocalesAuditMetadataTypeConverter _MetadataTypeConverter;

	private readonly IAccountLocalesChangeAgentTypeConverter _ChangeAgentTypeConverter;

	private readonly IAccountLocalesAuditCompositeEntryFactory _AuditCompositeEntryFactory;

	public AccountLocalesAuditCompositeEntryAccessorFactory(IUserFactory userFactory)
	{
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
		AccountLocalesChangeAgentTypeEntityFactory changeAgentTypeEntityFactory = new AccountLocalesChangeAgentTypeEntityFactory();
		AccountLocalesAuditMetadataTypeEntityFactory metadataTypeEntityFactory = new AccountLocalesAuditMetadataTypeEntityFactory();
		AccountLocalesAutomationTypeEntityFactory automationTypeEntityFactory = new AccountLocalesAutomationTypeEntityFactory();
		IAccountLocalesAuditMetadataTypeConverter metadataTypeConverter = (_MetadataTypeConverter = new AccountLocalesAuditMetadataTypeConverter(metadataTypeEntityFactory));
		_AuditCompositeEntryFactory = new AccountLocalesAuditCompositeEntryFactory(changeAgentTypeEntityFactory, metadataTypeEntityFactory, automationTypeEntityFactory, _ChangeAgentTypeConverter = new AccountLocalesChangeAgentTypeConverter(changeAgentTypeEntityFactory), metadataTypeConverter, userFactory);
	}

	public IAccountLocalesAuditCompositeEntryAccessor GetAccountLocalesAuditCompositeEntryAccessor()
	{
		return new AccountLocalesAuditCompositeEntryAccessor(new AccountLocalesAuditMetadataEntityFactory(_MetadataTypeConverter, _ChangeAgentTypeConverter), new AccountLocalesAuditEntryEntityFactory(), new AccountLocaleEntityFactory(), new Settings(), _AuditCompositeEntryFactory, _MetadataTypeConverter);
	}
}
