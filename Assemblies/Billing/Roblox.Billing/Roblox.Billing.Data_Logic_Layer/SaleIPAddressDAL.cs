using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing.Data_Logic_Layer;

public class SaleIPAddressDAL
{
	private int _ID;

	private int _SaleID;

	private int _IPAddressID;

	private DateTime _Created;

	private DateTime _Updated;

	internal int ID
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

	internal int SaleID
	{
		get
		{
			return _SaleID;
		}
		set
		{
			_SaleID = value;
		}
	}

	internal int IPAddressID
	{
		get
		{
			return _IPAddressID;
		}
		set
		{
			_IPAddressID = value;
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

	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	internal void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "SaleIPAddresses_DeleteSaleIPAddressByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@IPAddressID", IPAddressID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "SaleIPAddresses_InsertSaleIPAddress", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@IPAddressID", IPAddressID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "SaleIPAddresses_UpdateSaleIPAddressByID", queryParameters));
	}

	private static SaleIPAddressDAL BuildDAL(SqlDataReader reader)
	{
		SaleIPAddressDAL dal = new SaleIPAddressDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.SaleID = (int)reader["SaleID"];
			dal.IPAddressID = (int)reader["IPAddressID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static SaleIPAddressDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "SaleIPAddresses_GetSaleIPAddressByID", queryParameters), BuildDAL);
	}

	internal static SaleIPAddressDAL GetSaleIPAddressBySaleID(int saleID)
	{
		if (saleID == 0)
		{
			throw new ApplicationException("Required value not specified: SaleID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@SaleID", saleID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "SaleIPAddresses_GetSaleIPAddressBySaleID", queryParameters), BuildDAL);
	}

	internal static ICollection<int> GetSaleIPAddressIDsByIPAddressID_Paged(int ipAddressID, int startRowIndex, int maximumRows)
	{
		if (ipAddressID == 0)
		{
			throw new ApplicationException("Required value not specified: ipAddressID.");
		}
		if (maximumRows == 0)
		{
			throw new ApplicationException("Required value not specified: maximumRows.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: startRowIndex.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@IPAddressID", ipAddressID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "SaleIPAddresses_GetSaleIPAddressIDsByIPAddressID_Paged", queryParameters));
	}

	internal static int GetTotalNumberOfSaleIPAddressIDsByIPAddressIDAndCreatedOnOrAfter(int ipAddressID, DateTime startDate)
	{
		if (startDate == default(DateTime))
		{
			throw new ApplicationException("Required value not specified: startDate.");
		}
		if (ipAddressID == 0)
		{
			throw new ApplicationException("Required value not specified: ipAddressID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@IPAddressID", ipAddressID),
			new SqlParameter("@CreatedOnOrAfter", startDate)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "[dbo].[SaleIPAddresses_GetTotalNumberOfSaleIPAddressIDsByIPAddressIDAndCreatedOnOrAfter]", queryParameters));
	}
}
