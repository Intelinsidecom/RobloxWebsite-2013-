using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

public class PremiumFeatureActivationTaskDAL
{
	private long _ID;

	private long _AccountID;

	private int _PremiumFeatureID;

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

	internal long AccountID
	{
		get
		{
			return _AccountID;
		}
		set
		{
			_AccountID = value;
		}
	}

	internal int PremiumFeatureID
	{
		get
		{
			return _PremiumFeatureID;
		}
		set
		{
			_PremiumFeatureID = value;
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

	internal PremiumFeatureActivationTaskDAL()
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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[PremiumFeatureActivationTasksV2_DeletePremiumFeatureActivationTaskByID]", queryParameters));
	}

	internal void Insert()
	{
		if (_AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (_PremiumFeatureID == 0)
		{
			throw new ApplicationException("Required value not specified: PremiumFeatureID.");
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
		queryParameters.Add(new SqlParameter("@AccountID", _AccountID));
		queryParameters.Add(new SqlParameter("@PremiumFeatureID", _PremiumFeatureID));
		queryParameters.Add(new SqlParameter("@WorkerID", _WorkerID.HasValue ? ((object)_WorkerID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Completed", _Completed.HasValue ? ((object)_Completed.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[PremiumFeatureActivationTasksV2_InsertPremiumFeatureActivationTask]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	internal void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (_PremiumFeatureID == 0)
		{
			throw new ApplicationException("Required value not specified: PremiumFeatureID.");
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
		queryParameters.Add(new SqlParameter("@AccountID", _AccountID));
		queryParameters.Add(new SqlParameter("@PremiumFeatureID", _PremiumFeatureID));
		queryParameters.Add(new SqlParameter("@WorkerID", _WorkerID.HasValue ? ((object)_WorkerID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Completed", _Completed.HasValue ? ((object)_Completed.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[PremiumFeatureActivationTasksV2_UpdatePremiumFeatureActivationTaskByID]", queryParameters));
	}

	private static PremiumFeatureActivationTaskDAL BuildDAL(SqlDataReader reader)
	{
		PremiumFeatureActivationTaskDAL dal = new PremiumFeatureActivationTaskDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.PremiumFeatureID = (int)reader["PremiumFeatureID"];
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

	internal static PremiumFeatureActivationTaskDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[PremiumFeatureActivationTasksV2_GetPremiumFeatureActivationTaskByID]", queryParameters), BuildDAL);
	}

	internal static ICollection<long> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxToLease)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@WorkerID", workerId));
		queryParameters.Add(new SqlParameter("@NumberOfTasks", maxToLease));
		queryParameters.Add(new SqlParameter("@DurationInMinutes", leaseDurationInMinutes));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[PremiumFeatureActivationTasksV2_LeaseTasks]", queryParameters));
	}
}
