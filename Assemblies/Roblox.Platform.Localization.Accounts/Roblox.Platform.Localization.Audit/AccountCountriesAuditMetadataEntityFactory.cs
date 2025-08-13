using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesAuditMetadataEntityFactory : IAccountCountriesAuditMetadataEntityFactory
{
	private readonly IAccountCountriesAuditMetadataTypeConverter _MetadataTypeConverter;

	private readonly IAccountCountriesChangeAgentTypeConverter _ChangeAgentTypeConverter;

	public AccountCountriesAuditMetadataEntityFactory(IAccountCountriesAuditMetadataTypeConverter metadataTypeConverter, IAccountCountriesChangeAgentTypeConverter changeAgentTypeConverter)
	{
		_MetadataTypeConverter = metadataTypeConverter.AssignOrThrowIfNull("metadataTypeConverter");
		_ChangeAgentTypeConverter = changeAgentTypeConverter.AssignOrThrowIfNull("changeAgentTypeConverter");
	}

	public IAccountCountriesAuditMetadataEntity Get(long id)
	{
		if (id < 1)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive.", "id"));
		}
		AccountCountriesAuditMetadata cal = AccountCountriesAuditMetadata.Get(id);
		return CalToCachedMssql(cal);
	}

	public IReadOnlyCollection<IAccountCountriesAuditMetadataEntity> GetByAccountCountriesAuditEntryAuditIdAndAccountCountriesAuditMetadataTypeIdEnumerative(long accountCountriesAuditEntryAuditId, byte accountCountriesAuditMetadataTypeId, int count, long? exclusiveStartId = null)
	{
		if (accountCountriesAuditEntryAuditId < 1)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "accountCountriesAuditEntryAuditId"));
		}
		if (count < 1)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "count"));
		}
		return (IReadOnlyCollection<IAccountCountriesAuditMetadataEntity>)(object)AccountCountriesAuditMetadata.GetAccountCountriesAuditMetadataByAuditEntryAuditIdAndMetadataTypeId(accountCountriesAuditEntryAuditId, accountCountriesAuditMetadataTypeId, count, exclusiveStartId).Select(CalToCachedMssql).ToArray();
	}

	public IAccountCountriesAuditMetadataEntity Create(IAccountCountriesAuditEntryEntity auditEntryEntity, AccountCountriesAuditEntryMetadataType metadataType, AccountCountriesChangeAgentType changeAgentType, long? changeAgentTargetId)
	{
		if (auditEntryEntity == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} can not be null.", "auditEntryEntity"));
		}
		byte metadataTypeId = _MetadataTypeConverter.GetEntityIdFromEnum(metadataType);
		byte changeAgentTypeId = _ChangeAgentTypeConverter.GetEntityIdFromEnum(changeAgentType);
		AccountCountriesAuditMetadata cal = new AccountCountriesAuditMetadata
		{
			AccountCountriesAuditEntryPublicId = auditEntryEntity.PublicId,
			AccountCountriesAuditEntryAuditId = auditEntryEntity.AuditId,
			AccountCountriesAuditMetadataTypeId = metadataTypeId,
			ChangeAgentTypeId = changeAgentTypeId,
			ChangeAgentTargetId = changeAgentTargetId
		};
		cal.Save();
		return CalToCachedMssql(cal);
	}

	private IAccountCountriesAuditMetadataEntity CalToCachedMssql(AccountCountriesAuditMetadata cal)
	{
		if (cal != null)
		{
			return new AccountCountriesAuditMetadataCachedMssqlEntity
			{
				Id = cal.ID,
				AccountCountriesAuditEntryPublicId = cal.AccountCountriesAuditEntryPublicId,
				AccountCountriesAuditEntryAuditId = cal.AccountCountriesAuditEntryAuditId,
				AccountCountriesAuditMetadataTypeId = cal.AccountCountriesAuditMetadataTypeId,
				ChangeAgentTypeId = cal.ChangeAgentTypeId,
				ChangeAgentTargetId = cal.ChangeAgentTargetId,
				Created = cal.Created
			};
		}
		return null;
	}
}
