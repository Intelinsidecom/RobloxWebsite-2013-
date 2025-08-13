using System;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Demographics.Entities.Audit;

internal interface IAccountPhoneNumbersAuditEntryEntity : IUpdateableEntity<long>, IEntity<long>, IAuditEntry
{
	new Guid PublicId { get; }

	long Audit_Id { get; }

	long Audit_AccountId { get; }

	long? Audit_PhoneNumberId { get; set; }

	bool? Audit_IsVerified { get; }

	string Audit_Phone { get; set; }

	DateTime Audit_Created { get; }

	DateTime Audit_Updated { get; }
}
