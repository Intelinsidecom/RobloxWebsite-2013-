using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class DeveloperProductDAL
{
	private long _ID;

	private long _ShopID;

	private string _Name;

	private string _Description;

	private long? _IconImageAssetID;

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

	internal long ShopID
	{
		get
		{
			return _ShopID;
		}
		set
		{
			_ShopID = value;
		}
	}

	internal string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			_Name = value;
		}
	}

	internal string Description
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

	internal long? IconImageAssetID
	{
		get
		{
			return _IconImageAssetID;
		}
		set
		{
			_IconImageAssetID = value;
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

	private static string _DbConnectionString => Helper.DBConnectionString_DeveloperProducts;

	internal DeveloperProductDAL()
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "DeveloperProducts_DeleteDeveloperProductByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ShopID", ShopID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Description", string.IsNullOrEmpty(Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Description)),
			new SqlParameter("@IconImageAssetID", IconImageAssetID.HasValue ? ((object)IconImageAssetID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "DeveloperProducts_InsertDeveloperProduct", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@ShopID", ShopID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Description", string.IsNullOrEmpty(Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Description)),
			new SqlParameter("@IconImageAssetID", IconImageAssetID.HasValue ? ((object)IconImageAssetID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "DeveloperProducts_UpdateDeveloperProductByID", queryParameters));
	}

	private static DeveloperProductDAL BuildDAL(SqlDataReader reader)
	{
		DeveloperProductDAL dal = new DeveloperProductDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ShopID = (long)reader["ShopID"];
			dal.Name = (string)reader["Name"];
			dal.Description = (reader["Description"].Equals(DBNull.Value) ? null : ((string)reader["Description"]));
			dal.IconImageAssetID = (reader["IconImageAssetID"].Equals(DBNull.Value) ? null : ((long?)reader["IconImageAssetID"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static DeveloperProductDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "DeveloperProducts_GetDeveloperProductByID", queryParameters), BuildDAL);
	}

	internal static DeveloperProductDAL GetByShopIDAndName(long shopId, string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		if (shopId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ShopID", shopId),
			new SqlParameter("@Name", name)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "DeveloperProducts_GetDeveloperProductByShopIDAndName", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetDeveloperProductIDsByShopID_Paged(long shopId, long startRowIndex, long maxRows)
	{
		if (shopId == 0L)
		{
			throw new ApplicationException("Required value not specified: shopId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ShopID", shopId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "DeveloperProducts_GetDeveloperProductIDsByShopID_Paged", queryParameters));
	}

	internal static long GetTotalNumberOfDeveloperProductsByShopID(long shopId)
	{
		if (shopId == 0L)
		{
			throw new ApplicationException("Required value not specified: shopId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ShopID", shopId));
		return EntityHelper.GetDataCount<long>(new DbInfo(_DbConnectionString, "DeveloperProducts_GetTotalNumberOfDeveloperProductsByShopID", queryParameters));
	}
}
