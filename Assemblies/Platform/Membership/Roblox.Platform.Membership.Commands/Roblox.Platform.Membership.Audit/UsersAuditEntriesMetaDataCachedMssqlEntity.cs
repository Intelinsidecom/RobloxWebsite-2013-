using System;
using Roblox.Entities;

namespace Roblox.Platform.Membership.Audit;

internal class UsersAuditEntriesMetaDataCachedMssqlEntity : IUsersAuditEntriesMetaDataEntity, IEntity<long>
{
	public long Id { get; set; }

	public long UserId { get; set; }

	public byte UsersAuditEntriesMetaDataTypeId { get; set; }

	public Guid UsersAuditEntriesPublicId { get; set; }

	public long ActorUserId { get; set; }

	public bool IsLegacyValue { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(UsersAuditEntriesMetaData.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
