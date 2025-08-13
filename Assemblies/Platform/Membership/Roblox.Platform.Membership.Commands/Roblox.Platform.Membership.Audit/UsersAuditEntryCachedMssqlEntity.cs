using System;
using Roblox.Entities;

namespace Roblox.Platform.Membership.Audit;

internal class UsersAuditEntryCachedMssqlEntity : IUsersAuditEntryEntity, IEntity<long>
{
	public long Id { get; set; }

	public Guid PublicId { get; set; }

	public long Audit_Id { get; set; }

	public long Audit_AccountId { get; set; }

	public byte? Audit_AgeBracket { get; set; }

	public DateTime? Audit_BirthDate { get; set; }

	public byte? Audit_GenderTypeId { get; set; }

	public bool Audit_UseSuperSafeConversationMode { get; set; }

	public bool Audit_UseSuperSafePrivacyMode { get; set; }

	public DateTime Audit_Created { get; set; }

	public DateTime? Audit_Updated { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(UsersAuditEntry.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
