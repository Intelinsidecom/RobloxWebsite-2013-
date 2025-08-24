using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Properties;

namespace Roblox.PremiumFeatures;

public class PremiumFeatureActivationTasks_BillingTestDAL
{
	private long _ID;

	public long AccountID;

	public int PremiumFeatureID;

	public Guid? WorkerID;

	public DateTime? Completed;

	public DateTime Created;

	public DateTime Updated;

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

	private static string ConnectionString => Settings.Default.RobloxPremiumFeaturesTest;

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "PremiumFeatureActivationTasks_BillingTest_DeletePremiumFeatureActivationTasks_BillingTestByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@PremiumFeatureID", PremiumFeatureID));
		queryParameters.Add(new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Completed", Completed.HasValue ? ((object)Completed) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "PremiumFeatureActivationTasks_BillingTest_InsertPremiumFeatureActivationTasks_BillingTest", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@PremiumFeatureID", PremiumFeatureID));
		queryParameters.Add(new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Completed", Completed.HasValue ? ((object)Completed) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "PremiumFeatureActivationTasks_BillingTest_UpdatePremiumFeatureActivationTasks_BillingTestByID", queryParameters));
	}

	private static PremiumFeatureActivationTasks_BillingTestDAL BuildDAL(SqlDataReader reader)
	{
		PremiumFeatureActivationTasks_BillingTestDAL dal = new PremiumFeatureActivationTasks_BillingTestDAL();
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

	public static PremiumFeatureActivationTasks_BillingTestDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "PremiumFeatureActivationTasks_BillingTest_GetPremiumFeatureActivationTasks_BillingTestByID", queryParameters), BuildDAL);
	}
}
