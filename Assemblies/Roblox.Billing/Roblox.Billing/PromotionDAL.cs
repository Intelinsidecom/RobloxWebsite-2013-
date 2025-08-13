using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class PromotionDAL
{
	private short _ID;

	public int ProductID;

	public string Name;

	public string Description;

	public decimal DiscountedPrice;

	public bool Active;

	public byte? CurrencyTypeID;

	public DateTime Created;

	public DateTime Updated;

	public short ID
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

	private static string dbConnectionString_PromotionDAL => Settings.Default.BillingConnectionString;

	private static PromotionDAL BuildDAL(SqlDataReader reader)
	{
		PromotionDAL dal = new PromotionDAL();
		while (reader.Read())
		{
			dal.ID = (short)reader["ID"];
			dal.ProductID = (int)reader["ProductID"];
			dal.Name = (string)reader["Name"];
			dal.Description = (string)reader["Description"];
			dal.DiscountedPrice = (decimal)reader["DiscountedPrice"];
			dal.Active = (bool)reader["Active"];
			dal.CurrencyTypeID = (reader["CurrencyTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["CurrencyTypeID"]));
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
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Description", Description));
		queryParameters.Add(new SqlParameter("@DiscountedPrice", DiscountedPrice));
		queryParameters.Add(new SqlParameter("@Active", Active));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<short>(new DbInfo(dbConnectionString_PromotionDAL, "Promotions_InsertPromotion", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Description", Description));
		queryParameters.Add(new SqlParameter("@DiscountedPrice", DiscountedPrice));
		queryParameters.Add(new SqlParameter("@Active", Active));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_PromotionDAL, "Promotions_UpdatePromotionByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_PromotionDAL, "Promotions_DeletePromotionByID", queryParameters));
	}

	public static PromotionDAL Get(short id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_PromotionDAL, "Promotions_GetPromotionByID", queryParameters), BuildDAL);
	}

	public static PromotionDAL Get(string name)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_PromotionDAL, "[dbo].[Promotions_GetPromotionByName]", queryParameters), BuildDAL);
	}

	public static ICollection<short> GetPromotionIDsByProductID(int ProductID)
	{
		if (ProductID == 0)
		{
			throw new ApplicationException("Required value not specified: ProductID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		return EntityHelper.GetDataEntityIDCollection<short>(new DbInfo(dbConnectionString_PromotionDAL, "Promotions_GetPromotionIDsByProductID", queryParameters));
	}
}
