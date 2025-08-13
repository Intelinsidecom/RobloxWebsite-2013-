using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Membership.Commands.Audit;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Membership.Commands;

internal class AccountsAuditFactory : IAccountsAuditFactory
{
	private readonly IAccountsAuditMetadataEntityFactory _MetadataEntityFactory;

	private readonly IAccountsAuditEntryEntityFactory _AuditEntryEntityFactory;

	private readonly IUserFactory _UserFactory;

	public AccountsAuditFactory(IAccountsAuditMetadataEntityFactory metadataEntityFactory, IAccountsAuditEntryEntityFactory auditEntryEntityFactory, IUserFactory userFactory)
	{
		_MetadataEntityFactory = metadataEntityFactory ?? throw new ArgumentNullException("metadataEntityFactory");
		_AuditEntryEntityFactory = auditEntryEntityFactory ?? throw new ArgumentNullException("auditEntryEntityFactory");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public ICollection<IAccountsAuditCompositeEntry> GetAccountStatusChangeHistory(IUserIdentifier user, int count, long? exclusiveStartId = null, bool shouldReturnForgottenUser = false)
	{
		return GetByUserAndChangeTypeEnumerative(user, AccountsAuditChangeType.Status, shouldReturnForgottenUser, count, exclusiveStartId);
	}

	private ICollection<IAccountsAuditCompositeEntry> GetByUserAndChangeTypeEnumerative(IUserIdentifier user, AccountsAuditChangeType changeType, bool shouldReturnForgottenUser, int count, long? exclusiveStartId = null)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (count < 1)
		{
			throw new ArgumentException("'count' must be positive");
		}
		byte changeTypeId = (byte)changeType;
		ICollection<IAccountsAuditMetadataEntity> metaData = _MetadataEntityFactory.GetByAccountsChangeTypeIdAndUserIdEnumerative(changeTypeId, user.Id, count, exclusiveStartId);
		if (!metaData.Any())
		{
			return new IAccountsAuditCompositeEntry[0];
		}
		ICollection<IAccountsAuditEntryEntity> auditEntries = _AuditEntryEntityFactory.SingleGetsByPublicIds(metaData.Select((IAccountsAuditMetadataEntity md) => md.AccountsAuditEntriesPublicId));
		if (!auditEntries.Any())
		{
			return new IAccountsAuditCompositeEntry[0];
		}
		return (from ce in metaData.Join(auditEntries, (IAccountsAuditMetadataEntity md) => md.AccountsAuditEntriesPublicId, (IAccountsAuditEntryEntity ae) => ae.PublicId, (IAccountsAuditMetadataEntity mEntity, IAccountsAuditEntryEntity eEntity) => Build(mEntity, eEntity, shouldReturnForgottenUser))
			orderby ce.Id descending
			select ce).ToArray();
	}

	internal virtual IAccountsAuditCompositeEntry Build(IAccountsAuditMetadataEntity metadataEntity, IAccountsAuditEntryEntity auditEntryEntity, bool shouldReturnForgottenUser)
	{
		if (metadataEntity == null)
		{
			return null;
		}
		if (auditEntryEntity == null)
		{
			return null;
		}
		IUser actor = null;
		if (metadataEntity.ActorUserId.HasValue)
		{
			actor = _UserFactory.GetUser(metadataEntity.ActorUserId.Value);
		}
		IUser targetUser = _UserFactory.GetUser(metadataEntity.UserId, shouldReturnForgottenUser);
		AccountStatus accountStatus = TranslateAccountStatus(auditEntryEntity.Audit_AccountStatusId);
		IUser targetUser2 = targetUser;
		return new AccountsAuditCompositeEntry(metadataEntity, actor, targetUser2, accountStatus);
	}

	[ExcludeFromCodeCoverage]
	internal virtual AccountStatus TranslateAccountStatus(byte accountStatusId)
	{
		return AccountStatusExtensions.TranslateAccountStatus(accountStatusId);
	}
}
