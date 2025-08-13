using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing.Data_Logic_Layer;

public class InCommCardCreditValueDAL
{
	private short _ID;

	public short InCommCardID;

	public decimal? CreditValue = 0m;

	public DateTime Created;

	public DateTime Updated;

	public short ID
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

	private static string dbConnectionString_InCommCardCreditValueDAL => Settings.Default.BillingConnectionString;

	private static InCommCardCreditValueDAL BuildDAL(SqlDataReader reader)
	{
		InCommCardCreditValueDAL dal = new InCommCardCreditValueDAL();
		while (reader.Read())
		{
			dal.ID = (short)reader["ID"];
			dal.InCommCardID = (short)reader["InCommCardID"];
			dal.CreditValue = (reader["CreditValue"].Equals(DBNull.Value) ? null : ((decimal?)reader["CreditValue"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@InCommCardID", InCommCardID));
		queryParameters.Add(new SqlParameter("@CreditValue", CreditValue));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<short>(new DbInfo(dbConnectionString_InCommCardCreditValueDAL, "InCommCardCreditValues_InsertInCommCardCreditValue", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@InCommCardID", InCommCardID));
		queryParameters.Add(new SqlParameter("@CreditValue", CreditValue));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_InCommCardCreditValueDAL, "InCommCardCreditValues_UpdateInCommCardCreditValueByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_InCommCardCreditValueDAL, "InCommCardCreditValues_DeleteInCommCardCreditValueByID", queryParameters));
	}

	public static InCommCardCreditValueDAL Get(short id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_InCommCardCreditValueDAL, "InCommCardCreditValues_GetInCommCardCreditValueByID", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<InCommCardCreditValueDAL> GetOrCreate(short inCommCardId)
	{
		if (inCommCardId == 0)
		{
			throw new ApplicationException("Required value not specified: inCommCardId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@InCommCardID", inCommCardId));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(dbConnectionString_InCommCardCreditValueDAL, "[dbo].[InCommCardCreditValues_GetOrCreateInCommCardCreditValue]", queryParameters), BuildDAL);
	}

	public static InCommCardCreditValueDAL GetInCommCardCreditValueByInCommCardID(short InCommCardID)
	{
		if (InCommCardID == 0)
		{
			throw new ApplicationException("Required value not specified: InCommCardID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@InCommCardID", InCommCardID));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_InCommCardCreditValueDAL, "InCommCardCreditValues_GetInCommCardCreditValueByInCommCardID", queryParameters), BuildDAL);
	}
}
