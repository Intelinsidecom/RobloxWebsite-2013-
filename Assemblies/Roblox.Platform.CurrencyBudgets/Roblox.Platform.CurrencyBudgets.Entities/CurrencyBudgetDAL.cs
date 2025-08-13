using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.CurrencyBudgets.Entities;

internal class CurrencyBudgetDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxCurrencyBudgets;

	internal long ID { get; set; }

	internal int CurrencyBudgetTypeID { get; set; }

	internal byte CurrencyTypeID { get; set; }

	internal int CurrencyHolderTypeID { get; set; }

	internal long CurrencyHolderTargetID { get; set; }

	internal long Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static CurrencyBudgetDAL BuildDAL(IDictionary<string, object> record)
	{
		return new CurrencyBudgetDAL
		{
			ID = (long)record["ID"],
			CurrencyBudgetTypeID = (int)record["CurrencyBudgetTypeID"],
			CurrencyTypeID = (byte)record["CurrencyTypeID"],
			CurrencyHolderTypeID = (int)record["CurrencyHolderTypeID"],
			CurrencyHolderTargetID = (long)record["CurrencyHolderTargetID"],
			Value = (long)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxCurrencyBudgets.Delete("CurrencyBudgets_DeleteCurrencyBudgetByID", ID);
	}

	internal static CurrencyBudgetDAL Get(long id)
	{
		return RobloxDatabase.RobloxCurrencyBudgets.Get("CurrencyBudgets_GetCurrencyBudgetByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@CurrencyBudgetTypeID", CurrencyBudgetTypeID),
			new SqlParameter("@CurrencyTypeID", CurrencyTypeID),
			new SqlParameter("@CurrencyHolderTypeID", CurrencyHolderTypeID),
			new SqlParameter("@CurrencyHolderTargetID", CurrencyHolderTargetID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxCurrencyBudgets.Insert<long>("CurrencyBudgets_InsertCurrencyBudget", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@CurrencyBudgetTypeID", CurrencyBudgetTypeID),
			new SqlParameter("@CurrencyTypeID", CurrencyTypeID),
			new SqlParameter("@CurrencyHolderTypeID", CurrencyHolderTypeID),
			new SqlParameter("@CurrencyHolderTargetID", CurrencyHolderTargetID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxCurrencyBudgets.Update("CurrencyBudgets_UpdateCurrencyBudgetByID", queryParameters);
	}

	internal void Credit(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Amount must be positive");
		}
		SqlParameter outputValue = new SqlParameter("@Value", SqlDbType.BigInt)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter outputUpdated = new SqlParameter("@Updated", SqlDbType.DateTime)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Amount", amount),
			outputValue,
			outputUpdated
		};
		RobloxDatabase.RobloxCurrencyBudgets.ExecuteNonQuery("CurrencyBudgets_CreditCurrencyBudgetByID", queryParameters);
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
	}

	internal bool TryDebit(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Amount must be positive");
		}
		SqlParameter outputValue = new SqlParameter("@Value", SqlDbType.BigInt)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter outputUpdated = new SqlParameter("@Updated", SqlDbType.DateTime)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter outputIsSuccess = new SqlParameter("@IsSuccess", SqlDbType.Bit)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Amount", amount),
			outputValue,
			outputUpdated,
			outputIsSuccess
		};
		RobloxDatabase.RobloxCurrencyBudgets.ExecuteNonQuery("CurrencyBudgets_TryDebitCurrencyBudgetByID", queryParameters);
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
		return (bool)outputIsSuccess.Value;
	}

	internal static ICollection<CurrencyBudgetDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxCurrencyBudgets.MultiGet("CurrencyBudgets_GetCurrencyBudgetsByIDs", ids, BuildDAL);
	}

	internal static CurrencyBudgetDAL GetCurrencyBudgetByCurrencyBudgetTypeIDCurrencyTypeIDCurrencyHolderTypeIDAndCurrencyHolderTargetID(int currencyBudgetTypeId, byte currencyTypeId, int currencyHolderTypeId, long currencyHolderTargetId)
	{
		if (currencyBudgetTypeId == 0)
		{
			return null;
		}
		if (currencyTypeId == 0)
		{
			return null;
		}
		if (currencyHolderTypeId == 0)
		{
			return null;
		}
		if (currencyHolderTargetId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@CurrencyBudgetTypeID", currencyBudgetTypeId),
			new SqlParameter("@CurrencyTypeID", currencyTypeId),
			new SqlParameter("@CurrencyHolderTypeID", currencyHolderTypeId),
			new SqlParameter("@CurrencyHolderTargetID", currencyHolderTargetId)
		};
		return RobloxDatabase.RobloxCurrencyBudgets.Lookup("CurrencyBudgets_GetCurrencyBudgetByCurrencyBudgetTypeIDCurrencyTypeIDCurrencyHolderTypeIDAndCurrencyHolderTargetID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<CurrencyBudgetDAL> GetOrCreateCurrencyBudget(int currencyBudgetTypeId, byte currencyTypeId, int currencyHolderTypeId, long currencyHolderTargetId)
	{
		if (currencyBudgetTypeId == 0)
		{
			return null;
		}
		if (currencyTypeId == 0)
		{
			return null;
		}
		if (currencyHolderTypeId == 0)
		{
			return null;
		}
		if (currencyHolderTargetId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@CurrencyBudgetTypeID", currencyBudgetTypeId),
			new SqlParameter("@CurrencyTypeID", currencyTypeId),
			new SqlParameter("@CurrencyHolderTypeID", currencyHolderTypeId),
			new SqlParameter("@CurrencyHolderTargetID", currencyHolderTargetId)
		};
		return RobloxDatabase.RobloxCurrencyBudgets.GetOrCreate("CurrencyBudgets_GetOrCreateCurrencyBudget", BuildDAL, queryParameters);
	}
}
