using System;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

internal interface ITwoStepVerificationSettingsAuditEntryEntity : IEntity<long>, IAuditEntry
{
	new Guid PublicId { get; }

	long Audit_Id { get; }

	long Audit_UserId { get; }

	bool Audit_IsEnabled { get; }

	byte? Audit_TwoStepVerificationMediaTypeId { get; }

	DateTime Audit_Created { get; }

	DateTime Audit_Updated { get; }
}
