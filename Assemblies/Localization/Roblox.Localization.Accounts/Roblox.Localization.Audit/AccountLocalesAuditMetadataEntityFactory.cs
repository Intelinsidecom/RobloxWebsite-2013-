using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAuditMetadataEntityFactory : IAccountLocalesAuditMetadataEntityFactory
{
	private readonly IAccountLocalesAuditMetadataTypeConverter _MetadataTypeConverter;

	private readonly IAccountLocalesChangeAgentTypeConverter _ChangeAgentTypeConverter;

	public AccountLocalesAuditMetadataEntityFactory(IAccountLocalesAuditMetadataTypeConverter metadataTypeConverter, IAccountLocalesChangeAgentTypeConverter changeAgentTypeConverter)
	{
		_MetadataTypeConverter = metadataTypeConverter.AssignOrThrowIfNull("metadataTypeConverter");
		_ChangeAgentTypeConverter = changeAgentTypeConverter.AssignOrThrowIfNull("changeAgentTypeConverter");
	}

	public IAccountLocalesAuditMetadataEntity Get(long id)
	{
		return CalToCachedMssql(AccountLocalesAuditMetadata.Get(id));
	}

	public ICollection<IAccountLocalesAuditMetadataEntity> GetByAccountLocalesAuditEntryAuditIdAndAccountLocalesAuditMetadataTypeIdEnumerative(long accountLocalesAuditEntryAuditId, byte accountLocalesAuditMetadataTypeId, int count, long? exclusiveStartId = null)
	{
		if (accountLocalesAuditEntryAuditId < 1)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive.", "accountLocalesAuditEntryAuditId"));
		}
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive.");
		}
		return AccountLocalesAuditMetadata.GetAccountLocalesAuditMetadataByAccountLocalesAuditEntryAuditIdAndAccountLocalesAuditMetadataTypeId(accountLocalesAuditEntryAuditId, accountLocalesAuditMetadataTypeId, count, exclusiveStartId).Select(CalToCachedMssql).ToArray();
	}

	public IAccountLocalesAuditMetadataEntity Create(IAccountLocalesAuditEntryEntity auditEntryEntity, AccountLocalesAuditEntryMetadataType metadataType, AccountLocalesChangeAgentType changeAgentType, long? changeAgentTargetId)
	{
		if (auditEntryEntity == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} can not be null.", "auditEntryEntity"));
		}
		byte metadataTypeId = _MetadataTypeConverter.GetEntityIdFromEnum(metadataType);
		byte changeAgentTypeId = _ChangeAgentTypeConverter.GetEntityIdFromEnum(changeAgentType);
		AccountLocalesAuditMetadata accountLocalesAuditMetadata = new AccountLocalesAuditMetadata();
		accountLocalesAuditMetadata.AccountLocalesAuditEntryPublicId = auditEntryEntity.PublicId;
		accountLocalesAuditMetadata.AccountLocalesAuditEntryAuditId = auditEntryEntity.AuditId;
		accountLocalesAuditMetadata.AccountLocalesAuditMetadataTypeId = metadataTypeId;
		accountLocalesAuditMetadata.ChangeAgentTypeId = changeAgentTypeId;
		accountLocalesAuditMetadata.ChangeAgentTargetId = changeAgentTargetId;
		accountLocalesAuditMetadata.Save();
		return CalToCachedMssql(accountLocalesAuditMetadata);
	}

	private static IAccountLocalesAuditMetadataEntity CalToCachedMssql(AccountLocalesAuditMetadata cal)
	{
		if (cal != null)
		{
			return new AccountLocalesAuditMetadataCachedMssqlEntity
			{
				Id = cal.ID,
				AccountLocalesAuditEntryPublicId = cal.AccountLocalesAuditEntryPublicId,
				AccountLocalesAuditEntryAuditId = cal.AccountLocalesAuditEntryAuditId,
				AccountLocalesAuditMetadataTypeId = cal.AccountLocalesAuditMetadataTypeId,
				ChangeAgentTypeId = cal.ChangeAgentTypeId,
				ChangeAgentTargetId = cal.ChangeAgentTargetId,
				Created = cal.Created
			};
		}
		return null;
	}
}
