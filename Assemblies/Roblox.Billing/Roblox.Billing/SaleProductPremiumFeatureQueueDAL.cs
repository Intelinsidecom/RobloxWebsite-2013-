using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class SaleProductPremiumFeatureQueueDAL
{
	private long _ID;

	public long SaleProductID;

	public bool PremiumFeatureGrantRequested;

	public DateTime Created;

	public DateTime Updated;

	public DateTime? LeaseExpiration;

	public Guid? WorkerID;

	private static readonly string dbConnectionString_SaleProductPremiumFeatureQueueDAL = Settings.Default.BillingConnectionString;

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

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleProductID", SaleProductID));
		queryParameters.Add(new SqlParameter("@PremiumFeatureGrantRequested", PremiumFeatureGrantRequested));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@LeaseExpiration", LeaseExpiration.HasValue ? ((object)LeaseExpiration.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID.Value) : DBNull.Value));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_SaleProductPremiumFeatureQueueDAL, "SaleProductPremiumFeatureQueue_InsertSaleProductPremiumFeatureQueue", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@SaleProductID", SaleProductID));
		queryParameters.Add(new SqlParameter("@PremiumFeatureGrantRequested", PremiumFeatureGrantRequested));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@LeaseExpiration", LeaseExpiration.HasValue ? ((object)LeaseExpiration.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID.Value) : DBNull.Value));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_SaleProductPremiumFeatureQueueDAL, "SaleProductPremiumFeatureQueue_UpdateSaleProductPremiumFeatureQueueByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_SaleProductPremiumFeatureQueueDAL, "SaleProductPremiumFeatureQueue_DeleteSaleProductPremiumFeatureQueueByID", queryParameters));
	}

	public static SaleProductPremiumFeatureQueueDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_SaleProductPremiumFeatureQueueDAL, "SaleProductPremiumFeatureQueue_GetSaleProductPremiumFeatureQueueByID", queryParameters), BuildDAL);
	}

	internal static ICollection<long> LeasePendingPremiumFeaturesToAward(Guid workerId, int numberOfItems, int leaseDurationInMinutes)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@WorkerID", workerId));
		queryParameters.Add(new SqlParameter("@NumberOfItems", numberOfItems));
		queryParameters.Add(new SqlParameter("@LeaseDurationInMinutes", leaseDurationInMinutes));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_SaleProductPremiumFeatureQueueDAL, "[dbo].[SaleProductPremiumFeatureQueue_LeaseItems]", queryParameters));
	}

	private static SaleProductPremiumFeatureQueueDAL BuildDAL(SqlDataReader reader)
	{
		SaleProductPremiumFeatureQueueDAL dal = new SaleProductPremiumFeatureQueueDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.SaleProductID = (long)reader["SaleProductID"];
			dal.PremiumFeatureGrantRequested = (bool)reader["PremiumFeatureGrantRequested"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.LeaseExpiration = (reader["LeaseExpiration"].Equals(DBNull.Value) ? null : ((DateTime?)reader["LeaseExpiration"]));
			dal.WorkerID = (reader["WorkerID"].Equals(DBNull.Value) ? null : ((Guid?)reader["WorkerID"]));
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}
}
