using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ProductPaymentProviderTypeDAL
{
	private int _ID;

	public int ProductID;

	public byte PaymentProviderTypeID;

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

	private static string dbConnectionString_ProductPaymentProviderTypeDAL => Settings.Default.BillingConnectionString;

	private static ProductPaymentProviderTypeDAL BuildDAL(SqlDataReader reader)
	{
		ProductPaymentProviderTypeDAL dal = new ProductPaymentProviderTypeDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.ProductID = (int)reader["ProductID"];
			dal.PaymentProviderTypeID = (byte)reader["PaymentProviderTypeID"];
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
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@PaymentProviderTypeID", PaymentProviderTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_ProductPaymentProviderTypeDAL, "ProductPaymentProviderTypes_InsertProductPaymentProviderType", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@PaymentProviderTypeID", PaymentProviderTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_ProductPaymentProviderTypeDAL, "ProductPaymentProviderTypes_UpdateProductPaymentProviderTypeByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_ProductPaymentProviderTypeDAL, "ProductPaymentProviderTypes_DeleteProductPaymentProviderTypeByID", queryParameters));
	}

	public static ProductPaymentProviderTypeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ProductPaymentProviderTypeDAL, "ProductPaymentProviderTypes_GetProductPaymentProviderTypeByID", queryParameters), BuildDAL);
	}

	public static ProductPaymentProviderTypeDAL GetProductPaymentProviderTypeByProductIDAndPaymentProviderTypeID(int productid, int paymentprovidertypeid)
	{
		if (productid == 0 || paymentprovidertypeid == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", productid));
		queryParameters.Add(new SqlParameter("@PaymentProviderTypeID", paymentprovidertypeid));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ProductPaymentProviderTypeDAL, "ProductPaymentProviderTypes_GetProductPaymentProviderTypeByProductIDAndPaymentProviderTypeID", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetProductPaymentProviderTypeIDsByPaymentProviderTypeID(int paymentProviderTypeId)
	{
		if (paymentProviderTypeId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PaymentProviderTypeID", paymentProviderTypeId));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_ProductPaymentProviderTypeDAL, "ProductPaymentProviderTypes_GetProductPaymentProviderTypeIDsByPaymentProviderTypeID", queryParameters));
	}

	public static ICollection<int> GetProductPaymentProviderTypeIDsByProductID(int productID)
	{
		if (productID == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", productID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_ProductPaymentProviderTypeDAL, "ProductPaymentProviderTypes_GetProductPaymentProviderTypeIDsByProductID", queryParameters));
	}
}
