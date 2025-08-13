using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class CancellationDAL
{
	private int _ID;

	public int SaleID;

	public string PaypalAccountID;

	public DateTime? LeaseExpiration;

	public Guid? WorkerID;

	public bool SentToPayPal;

	public DateTime Created;

	public DateTime Updated;

	private static readonly string dbConnectionString_CancellationDAL = Settings.Default.BillingConnectionString;

	public int ID
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

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_CancellationDAL, "Cancellations_DeleteCancellationByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@PaypalAccountID", PaypalAccountID));
		queryParameters.Add(new SqlParameter("@LeaseExpiration", LeaseExpiration.HasValue ? ((object)LeaseExpiration.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@SentToPayPal", SentToPayPal));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_CancellationDAL, "Cancellations_InsertCancellation", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@PaypalAccountID", PaypalAccountID));
		queryParameters.Add(new SqlParameter("@LeaseExpiration", LeaseExpiration.HasValue ? ((object)LeaseExpiration.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@SentToPayPal", SentToPayPal));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_CancellationDAL, "Cancellations_UpdateCancellationByID", queryParameters));
	}

	private static CancellationDAL BuildDAL(SqlDataReader reader)
	{
		CancellationDAL dal = new CancellationDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.SaleID = (int)reader["SaleID"];
			dal.PaypalAccountID = (string)reader["PaypalAccountID"];
			dal.SentToPayPal = (bool)reader["SentToPayPal"];
			dal.WorkerID = (reader["WorkerID"].Equals(DBNull.Value) ? null : ((Guid?)reader["WorkerID"]));
			dal.LeaseExpiration = (reader["LeaseExpiration"].Equals(DBNull.Value) ? null : ((DateTime?)reader["LeaseExpiration"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static ICollection<int> LeasePendingCancellations(Guid workerId, int numberOfItems, int leaseDurationInMinutes, int maxCancellationsPerDay)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@WorkerID", workerId));
		queryParameters.Add(new SqlParameter("@NumberOfItems", numberOfItems));
		queryParameters.Add(new SqlParameter("@LeaseDurationInMinutes", leaseDurationInMinutes));
		queryParameters.Add(new SqlParameter("@MaxCancellationsPerDay", maxCancellationsPerDay));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_CancellationDAL, "[dbo].[Cancellations_LeaseItems]", queryParameters));
	}

	public static CancellationDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_CancellationDAL, "Cancellations_GetCancellationByID", queryParameters), BuildDAL);
	}
}
