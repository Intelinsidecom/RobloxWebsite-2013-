using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAuditEntryCachedMssqlEntity : IAccountLocalesAuditEntryEntity, IEntity<long>
{
	public long Id { get; set; }

	public Guid PublicId { get; set; }

	public long AuditId { get; set; }

	public long AuditAccountId { get; set; }

	public int AuditObservedLocaleId { get; set; }

	public int? AuditSupportedLocaleId { get; set; }

	public DateTime AuditCreated { get; set; }

	public DateTime AuditUpdated { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(AccountLocalesAuditEntry.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
