using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Billing;

public class SaleDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxBilling.GetConnectionString();

	public int ID { get; set; }

	public byte SaleStatusTypeID { get; set; }

	public long? PurchaserAccountID { get; set; }

	public decimal ListPriceTotal { get; set; }

	public decimal DiscountedPriceTotal { get; set; }

	public decimal? RecurringPrice { get; set; }

	public DateTime? RenewalDate { get; set; }

	public byte? CurrencyTypeID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public static SaleDAL BuildDAL(SqlDataReader reader)
	{
		SaleDAL dal = new SaleDAL();
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	public static SaleDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[Sales_GetSaleByID]", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetSaleIDsByPurchaserAccountID(long purchaserAccountId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PurchaserAccountID", purchaserAccountId)
		};
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[Sales_GetSaleIDsByPurchaserAccountID]", queryParameters));
	}

	public static ICollection<int> GetSaleIDsByPurchaserAccountIDAndSaleStatusTypeID(long purchaserAccountId, byte saleStatusTypeID)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PurchaserAccountID", purchaserAccountId),
			new SqlParameter("@SaleStatusTypeID", saleStatusTypeID)
		};
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[Sales_GetSaleIDsByPurchaserAccountIDAndSaleStatusTypeID]", queryParameters));
	}

	internal static int GetTotalNumberOfSalesByPurchaserAccountID(long? purchaserAccountID)
	{
		if (purchaserAccountID == 0)
		{
			throw new ArgumentException("Parameter 'purchaserAccountID' cannot be null, empty or the default value.");
		}
		SqlParameter[] array = new SqlParameter[1];
		long? num = purchaserAccountID;
		array[0] = new SqlParameter("@PurchaserAccountID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = array;
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "dbo.Sales_GetTotalNumberOfSalesByPurchaserAccountID", queryParameters));
	}

	internal static int GetTotalNumberOfSalesBySaleStatusTypeIDAndPurchaserAccountID(byte saleStatusTypeID, long? purchaserAccountID)
	{
		if (saleStatusTypeID == 0)
		{
			throw new ArgumentException("Parameter 'saleStatusTypeID' cannot be null, empty or the default value.");
		}
		if (purchaserAccountID == 0)
		{
			throw new ArgumentException("Parameter 'purchaserAccountID' cannot be null, empty or the default value.");
		}
		SqlParameter[] obj = new SqlParameter[2]
		{
			new SqlParameter("@SaleStatusTypeID", saleStatusTypeID),
			null
		};
		long? num = purchaserAccountID;
		obj[1] = new SqlParameter("@PurchaserAccountID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "dbo.Sales_GetTotalNumberOfSalesBySaleStatusTypeIDAndPurchaserAccountID", queryParameters));
	}

	public static ICollection<SaleDAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "Sales_GetSalesByIDs"), ids, BuildDalCollection);
	}

	private static SaleDAL GetDALFromReader(SqlDataReader reader)
	{
		SaleDAL dal = new SaleDAL
		{
			ID = (int)reader["ID"],
			SaleStatusTypeID = (byte)reader["SaleStatusTypeID"],
			PurchaserAccountID = (reader["PurchaserAccountID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["PurchaserAccountID"]))),
			ListPriceTotal = (decimal)reader["ListPriceTotal"],
			DiscountedPriceTotal = (decimal)reader["DiscountedPriceTotal"],
			RecurringPrice = (reader["RecurringPrice"].Equals(DBNull.Value) ? null : ((decimal?)reader["RecurringPrice"])),
			RenewalDate = (reader["RenewalDate"].Equals(DBNull.Value) ? null : ((DateTime?)reader["RenewalDate"])),
			CurrencyTypeID = (reader["CurrencyTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["CurrencyTypeID"])),
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static List<SaleDAL> BuildDalCollection(SqlDataReader reader)
	{
		List<SaleDAL> dals = new List<SaleDAL>();
		while (reader.Read())
		{
			SaleDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal static ICollection<int> GetSaleIDsByPurchaserAccountIDPaged(long? purchaserAccountID, int startRowIndex, int maximumRows)
	{
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] array = new SqlParameter[3];
		long? num = purchaserAccountID;
		array[0] = new SqlParameter("@PurchaserAccountID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		array[1] = new SqlParameter("@StartRowIndex", startRowIndex);
		array[2] = new SqlParameter("@MaximumRows", maximumRows);
		SqlParameter[] queryParameters = array;
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[Sales_GetSaleIDsByPurchaserAccountID_Paged]", queryParameters));
	}

	public static ICollection<int> GetSaleIDsByPurchaserAccountIDAndSaleStatusTypeID_Paged(long? purchaserAccountId, byte saleStatusTypeID, int startRowIndex, int maximumRows)
	{
		List<SqlParameter> list = new List<SqlParameter>();
		long? num = purchaserAccountId;
		list.Add(new SqlParameter("@PurchaserAccountID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value));
		list.Add(new SqlParameter("@SaleStatusTypeID", saleStatusTypeID));
		list.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		list.Add(new SqlParameter("@MaximumRows", maximumRows));
		List<SqlParameter> queryParameters = list;
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[Sales_GetSaleIDsByPurchaserAccountIDAndSaleStatusTypeID_Paged]", queryParameters));
	}

	public static ICollection<int> GetSaleIDsUpForRenewal()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[Sales_GetSaleIDsUpForRenewal]", queryParameters));
	}

	public static ICollection<int> GetRecurringSaleIDsUpForRenewal(int count, int exclusiveStartSaleID)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Count", count));
		queryParameters.Add(new SqlParameter("@ExclusiveStartSaleID", exclusiveStartSaleID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[Sales_GetRecurringSaleIDsUpForRenewal]", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "Sales_DeleteSaleByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> obj = new List<SqlParameter>
		{
			new SqlParameter("@SaleStatusTypeID", SaleStatusTypeID)
		};
		long? purchaserAccountID = PurchaserAccountID;
		obj.Add(new SqlParameter("@PurchaserAccountID", purchaserAccountID.HasValue ? ((object)purchaserAccountID.GetValueOrDefault()) : DBNull.Value));
		obj.Add(new SqlParameter("@ListPriceTotal", ListPriceTotal));
		obj.Add(new SqlParameter("@DiscountedPriceTotal", DiscountedPriceTotal));
		decimal? recurringPrice = RecurringPrice;
		obj.Add(new SqlParameter("@RecurringPrice", recurringPrice.HasValue ? ((object)recurringPrice.GetValueOrDefault()) : DBNull.Value));
		DateTime? renewalDate = RenewalDate;
		obj.Add(new SqlParameter("@RenewalDate", renewalDate.HasValue ? ((object)renewalDate.GetValueOrDefault()) : DBNull.Value));
		byte? currencyTypeID = CurrencyTypeID;
		obj.Add(new SqlParameter("@CurrencyTypeID", currencyTypeID.HasValue ? ((object)currencyTypeID.GetValueOrDefault()) : DBNull.Value));
		obj.Add(new SqlParameter("@Created", Created));
		obj.Add(new SqlParameter("@Updated", Updated));
		List<SqlParameter> queryParameters = obj;
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "[dbo].[Sales_InsertSale]", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> obj = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SaleStatusTypeID", SaleStatusTypeID)
		};
		long? purchaserAccountID = PurchaserAccountID;
		obj.Add(new SqlParameter("@PurchaserAccountID", purchaserAccountID.HasValue ? ((object)purchaserAccountID.GetValueOrDefault()) : DBNull.Value));
		obj.Add(new SqlParameter("@ListPriceTotal", ListPriceTotal));
		obj.Add(new SqlParameter("@DiscountedPriceTotal", DiscountedPriceTotal));
		decimal? recurringPrice = RecurringPrice;
		obj.Add(new SqlParameter("@RecurringPrice", recurringPrice.HasValue ? ((object)recurringPrice.GetValueOrDefault()) : DBNull.Value));
		DateTime? renewalDate = RenewalDate;
		obj.Add(new SqlParameter("@RenewalDate", renewalDate.HasValue ? ((object)renewalDate.GetValueOrDefault()) : DBNull.Value));
		byte? currencyTypeID = CurrencyTypeID;
		obj.Add(new SqlParameter("@CurrencyTypeID", currencyTypeID.HasValue ? ((object)currencyTypeID.GetValueOrDefault()) : DBNull.Value));
		obj.Add(new SqlParameter("@Created", Created));
		obj.Add(new SqlParameter("@Updated", Updated));
		List<SqlParameter> queryParameters = obj;
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[Sales_UpdateSaleByID]", queryParameters));
	}
}
