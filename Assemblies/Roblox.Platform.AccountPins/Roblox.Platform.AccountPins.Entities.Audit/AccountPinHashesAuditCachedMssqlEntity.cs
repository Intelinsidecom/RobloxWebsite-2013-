using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AccountPins.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPinHashesAuditCachedMssqlEntity : IAccountPinHashesAuditEntity, IEntity<long>, IAuditEntry
{
	public long Id { get; set; }

	public Guid PublicId { get; set; }

	public long Audit_Id { get; set; }

	public long Audit_AccountId { get; set; }

	public string Audit_PinHash { get; set; }

	public bool Audit_IsValid { get; set; }

	public DateTime Audit_Created { get; set; }

	public DateTime Audit_Updated { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(AccountPinHashesAuditCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}

	public IAccountPinHashesAuditMetadataEntity BuildMetadataEntity(AccountPinsDomainFactories domainFactories, IUserIdentifier targetUser, AccountPinChangeType changeType, IUserIdentifier actorUserIdentity)
	{
		return domainFactories.AccountPinHashesAuditMetadataEntityFactory.CreateNew(targetUser, PublicId, changeType, actorUserIdentity);
	}
}
