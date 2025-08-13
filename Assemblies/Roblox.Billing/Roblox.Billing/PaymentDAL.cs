using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class PaymentDAL
{
	public long ID;

	public int SaleID;

	public byte PaymentProviderTypeID;

	public byte PaymentStatusTypeID;

	public DateTime PaymentDate = DateTime.MinValue;

	public decimal Amount;

	public byte? CurrencyTypeID;

	public DateTime Created = DateTime.MinValue;

	public DateTime Updated = DateTime.MinValue;

	public static readonly string DBConnectionString = Settings.Default.BillingConnectionString;

	public static PaymentDAL BuildDAL(SqlDataReader reader)
	{
		PaymentDAL dal = new PaymentDAL();
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PaymentDAL> BuildDalCollection(SqlDataReader reader)
	{
		List<PaymentDAL> dals = new List<PaymentDAL>();
		while (reader.Read())
		{
			PaymentDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	private static PaymentDAL GetDALFromReader(SqlDataReader reader)
	{
		PaymentDAL dal = new PaymentDAL
		{
			ID = (long)reader["ID"],
			SaleID = (int)reader["SaleID"],
			PaymentProviderTypeID = (byte)reader["PaymentProviderTypeID"],
			PaymentStatusTypeID = (byte)reader["PaymentStatusTypeID"],
			PaymentDate = (DateTime)reader["PaymentDate"],
			Amount = (decimal)reader["Amount"],
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

	internal void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(DBConnectionString, "Payments_DeletePaymentByID", queryParameters));
	}

	internal static long GetTotalNumberOfPaymentsBySaleID(int saleID)
	{
		if (saleID == 0)
		{
			throw new ArgumentException("Parameter 'saleID' cannot be null, empty or the default value.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@SaleID", saleID)
		};
		return EntityHelper.GetDataCount<long>(new DbInfo(DBConnectionString, "dbo.Payments_GetTotalNumberOfPaymentsBySaleID", queryParameters));
	}

	internal static ICollection<long> GetPaymentIDsBySaleIDPaged(int saleID, long startRowIndex, long maximumRows)
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
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(DBConnectionString, "[dbo].[Payments_GetPaymentIDsBySaleID_Paged]", queryParameters));
	}

	internal static ICollection<long> GetPaymentIDsBySaleIDPagedPaymentDateAsc(int saleID, long startRowIndex, long maximumRows)
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
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(DBConnectionString, "[dbo].[Payments_GetPaymentIDsBySaleID_Paged_PaymentDateAsc]", queryParameters));
	}

	internal static ICollection<PaymentDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(DBConnectionString, "Payments_GetPaymentsByIDs"), ids, BuildDalCollection);
	}

	public static PaymentDAL Get(long id)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(DBConnectionString, "[dbo].[Payments_GetPaymentByID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetPaymentIDsBySaleID(int SaleID)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(DBConnectionString, "[dbo].[Payments_GetPaymentIDsBySaleID]", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@PaymentProviderTypeID", PaymentProviderTypeID));
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", PaymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@PaymentDate", PaymentDate));
		queryParameters.Add(new SqlParameter("@Amount", Amount));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(DBConnectionString, "[dbo].[Payments_InsertPayment]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@PaymentProviderTypeID", PaymentProviderTypeID));
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", PaymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@PaymentDate", PaymentDate));
		queryParameters.Add(new SqlParameter("@Amount", Amount));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(DBConnectionString, "[dbo].[Payments_UpdatePaymentByID]", queryParameters));
	}
}
