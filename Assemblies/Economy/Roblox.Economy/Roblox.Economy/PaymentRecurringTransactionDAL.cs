using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common.Properties;

namespace Roblox.Economy;

public class PaymentRecurringTransactionDAL
{
	internal long ID { get; set; }

	internal long PaymentID { get; set; }

	internal string RecurringTransactionID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.DBConnectionString;

	internal PaymentRecurringTransactionDAL()
	{
	}

	private static PaymentRecurringTransactionDAL GetDALFromReader(SqlDataReader reader)
	{
		PaymentRecurringTransactionDAL dal = new PaymentRecurringTransactionDAL
		{
			ID = (long)reader["ID"],
			PaymentID = (long)reader["PaymentID"],
			RecurringTransactionID = (string)reader["RecurringTransactionID"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static PaymentRecurringTransactionDAL BuildDAL(SqlDataReader reader)
	{
		PaymentRecurringTransactionDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PaymentRecurringTransactionDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PaymentRecurringTransactionDAL> dals = new List<PaymentRecurringTransactionDAL>();
		while (reader.Read())
		{
			PaymentRecurringTransactionDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PaymentRecurringTransactions_DeletePaymentRecurringTransactionByID", queryParameters));
	}

	internal static PaymentRecurringTransactionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PaymentRecurringTransactions_GetPaymentRecurringTransactionByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@PaymentID", PaymentID),
			new SqlParameter("@RecurringTransactionID", RecurringTransactionID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PaymentRecurringTransactions_InsertPaymentRecurringTransaction", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PaymentID", PaymentID),
			new SqlParameter("@RecurringTransactionID", RecurringTransactionID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PaymentRecurringTransactions_UpdatePaymentRecurringTransactionByID", queryParameters));
	}

	internal static ICollection<PaymentRecurringTransactionDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "PaymentRecurringTransactions_GetPaymentRecurringTransactionsByIDs"), ids, BuildDALCollection);
	}

	internal static PaymentRecurringTransactionDAL GetPaymentRecurringTransactionByPaymentID(long paymentID)
	{
		if (paymentID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PaymentID", paymentID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PaymentRecurringTransactions_GetPaymentRecurringTransactionByPaymentID", queryParameters), BuildDAL);
	}

	internal static PaymentRecurringTransactionDAL GetPaymentRecurringTransactionByRecurringTransactionID(string recurringTransactionID)
	{
		if (string.IsNullOrEmpty(recurringTransactionID))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@RecurringTransactionID", recurringTransactionID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PaymentRecurringTransactions_GetPaymentRecurringTransactionByRecurringTransactionID", queryParameters), BuildDAL);
	}
}
