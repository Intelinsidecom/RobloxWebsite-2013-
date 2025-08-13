using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class InteractionCounterDAL
{
	private long _ID;

	private byte _InteractionCounterTypeID;

	private long _UserID;

	private long _OtherUserID;

	private long _Value;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	public long ID
	{
		get
		{
			return _ID;
		}
		set
		{
			_ID = value;
		}
	}

	public byte InteractionCounterTypeID
	{
		get
		{
			return _InteractionCounterTypeID;
		}
		set
		{
			_InteractionCounterTypeID = value;
		}
	}

	public long UserID
	{
		get
		{
			return _UserID;
		}
		set
		{
			_UserID = value;
		}
	}

	public long OtherUserID
	{
		get
		{
			return _OtherUserID;
		}
		set
		{
			_OtherUserID = value;
		}
	}

	public long Value
	{
		get
		{
			return _Value;
		}
		set
		{
			_Value = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _Created;
		}
		set
		{
			_Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _Updated;
		}
		set
		{
			_Updated = value;
		}
	}

	private static string ConnectionString => RobloxDatabase.RobloxInteractionCounters.GetConnectionString();

	public void Increment(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		SqlParameter output_Value = new SqlParameter("@Value", SqlDbType.BigInt);
		output_Value.Direction = ParameterDirection.Output;
		SqlParameter output_Updated = new SqlParameter("@Updated", SqlDbType.DateTime);
		output_Updated.Direction = ParameterDirection.Output;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Amount", amount));
		queryParameters.Add(output_Value);
		queryParameters.Add(output_Updated);
		EntityHelper.DoEntityDALAction(new DbInfo(ConnectionString, "[dbo].[InteractionCounters_IncrementInteractionCounterByID]", queryParameters));
		_Value = (long)output_Value.Value;
		_Updated = (DateTime)output_Updated.Value;
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
		SqlParameter output_Value = new SqlParameter("@Value", SqlDbType.BigInt);
		output_Value.Direction = ParameterDirection.Output;
		SqlParameter output_Updated = new SqlParameter("@Updated", SqlDbType.DateTime);
		output_Updated.Direction = ParameterDirection.Output;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Amount", amount));
		queryParameters.Add(new SqlParameter("@DateThresholdToReset", dateThresholdToReset));
		queryParameters.Add(output_Value);
		queryParameters.Add(output_Updated);
		EntityHelper.DoEntityDALAction(new DbInfo(ConnectionString, "[dbo].[InteractionCounters_IncrementResettingInteractionCounterByID]", queryParameters));
		_Value = (long)output_Value.Value;
		_Updated = (DateTime)output_Updated.Value;
	}

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[InteractionCounters_DeleteInteractionCounterByID]", queryParameters));
	}

	public void Decrement(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		SqlParameter output_Value = new SqlParameter("@Value", SqlDbType.BigInt);
		output_Value.Direction = ParameterDirection.Output;
		SqlParameter output_Updated = new SqlParameter("@Updated", SqlDbType.DateTime);
		output_Updated.Direction = ParameterDirection.Output;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Amount", amount));
		queryParameters.Add(output_Value);
		queryParameters.Add(output_Updated);
		EntityHelper.DoEntityDALAction(new DbInfo(ConnectionString, "[dbo].[InteractionCounters_DecrementInteractionCounterByID]", queryParameters));
		_Value = (long)output_Value.Value;
		_Updated = (DateTime)output_Updated.Value;
	}

	private static InteractionCounterDAL BuildDAL(SqlDataReader reader)
	{
		InteractionCounterDAL dal = new InteractionCounterDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.InteractionCounterTypeID = (byte)reader["InteractionCounterTypeID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.OtherUserID = Convert.ToInt64(reader["OtherUserID"]);
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

	public static EntityHelper.GetOrCreateDALWrapper<InteractionCounterDAL> GetOrCreate(byte interactionCounterTypeId, long userId, long otherUserId)
	{
		if (interactionCounterTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: InteractionCounterTypeID.");
		}
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (otherUserId == 0L)
		{
			throw new ApplicationException("Required value not specified: OtherUserID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@InteractionCounterTypeID", interactionCounterTypeId));
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@OtherUserID", otherUserId));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[InteractionCounters_GetOrCreateInteractionCounter]", queryParameters), BuildDAL);
	}

	public static InteractionCounterDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[InteractionCounters_GetInteractionCounterByID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetUserInteractionCounterIDsByTypePaged(long userId, byte interactionCounterTypeId, int startRowIndex, int maximumRows)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (interactionCounterTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: InteractionCounterTypeID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@InteractionCounterTypeID", interactionCounterTypeId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[InteractionCounters_GetUserInteractionCountersByTypeID_Paged]", queryParameters));
	}
}
