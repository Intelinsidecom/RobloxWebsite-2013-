using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class AssetSetDAL
{
	private int _ID;

	public string Name;

	public string Description = string.Empty;

	public long CreatorAgentID;

	public long ImageAssetID;

	public bool IsSubscribable;

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
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Description", string.IsNullOrEmpty(Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Description)));
		queryParameters.Add(new SqlParameter("@CreatorAgentID", CreatorAgentID));
		queryParameters.Add(new SqlParameter("@ImageAssetID", ImageAssetID));
		queryParameters.Add(new SqlParameter("@IsSubscribable", IsSubscribable));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "AssetSets_InsertAssetSet", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Description", string.IsNullOrEmpty(Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Description)));
		queryParameters.Add(new SqlParameter("@CreatorAgentID", CreatorAgentID));
		queryParameters.Add(new SqlParameter("@ImageAssetID", ImageAssetID));
		queryParameters.Add(new SqlParameter("@IsSubscribable", IsSubscribable));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "AssetSets_UpdateAssetSetByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "AssetSets_DeleteAssetSetByID", queryParameters));
	}

	private static AssetSetDAL BuildDAL(SqlDataReader reader)
	{
		AssetSetDAL dal = new AssetSetDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Name = (string)reader["Name"];
			dal.Description = (reader["Description"].Equals(DBNull.Value) ? string.Empty : ((string)reader["Description"]));
			dal.CreatorAgentID = Convert.ToInt64(reader["CreatorAgentID"]);
			dal.ImageAssetID = (long)reader["ImageAssetID"];
			dal.IsSubscribable = (bool)reader["IsSubscribable"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static AssetSetDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetSets_GetAssetSetByID", queryParameters), BuildDAL);
	}

	public static AssetSetDAL Get(long creatorAgentId, string name)
	{
		if (creatorAgentId == 0L)
		{
			return null;
		}
		if (name == string.Empty)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CreatorAgentID", creatorAgentId));
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetSets_GetAssetSetByCreatorAgentIDAndName", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetAssetSetIDsPaged(long creatorAgentId, int startRowIndex, int maximumRows)
	{
		if (creatorAgentId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CreatorAgentID", creatorAgentId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "AssetSets_GetAssetSetIDsByCreatorAgentID_Paged", queryParameters));
	}

	public static ICollection<int> GetAssetSetIDsByKeywordSearchPagedAndSorted(string keyword, int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Keyword", (keyword.Trim().Length > 0) ? ((IConvertible)keyword.ToQuery()) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "AssetSets_GetAssetSetIDsBySearchCriteria_PagedAndSorted", queryParameters));
	}

	public static int GetTotalNumberOfAssetSetsByCreatorAgentID(long creatorAgentId)
	{
		if (creatorAgentId == 0L)
		{
			return 0;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CreatorAgentID", creatorAgentId));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "AssetSets_GetTotalNumberOfAssetSetsByCreatorAgentID", queryParameters));
	}

	public static int GetTotalNumberOfAssetSetsBySearchCriteria(string keyword)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Keyword", (keyword.Trim().Length > 0) ? ((IConvertible)keyword.ToQuery()) : ((IConvertible)DBNull.Value)));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "AssetSets_GetTotalNumberOfAssetSetsBySearchCriteria", queryParameters));
	}
}
