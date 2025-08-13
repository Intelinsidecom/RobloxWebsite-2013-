using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Assets.Properties;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Assets;

public class MarketingBoostDAL
{
	private long _ID;

	private long _AssetID;

	private long _BoostAmount;

	private DateTime _StartDate;

	private DateTime _EndDate;

	private DateTime _Created;

	private DateTime _Updated;

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

	public long AssetID
	{
		get
		{
			return _AssetID;
		}
		set
		{
			_AssetID = value;
		}
	}

	public long BoostAmount
	{
		get
		{
			return _BoostAmount;
		}
		set
		{
			_BoostAmount = value;
		}
	}

	public DateTime StartDate
	{
		get
		{
			return _StartDate;
		}
		set
		{
			_StartDate = value;
		}
	}

	public DateTime EndDate
	{
		get
		{
			return _EndDate;
		}
		set
		{
			_EndDate = value;
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

	private static string _DbConnectionString => Settings.Default.AssetsDB;

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "MarketingBoosts_DeleteMarketingBoostByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@BoostAmount", BoostAmount),
			new SqlParameter("@StartDate", StartDate),
			new SqlParameter("@EndDate", EndDate),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "MarketingBoosts_InsertMarketingBoost", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@BoostAmount", BoostAmount),
			new SqlParameter("@StartDate", StartDate),
			new SqlParameter("@EndDate", EndDate),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "MarketingBoosts_UpdateMarketingBoostByID", queryParameters));
	}

	private static MarketingBoostDAL BuildDAL(SqlDataReader reader)
	{
		MarketingBoostDAL dal = new MarketingBoostDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.BoostAmount = (long)reader["BoostAmount"];
			dal.StartDate = (DateTime)reader["StartDate"];
			dal.EndDate = (DateTime)reader["EndDate"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static MarketingBoostDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "MarketingBoosts_GetMarketingBoostByID", queryParameters), BuildDAL);
	}

	public static MarketingBoostDAL GetMarketingBoostByAssetID(long assetID)
	{
		if (assetID == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AssetID", assetID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "MarketingBoosts_GetMarketingBoostByAssetID", queryParameters), BuildDAL);
	}
}
