using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocalesAuditCompositeEntryFactory : IAccountLocalesAuditCompositeEntryFactory
{
	private readonly IAccountLocalesChangeAgentTypeEntityFactory _ChangeAgentTypeEntityFactory;

	private readonly IAccountLocalesAuditMetadataTypeEntityFactory _MetadataTypeEntityFactory;

	private readonly IAccountLocalesAutomationTypeEntityFactory _AutomationTypeEntityFactory;

	private readonly IAccountLocalesChangeAgentTypeConverter _ChangeAgentTypeConverter;

	private readonly IAccountLocalesAuditMetadataTypeConverter _MetadataTypeConverter;

	private readonly IUserFactory _UserFactory;

	public AccountLocalesAuditCompositeEntryFactory(IAccountLocalesChangeAgentTypeEntityFactory changeAgentTypeEntityFactory, IAccountLocalesAuditMetadataTypeEntityFactory metadataTypeEntityFactory, IAccountLocalesAutomationTypeEntityFactory automationTypeEntityFactory, IAccountLocalesChangeAgentTypeConverter changeAgentTypeConverter, IAccountLocalesAuditMetadataTypeConverter metadataTypeConverter, IUserFactory userFactory)
	{
		_ChangeAgentTypeEntityFactory = changeAgentTypeEntityFactory.AssignOrThrowIfNull("changeAgentTypeEntityFactory");
		_MetadataTypeEntityFactory = metadataTypeEntityFactory.AssignOrThrowIfNull("metadataTypeEntityFactory");
		_AutomationTypeEntityFactory = automationTypeEntityFactory.AssignOrThrowIfNull("automationTypeEntityFactory");
		_ChangeAgentTypeConverter = changeAgentTypeConverter.AssignOrThrowIfNull("changeAgentTypeConverter");
		_MetadataTypeConverter = metadataTypeConverter.AssignOrThrowIfNull("metadataTypeConverter");
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
	}

	public IAccountLocalesAuditCompositeEntry Create(IAccountLocalesAuditMetadataEntity metadata, IAccountLocalesAuditEntryEntity auditEntry)
	{
		if (metadata == null)
		{
			throw new PlatformArgumentNullException("metadata");
		}
		AccountLocalesAuditCompositeEntry accountLocalesAuditCompositeEntry = new AccountLocalesAuditCompositeEntry(metadata, auditEntry, _UserFactory, _AutomationTypeEntityFactory);
		IAccountLocalesChangeAgentTypeEntity changeAgentTypeEntity = _ChangeAgentTypeEntityFactory.Get(metadata.ChangeAgentTypeId);
		AccountLocalesChangeAgentType changeAgentTypeEnum = _ChangeAgentTypeConverter.GetEnumFromEntity(changeAgentTypeEntity);
		accountLocalesAuditCompositeEntry.ChangeAgentType = changeAgentTypeEnum;
		IAccountLocalesAuditMetadataTypeEntity metadataTypeEntity = _MetadataTypeEntityFactory.Get(metadata.AccountLocalesAuditMetadataTypeId);
		AccountLocalesAuditEntryMetadataType metadataTypeEnum = _MetadataTypeConverter.GetEnumFromEntity(metadataTypeEntity);
		accountLocalesAuditCompositeEntry.MetadataType = metadataTypeEnum;
		return accountLocalesAuditCompositeEntry;
	}
}
