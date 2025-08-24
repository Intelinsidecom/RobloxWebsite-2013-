using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Economy;

public class SaleHoldDAL
{
	private long _ID;

	internal long SaleID;

	internal string RobuxHoldID;

	internal string TicketsHoldID;

	internal long ProductID;

	internal long? PriceInTickets;

	internal long? PriceInRobux;

	internal DateTime Created;

	internal DateTime Updated;

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

	private static string dbConnectionString_SaleHoldDAL => RobloxDatabase.RobloxEconomy.GetConnectionString();

	internal SaleHoldDAL()
	{
	}

	private static SaleHoldDAL BuildDAL(SqlDataReader reader)
	{
		SaleHoldDAL dal = new SaleHoldDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt64(reader["ID"]);
			dal.SaleID = (long)reader["SaleID"];
			dal.RobuxHoldID = reader["RobuxHoldID"] as string;
			dal.TicketsHoldID = reader["TicketsHoldID"] as string;
			dal.ProductID = (long)reader["ProductID"];
			dal.PriceInTickets = (reader["PriceInTickets"].Equals(DBNull.Value) ? null : ((long?)reader["PriceInTickets"]));
			dal.PriceInRobux = (reader["PriceInRobux"].Equals(DBNull.Value) ? null : ((long?)reader["PriceInRobux"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@RobuxHoldID", string.IsNullOrEmpty(RobuxHoldID) ? ((IConvertible)DBNull.Value) : ((IConvertible)RobuxHoldID)));
		queryParameters.Add(new SqlParameter("@TicketsHoldID", string.IsNullOrEmpty(TicketsHoldID) ? ((IConvertible)DBNull.Value) : ((IConvertible)TicketsHoldID)));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@PriceInTickets", PriceInTickets.HasValue ? ((object)PriceInTickets) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@PriceInRobux", PriceInRobux.HasValue ? ((object)PriceInRobux) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_SaleHoldDAL, "SaleHolds_InsertSaleHold", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@RobuxHoldID", string.IsNullOrEmpty(RobuxHoldID) ? ((IConvertible)DBNull.Value) : ((IConvertible)RobuxHoldID)));
		queryParameters.Add(new SqlParameter("@TicketsHoldID", string.IsNullOrEmpty(TicketsHoldID) ? ((IConvertible)DBNull.Value) : ((IConvertible)TicketsHoldID)));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@PriceInTickets", PriceInTickets.HasValue ? ((object)PriceInTickets) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@PriceInRobux", PriceInRobux.HasValue ? ((object)PriceInRobux) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_SaleHoldDAL, "SaleHolds_UpdateSaleHoldByID", queryParameters));
	}

	internal void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALAction(new DbInfo(dbConnectionString_SaleHoldDAL, "SaleHolds_DeleteSaleHoldByID", queryParameters));
	}

	internal static SaleHoldDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_SaleHoldDAL, "SaleHolds_GetSaleHoldByID", queryParameters), BuildDAL);
	}

	internal static SaleHoldDAL Get_NoLock(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_SaleHoldDAL, "SaleHoldsV2_GetSaleHoldByID_NoLock", queryParameters), BuildDAL);
	}

	internal static SaleHoldDAL GetByRobuxHoldID(string robuxHoldID)
	{
		if (string.IsNullOrEmpty(robuxHoldID))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@RobuxHoldID", robuxHoldID));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_SaleHoldDAL, "SaleHolds_GetSaleHoldByRobuxHoldID", queryParameters), BuildDAL);
	}

	internal static SaleHoldDAL GetByRobuxHoldID_NoLock(string robuxHoldID)
	{
		if (string.IsNullOrEmpty(robuxHoldID))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@RobuxHoldID", robuxHoldID));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_SaleHoldDAL, "SaleHoldsV2_GetSaleHoldByRobuxHoldID_NoLock", queryParameters), BuildDAL);
	}

	internal static SaleHoldDAL GetByTicketsHoldID(string ticketsHoldID)
	{
		if (string.IsNullOrEmpty(ticketsHoldID))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@TicketsHoldID", ticketsHoldID));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_SaleHoldDAL, "SaleHolds_GetSaleHoldByTicketsHoldID", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetSaleHoldIDsByProductID(long ProductID)
	{
		if (ProductID == 0L)
		{
			throw new ApplicationException("Required value not specified: ProductID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_SaleHoldDAL, "SaleHolds_GetSaleHoldIDsByProductID", queryParameters));
	}

	internal static ICollection<long> GetSaleHoldIDsByProductID(long productID, int count, long exclusiveStartSaleHoldID)
	{
		if (productID == 0L)
		{
			throw new ApplicationException("Required value not specified: ProductID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", productID));
		queryParameters.Add(new SqlParameter("@Count", count));
		queryParameters.Add(new SqlParameter("@ExclusiveStartSaleHoldID", exclusiveStartSaleHoldID));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_SaleHoldDAL, "SaleHolds_GetSaleHoldIDsByProductIDAsc", queryParameters));
	}
}
