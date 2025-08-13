using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class UserCounterDAL
{
	public long ID { get; set; }

	public long UserID { get; set; }

	public byte UserCounterTypeID { get; set; }

	public long Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxUserCounters.GetConnectionString();

	public void Increment(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		SqlParameter outputValue = new SqlParameter("@Value", SqlDbType.BigInt);
		outputValue.Direction = ParameterDirection.Output;
		SqlParameter outputUpdated = new SqlParameter("@Updated", SqlDbType.DateTime);
		outputUpdated.Direction = ParameterDirection.Output;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@Amount", amount));
		queryParameters.Add(outputValue);
		queryParameters.Add(outputUpdated);
		EntityHelper.DoEntityDALAction(new DbInfo(ConnectionString, "[dbo].[UserCountersV2_IncrementUserCounterV2ByID]", queryParameters));
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
	}

	public void IncrementResetting(long amount, DateTime dateThresholdToReset)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		if (dateThresholdToReset == default(DateTime))
		{
			throw new ApplicationException("Required value not specified: DateRangeToReset.");
		}
		SqlParameter outputValue = new SqlParameter("@Value", SqlDbType.BigInt);
		outputValue.Direction = ParameterDirection.Output;
		SqlParameter outputUpdated = new SqlParameter("@Updated", SqlDbType.DateTime);
		outputUpdated.Direction = ParameterDirection.Output;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@Amount", amount));
		queryParameters.Add(new SqlParameter("@DateThresholdToReset", dateThresholdToReset));
		queryParameters.Add(outputValue);
		queryParameters.Add(outputUpdated);
		EntityHelper.DoEntityDALAction(new DbInfo(ConnectionString, "[dbo].[UserCountersV2_IncrementResettingUserCounterV2ByID]", queryParameters));
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
	}

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[UserCountersV2_DeleteUserCounterV2ByID]", queryParameters));
	}

	public void Decrement(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		SqlParameter outputValue = new SqlParameter("@Value", SqlDbType.BigInt);
		outputValue.Direction = ParameterDirection.Output;
		SqlParameter outputUpdated = new SqlParameter("@Updated", SqlDbType.DateTime);
		outputUpdated.Direction = ParameterDirection.Output;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@Amount", amount));
		queryParameters.Add(outputValue);
		queryParameters.Add(outputUpdated);
		EntityHelper.DoEntityDALAction(new DbInfo(ConnectionString, "[dbo].[UserCountersV2_DecrementUserCounterV2ByID]", queryParameters));
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
	}

	private static UserCounterDAL BuildDAL(SqlDataReader reader)
	{
		UserCounterDAL dal = new UserCounterDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.UserCounterTypeID = (byte)reader["UserCounterTypeID"];
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

	public static EntityHelper.GetOrCreateDALWrapper<UserCounterDAL> GetOrCreate(long userId, byte userCounterTypeId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (userCounterTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: UserCounterTypeID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@UserCounterTypeID", userCounterTypeId));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[UserCountersV2_GetOrCreateUserCounterV2]", queryParameters), BuildDAL);
	}

	public static UserCounterDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[UserCountersV2_GetUserCounterV2ByID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetUserCounterIDsByRankPaged(int userCounterTypeID, DateTime dateStart, DateTime dateEnd, int startRowIndex, int maximumRows)
	{
		if (userCounterTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: UserCounterTypeID.");
		}
		if (dateStart == default(DateTime))
		{
			throw new ApplicationException("Required value not specified: DateStart.");
		}
		if (dateEnd == default(DateTime))
		{
			throw new ApplicationException("Required value not specified: DateEnd.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserCounterTypeID", userCounterTypeID));
		queryParameters.Add(new SqlParameter("@DateStart", dateStart));
		queryParameters.Add(new SqlParameter("@DateEnd", dateEnd));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[UserCountersV2_GetUserCounterV2IDsByRank_Paged]", queryParameters));
	}
}
