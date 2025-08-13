using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets.Entities;

internal class AssetProtectionOptionDAL
{
	private long _ID;

	private long _AssetId;

	private bool _IsCopyAllowed;

	private bool _IsUpdateAllowed;

	private DateTime _Created;

	private DateTime _Updated;

	internal long ID
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

	internal long AssetId
	{
		get
		{
			return _AssetId;
		}
		set
		{
			_AssetId = value;
		}
	}

	internal bool IsCopyAllowed
	{
		get
		{
			return _IsCopyAllowed;
		}
		set
		{
			_IsCopyAllowed = value;
		}
	}

	internal bool IsUpdateAllowed
	{
		get
		{
			return _IsUpdateAllowed;
		}
		set
		{
			_IsUpdateAllowed = value;
		}
	}

	internal DateTime Created
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

	internal DateTime Updated
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

	private static string _DbConnectionString => Settings.Default.DbConnectionString_RobloxAssets;

	internal void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "AssetProtectionOptions_DeleteAssetProtectionOptionByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AssetID", AssetId),
			new SqlParameter("@IsCopyAllowed", IsCopyAllowed),
			new SqlParameter("@IsUpdateAllowed", IsUpdateAllowed),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "AssetProtectionOptions_InsertAssetProtectionOption", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@AssetID", AssetId),
			new SqlParameter("@IsCopyAllowed", IsCopyAllowed),
			new SqlParameter("@IsUpdateAllowed", IsUpdateAllowed),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "AssetProtectionOptions_UpdateAssetProtectionOptionByID", queryParameters));
	}

	private static AssetProtectionOptionDAL BuildDAL(SqlDataReader reader)
	{
		AssetProtectionOptionDAL dal = new AssetProtectionOptionDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetId = (long)reader["AssetID"];
			dal.IsCopyAllowed = (bool)reader["IsCopyAllowed"];
			dal.IsUpdateAllowed = (bool)reader["IsUpdateAllowed"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static AssetProtectionOptionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "AssetProtectionOptions_GetAssetProtectionOptionByID", queryParameters), BuildDAL);
	}

	internal static AssetProtectionOptionDAL GetByAssetId(long assetId)
	{
		if (assetId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AssetID", assetId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "AssetProtectionOptions_GetAssetProtectionOptionByAssetID", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AssetProtectionOptionDAL> GetOrCreate(long assetId)
	{
		if (assetId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AssetID", assetId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "AssetProtectionOptions_GetOrCreateAssetProtectionOption", queryParameters), BuildDAL);
	}
}
