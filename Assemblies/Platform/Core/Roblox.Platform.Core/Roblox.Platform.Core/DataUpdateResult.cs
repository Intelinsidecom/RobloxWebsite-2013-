namespace Roblox.Platform.Core;

/// <summary>
/// This is effectively a tuple to encapsulate data change results (creation/modification) at the entity level in an auditing pattern
/// </summary>
/// <typeparam name="TDataEntity">The type of the Entity object representing the data record in question</typeparam>
/// <typeparam name="TAuditEntryEntity">The type of AuditEntryEntity</typeparam>
public struct DataUpdateResult<TDataEntity, TAuditEntryEntity>
{
	public TDataEntity DataEntity { get; }

	public TAuditEntryEntity AuditEntryEntity { get; }

	public DataUpdateResult(TDataEntity dataEntity, TAuditEntryEntity auditEntryEntity)
	{
		DataEntity = dataEntity;
		AuditEntryEntity = auditEntryEntity;
	}
}
