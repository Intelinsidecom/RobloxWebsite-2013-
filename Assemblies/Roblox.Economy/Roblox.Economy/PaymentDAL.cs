using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common.Properties;

namespace Roblox.Economy;

public class PaymentDAL
{
	internal long ID { get; set; }

	internal long SaleID { get; set; }

	internal long UnitPrice { get; set; }

	internal int CurrencyTypeID { get; set; }

	internal byte PaymentStatusTypeID { get; set; }

	internal DateTime PaymentDate { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.DBConnectionString;

	private static PaymentDAL GetDALFromReader(SqlDataReader reader)
	{
		PaymentDAL dal = new PaymentDAL
		{
			ID = (long)reader["ID"],
			SaleID = (long)reader["SaleID"],
			UnitPrice = (long)reader["UnitPrice"],
			CurrencyTypeID = (int)reader["CurrencyTypeID"],
			PaymentStatusTypeID = (byte)reader["PaymentStatusTypeID"],
			PaymentDate = (DateTime)reader["PaymentDate"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static PaymentDAL BuildDAL(SqlDataReader reader)
	{
		PaymentDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PaymentDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PaymentDAL> dals = new List<PaymentDAL>();
		while (reader.Read())
		{
			PaymentDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "Payments_DeletePaymentByID", queryParameters));
	}

	internal static PaymentDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "Payments_GetPaymentByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@UnitPrice", UnitPrice),
			new SqlParameter("@CurrencyTypeID", CurrencyTypeID),
			new SqlParameter("@PaymentStatusTypeID", PaymentStatusTypeID),
			new SqlParameter("@PaymentDate", PaymentDate),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "Payments_InsertPayment", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@UnitPrice", UnitPrice),
			new SqlParameter("@CurrencyTypeID", CurrencyTypeID),
			new SqlParameter("@PaymentStatusTypeID", PaymentStatusTypeID),
			new SqlParameter("@PaymentDate", PaymentDate),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "Payments_UpdatePaymentByID", queryParameters));
	}

	internal static ICollection<PaymentDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "Payments_GetPaymentsByIDs"), ids, BuildDALCollection);
	}

	internal static ICollection<long> GetPaymentIDsBySaleIDPaged(long saleID, long startRowIndex, long maximumRows)
	{
		if (saleID == 0L)
		{
			throw new ApplicationException("Required value not specified: saleID");
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
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "Payments_GetPaymentIDsBySaleID_Paged", queryParameters));
	}

	internal static long GetTotalNumberOfPaymentsBySaleID(long saleID)
	{
		if (saleID == 0L)
		{
			throw new ApplicationException("Required value not specified: saleID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@SaleID", saleID)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "Payments_GetTotalNumberOfPaymentsBySaleID", queryParameters));
	}
}
