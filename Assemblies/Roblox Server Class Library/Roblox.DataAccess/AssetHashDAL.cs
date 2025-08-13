using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class AssetHashDAL
{
	private long _ID;

	private int _AssetTypeID;

	private string _Hash = string.Empty;

	private bool _IsApproved = true;

	private bool _IsReviewed;

	private long _CreatorID;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	public long ID
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

	public int AssetTypeID
	{
		get
		{
			return _AssetTypeID;
		}
		set
		{
			_AssetTypeID = value;
		}
	}

	public string Hash
	{
		get
		{
			return _Hash;
		}
		set
		{
			_Hash = value.Substring(0, (value.Length < 32) ? value.Length : 32);
		}
	}

	public bool IsApproved
	{
		get
		{
			return _IsApproved;
		}
		set
		{
			_IsApproved = value;
		}
	}

	public bool IsReviewed
	{
		get
		{
			return _IsReviewed;
		}
		set
		{
			_IsReviewed = value;
		}
	}

	public long CreatorID
	{
		get
		{
			return _CreatorID;
		}
		set
		{
			_CreatorID = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _Created;
		}
		set
		{
			_Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _Updated;
		}
		set
		{
			_Updated = value;
		}
	}

	private static string ConnectionString => RobloxDatabase.RobloxAssetHashes.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.ExecuteSQLScalar("[dbo].[AssetHashes_DeleteAssetHashByID]", CommandType.StoredProcedure);
	}

	public void Insert()
	{
		if (_AssetTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
		}
		if (_Hash.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Hash.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", _AssetTypeID);
		dbHelper.SQLParameters.AddWithValue("@Hash", _Hash);
		dbHelper.SQLParameters.AddWithValue("@IsApproved", _IsApproved);
		dbHelper.SQLParameters.AddWithValue("@IsReviewed", _IsReviewed);
		dbHelper.SQLParameters.AddWithValue("@CreatorID", _CreatorID);
		dbHelper.SQLParameters.AddWithValue("@Created", _Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", _Updated);
		SqlParameter id = dbHelper.SQLParameters.Add("@ID", SqlDbType.BigInt);
		id.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[AssetHashes_InsertAssetHash]", CommandType.StoredProcedure);
		_ID = Convert.ToInt64(id.Value);
	}

	public void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (_AssetTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
		}
		if (_Hash.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Hash.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", _AssetTypeID);
		dbHelper.SQLParameters.AddWithValue("@Hash", _Hash);
		dbHelper.SQLParameters.AddWithValue("@IsApproved", _IsApproved);
		dbHelper.SQLParameters.AddWithValue("@IsReviewed", _IsReviewed);
		dbHelper.SQLParameters.AddWithValue("@CreatorID", _CreatorID);
		dbHelper.SQLParameters.AddWithValue("@Created", _Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", _Updated);
		dbHelper.ExecuteSQLScalar("[dbo].[AssetHashes_UpdateAssetHashByID]", CommandType.StoredProcedure);
	}

	private static AssetHashDAL BuildDAL(SqlDataReader reader)
	{
		AssetHashDAL dal = new AssetHashDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetTypeID = (int)reader["AssetTypeID"];
			dal.Hash = (string)reader["Hash"];
			dal.IsApproved = (bool)reader["IsApproved"];
			dal.IsReviewed = (bool)reader["IsReviewed"];
			dal.CreatorID = Convert.ToInt64(reader["CreatorID"]);
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.Created == DateTime.MinValue)
		{
			return null;
		}
		return dal;
	}

	public static AssetHashDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetHashes_GetAssetHashByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static AssetHashDAL Get(int assetTypeID, string hash)
	{
		if (string.IsNullOrEmpty(hash))
		{
			return null;
		}
		if (assetTypeID == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", assetTypeID);
		dbHelper.SQLParameters.AddWithValue("@Hash", hash);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetHashes_GetAssetHashByAssetTypeIDAndHash]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static EntityHelper.GetOrCreateDALWrapper<AssetHashDAL> GetOrCreate(int assetTypeId, string hash, bool isApproved, bool isReviewed, long creatorId)
	{
		if (assetTypeId == 0 || string.IsNullOrEmpty(hash))
		{
			throw new ApplicationException("GetOrCreate failure.");
		}
		SqlParameter createdNewEntityParameter = new SqlParameter("@CreatedNewEntity", SqlDbType.Bit);
		createdNewEntityParameter.Direction = ParameterDirection.Output;
		AssetHashDAL dal;
		using (DbHelper dbHelper = new DbHelper(ConnectionString))
		{
			dbHelper.SQLParameters.Add(createdNewEntityParameter);
			dbHelper.SQLParameters.AddWithValue("@AssetTypeID", assetTypeId);
			dbHelper.SQLParameters.AddWithValue("@Hash", hash);
			dbHelper.SQLParameters.AddWithValue("@IsApproved", isApproved);
			dbHelper.SQLParameters.AddWithValue("@IsReviewed", isReviewed);
			dbHelper.SQLParameters.AddWithValue("@CreatorID", creatorId);
			using SqlDataReader dataReader = dbHelper.ExecuteSQLReader("[dbo].[AssetHashes_GetOrCreateAssetHashByAssetTypeIDAndHash_NEW]", CommandType.StoredProcedure);
			dal = BuildDAL(dataReader);
		}
		if (dal == null)
		{
			throw new ApplicationException("GetOrCreate failure.");
		}
		return new EntityHelper.GetOrCreateDALWrapper<AssetHashDAL>((bool)createdNewEntityParameter.Value, dal);
	}

	public static EntityHelper.GetOrCreateDALWrapper<AssetHashDAL> GetOrCreate(int assetTypeId, string hash, bool isApproved, bool isReviewed, long creatorId, byte creatorType)
	{
		return GetOrCreate(assetTypeId, hash, isApproved, isReviewed, creatorId);
	}

	public static ICollection<long> GetAssetHashIDsPaged(string hash, int startRowIndex, int maximumRows)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Hash", hash);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetHashes_GetAssetHashIDsByHash_Paged]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	public static ICollection<long> GetAssetHashIDsPaged(int assetTypeID, int startRowIndex, int maximumRows)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", assetTypeID);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetHashes_GetAssetHashIDsByAssetTypeID_Paged]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	public static int GetTotalNumberOfAssetHashes(int assetTypeID)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetID", assetTypeID);
		return Convert.ToInt32(dbHelper.ExecuteSQLScalar("[dbo].[AssetHashes_GetTotalNumberOfAssetHashesByAssetTypeID]", CommandType.StoredProcedure));
	}

	public static int GetTotalNumberOfAssetHashes(string hash)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Hash", hash);
		return Convert.ToInt32(dbHelper.ExecuteSQLScalar("[dbo].[AssetHashes_GetTotalNumberOfAssetHashesByHash]", CommandType.StoredProcedure));
	}

	public static int GetTotalNumberOfUnreviewedAssetHashes(int assetTypeId)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", assetTypeId);
		return Convert.ToInt32(dbHelper.ExecuteSQLScalar("[dbo].[AssetHashes_GetTotalNumberOfUnreviewedAssetHashesByAssetTypeID]", CommandType.StoredProcedure));
	}

	public static ICollection<long> GetUnreviewedAssetHashIDs(int assetTypeId, int startRowIndex, int maximumRows)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", assetTypeId);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetHashes_GetUnreviewedAssetHashIDsByAssetTypeID_Paged]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}
}
