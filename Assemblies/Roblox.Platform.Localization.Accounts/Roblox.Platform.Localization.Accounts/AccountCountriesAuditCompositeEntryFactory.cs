using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountCountriesAuditCompositeEntryFactory : IAccountCountriesAuditCompositeEntryFactory
{
	private readonly IAccountCountriesChangeAgentTypeEntityFactory _ChangeAgentTypeEntityFactory;

	private readonly IAccountCountriesAuditMetadataTypeEntityFactory _MetadataTypeEntityFactory;

	private readonly IAccountCountriesAutomationTypeEntityFactory _AutomationTypeEntityFactory;

	private readonly IAccountCountriesChangeAgentTypeConverter _ChangeAgentTypeConverter;

	private readonly IAccountCountriesAuditMetadataTypeConverter _MetadataTypeConverter;

	private readonly IUserFactory _UserFactory;

	public AccountCountriesAuditCompositeEntryFactory(IAccountCountriesChangeAgentTypeEntityFactory changeAgentTypeEntityFactory, IAccountCountriesAuditMetadataTypeEntityFactory metadataTypeEntityFactory, IAccountCountriesAutomationTypeEntityFactory automationTypeEntityFactory, IAccountCountriesChangeAgentTypeConverter changeAgentTypeConverter, IAccountCountriesAuditMetadataTypeConverter metadataTypeConverter, IUserFactory userFactory)
	{
		_ChangeAgentTypeEntityFactory = changeAgentTypeEntityFactory.AssignOrThrowIfNull("changeAgentTypeEntityFactory");
		_MetadataTypeEntityFactory = metadataTypeEntityFactory.AssignOrThrowIfNull("metadataTypeEntityFactory");
		_AutomationTypeEntityFactory = automationTypeEntityFactory.AssignOrThrowIfNull("automationTypeEntityFactory");
		_ChangeAgentTypeConverter = changeAgentTypeConverter.AssignOrThrowIfNull("changeAgentTypeConverter");
		_MetadataTypeConverter = metadataTypeConverter.AssignOrThrowIfNull("metadataTypeConverter");
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
	}

	public IAccountCountriesAuditCompositeEntry Create(IAccountCountriesAuditMetadataEntity metadata, IAccountCountriesAuditEntryEntity auditEntry)
	{
		if (metadata == null)
		{
			throw new PlatformArgumentNullException("metadata");
		}
		AccountCountriesAuditCompositeEntry accountCountriesAuditCompositeEntry = new AccountCountriesAuditCompositeEntry(metadata, auditEntry, _UserFactory, _AutomationTypeEntityFactory);
		IAccountCountriesChangeAgentTypeEntity changeAgentTypeEntity = _ChangeAgentTypeEntityFactory.Get(metadata.ChangeAgentTypeId);
		AccountCountriesChangeAgentType changeAgentTypeEnum = _ChangeAgentTypeConverter.GetEnumFromEntity(changeAgentTypeEntity);
		accountCountriesAuditCompositeEntry.ChangeAgentType = changeAgentTypeEnum;
		IAccountCountriesAuditMetadataTypeEntity metadataTypeEntity = _MetadataTypeEntityFactory.Get(metadata.AccountCountriesAuditMetadataTypeId);
		AccountCountriesAuditEntryMetadataType metadataTypeEnum = _MetadataTypeConverter.GetEnumFromEntity(metadataTypeEntity);
		accountCountriesAuditCompositeEntry.MetadataType = metadataTypeEnum;
		return accountCountriesAuditCompositeEntry;
	}
}
