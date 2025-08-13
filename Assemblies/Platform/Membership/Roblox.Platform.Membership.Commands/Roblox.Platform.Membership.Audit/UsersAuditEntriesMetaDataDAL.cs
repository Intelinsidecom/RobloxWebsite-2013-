using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Membership.Audit;

internal class UsersAuditEntriesMetaDataDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxUsersAudit;

	internal long ID { get; set; }

	internal long UserID { get; set; }

	internal byte UsersAuditEntriesMetaDataTypeID { get; set; }

	internal Guid UsersAuditEntriesPublicID { get; set; }

	internal long ActorUserID { get; set; }

	internal bool IsLegacyValue { get; set; }

	internal DateTime Created { get; set; }

	private static UsersAuditEntriesMetaDataDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UsersAuditEntriesMetaDataDAL
		{
			ID = (long)record["ID"],
			UserID = (long)record["UserID"],
			UsersAuditEntriesMetaDataTypeID = (byte)record["UsersAuditEntriesMetaDataTypeID"],
			UsersAuditEntriesPublicID = (Guid)record["UsersAuditEntriesPublicID"],
			ActorUserID = (long)record["ActorUserID"],
			IsLegacyValue = (bool)record["IsLegacyValue"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxUsersAudit.Delete("UsersAuditEntriesMetaDataV2_DeleteUsersAuditEntriesMetaDataV2ByID", ID);
	}

	internal static UsersAuditEntriesMetaDataDAL Get(long id)
	{
		return RobloxDatabase.RobloxUsersAudit.Get("UsersAuditEntriesMetaDataV2_GetUsersAuditEntriesMetaDataV2ByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@UsersAuditEntriesMetaDataTypeID", UsersAuditEntriesMetaDataTypeID),
			new SqlParameter("@UsersAuditEntriesPublicID", UsersAuditEntriesPublicID),
			new SqlParameter("@ActorUserID", ActorUserID),
			new SqlParameter("@IsLegacyValue", IsLegacyValue),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxUsersAudit.Insert<long>("UsersAuditEntriesMetaDataV2_InsertUsersAuditEntriesMetaDataV2", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@UsersAuditEntriesMetaDataTypeID", UsersAuditEntriesMetaDataTypeID),
			new SqlParameter("@UsersAuditEntriesPublicID", UsersAuditEntriesPublicID),
			new SqlParameter("@ActorUserID", ActorUserID),
			new SqlParameter("@IsLegacyValue", IsLegacyValue),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxUsersAudit.Update("UsersAuditEntriesMetaDataV2_UpdateUsersAuditEntriesMetaDataV2ByID", queryParameters);
	}

	internal static ICollection<UsersAuditEntriesMetaDataDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxUsersAudit.MultiGet("UsersAuditEntriesMetaDataV2_GetUsersAuditEntriesMetaDataV2ByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetUsersAuditEntriesMetaDataIDsByUserIDAndUsersAuditEntriesMetaDataTypeID(long userID, byte usersAuditEntriesMetaDataTypeID, int count, long exclusiveStartUsersAuditEntriesMetaDataId)
	{
		if (userID == 0L)
		{
			throw new ArgumentException("Parameter 'userID' cannot be null, empty or the default value.");
		}
		if (usersAuditEntriesMetaDataTypeID == 0)
		{
			throw new ArgumentException("Parameter 'usersAuditEntriesMetaDataTypeID' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartUsersAuditEntriesMetaDataId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartUsersAuditEntriesMetaDataID.");
		}
		if (exclusiveStartUsersAuditEntriesMetaDataId == 0L)
		{
			SqlParameter[] queryParameters2 = new SqlParameter[3]
			{
				new SqlParameter("@UserID", userID),
				new SqlParameter("@UsersAuditEntriesMetaDataTypeID", usersAuditEntriesMetaDataTypeID),
				new SqlParameter("@Count", count)
			};
			return RobloxDatabase.RobloxUsersAudit.GetIDCollection<long>("UsersAuditEntriesMetaDataV2_GetUsersAuditEntriesMetaDataV2IDsByUserIDAndUsersAuditEntriesMetaDataTypeID_BaseCase", queryParameters2);
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@UserID", userID),
			new SqlParameter("@UsersAuditEntriesMetaDataTypeID", usersAuditEntriesMetaDataTypeID),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartUsersAuditEntriesMetaDataID", exclusiveStartUsersAuditEntriesMetaDataId)
		};
		return RobloxDatabase.RobloxUsersAudit.GetIDCollection<long>("UsersAuditEntriesMetaDataV2_GetUsersAuditEntriesMetaDataV2IDsByUserIDAndUsersAuditEntriesMetaDataTypeID", queryParameters);
	}
}
