using System;
using Roblox.Entities;

namespace Roblox.Platform.Membership.Audit;

internal interface IUsersAuditEntryEntity : IEntity<long>
{
	Guid PublicId { get; }

	long Audit_Id { get; }

	long Audit_AccountId { get; }

	byte? Audit_AgeBracket { get; }

	DateTime? Audit_BirthDate { get; }

	byte? Audit_GenderTypeId { get; }

	bool Audit_UseSuperSafeConversationMode { get; }

	bool Audit_UseSuperSafePrivacyMode { get; }

	DateTime Audit_Created { get; }

	DateTime? Audit_Updated { get; }
}
