using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Membership.Audit;

internal class UsersAuditEntriesMetaDataEntityFactory : IUsersAuditEntriesMetaDataEntityFactory
{
	public IUsersAuditEntriesMetaDataEntity Get(long id)
	{
		return CalToCachedMssql(UsersAuditEntriesMetaData.Get(id));
	}

	public ICollection<IUsersAuditEntriesMetaDataEntity> GetByUserIdAndUsersAuditEntriesMetaDataTypeIdEnumerative(long userId, byte usersAuditEntriesMetaDataTypeId, int count, long exclusiveStartUsersAuditEntriesMetaDataId)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return UsersAuditEntriesMetaData.GetUsersAuditEntriesMetaDataByUserIDAndUsersAuditEntriesMetaDataTypeID(userId, usersAuditEntriesMetaDataTypeId, count, exclusiveStartUsersAuditEntriesMetaDataId).Select(CalToCachedMssql).ToArray();
	}

	private static IUsersAuditEntriesMetaDataEntity CalToCachedMssql(UsersAuditEntriesMetaData cal)
	{
		if (cal != null)
		{
			return new UsersAuditEntriesMetaDataCachedMssqlEntity
			{
				Id = cal.ID,
				UserId = cal.UserID,
				UsersAuditEntriesMetaDataTypeId = cal.UsersAuditEntriesMetaDataTypeID,
				UsersAuditEntriesPublicId = cal.UsersAuditEntriesPublicID,
				ActorUserId = cal.ActorUserID,
				IsLegacyValue = cal.IsLegacyValue,
				Created = cal.Created
			};
		}
		return null;
	}

	public IUsersAuditEntriesMetaDataEntity CreateNew(IUser targetUser, Guid auditEntryPublicId, UsersAuditEntryMetaDataType typeId, long actorUserId)
	{
		UsersAuditEntriesMetaData usersAuditEntriesMetaData = new UsersAuditEntriesMetaData();
		usersAuditEntriesMetaData.UserID = targetUser.Id;
		usersAuditEntriesMetaData.UsersAuditEntriesMetaDataTypeID = (byte)typeId;
		usersAuditEntriesMetaData.UsersAuditEntriesPublicID = auditEntryPublicId;
		usersAuditEntriesMetaData.ActorUserID = actorUserId;
		usersAuditEntriesMetaData.IsLegacyValue = false;
		usersAuditEntriesMetaData.Save();
		return CalToCachedMssql(usersAuditEntriesMetaData);
	}

	public IUsersAuditEntriesMetaDataEntity CreateLegacyEntry(IUser targetUser, Guid auditEntryPublicId, UsersAuditEntryMetaDataType typeId, long userId)
	{
		UsersAuditEntriesMetaData usersAuditEntriesMetaData = new UsersAuditEntriesMetaData();
		usersAuditEntriesMetaData.UserID = targetUser.Id;
		usersAuditEntriesMetaData.UsersAuditEntriesMetaDataTypeID = (byte)typeId;
		usersAuditEntriesMetaData.UsersAuditEntriesPublicID = auditEntryPublicId;
		usersAuditEntriesMetaData.ActorUserID = userId;
		usersAuditEntriesMetaData.IsLegacyValue = true;
		usersAuditEntriesMetaData.Save();
		return CalToCachedMssql(usersAuditEntriesMetaData);
	}
}
