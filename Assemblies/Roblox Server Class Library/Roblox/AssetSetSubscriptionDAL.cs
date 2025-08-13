using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class AssetSetSubscriptionDAL
{
	private int _ID;

	public long SubscriberUserID;

	public long AssetSetCreatorAgentID;

	public int AssetSetID;

	public DateTime Created;

	public DateTime Updated;

	public int ID
	{
		get
		{
			return _ID;
		}
		set
		{
			_ID = value;
		}
	}

	private static string ConnectionString => RobloxDatabase.RobloxAssetSets.GetConnectionString();

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SubscriberUserID", SubscriberUserID));
		queryParameters.Add(new SqlParameter("@AssetSetCreatorAgentID", AssetSetCreatorAgentID));
		queryParameters.Add(new SqlParameter("@AssetSetID", AssetSetID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "AssetSetSubscriptions_InsertAssetSetSubscription", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@SubscriberUserID", SubscriberUserID));
		queryParameters.Add(new SqlParameter("@AssetSetCreatorAgentID", AssetSetCreatorAgentID));
		queryParameters.Add(new SqlParameter("@AssetSetID", AssetSetID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "AssetSetSubscriptions_UpdateAssetSetSubscriptionByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "AssetSetSubscriptions_DeleteAssetSetSubscriptionByID", queryParameters));
	}

	private static AssetSetSubscriptionDAL BuildDAL(SqlDataReader reader)
	{
		AssetSetSubscriptionDAL dal = new AssetSetSubscriptionDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.SubscriberUserID = Convert.ToInt64(reader["SubscriberUserID"]);
			dal.AssetSetCreatorAgentID = Convert.ToInt64(reader["AssetSetCreatorAgentID"]);
			dal.AssetSetID = (int)reader["AssetSetID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static AssetSetSubscriptionDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetSetSubscriptions_GetAssetSetSubscriptionByID", queryParameters), BuildDAL);
	}

	public static AssetSetSubscriptionDAL Get(long subscriberUserId, int assetSetId)
	{
		if (subscriberUserId == 0L)
		{
			return null;
		}
		if (assetSetId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SubscriberUserID", subscriberUserId));
		queryParameters.Add(new SqlParameter("@AssetSetID", assetSetId));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetSetSubscriptions_GetAssetSetSubscriptionBySubscriberUserIDAssetSetID", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetAssetSetSubscriptionIDsByAssetSetID(int assetSetId, int startRowIndex, int maximumRows)
	{
		if (assetSetId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetSetID", assetSetId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "AssetSetSubscriptions_GetAssetSetSubscriptionIDsByAssetSetID_Paged", queryParameters));
	}

	public static ICollection<int> GetAssetSetSubscriptionIDsBySubscriberUserID(long subscriberUserId, int startRowIndex, int maximumRows)
	{
		if (subscriberUserId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SubscriberUserID", subscriberUserId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "AssetSetSubscriptions_GetAssetSetSubscriptionIDsBySubscriberUserID_Paged", queryParameters));
	}

	public static int GetTotalNumberOfAssetSetSubscriptionsByAssetSetID(int assetSetId)
	{
		if (assetSetId == 0)
		{
			return 0;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetSetID", assetSetId));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "AssetSetSubscriptions_GetTotalNumberOfAssetSetSubscriptionsByAssetSetID", queryParameters));
	}

	public static int GetTotalNumberOfAssetSetSubscriptionsBySubscriberUserID(long subscriberUserId)
	{
		if (subscriberUserId == 0L)
		{
			return 0;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SubscriberUserID", subscriberUserId));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "AssetSetSubscriptions_GetTotalNumberOfAssetSetSubscriptionsBySubscriberUserID", queryParameters));
	}
}
