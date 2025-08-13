using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAuditMetadataCachedMssqlEntity : IAccountLocalesAuditMetadataEntity, IEntity<long>
{
	public long Id { get; set; }

	public Guid AccountLocalesAuditEntryPublicId { get; set; }

	public long AccountLocalesAuditEntryAuditId { get; set; }

	public byte AccountLocalesAuditMetadataTypeId { get; set; }

	public byte ChangeAgentTypeId { get; set; }

	public long? ChangeAgentTargetId { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(AccountLocalesAuditMetadata.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
