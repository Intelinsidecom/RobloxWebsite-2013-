using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesAuditMetadataCachedMssqlEntity : IAccountCountriesAuditMetadataEntity, IEntity<long>
{
	public long Id { get; set; }

	public Guid AccountCountriesAuditEntryPublicId { get; set; }

	public long AccountCountriesAuditEntryAuditId { get; set; }

	public byte AccountCountriesAuditMetadataTypeId { get; set; }

	public byte ChangeAgentTypeId { get; set; }

	public long? ChangeAgentTargetId { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(AccountCountriesAuditMetadata.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
