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
internal class ClanMemberDAL
{
	private static bool IsClanMemberConnectionEnabled => Settings.Default.IsClanMemberConnectionEnabled;

	private static string ConnectionString
	{
		get
		{
			if (!IsClanMemberConnectionEnabled)
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

	private static ClanMemberDAL BuildDAL(SqlDataReader reader)
	{
		ClanMemberDAL dal = new ClanMemberDAL();
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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "ClanMembers_DeleteClanMemberByID", queryParameters));
	}

	internal static ClanMemberDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ClanMembers_GetClanMemberByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "ClanMembers_InsertClanMember", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
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
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "ClanMembers_UpdateClanMemberByID", queryParameters));
	}

	internal static ClanMemberDAL GetClanMemberByUserID(long userID)
	{
		if (userID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ClanMembers_GetClanMemberByUserID", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetClanMemberIDsByGroupID_Paged(long groupId, int startIndex, int maxRows)
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
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "ClanMembers_GetClanMemberIDsByGroupID_Paged", queryParameters));
	}

	internal static int GetTotalNumberOfClanMembersByGroupID(long groupId)
	{
		if (groupId == 0L)
		{
			return 0;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@GroupID", groupId));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "dbo.ClanMembers_GetTotalNumberOfClanMembersByGroupID", queryParameters));
	}
}
