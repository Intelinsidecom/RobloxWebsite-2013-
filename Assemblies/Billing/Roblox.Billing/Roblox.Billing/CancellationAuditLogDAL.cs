using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class CancellationAuditLogDAL
{
	private int _ID;

	public int SaleID;

	public string CancelledBy;

	public DateTime Created;

	public DateTime Updated;

	private static readonly string dbConnectionString_CancellationAuditLogDAL = Settings.Default.BillingConnectionString;

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
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_CancellationAuditLogDAL, "CancellationAuditLog_DeleteCancellationAuditLogByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@CancelledBy", CancelledBy));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_CancellationAuditLogDAL, "CancellationAuditLog_InsertCancellationAuditLog", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@CancelledBy", CancelledBy));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_CancellationAuditLogDAL, "CancellationAuditLog_UpdateCancellationAuditLogByID", queryParameters));
	}

	private static CancellationAuditLogDAL BuildDAL(SqlDataReader reader)
	{
		CancellationAuditLogDAL dal = new CancellationAuditLogDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.SaleID = (int)reader["SaleID"];
			dal.CancelledBy = (string)reader["CancelledBy"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static CancellationAuditLogDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_CancellationAuditLogDAL, "CancellationAuditLog_GetCancellationAuditLogByID", queryParameters), BuildDAL);
	}
}
