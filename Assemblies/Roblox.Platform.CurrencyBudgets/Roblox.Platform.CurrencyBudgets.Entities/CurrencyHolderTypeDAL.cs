using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.CurrencyBudgets.Entities;

internal class CurrencyHolderTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxCurrencyBudgets;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	private static CurrencyHolderTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new CurrencyHolderTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxCurrencyBudgets.Delete("CurrencyHolderTypes_DeleteCurrencyHolderTypeByID", ID);
	}

	internal static CurrencyHolderTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxCurrencyBudgets.Get("CurrencyHolderTypes_GetCurrencyHolderTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxCurrencyBudgets.Insert<int>("CurrencyHolderTypes_InsertCurrencyHolderType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxCurrencyBudgets.Update("CurrencyHolderTypes_UpdateCurrencyHolderTypeByID", queryParameters);
	}

	internal static ICollection<CurrencyHolderTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxCurrencyBudgets.MultiGet("CurrencyHolderTypes_GetCurrencyHolderTypesByIDs", ids, BuildDAL);
	}

	internal static CurrencyHolderTypeDAL GetCurrencyHolderTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxCurrencyBudgets.Lookup("CurrencyHolderTypes_GetCurrencyHolderTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<CurrencyHolderTypeDAL> GetOrCreateCurrencyHolderType(string value)
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
		return RobloxDatabase.RobloxCurrencyBudgets.GetOrCreate("CurrencyHolderTypes_GetOrCreateCurrencyHolderType", BuildDAL, queryParameters);
	}
}
