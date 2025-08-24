using System;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AccountPins.Entities.Audit;

internal interface IAccountPinHashesAuditEntity : IEntity<long>, IAuditEntry
{
	new Guid PublicId { get; }

	long Audit_Id { get; }

	long Audit_AccountId { get; }

	string Audit_PinHash { get; }

	bool Audit_IsValid { get; }

	DateTime Audit_Created { get; }

	DateTime Audit_Updated { get; }

	/// <summary>
	/// Builds a MetadataEntity around the IAccountPinHashesAuditEntity using provided information.
	/// </summary>
	IAccountPinHashesAuditMetadataEntity BuildMetadataEntity(AccountPinsDomainFactories domainFactories, IUserIdentifier targetUser, AccountPinChangeType changeType, IUserIdentifier actorUserIdentity);
}
