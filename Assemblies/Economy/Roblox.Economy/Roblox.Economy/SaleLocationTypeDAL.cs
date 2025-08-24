using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class SaleLocationTypeDAL
{
	private byte _ID;

	public string Value;

	public DateTime Created;

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

	private static string ConnectionString => Helper.DBConnectionString;

	private static SaleLocationTypeDAL BuildDAL(SqlDataReader reader)
	{
		SaleLocationTypeDAL dal = new SaleLocationTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
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
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(ConnectionString, "SaleLocationTypes_InsertSaleLocationType", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "SaleLocationTypes_UpdateSaleLocationTypeByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "SaleLocationTypes_DeleteSaleLocationTypeByID", queryParameters));
	}

	public static SaleLocationTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "SaleLocationTypes_GetSaleLocationTypeByID", queryParameters), BuildDAL);
	}

	public static SaleLocationTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "SaleLocationTypes_GetSaleLocationTypeByValue", queryParameters), BuildDAL);
	}
}
