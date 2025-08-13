using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.CurrencyBudgets.Entities;

internal class CurrencyBudgetTransactionDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxCurrencyBudgets;

	internal long ID { get; set; }

	internal long CurrencyBudgetID { get; set; }

	internal long Delta { get; set; }

	internal int CurrencyBudgetTransactionTypeID { get; set; }

	internal long CurrencyBudgetTransactionTargetID { get; set; }

	internal DateTime Created { get; set; }

	private static CurrencyBudgetTransactionDAL BuildDAL(IDictionary<string, object> record)
	{
		return new CurrencyBudgetTransactionDAL
		{
			ID = (long)record["ID"],
			CurrencyBudgetID = (long)record["CurrencyBudgetID"],
			Delta = (long)record["Delta"],
			CurrencyBudgetTransactionTypeID = (int)record["CurrencyBudgetTransactionTypeID"],
			CurrencyBudgetTransactionTargetID = (long)record["CurrencyBudgetTransactionTargetID"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxCurrencyBudgets.Delete("CurrencyBudgetTransactions_DeleteCurrencyBudgetTransactionByID", ID);
	}

	internal static CurrencyBudgetTransactionDAL Get(long id)
	{
		return RobloxDatabase.RobloxCurrencyBudgets.Get("CurrencyBudgetTransactions_GetCurrencyBudgetTransactionByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@CurrencyBudgetID", CurrencyBudgetID),
			new SqlParameter("@Delta", Delta),
			new SqlParameter("@CurrencyBudgetTransactionTypeID", CurrencyBudgetTransactionTypeID),
			new SqlParameter("@CurrencyBudgetTransactionTargetID", CurrencyBudgetTransactionTargetID),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxCurrencyBudgets.Insert<long>("CurrencyBudgetTransactions_InsertCurrencyBudgetTransaction", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@CurrencyBudgetID", CurrencyBudgetID),
			new SqlParameter("@Delta", Delta),
			new SqlParameter("@CurrencyBudgetTransactionTypeID", CurrencyBudgetTransactionTypeID),
			new SqlParameter("@CurrencyBudgetTransactionTargetID", CurrencyBudgetTransactionTargetID),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxCurrencyBudgets.Update("CurrencyBudgetTransactions_UpdateCurrencyBudgetTransactionByID", queryParameters);
	}

	internal static ICollection<CurrencyBudgetTransactionDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxCurrencyBudgets.MultiGet("CurrencyBudgetTransactions_GetCurrencyBudgetTransactionsByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetCurrencyBudgetTransactionIDsByCurrencyBudgetIDPaged(long currencyBudgetId, long startRowIndex, long maximumRows)
	{
		if (currencyBudgetId == 0L)
		{
			throw new ArgumentException("Parameter 'CurrencyBudgetID' cannot be null, empty or the default value.");
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
			new SqlParameter("@CurrencyBudgetID", currencyBudgetId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxCurrencyBudgets.GetIDCollection<long>("CurrencyBudgetTransactions_GetCurrencyBudgetTransactionIDsByCurrencyBudgetID_Paged", queryParameters);
	}

	internal static long GetTotalNumberOfCurrencyBudgetTransactionsByCurrencyBudgetID(long currencyBudgetId)
	{
		if (currencyBudgetId == 0L)
		{
			throw new ArgumentException("Parameter 'CurrencyBudgetID' cannot be null, empty or the default value.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@CurrencyBudgetID", currencyBudgetId)
		};
		return RobloxDatabase.RobloxCurrencyBudgets.GetCount<long>("CurrencyBudgetTransactions_GetTotalNumberOfCurrencyBudgetTransactionsByCurrencyBudgetID", queryParameters);
	}
}
