using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Billing;

public class SaleProductDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxBilling.GetConnectionString();

	public long ID { get; set; }

	public int SaleID { get; set; }

	public int ProductID { get; set; }

	public decimal ListPrice { get; set; }

	public decimal DiscountedPrice { get; set; }

	public long? RecipientAccountID { get; set; }

	public decimal? RecurringPrice { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public byte? CurrencyTypeID { get; set; }

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@ListPrice", ListPrice));
		queryParameters.Add(new SqlParameter("@DiscountedPrice", DiscountedPrice));
		queryParameters.Add(new SqlParameter("@RecipientAccountID", RecipientAccountID.HasValue ? ((object)RecipientAccountID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@RecurringPrice", RecurringPrice.HasValue ? ((object)RecurringPrice) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "SaleProducts_InsertSaleProduct", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@ListPrice", ListPrice));
		queryParameters.Add(new SqlParameter("@DiscountedPrice", DiscountedPrice));
		queryParameters.Add(new SqlParameter("@RecipientAccountID", RecipientAccountID.HasValue ? ((object)RecipientAccountID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@RecurringPrice", RecurringPrice.HasValue ? ((object)RecurringPrice) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "SaleProducts_UpdateSaleProductByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "SaleProducts_DeleteSaleProductByID", queryParameters));
	}

	public static SaleProductDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "SaleProducts_GetSaleProductByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetIDsBySaleID(int saleID)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleID", saleID));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[SaleProducts_GetSaleProductIDsBySaleID]", queryParameters));
	}

	private static SaleProductDAL BuildDAL(SqlDataReader reader)
	{
		SaleProductDAL dal = new SaleProductDAL();
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static SaleProductDAL GetDALFromReader(SqlDataReader reader)
	{
		SaleProductDAL dal = new SaleProductDAL
		{
			ID = (long)reader["ID"],
			SaleID = (int)reader["SaleID"],
			ProductID = (int)reader["ProductID"],
			ListPrice = (decimal)reader["ListPrice"],
			DiscountedPrice = (decimal)reader["DiscountedPrice"],
			RecipientAccountID = (reader["RecipientAccountID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["RecipientAccountID"]))),
			RecurringPrice = (reader["RecurringPrice"].Equals(DBNull.Value) ? null : ((decimal?)reader["RecurringPrice"])),
			CurrencyTypeID = (reader["CurrencyTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["CurrencyTypeID"])),
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static List<SaleProductDAL> BuildDalCollection(SqlDataReader reader)
	{
		List<SaleProductDAL> dals = new List<SaleProductDAL>();
		while (reader.Read())
		{
			SaleProductDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal static ICollection<SaleProductDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "SaleProducts_GetSaleProductsByIDs"), ids, BuildDalCollection);
	}

	internal static ICollection<long> GetSaleProductIDsBySaleIDPaged(int saleID, long startRowIndex, long maximumRows)
	{
		if (saleID == 0)
		{
			throw new ArgumentException("Parameter 'saleID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@SaleID", saleID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[SaleProducts_GetSaleProductIDsBySaleID_Paged]", queryParameters));
	}

	internal static long GetTotalNumberOfSaleProductsBySaleID(int saleID)
	{
		if (saleID == 0)
		{
			throw new ArgumentException("Parameter 'saleID' cannot be null, empty or the default value.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@SaleID", saleID)
		};
		return EntityHelper.GetDataCount<long>(new DbInfo(ConnectionString, "dbo.SaleProducts_GetTotalNumberOfSaleProductsBySaleID", queryParameters));
	}
}
