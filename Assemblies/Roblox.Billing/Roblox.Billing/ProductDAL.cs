using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ProductDAL
{
	private int _ID;

	public byte ProductGroupID;

	public string Name;

	public decimal Price;

	public bool IsRenewable;

	public byte? RenewalPeriodTypeID;

	public DateTime Created;

	public DateTime Updated;

	public int PremiumFeatureID;

	public byte? CurrencyTypeID;

	private static readonly string dbConnectionString_ProductDAL = Settings.Default.BillingConnectionString;

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
		queryParameters.Add(new SqlParameter("@ProductGroupID", ProductGroupID));
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Price", Price));
		queryParameters.Add(new SqlParameter("@IsRenewable", IsRenewable));
		queryParameters.Add(new SqlParameter("@RenewalPeriodTypeID", RenewalPeriodTypeID.HasValue ? ((object)RenewalPeriodTypeID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@PremiumFeatureID", PremiumFeatureID));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_ProductDAL, "Products_InsertProduct", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@ProductGroupID", ProductGroupID));
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Price", Price));
		queryParameters.Add(new SqlParameter("@IsRenewable", IsRenewable));
		queryParameters.Add(new SqlParameter("@RenewalPeriodTypeID", RenewalPeriodTypeID.HasValue ? ((object)RenewalPeriodTypeID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@PremiumFeatureID", PremiumFeatureID));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_ProductDAL, "Products_UpdateProductByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_ProductDAL, "Products_DeleteProductByID", queryParameters));
	}

	public static ProductDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ProductDAL, "Products_GetProductByID", queryParameters), BuildDAL);
	}

	public static ProductDAL Get(string name)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ProductDAL, "Products_GetProductByName", queryParameters), BuildDAL);
	}

	public static ProductDAL GetByPremiumFeatureID(int pfid)
	{
		if (pfid == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PremiumFeatureID", pfid));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_ProductDAL, "Products_GetProductByPremiumFeatureID", queryParameters), BuildDAL);
	}

	private static ProductDAL BuildDAL(SqlDataReader reader)
	{
		ProductDAL dal = new ProductDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.ProductGroupID = (byte)reader["ProductGroupID"];
			dal.Name = (string)reader["Name"];
			dal.Price = (decimal)reader["Price"];
			dal.IsRenewable = (bool)reader["IsRenewable"];
			dal.RenewalPeriodTypeID = (reader["RenewalPeriodTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["RenewalPeriodTypeID"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.PremiumFeatureID = (int)reader["PremiumFeatureID"];
			dal.CurrencyTypeID = (reader["CurrencyTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["CurrencyTypeID"]));
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static ICollection<int> GetProductsPaged(int startIndex, int maxRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_ProductDAL, "[dbo].[Products_GetProductIDs_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfProducts()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(dbConnectionString_ProductDAL, "Products_GetTotalNumberOfProducts", queryParameters));
	}
}
