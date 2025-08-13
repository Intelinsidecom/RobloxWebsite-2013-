using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Membership.Commands.Audit;

[ExcludeFromCodeCoverage]
internal class AccountsAuditEntryCachedMssqlEntity : IAccountsAuditEntryEntity, IEntity<long>
{
	public long Id { get; set; }

	public Guid PublicId { get; set; }

	public long Audit_Id { get; set; }

	public string Audit_Name { get; set; }

	public byte Audit_AccountStatusId { get; set; }

	public int Audit_RoleSetId { get; set; }

	public string Audit_Description { get; set; }

	public DateTime Audit_Created { get; set; }

	public DateTime Audit_Updated { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(AccountsAuditEntryCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
