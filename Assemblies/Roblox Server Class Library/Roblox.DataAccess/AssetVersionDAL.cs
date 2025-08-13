using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.DataV2.Core;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class AssetVersionDAL
{
	private string _Hash = string.Empty;

	private static string ConnectionString => RobloxDatabase.RobloxAssetVersions.GetConnectionString();

	public long ID { get; set; }

	public long AssetID { get; set; }

	public int AssetTypeID { get; set; }

	public long AssetHashID { get; set; }

	public int VersionNumber { get; set; }

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

	public long? ParentAssetVersionID { get; set; }

	public long CreatorID { get; set; }

	public long? CreatingUniverseID { get; set; }

	public DateTime Created { get; set; } = DateTime.MinValue;


	public DateTime Updated { get; set; } = DateTime.MinValue;


	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.ExecuteSQLScalar("[dbo].[AssetVersionsV2_DeleteAssetVersionByID]", CommandType.StoredProcedure);
	}

	public void Insert()
	{
		if (AssetID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		if (AssetTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
		}
		if (VersionNumber == 0)
		{
			throw new ApplicationException("Required value not specified: VersionNumber.");
		}
		if (_Hash.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Hash.");
		}
		if (CreatorID == 0L)
		{
			throw new ApplicationException("Required value not specified: CreatorID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetID", AssetID);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", AssetTypeID);
		dbHelper.SQLParameters.AddWithValue("@AssetHashID", AssetHashID);
		dbHelper.SQLParameters.AddWithValue("@VersionNumber", VersionNumber);
		dbHelper.SQLParameters.AddWithValue("@Hash", _Hash);
		SqlParameterCollection sQLParameters = dbHelper.SQLParameters;
		long? parentAssetVersionID = ParentAssetVersionID;
		sQLParameters.AddWithValue("@ParentAssetVersionID", parentAssetVersionID.HasValue ? ((object)parentAssetVersionID.GetValueOrDefault()) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@CreatorID", CreatorID);
		SqlParameterCollection sQLParameters2 = dbHelper.SQLParameters;
		parentAssetVersionID = CreatingUniverseID;
		sQLParameters2.AddWithValue("@CreatingUniverseID", parentAssetVersionID.HasValue ? ((object)parentAssetVersionID.GetValueOrDefault()) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@CreatedUtc", Created.ToUniversalTime());
		dbHelper.SQLParameters.AddWithValue("@UpdatedUtc", Updated.ToUniversalTime());
		SqlParameter id = dbHelper.SQLParameters.Add("@ID", SqlDbType.BigInt);
		id.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[AssetVersionsV2_InsertAssetVersion]", CommandType.StoredProcedure);
		ID = Convert.ToInt64(id.Value);
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (AssetID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		if (AssetTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
		}
		if (VersionNumber == 0)
		{
			throw new ApplicationException("Required value not specified: VersionNumber.");
		}
		if (_Hash.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Hash.");
		}
		if (CreatorID == 0L)
		{
			throw new ApplicationException("Required value not specified: CreatorID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.SQLParameters.AddWithValue("@AssetID", AssetID);
		dbHelper.SQLParameters.AddWithValue("@AssetTypeID", AssetTypeID);
		dbHelper.SQLParameters.AddWithValue("@AssetHashID", AssetHashID);
		dbHelper.SQLParameters.AddWithValue("@VersionNumber", VersionNumber);
		dbHelper.SQLParameters.AddWithValue("@Hash", _Hash);
		SqlParameterCollection sQLParameters = dbHelper.SQLParameters;
		long? parentAssetVersionID = ParentAssetVersionID;
		sQLParameters.AddWithValue("@ParentAssetVersionID", parentAssetVersionID.HasValue ? ((object)parentAssetVersionID.GetValueOrDefault()) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@CreatorID", CreatorID);
		SqlParameterCollection sQLParameters2 = dbHelper.SQLParameters;
		parentAssetVersionID = CreatingUniverseID;
		sQLParameters2.AddWithValue("@CreatingUniverseID", parentAssetVersionID.HasValue ? ((object)parentAssetVersionID.GetValueOrDefault()) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@CreatedUtc", Created.ToUniversalTime());
		dbHelper.SQLParameters.AddWithValue("@UpdatedUtc", Updated.ToUniversalTime());
		dbHelper.ExecuteSQLScalar("[dbo].[AssetVersionsV2_UpdateAssetVersionByID]", CommandType.StoredProcedure);
	}

	private static AssetVersionDAL BuildDAL(SqlDataReader reader)
	{
		AssetVersionDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static AssetVersionDAL GetDALFromReader(SqlDataReader reader)
	{
		AssetVersionDAL dal = new AssetVersionDAL
		{
			ID = (long)reader["ID"],
			AssetID = (long)reader["AssetID"],
			AssetTypeID = (int)reader["AssetTypeID"],
			AssetHashID = (long)reader["AssetHashID"],
			VersionNumber = (int)reader["VersionNumber"],
			Hash = (string)reader["Hash"],
			ParentAssetVersionID = (reader["ParentAssetVersionID"].Equals(Convert.DBNull) ? null : ((long?)reader["ParentAssetVersionID"])),
			CreatorID = (long)reader["CreatorID"],
			CreatingUniverseID = (reader["CreatingUniverseID"].Equals(DBNull.Value) ? null : ((long?)reader["CreatingUniverseID"])),
			Created = DateTime.SpecifyKind((DateTime)reader["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)reader["UpdatedUtc"], DateTimeKind.Utc)
		};
		if (dal.Created == DateTime.MinValue)
		{
			return null;
		}
		return dal;
	}

	public static AssetVersionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetVersionsV2_GetAssetVersionByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static AssetVersionDAL Get(long assetId, int versionNumber)
	{
		if (assetId == 0L || versionNumber == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetID", assetId);
		dbHelper.SQLParameters.AddWithValue("@VersionNumber", versionNumber);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetVersionsV2_GetAssetVersionByAssetIDAndVersionNumber]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	private static List<AssetVersionDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<AssetVersionDAL> dals = new List<AssetVersionDAL>();
		while (reader.Read())
		{
			AssetVersionDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	public static ICollection<AssetVersionDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "[dbo].[AssetVersionsV2_GetAssetVersionsByIDs]"), ids, BuildDALCollection);
	}

	public static ICollection<long> GetAssetVersionIDs(long assetId)
	{
		if (assetId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetID", assetId);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetVersionsV2_GetAssetVersionIDsByAssetID]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	public static ICollection<long> GetAssetVersionIDsPaged(long assetID, int startRowIndex, int maximumRows)
	{
		return GetAssetVersionIDsPaged(AssetVersion.LookupFilter.AssetID, assetID, startRowIndex, maximumRows);
	}

	public static ICollection<long> GetAssetVersionIDsPaged(AssetVersion.LookupFilter lookupFilter, long id, int startRowIndex, int maximumRows)
	{
		string storedProcedure = lookupFilter switch
		{
			AssetVersion.LookupFilter.AssetHashID => "AssetVersionsV2_GetAssetVersionIDsByAssetHashID_Paged", 
			AssetVersion.LookupFilter.AssetID => "AssetVersionsV2_GetAssetVersionIDsByAssetID_Paged", 
			_ => throw new ApplicationException("Unknown SelectFilter: " + lookupFilter), 
		};
		if (id == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue($"@{lookupFilter}", id);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader($"[dbo].[{storedProcedure}]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	public static ICollection<long> GetAssetVersionIDsPaged(long assetId, int? exclusiveStartVersionNumber, int count, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		if (assetId == 0L)
		{
			return null;
		}
		if (exclusiveStartVersionNumber.HasValue && exclusiveStartVersionNumber.Value < 0)
		{
			throw new ArgumentOutOfRangeException("exclusiveStartVersionNumber", $"Invalid exclusive start version number: {exclusiveStartVersionNumber}");
		}
		if (count <= 0)
		{
			throw new ArgumentOutOfRangeException("count", $"Invalid count: {count}");
		}
		string sortSuffix = ((sortOrder == Roblox.DataV2.Core.SortOrder.Desc) ? "_Desc" : "");
		string storedProcedure = $"AssetVersionsV2_GetAssetVersionIDsByAssetID_ExclusiveStartPaging{sortSuffix}";
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetID", assetId);
		SqlParameterCollection sQLParameters = dbHelper.SQLParameters;
		int? num = exclusiveStartVersionNumber;
		sQLParameters.AddWithValue("@ExclusiveStartVersionNumber", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@Count", count);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader($"[dbo].[{storedProcedure}]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	public static int GetTotalNumberOfAssetVersions(long assetID)
	{
		return GetTotalNumberOfAssetVersions(AssetVersion.LookupFilter.AssetID, assetID);
	}

	public static int GetTotalNumberOfAssetVersions(AssetVersion.LookupFilter lookupFilter, long id)
	{
		string storedProcedure = lookupFilter switch
		{
			AssetVersion.LookupFilter.AssetHashID => "AssetVersionsV2_GetTotalNumberOfAssetVersionsByAssetHashID", 
			AssetVersion.LookupFilter.AssetID => "AssetVersionsV2_GetTotalNumberOfAssetVersionsByAssetID", 
			_ => throw new ApplicationException("Unknown SelectFilter: " + lookupFilter), 
		};
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue($"@{lookupFilter}", id);
		return Convert.ToInt32(dbHelper.ExecuteSQLScalar($"[dbo].[{storedProcedure}]", CommandType.StoredProcedure));
	}
}
