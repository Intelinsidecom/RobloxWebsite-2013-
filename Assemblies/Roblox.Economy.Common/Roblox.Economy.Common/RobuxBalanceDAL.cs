using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Economy.Common;

[Serializable]
public class RobuxBalanceDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxCurrency.GetConnectionString();

	public long ID { get; set; }

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
		EntityHelper.DoEntityDALAction(new DbInfo(ConnectionString, "[dbo].[RobuxBalances_CreditRobuxBalanceByID]", queryParameters));
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
	}

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[RobuxBalances_DeleteRobuxBalanceByID]", queryParameters));
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
		EntityHelper.DoEntityDALAction(new DbInfo(ConnectionString, "[dbo].[RobuxBalances_TryDebitRobuxBalanceByID]", queryParameters));
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
		return (bool)outputIsSuccess.Value;
	}

	private static RobuxBalanceDAL BuildDAL(SqlDataReader reader)
	{
		RobuxBalanceDAL dal = new RobuxBalanceDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt64(reader["ID"]);
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.Value = (long)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static EntityHelper.GetOrCreateDALWrapper<RobuxBalanceDAL> GetOrCreate(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobuxBalances_GetOrCreateRobuxBalance]", queryParameters), BuildDAL);
	}

	public static RobuxBalanceDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobuxBalances_GetRobuxBalanceByID]", queryParameters), BuildDAL);
	}
}
