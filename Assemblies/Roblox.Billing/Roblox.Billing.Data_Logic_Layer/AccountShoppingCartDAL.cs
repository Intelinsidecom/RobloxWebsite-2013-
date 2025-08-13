using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing.Data_Logic_Layer;

public class AccountShoppingCartDAL
{
	private int _ID;

	public long AccountID;

	public int ShoppingCartID;

	public DateTime Created;

	public DateTime Updated;

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

	private static string dbConnectionString_AccountShoppingCartDAL => Settings.Default.BillingConnectionString;

	private static AccountShoppingCartDAL BuildDAL(SqlDataReader reader)
	{
		AccountShoppingCartDAL dal = new AccountShoppingCartDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.ShoppingCartID = (int)reader["ShoppingCartID"];
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
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@ShoppingCartID", ShoppingCartID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_AccountShoppingCartDAL, "AccountShoppingCarts_InsertAccountShoppingCart", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@ShoppingCartID", ShoppingCartID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_AccountShoppingCartDAL, "AccountShoppingCarts_UpdateAccountShoppingCartByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_AccountShoppingCartDAL, "AccountShoppingCarts_DeleteAccountShoppingCartByID", queryParameters));
	}

	public static AccountShoppingCartDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AccountShoppingCartDAL, "AccountShoppingCarts_GetAccountShoppingCartByID", queryParameters), BuildDAL);
	}

	public static AccountShoppingCartDAL GetByAccountID(long accountId)
	{
		if (accountId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", accountId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AccountShoppingCartDAL, "AccountShoppingCarts_GetAccountShoppingCartByAccountID", queryParameters), BuildDAL);
	}

	public static AccountShoppingCartDAL GetByShoppingCartID(int shoppingCartId)
	{
		if (shoppingCartId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ShoppingCartID", shoppingCartId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AccountShoppingCartDAL, "AccountShoppingCarts_GetAccountShoppingCartByShoppingCartID", queryParameters), BuildDAL);
	}
}
