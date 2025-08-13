using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSettingsAuditEntryCachedMssqlEntity : ITwoStepVerificationSettingsAuditEntryEntity, IEntity<long>, IAuditEntry
{
	public long Id { get; set; }

	public Guid PublicId { get; set; }

	public long Audit_Id { get; set; }

	public long Audit_UserId { get; set; }

	public bool Audit_IsEnabled { get; set; }

	public byte? Audit_TwoStepVerificationMediaTypeId { get; set; }

	public DateTime Audit_Created { get; set; }

	public DateTime Audit_Updated { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(TwoStepVerificationSettingsAuditEntry.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
