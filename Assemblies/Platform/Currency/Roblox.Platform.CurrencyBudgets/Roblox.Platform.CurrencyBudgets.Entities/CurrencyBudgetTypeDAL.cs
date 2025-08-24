using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.CurrencyBudgets.Entities;

internal class CurrencyBudgetTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxCurrencyBudgets;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	private static CurrencyBudgetTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new CurrencyBudgetTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxCurrencyBudgets.Delete("CurrencyBudgetTypes_DeleteCurrencyBudgetTypeByID", ID);
	}

	internal static CurrencyBudgetTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxCurrencyBudgets.Get("CurrencyBudgetTypes_GetCurrencyBudgetTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxCurrencyBudgets.Insert<int>("CurrencyBudgetTypes_InsertCurrencyBudgetType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxCurrencyBudgets.Update("CurrencyBudgetTypes_UpdateCurrencyBudgetTypeByID", queryParameters);
	}

	internal static ICollection<CurrencyBudgetTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxCurrencyBudgets.MultiGet("CurrencyBudgetTypes_GetCurrencyBudgetTypesByIDs", ids, BuildDAL);
	}

	internal static CurrencyBudgetTypeDAL GetCurrencyBudgetTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxCurrencyBudgets.Lookup("CurrencyBudgetTypes_GetCurrencyBudgetTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<CurrencyBudgetTypeDAL> GetOrCreateCurrencyBudgetType(string value)
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
		return RobloxDatabase.RobloxCurrencyBudgets.GetOrCreate("CurrencyBudgetTypes_GetOrCreateCurrencyBudgetType", BuildDAL, queryParameters);
	}
}
