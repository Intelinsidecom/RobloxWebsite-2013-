using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Billing;

public class ProductPriceDAL
{
	public int ID;

	public int ProductPaymentProviderTypeID;

	public int CountryCurrencyID;

	public decimal Price;

	public DateTime Created;

	public DateTime Updated;

	public bool? IsActive;

	private static string ConnectionString => RobloxDatabase.RobloxBilling.GetConnectionString();

	private static ProductPriceDAL BuildDAL(SqlDataReader reader)
	{
		ProductPriceDAL dal = new ProductPriceDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.ProductPaymentProviderTypeID = (int)reader["ProductPaymentProviderTypeID"];
			dal.Price = (decimal)reader["Price"];
			dal.CountryCurrencyID = (int)reader["CountryCurrencyID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.IsActive = (reader["IsActive"].Equals(DBNull.Value) ? null : ((bool?)reader["IsActive"]));
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
		queryParameters.Add(new SqlParameter("@ProductPaymentProviderTypeID", ProductPaymentProviderTypeID));
		queryParameters.Add(new SqlParameter("@Price", Price));
		queryParameters.Add(new SqlParameter("@CountryCurrencyID", CountryCurrencyID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@IsActive", IsActive));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "ProductPrices_InsertProductPrice", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@ProductPaymentProviderTypeID", ProductPaymentProviderTypeID));
		queryParameters.Add(new SqlParameter("@Price", Price));
		queryParameters.Add(new SqlParameter("@CountryCurrencyID", CountryCurrencyID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@IsActive", IsActive));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "ProductPrices_UpdateProductPriceByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "ProductPrices_DeleteProductPriceByID", queryParameters));
	}

	public static ProductPriceDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ProductPrices_GetProductPriceByID", queryParameters), BuildDAL);
	}

	public static ProductPriceDAL GetByProductPaymentProviderTypeIDAndCountryCurrencyID(int productPaymentProviderTypeID, int countryCurrencyID)
	{
		if (productPaymentProviderTypeID == 0)
		{
			return null;
		}
		if (countryCurrencyID == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductPaymentProviderTypeID", productPaymentProviderTypeID));
		queryParameters.Add(new SqlParameter("@CountryCurrencyID", countryCurrencyID));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ProductPrices_GetProductPriceByProductPaymentProviderTypeIDAndCountryCurrencyID", queryParameters), BuildDAL);
	}

	public static int GetTotalNumberOfProductPricesByProductPaymentProviderTypeID(int productPaymentProviderTypeID)
	{
		if (productPaymentProviderTypeID == 0)
		{
			return -1;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductPaymentProviderTypeID", productPaymentProviderTypeID));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "ProductPrices_GetTotalNumberOfProductPricesByProductPaymentProviderTypeID", queryParameters));
	}
}
