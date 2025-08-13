using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Moderation.Properties;

namespace Roblox.Platform.Moderation;

public class WatchDogWhitelistedAssetHashDAL
{
	private long _ID;

	private long _AssetHashID;

	private DateTime _Created;

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

	internal long AssetHashID
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

	private static string _DbConnectionString => Settings.Default.ModerationNewConnectionString;

	internal WatchDogWhitelistedAssetHashDAL()
	{
	}

	private static WatchDogWhitelistedAssetHashDAL BuildDAL(SqlDataReader reader)
	{
		WatchDogWhitelistedAssetHashDAL dal = new WatchDogWhitelistedAssetHashDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetHashID = (long)reader["AssetHashID"];
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
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "WatchDogWhitelistedAssetHashes_DeleteWatchDogWhitelistedAssetHashByID", queryParameters));
	}

	internal static WatchDogWhitelistedAssetHashDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "WatchDogWhitelistedAssetHashes_GetWatchDogWhitelistedAssetHashByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@AssetHashID", AssetHashID),
			new SqlParameter("@Created", Created)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "WatchDogWhitelistedAssetHashes_InsertWatchDogWhitelistedAssetHash", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@AssetHashID", AssetHashID),
			new SqlParameter("@Created", Created)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "WatchDogWhitelistedAssetHashes_UpdateWatchDogWhitelistedAssetHashByID", queryParameters));
	}

	internal static WatchDogWhitelistedAssetHashDAL GetWatchDogWhitelistedAssetHashByAssetHashID(long assetHashID)
	{
		if (assetHashID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AssetHashID", assetHashID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "WatchDogWhitelistedAssetHashes_GetWatchDogWhitelistedAssetHashByAssetHashID", queryParameters), BuildDAL);
	}
}
