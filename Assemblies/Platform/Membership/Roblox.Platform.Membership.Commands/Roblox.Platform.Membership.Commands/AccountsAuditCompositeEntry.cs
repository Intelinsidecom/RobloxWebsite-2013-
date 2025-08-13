using System;
using Roblox.Platform.Membership.Commands.Audit;

namespace Roblox.Platform.Membership.Commands;

internal class AccountsAuditCompositeEntry : IAccountsAuditCompositeEntry
{
	public long Id { get; }

	public AccountsAuditChangeType ChangeType { get; }

	public IUser ActorUser { get; }

	public IUser TargetUser { get; }

	public DateTime Created { get; }

	public AccountStatus Audit_AccountStatus { get; }

	public AccountsAuditCompositeEntry(IAccountsAuditMetadataEntity metadataEntity, IUser actorUser, IUser targetUser, AccountStatus audit_AccountStatus)
	{
		if (metadataEntity == null)
		{
			throw new ArgumentNullException("metadataEntity");
		}
		Id = metadataEntity.Id;
		ChangeType = (AccountsAuditChangeType)metadataEntity.AccountsChangeTypeId;
		ActorUser = actorUser;
		TargetUser = targetUser ?? throw new ArgumentNullException("targetUser");
		Created = metadataEntity.Created;
		Audit_AccountStatus = audit_AccountStatus;
	}
}
