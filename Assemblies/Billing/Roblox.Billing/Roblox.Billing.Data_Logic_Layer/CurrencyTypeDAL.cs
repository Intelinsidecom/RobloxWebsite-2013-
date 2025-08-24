using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Billing.Data_Logic_Layer;

public class CurrencyTypeDAL
{
	public string Name;

	public string Code;

	public DateTime Created;

	public DateTime Updated;

	public string Symbol;

	private static string ConnectionString => RobloxDatabase.RobloxBilling.GetConnectionString();

	public byte ID { get; set; }

	private static CurrencyTypeDAL BuildDAL(SqlDataReader reader)
	{
		CurrencyTypeDAL dal = new CurrencyTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Name = (string)reader["Name"];
			dal.Code = (string)reader["Code"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.Symbol = (string)reader["Symbol"];
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
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Code", Code));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@Symbol", Symbol));
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(ConnectionString, "CurrencyTypes_InsertCurrencyType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}

	public void Delete()
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "CurrencyTypes_DeleteCurrencyTypeByID", queryParameters));
	}

	public static CurrencyTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "CurrencyTypes_GetCurrencyTypeByID", queryParameters), BuildDAL);
	}

	public static CurrencyTypeDAL GetByCode(string code)
	{
		if (code == null)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Code", code));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "CurrencyTypes_GetCurrencyTypeByCode", queryParameters), BuildDAL);
	}

	public static ICollection<byte> GetCurrencyTypesByID_Paged(byte startRowIndex, byte maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(ConnectionString, "[dbo].[CurrencyTypes_GetCurrencyTypeIDs_Paged]", queryParameters));
	}
}
