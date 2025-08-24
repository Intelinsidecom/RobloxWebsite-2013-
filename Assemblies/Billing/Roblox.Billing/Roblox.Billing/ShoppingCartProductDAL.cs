using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ShoppingCartProductDAL
{
	private long _ID;

	public int ShoppingCartID;

	public int ProductID;

	public long? RecipientAccountID;

	public DateTime Created;

	public DateTime Updated;

	public decimal Price;

	public byte? CurrencyTypeID;

	private static readonly string dbConnectionString_ShoppingCartProductDAL = Settings.Default.BillingConnectionString;

	public long ID
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
		queryParameters.Add(new SqlParameter("@ShoppingCartID", ShoppingCartID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@RecipientAccountID", RecipientAccountID.HasValue ? ((object)RecipientAccountID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@Price", Price));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_ShoppingCartProductDAL, "ShoppingCartProducts_InsertShoppingCartProduct", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@ShoppingCartID", ShoppingCartID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@RecipientAccountID", RecipientAccountID.HasValue ? ((object)RecipientAccountID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@Price", Price));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_ShoppingCartProductDAL, "ShoppingCartProducts_UpdateShoppingCartProductByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_ShoppingCartProductDAL, "ShoppingCartProducts_DeleteShoppingCartProductByID", queryParameters));
	}

	public static ShoppingCartProductDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ShoppingCartProductDAL, "ShoppingCartProducts_GetShoppingCartProductByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetIDsByShoppingCartID(int shoppingCartID)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ShoppingCartID", shoppingCartID));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_ShoppingCartProductDAL, "[dbo].[ShoppingCartProducts_GetShoppingCartProductIDsByShoppingCartID]", queryParameters));
	}

	private static ShoppingCartProductDAL BuildDAL(SqlDataReader reader)
	{
		ShoppingCartProductDAL dal = new ShoppingCartProductDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ShoppingCartID = (int)reader["ShoppingCartID"];
			dal.ProductID = (int)reader["ProductID"];
			dal.RecipientAccountID = (reader["RecipientAccountID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["RecipientAccountID"])));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.Price = (decimal)reader["Price"];
			dal.CurrencyTypeID = (reader["CurrencyTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["CurrencyTypeID"]));
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}
}
