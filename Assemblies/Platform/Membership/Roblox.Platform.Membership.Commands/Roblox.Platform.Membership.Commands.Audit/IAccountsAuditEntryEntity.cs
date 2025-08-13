using System;
using Roblox.Entities;

namespace Roblox.Platform.Membership.Commands.Audit;

internal interface IAccountsAuditEntryEntity : IEntity<long>
{
	Guid PublicId { get; }

	long Audit_Id { get; }

	string Audit_Name { get; }

	byte Audit_AccountStatusId { get; }

	int Audit_RoleSetId { get; }

	string Audit_Description { get; }

	DateTime Audit_Created { get; }

	DateTime Audit_Updated { get; }
}
