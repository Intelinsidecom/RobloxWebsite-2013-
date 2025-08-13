using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class AssetOptionDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxAssets.GetConnectionString();

	public long ID { get; set; }

	public long AssetID { get; set; }

	public bool EnableComments { get; set; }

	public bool EnableRatings { get; set; }

	public bool IsCopyLocked { get; set; }

	public bool IsFriendsOnly { get; set; }

	public bool IsAllowingGear { get; set; }

	public long AllowedGearCategories { get; set; }

	public long? DefaultExpirationInTicks { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public bool EnforceGenre { get; set; }

	public byte MinMembershipType { get; set; }

	public AssetOptionDAL()
	{
		AllowedGearCategories = 0L;
		IsCopyLocked = true;
		IsFriendsOnly = false;
		ID = 0L;
		EnableComments = true;
		AssetID = 0L;
		EnableRatings = true;
		IsAllowingGear = false;
		DefaultExpirationInTicks = null;
		Created = DateTime.MinValue;
		Updated = DateTime.MinValue;
		MinMembershipType = 0;
		EnforceGenre = true;
	}

	private static AssetOptionDAL BuildDAL(SqlDataReader reader)
	{
		AssetOptionDAL dal = new AssetOptionDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.EnableComments = (bool)reader["EnableComments"];
			dal.EnableRatings = (bool)reader["EnableRatings"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.IsCopyLocked = (bool)reader["IsCopyLocked"];
			dal.IsFriendsOnly = (bool)reader["IsFriendsOnly"];
			dal.IsAllowingGear = (bool)reader["IsAllowingGear"];
			dal.AllowedGearCategories = (long)reader["AllowedGearCategories"];
			dal.DefaultExpirationInTicks = (reader["DefaultExpirationInTicks"].Equals(DBNull.Value) ? null : ((long?)reader["DefaultExpirationInTicks"]));
			dal.EnforceGenre = (bool)reader["EnforceGenre"];
			dal.MinMembershipType = (byte)reader["MinMembershipType"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@EnableComments", EnableComments));
		queryParameters.Add(new SqlParameter("@EnableRatings", EnableRatings));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@IsCopyLocked", IsCopyLocked));
		queryParameters.Add(new SqlParameter("@IsFriendsOnly", IsFriendsOnly));
		queryParameters.Add(new SqlParameter("@IsAllowingGear", IsAllowingGear));
		queryParameters.Add(new SqlParameter("@AllowedGearCategories", AllowedGearCategories));
		queryParameters.Add(new SqlParameter("@DefaultExpirationInTicks", DefaultExpirationInTicks.HasValue ? ((object)DefaultExpirationInTicks) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@EnforceGenre", EnforceGenre));
		queryParameters.Add(new SqlParameter("@MinMembershipType", MinMembershipType));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "AssetOptions_InsertAssetOption", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@EnableComments", EnableComments));
		queryParameters.Add(new SqlParameter("@EnableRatings", EnableRatings));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@IsCopyLocked", IsCopyLocked));
		queryParameters.Add(new SqlParameter("@IsFriendsOnly", IsFriendsOnly));
		queryParameters.Add(new SqlParameter("@IsAllowingGear", IsAllowingGear));
		queryParameters.Add(new SqlParameter("@AllowedGearCategories", AllowedGearCategories));
		queryParameters.Add(new SqlParameter("@DefaultExpirationInTicks", DefaultExpirationInTicks.HasValue ? ((object)DefaultExpirationInTicks) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@EnforceGenre", EnforceGenre));
		queryParameters.Add(new SqlParameter("@MinMembershipType", MinMembershipType));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "AssetOptions_UpdateAssetOptionByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "AssetOptions_DeleteAssetOptionByID", queryParameters));
	}

	public static EntityHelper.GetOrCreateDALWrapper<AssetOptionDAL> GetOrCreate(long assetId)
	{
		if (assetId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", assetId));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "AssetOptions_GetOrCreateAssetOption", queryParameters), BuildDAL);
	}

	public static AssetOptionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetOptions_GetAssetOptionByID", queryParameters), BuildDAL);
	}
}
