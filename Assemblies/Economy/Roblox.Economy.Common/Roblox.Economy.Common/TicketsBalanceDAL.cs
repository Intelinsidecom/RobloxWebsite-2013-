using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Economy.Common;

[Serializable]
public class TicketsBalanceDAL
{
	public int ID { get; set; }

	public long UserID { get; set; }

	public long Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Credit(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
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
		EntityHelper.DoEntityDALAction(new DbInfo(Helper.DBConnectionString_Currency, "[dbo].[TicketsBalances_CreditTicketsBalanceByID]", queryParameters));
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
	}

	public void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString_Currency, "[dbo].[TicketsBalances_DeleteTicketsBalanceByID]", queryParameters));
	}

	public bool TryDebit(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
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
		EntityHelper.DoEntityDALAction(new DbInfo(Helper.DBConnectionString_Currency, "[dbo].[TicketsBalances_TryDebitTicketsBalanceByID]", queryParameters));
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
		return (bool)outputIsSuccess.Value;
	}

	private static TicketsBalanceDAL BuildDAL(SqlDataReader reader)
	{
		TicketsBalanceDAL dal = new TicketsBalanceDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.Value = (long)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static EntityHelper.GetOrCreateDALWrapper<TicketsBalanceDAL> GetOrCreate(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Helper.DBConnectionString_Currency, "[dbo].[TicketsBalances_GetOrCreateTicketsBalance]", queryParameters), BuildDAL);
	}

	public static TicketsBalanceDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString_Currency, "[dbo].[TicketsBalances_GetTicketsBalanceByID]", queryParameters), BuildDAL);
	}
}
