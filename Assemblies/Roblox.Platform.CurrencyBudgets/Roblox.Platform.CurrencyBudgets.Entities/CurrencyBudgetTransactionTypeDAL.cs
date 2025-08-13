using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.CurrencyBudgets.Entities;

internal class CurrencyBudgetTransactionTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxCurrencyBudgets;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	private static CurrencyBudgetTransactionTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new CurrencyBudgetTransactionTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxCurrencyBudgets.Delete("CurrencyBudgetTransactionTypes_DeleteCurrencyBudgetTransactionTypeByID", ID);
	}

	internal static CurrencyBudgetTransactionTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxCurrencyBudgets.Get("CurrencyBudgetTransactionTypes_GetCurrencyBudgetTransactionTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxCurrencyBudgets.Insert<int>("CurrencyBudgetTransactionTypes_InsertCurrencyBudgetTransactionType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxCurrencyBudgets.Update("CurrencyBudgetTransactionTypes_UpdateCurrencyBudgetTransactionTypeByID", queryParameters);
	}

	internal static ICollection<CurrencyBudgetTransactionTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxCurrencyBudgets.MultiGet("CurrencyBudgetTransactionTypes_GetCurrencyBudgetTransactionTypesByIDs", ids, BuildDAL);
	}

	internal static CurrencyBudgetTransactionTypeDAL GetCurrencyBudgetTransactionTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxCurrencyBudgets.Lookup("CurrencyBudgetTransactionTypes_GetCurrencyBudgetTransactionTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<CurrencyBudgetTransactionTypeDAL> GetOrCreateCurrencyBudgetTransactionType(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxCurrencyBudgets.GetOrCreate("CurrencyBudgetTransactionTypes_GetOrCreateCurrencyBudgetTransactionType", BuildDAL, queryParameters);
	}
}
