using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership.Entities;

namespace Roblox.Platform.Membership.Audit;

internal class UsersAuditEntryEntityFactory : IUsersAuditEntryEntityFactory
{
	public IUsersAuditEntryEntity Get(long id)
	{
		return CalToCachedMssql(UsersAuditEntry.Get(id));
	}

	public IUsersAuditEntryEntity GetByPublicId(Guid publicId)
	{
		if (publicId == Guid.Empty)
		{
			return null;
		}
		return CalToCachedMssql(UsersAuditEntry.GetByPublicID(publicId));
	}

	public ICollection<IUsersAuditEntryEntity> SingleGetsByPublicIds(IEnumerable<Guid> publicIds)
	{
		return UsersAuditEntry.SingleGetsByPublicIds(publicIds).Select(CalToCachedMssql).ToArray();
	}

	private static IUsersAuditEntryEntity CalToCachedMssql(UsersAuditEntry cal)
	{
		if (cal != null)
		{
			return new UsersAuditEntryCachedMssqlEntity
			{
				Id = cal.ID,
				PublicId = cal.PublicID,
				Audit_Id = cal.Audit_ID,
				Audit_AccountId = cal.Audit_AccountID,
				Audit_AgeBracket = cal.Audit_AgeBracket,
				Audit_BirthDate = cal.Audit_BirthDate,
				Audit_GenderTypeId = cal.Audit_GenderTypeID,
				Audit_UseSuperSafeConversationMode = cal.Audit_UseSuperSafeConversationMode,
				Audit_UseSuperSafePrivacyMode = cal.Audit_UseSuperSafePrivacyMode,
				Audit_Created = cal.Audit_Created,
				Audit_Updated = cal.Audit_Updated,
				Created = cal.Created
			};
		}
		return null;
	}

	public IUsersAuditEntryEntity CreateNew(IUserEntity entity)
	{
		UsersAuditEntry usersAuditEntry = new UsersAuditEntry();
		usersAuditEntry.Audit_ID = entity.ID;
		usersAuditEntry.Audit_AccountID = entity.AccountID;
		usersAuditEntry.Audit_AgeBracket = (byte)entity.AgeBracket;
		usersAuditEntry.Audit_BirthDate = entity.BirthDate;
		usersAuditEntry.Audit_GenderTypeID = entity.GenderTypeId;
		usersAuditEntry.Audit_UseSuperSafeConversationMode = entity.UseSuperSafeConversationMode;
		usersAuditEntry.Audit_UseSuperSafePrivacyMode = entity.UseSuperSafePrivacyMode;
		usersAuditEntry.Audit_Created = entity.Created;
		usersAuditEntry.Audit_Updated = entity.Updated;
		usersAuditEntry.Save();
		return CalToCachedMssql(usersAuditEntry);
	}
}
