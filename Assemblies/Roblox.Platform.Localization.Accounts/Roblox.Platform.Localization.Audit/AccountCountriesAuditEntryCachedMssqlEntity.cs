using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesAuditEntryCachedMssqlEntity : IAccountCountriesAuditEntryEntity, IEntity<long>
{
	public long Id { get; set; }

	public Guid PublicId { get; set; }

	public long AuditId { get; set; }

	public long AuditAccountId { get; set; }

	public int? AuditCountryId { get; set; }

	public bool AuditIsVerified { get; set; }

	public DateTime AuditCreated { get; set; }

	public DateTime AuditUpdated { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(AccountCountriesAuditEntry.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
