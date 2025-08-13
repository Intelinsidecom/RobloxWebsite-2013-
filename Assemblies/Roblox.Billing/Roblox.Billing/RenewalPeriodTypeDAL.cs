using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class RenewalPeriodTypeDAL
{
	private byte _ID;

	private string _Value = "";

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	public static readonly string DBConnectionString = Settings.Default.BillingConnectionString;

	public byte ID
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

	public string Value
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

	public static RenewalPeriodTypeDAL BuildDAL(SqlDataReader reader)
	{
		RenewalPeriodTypeDAL dal = new RenewalPeriodTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static RenewalPeriodTypeDAL Get(string renewalPeriodType)
	{
		if (renewalPeriodType.Trim().Length == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", renewalPeriodType));
		return EntityHelper.GetEntityDAL(new DbInfo(DBConnectionString, "[dbo].[RenewalPeriodTypes_GetRenewalPeriodTypeByValue]", queryParameters), BuildDAL);
	}

	public static RenewalPeriodTypeDAL Get(byte id)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(DBConnectionString, "[dbo].[RenewalPeriodTypes_GetRenewalPeriodTypeByID]", queryParameters), BuildDAL);
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(DBConnectionString, "RenewalPeriodTypes_DeleteRenewalPeriodTypeByID", queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(DBConnectionString, "[dbo].[RenewalPeriodTypes_UpdateRenewalPeriodTypeByID]", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(DBConnectionString, "RenewalPeriodTypes_InsertRenewalPeriodType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}
}
