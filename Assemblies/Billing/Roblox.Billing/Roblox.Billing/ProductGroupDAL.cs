using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ProductGroupDAL
{
	private byte _ID;

	public string Name;

	public DateTime Created;

	public DateTime Updated;

	private static readonly string dbConnectionString_ProductGroupDAL = Settings.Default.BillingConnectionString;

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

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(dbConnectionString_ProductGroupDAL, "ProductGroups_InsertProductGroup", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_ProductGroupDAL, "ProductGroups_UpdateProductGroupByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_ProductGroupDAL, "ProductGroups_DeleteProductGroupByID", queryParameters));
	}

	public static ProductGroupDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ProductGroupDAL, "ProductGroups_GetProductGroupByID", queryParameters), BuildDAL);
	}

	public static ProductGroupDAL Get(string name)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ProductGroupDAL, "ProductGroups_GetProductGroupByName", queryParameters), BuildDAL);
	}

	private static ProductGroupDAL BuildDAL(SqlDataReader reader)
	{
		ProductGroupDAL dal = new ProductGroupDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Name = (string)reader["Name"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}
}
