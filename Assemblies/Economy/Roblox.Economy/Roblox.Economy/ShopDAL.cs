using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class ShopDAL
{
	private long _ID;

	private long _CreatorTargetID;

	private int _CreatorTypeID;

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

	internal long CreatorTargetID
	{
		get
		{
			return _CreatorTargetID;
		}
		set
		{
			_CreatorTargetID = value;
		}
	}

	internal int CreatorTypeID
	{
		get
		{
			return _CreatorTypeID;
		}
		set
		{
			_CreatorTypeID = value;
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

	private static string _DbConnectionString => Helper.DBConnectionString_Shops;

	internal ShopDAL()
	{
	}

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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "Shops_DeleteShopByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@CreatorTargetID", CreatorTargetID),
			new SqlParameter("@CreatorTypeID", CreatorTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "Shops_InsertShop", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@CreatorTargetID", CreatorTargetID),
			new SqlParameter("@CreatorTypeID", CreatorTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "Shops_UpdateShopByID", queryParameters));
	}

	private static ShopDAL BuildDAL(SqlDataReader reader)
	{
		ShopDAL dal = new ShopDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.CreatorTargetID = (long)reader["CreatorTargetID"];
			dal.CreatorTypeID = (int)reader["CreatorTypeID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static ShopDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "Shops_GetShopByID", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetShopIDsByCreatorTypeIDAndCreatorTargetID_Paged(int creatorTypeId, long creatorTargetId, long startRowIndex, long maxRows)
	{
		if (creatorTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: creatorTypeId.");
		}
		if (creatorTargetId == 0L)
		{
			throw new ApplicationException("Required value not specified: creatorTargetId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CreatorTypeID", creatorTypeId));
		queryParameters.Add(new SqlParameter("@CreatorTargetID", creatorTargetId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "Shops_GetShopIDsByCreatorTypeIDAndCreatorTargetID_Paged", queryParameters));
	}

	internal static long GetTotalNumberOfShopsByCreatorTypeIDAndCreatorTargetID(int creatorTypeId, long creatorTargetId)
	{
		if (creatorTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: creatorTypeId.");
		}
		if (creatorTargetId == 0L)
		{
			throw new ApplicationException("Required value not specified: creatorTargetId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CreatorTypeID", creatorTypeId));
		queryParameters.Add(new SqlParameter("@CreatorTargetID", creatorTargetId));
		return EntityHelper.GetDataCount<long>(new DbInfo(_DbConnectionString, "Shops_GetTotalNumberOfShopsByCreatorTypeIDAndCreatorTargetID", queryParameters));
	}
}
