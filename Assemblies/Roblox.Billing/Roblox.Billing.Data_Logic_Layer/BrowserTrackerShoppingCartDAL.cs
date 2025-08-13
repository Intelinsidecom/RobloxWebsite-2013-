using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing.Data_Logic_Layer;

public class BrowserTrackerShoppingCartDAL
{
	private int _ID;

	public long BrowserTrackerID;

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

	private static string dbConnectionString_BrowserTrackerShoppingCartDAL => Settings.Default.BillingConnectionString;

	private static BrowserTrackerShoppingCartDAL BuildDAL(SqlDataReader reader)
	{
		BrowserTrackerShoppingCartDAL dal = new BrowserTrackerShoppingCartDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.BrowserTrackerID = (long)reader["BrowserTrackerID"];
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
		queryParameters.Add(new SqlParameter("@BrowserTrackerID", BrowserTrackerID));
		queryParameters.Add(new SqlParameter("@ShoppingCartID", ShoppingCartID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_BrowserTrackerShoppingCartDAL, "BrowserTrackerShoppingCarts_InsertBrowserTrackerShoppingCart", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@BrowserTrackerID", BrowserTrackerID));
		queryParameters.Add(new SqlParameter("@ShoppingCartID", ShoppingCartID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_BrowserTrackerShoppingCartDAL, "BrowserTrackerShoppingCarts_UpdateBrowserTrackerShoppingCartByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_BrowserTrackerShoppingCartDAL, "BrowserTrackerShoppingCarts_DeleteBrowserTrackerShoppingCartByID", queryParameters));
	}

	public static BrowserTrackerShoppingCartDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_BrowserTrackerShoppingCartDAL, "BrowserTrackerShoppingCarts_GetBrowserTrackerShoppingCartByID", queryParameters), BuildDAL);
	}

	public static BrowserTrackerShoppingCartDAL GetByBrowserTrackerID(long browserTrackerId)
	{
		if (browserTrackerId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@BrowserTrackerID", browserTrackerId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_BrowserTrackerShoppingCartDAL, "BrowserTrackerShoppingCarts_GetBrowserTrackerShoppingCartByBrowserTrackerID", queryParameters), BuildDAL);
	}
}
