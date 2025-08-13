using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ShoppingCartDAL
{
	private int _ID;

	public DateTime Created;

	public DateTime Updated;

	private static readonly string dbConnectionString_ShoppingCartDAL = Settings.Default.BillingConnectionString;

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

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_ShoppingCartDAL, "ShoppingCarts_InsertShoppingCart", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_ShoppingCartDAL, "ShoppingCarts_UpdateShoppingCartByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_ShoppingCartDAL, "ShoppingCarts_DeleteShoppingCartByID", queryParameters));
	}

	public static ShoppingCartDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ShoppingCartDAL, "ShoppingCarts_GetShoppingCartByID", queryParameters), BuildDAL);
	}

	private static ShoppingCartDAL BuildDAL(SqlDataReader reader)
	{
		ShoppingCartDAL dal = new ShoppingCartDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
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
