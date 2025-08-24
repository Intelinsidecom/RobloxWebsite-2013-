using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

public class GrantedBadgeListActivationTaskDAL
{
	private long _ID;

	private long _PremiumFeatureActivationTaskID;

	private Guid? _WorkerID;

	private DateTime? _Completed;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	internal long ID
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

	internal long PremiumFeatureActivationTaskID
	{
		get
		{
			return _PremiumFeatureActivationTaskID;
		}
		set
		{
			_PremiumFeatureActivationTaskID = value;
		}
	}

	internal Guid? WorkerID
	{
		get
		{
			return _WorkerID;
		}
		set
		{
			_WorkerID = value;
		}
	}

	internal DateTime? Completed
	{
		get
		{
			return _Completed;
		}
		set
		{
			_Completed = value;
		}
	}

	internal DateTime Created
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

	internal DateTime Updated
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

	private static string ConnectionString => RobloxDatabase.RobloxPremiumFeatures.GetConnectionString();

	internal GrantedBadgeListActivationTaskDAL()
	{
	}

	internal void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListActivationTasks_DeleteGrantedBadgeListActivationTaskByID]", queryParameters));
	}

	internal void Insert()
	{
		if (_PremiumFeatureActivationTaskID == 0L)
		{
			throw new ApplicationException("Required value not specified: PremiumFeatureActivationTaskID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PremiumFeatureActivationTaskID", _PremiumFeatureActivationTaskID));
		queryParameters.Add(new SqlParameter("@WorkerID", _WorkerID.HasValue ? ((object)_WorkerID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Completed", _Completed.HasValue ? ((object)_Completed.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListActivationTasks_InsertGrantedBadgeListActivationTask]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	internal void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_PremiumFeatureActivationTaskID == 0L)
		{
			throw new ApplicationException("Required value not specified: PremiumFeatureActivationTaskID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@PremiumFeatureActivationTaskID", _PremiumFeatureActivationTaskID));
		queryParameters.Add(new SqlParameter("@WorkerID", _WorkerID.HasValue ? ((object)_WorkerID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Completed", _Completed.HasValue ? ((object)_Completed.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListActivationTasks_UpdateGrantedBadgeListActivationTaskByID]", queryParameters));
	}

	private static GrantedBadgeListActivationTaskDAL BuildDAL(SqlDataReader reader)
	{
		GrantedBadgeListActivationTaskDAL dal = new GrantedBadgeListActivationTaskDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.PremiumFeatureActivationTaskID = (long)reader["PremiumFeatureActivationTaskID"];
			dal.WorkerID = (reader["WorkerID"].Equals(DBNull.Value) ? null : ((Guid?)reader["WorkerID"]));
			dal.Completed = (reader["Completed"].Equals(DBNull.Value) ? null : ((DateTime?)reader["Completed"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static GrantedBadgeListActivationTaskDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListActivationTasks_GetGrantedBadgeListActivationTaskByID]", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<GrantedBadgeListActivationTaskDAL> GetOrCreate(long premiumFeatureActivationTaskID)
	{
		if (premiumFeatureActivationTaskID == 0L)
		{
			throw new ApplicationException("Required value not specified: PremiumFeatureActivationTaskID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PremiumFeatureActivationTaskID", premiumFeatureActivationTaskID));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListActivationTasks_GetOrCreateGrantedBadgeListActivationTask]", queryParameters), BuildDAL);
	}

	internal static ICollection<long> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxToLease)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@WorkerID", workerId));
		queryParameters.Add(new SqlParameter("@NumberOfTasks", maxToLease));
		queryParameters.Add(new SqlParameter("@DurationInMinutes", leaseDurationInMinutes));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListActivationTasks_LeaseTasks]", queryParameters));
	}
}
