using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Web.Games;

[Serializable]
internal class BadgeAssetAwardDAL
{
	public int ID;

	public long BadgeID;

	public long AssetAwardID;

	public string Description = "";

	public DateTime Created;

	public DateTime Updated;

	private static string dbConnectionString_BadgeAssetAwardDAL => RobloxDatabase.RobloxAssets.GetConnectionString();

	private static BadgeAssetAwardDAL BuildDAL(SqlDataReader reader)
	{
		BadgeAssetAwardDAL dal = new BadgeAssetAwardDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.BadgeID = (long)reader["BadgeID"];
			dal.AssetAwardID = (long)reader["AssetAwardID"];
			dal.Description = (string)reader["Description"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@BadgeID", BadgeID));
		queryParameters.Add(new SqlParameter("@AssetAwardID", AssetAwardID));
		queryParameters.Add(new SqlParameter("@Description", Description));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		SqlParameter insertID = new SqlParameter("@ID", SqlDbType.Int);
		insertID.Direction = ParameterDirection.Output;
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_BadgeAssetAwardDAL, "BadgeAssetAwards_InsertBadgeAssetAward", insertID, queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@BadgeID", BadgeID));
		queryParameters.Add(new SqlParameter("@AssetAwardID", AssetAwardID));
		queryParameters.Add(new SqlParameter("@Description", Description));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_BadgeAssetAwardDAL, "BadgeAssetAwards_UpdateBadgeAssetAwardByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_BadgeAssetAwardDAL, "BadgeAssetAwards_DeleteBadgeAssetAwardByID", queryParameters));
	}

	public static BadgeAssetAwardDAL Get(int id)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_BadgeAssetAwardDAL, "BadgeAssetAwards_GetBadgeAssetAwardByID", queryParameters), BuildDAL);
	}

	internal static ICollection<int> GetBadgeAssetAwardIDsByBadgeID(long badgeID)
	{
		if (badgeID == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@BadgeID", badgeID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_BadgeAssetAwardDAL, "[dbo].[BadgeAssetAwards_GetBadgeAssetAwardIDsByBadgeID]", queryParameters));
	}

	public static ICollection<int> GetBadgeAssetAwardIDsPaged(int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_BadgeAssetAwardDAL, "BadgeAssetAwards_GetBadgeAssetAwardIDs_Paged", queryParameters));
	}

	public static int GetTotalNumberOfBadgeAssetAwards()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(dbConnectionString_BadgeAssetAwardDAL, "BadgeAssetAwards_GetTotalNumberOfBadgeAssetAwards", queryParameters));
	}
}
