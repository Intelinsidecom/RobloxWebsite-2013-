using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Properties;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class ClanInvitationDAL
{
	private static bool IsClanInvitationConnectionEnabled => Settings.Default.IsClanInvitationConnectionEnabled;

	private static string ConnectionString
	{
		get
		{
			if (!IsClanInvitationConnectionEnabled)
			{
				throw new PlatformOperationUnavailableException("Database is temporarily offline for maintenance.");
			}
			return RobloxDatabase.RobloxClans.GetConnectionString();
		}
	}

	internal long ID { get; set; }

	internal long GroupID { get; set; }

	internal long UserID { get; set; }

	internal DateTime Created { get; set; }

	private static ClanInvitationDAL BuildDAL(SqlDataReader reader)
	{
		ClanInvitationDAL dal = new ClanInvitationDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.GroupID = Convert.ToInt64(reader["GroupID"]);
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "ClanInvitations_DeleteClanInvitationByID", queryParameters));
	}

	internal static ClanInvitationDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ClanInvitations_GetClanInvitationByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "ClanInvitations_InsertClanInvitation", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "ClanInvitations_UpdateClanInvitationByID", queryParameters));
	}

	internal static ClanInvitationDAL GetClanInvitationByGroupIDUserID(long groupID, long userID)
	{
		if (groupID == 0L)
		{
			return null;
		}
		if (userID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@GroupID", groupID),
			new SqlParameter("@UserID", userID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ClanInvitations_GetClanInvitationByGroupIDUserID", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetClanInvitationIDsByGroupID_Paged(long groupId, int startIndex, int maxRows)
	{
		if (groupId == 0L || maxRows == 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@StartRowIndex", startIndex),
			new SqlParameter("@MaximumRows", maxRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "ClanInvitations_GetClanInvitationIDsByGroupID_Paged", queryParameters));
	}

	internal static int GetTotalNumberOfClanInvitationsByGroupID(long groupId)
	{
		if (groupId == 0L)
		{
			return 0;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@GroupID", groupId));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "dbo.ClanInvitations_GetTotalNumberOfClanInvitationsByGroupID", queryParameters));
	}
}
