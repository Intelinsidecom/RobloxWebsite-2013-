using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class AssetDAL
{
	private long _ID;

	private int _AssetTypeID;

	private long _AssetHashID;

	private long _AssetCategories;

	private long _AssetGenres;

	private string _Hash = string.Empty;

	private string _Name = string.Empty;

	private string _Description;

	private long _CreatorID;

	private long _CurrentVersionID;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	private bool? _IsArchived;

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

	public long AssetHashID
	{
		get
		{
			return _AssetHashID;
		}
		set
		{
			_AssetHashID = value;
		}
	}

	public long AssetCategories
	{
		get
		{
			return _AssetCategories;
		}
		set
		{
			_AssetCategories = value;
		}
	}

	public long AssetGenres
	{
		get
		{
			return _AssetGenres;
		}
		set
		{
			_AssetGenres = value;
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

	public string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			_Name = value.Substring(0, (value.Length < 50) ? value.Length : 50);
		}
	}

	public string Description
	{
		get
		{
			return _Description;
		}
		set
		{
			_Description = value;
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

	public long CurrentVersionID
	{
		get
		{
			return _CurrentVersionID;
		}
		set
		{
			_CurrentVersionID = value;
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

	public bool? IsArchived
	{
		get
		{
			return _IsArchived;
		}
		set
		{
			_IsArchived = value;
		}
	}

	private static string ConnectionString => RobloxDatabase.RobloxAssets.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.ExecuteSQLScalar("[dbo].[AssetsV2_DeleteAssetByID]", CommandType.StoredProcedure);
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
		if (_Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		if (_CreatorID == 0L)
		{
			throw new ApplicationException("Required value not specified: CreatorID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", _AssetTypeID);
		dbHelper.SQLParameters.AddWithValue("@AssetHashID", _AssetHashID);
		dbHelper.SQLParameters.AddWithValue("@AssetCategories", _AssetCategories);
		dbHelper.SQLParameters.AddWithValue("@AssetGenres", _AssetGenres);
		dbHelper.SQLParameters.AddWithValue("@Hash", _Hash);
		dbHelper.SQLParameters.AddWithValue("@Name", _Name);
		dbHelper.SQLParameters.AddWithValue("@Description", ((object)_Description) ?? ((object)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@CreatorID", _CreatorID);
		dbHelper.SQLParameters.AddWithValue("@CurrentVersionID", _CurrentVersionID);
		dbHelper.SQLParameters.AddWithValue("@CreatedUtc", _Created.ToUniversalTime());
		dbHelper.SQLParameters.AddWithValue("@UpdatedUtc", _Updated.ToUniversalTime());
		SqlParameterCollection sQLParameters = dbHelper.SQLParameters;
		bool? isArchived = _IsArchived;
		sQLParameters.AddWithValue("@IsArchived", isArchived.HasValue ? ((object)isArchived.GetValueOrDefault()) : DBNull.Value);
		SqlParameter ID = dbHelper.SQLParameters.Add("@ID", SqlDbType.BigInt);
		ID.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[AssetsV2_InsertAsset]", CommandType.StoredProcedure);
		_ID = Convert.ToInt64(ID.Value);
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
		if (_Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		if (_CreatorID == 0L)
		{
			throw new ApplicationException("Required value not specified: CreatorID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", _AssetTypeID);
		dbHelper.SQLParameters.AddWithValue("@AssetHashID", _AssetHashID);
		dbHelper.SQLParameters.AddWithValue("@AssetCategories", _AssetCategories);
		dbHelper.SQLParameters.AddWithValue("@AssetGenres", _AssetGenres);
		dbHelper.SQLParameters.AddWithValue("@Hash", _Hash);
		dbHelper.SQLParameters.AddWithValue("@Name", _Name);
		dbHelper.SQLParameters.AddWithValue("@Description", ((object)_Description) ?? ((object)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@CreatorID", _CreatorID);
		dbHelper.SQLParameters.AddWithValue("@CurrentVersionID", _CurrentVersionID);
		dbHelper.SQLParameters.AddWithValue("@CreatedUtc", _Created.ToUniversalTime());
		dbHelper.SQLParameters.AddWithValue("@UpdatedUtc", _Updated.ToUniversalTime());
		SqlParameterCollection sQLParameters = dbHelper.SQLParameters;
		bool? isArchived = _IsArchived;
		sQLParameters.AddWithValue("@IsArchived", isArchived.HasValue ? ((object)isArchived.GetValueOrDefault()) : DBNull.Value);
		dbHelper.ExecuteSQLScalar("[dbo].[AssetsV2_UpdateAssetByID]", CommandType.StoredProcedure);
	}

	private static AssetDAL BuildDAL(SqlDataReader reader)
	{
		AssetDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static AssetDAL GetDALFromReader(SqlDataReader reader)
	{
		return new AssetDAL
		{
			ID = (long)reader["ID"],
			AssetTypeID = (int)reader["AssetTypeID"],
			AssetHashID = (long)reader["AssetHashID"],
			AssetCategories = (long)reader["AssetCategories"],
			AssetGenres = (long)reader["AssetGenres"],
			Hash = (string)reader["Hash"],
			Name = (string)reader["Name"],
			Description = (reader["Description"].Equals(Convert.DBNull) ? null : ((string)reader["Description"])),
			CreatorID = Convert.ToInt64(reader["CreatorID"]),
			CurrentVersionID = (long)reader["CurrentVersionID"],
			Created = DateTime.SpecifyKind((DateTime)reader["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)reader["UpdatedUtc"], DateTimeKind.Utc),
			IsArchived = (reader["IsArchived"].Equals(Convert.DBNull) ? null : ((bool?)reader["IsArchived"]))
		};
	}

	private static List<AssetDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<AssetDAL> dals = new List<AssetDAL>();
		while (reader.Read())
		{
			AssetDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	public static ICollection<AssetDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "[dbo].[AssetsV2_GetAssetsByIDs]"), ids, BuildDALCollection);
	}

	public static AssetDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetsV2_GetAssetByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ICollection<long> GetToolboxAssetIDsPaged(int toolboxId, int startRowIndex, int maximumRows)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ToolboxID", (toolboxId > 0) ? ((object)toolboxId) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[Assets_GetAssetIDsByToolboxID_Paged]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	public static long GetTotalNumberOfToolboxAssets(int toolboxId)
	{
		object count;
		using (DbHelper dbHelper = new DbHelper(ConnectionString))
		{
			dbHelper.SQLParameters.AddWithValue("@ToolboxID", (toolboxId > 0) ? ((object)toolboxId) : DBNull.Value);
			count = dbHelper.ExecuteSQLScalar("[dbo].[Assets_GetTotalNumberOfAssetsByToolboxID]", CommandType.StoredProcedure);
		}
		return Convert.ToInt64(count);
	}

	public static long GetTotalNumberOfAssetsByCreatorID(int assetTypeId, long userId)
	{
		object count;
		using (DbHelper dbHelper = new DbHelper(ConnectionString))
		{
			dbHelper.SQLParameters.AddWithValue("@AssetTypeID", (assetTypeId > 0) ? ((object)assetTypeId) : DBNull.Value);
			dbHelper.SQLParameters.AddWithValue("@CreatorID", (userId > 0) ? ((object)userId) : DBNull.Value);
			count = dbHelper.ExecuteSQLScalar("[dbo].[AssetsV2_GetTotalNumberOfAssetsByCreatorID]", CommandType.StoredProcedure);
		}
		return Convert.ToInt64(count);
	}

	public static ICollection<long> GetAssetIDsByUserIDPaged(int assetTypeId, long userId, int startRowIndex, int maximumRows)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", assetTypeId);
		dbHelper.SQLParameters.AddWithValue("@CreatorId", userId);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetsV2_GetAssetIDsByCreatorID_PagedAndSorted]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	public static ICollection<long> GetAssetIDsByUserIDAndArchivedStatusPaged(int assetTypeId, long userId, bool isArchived, int startRowIndex, int maximumRows)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", assetTypeId);
		dbHelper.SQLParameters.AddWithValue("@CreatorId", userId);
		dbHelper.SQLParameters.AddWithValue("@IsArchived", isArchived);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetsV2_GetAssetIDsByCreatorIDAndIsArchived_Paged]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}
}
