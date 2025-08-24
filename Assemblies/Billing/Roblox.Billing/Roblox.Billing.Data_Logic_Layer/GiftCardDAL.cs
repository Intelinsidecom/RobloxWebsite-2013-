using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing.Data_Logic_Layer;

public class GiftCardDAL
{
	private int _ID;

	public string PurchaserName;

	public string PurchaserEmail;

	public string RecipientName;

	public string RecipientEmail;

	public string Message;

	public decimal Value;

	public long? SaleProductID;

	public long ShoppingCartProductID;

	public string RedemptionCode;

	public DateTime? RedemptionDate;

	public long? RedeemerAccountID;

	public byte StatusTypeID;

	public byte ThemeTypeID;

	public DateTime? DeliveryDate;

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

	private static string dbConnectionString_GiftCardDAL => Settings.Default.BillingConnectionString;

	private static GiftCardDAL BuildDAL(SqlDataReader reader)
	{
		GiftCardDAL dal = new GiftCardDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.PurchaserName = (string)reader["PurchaserName"];
			dal.PurchaserEmail = (string)reader["PurchaserEmail"];
			dal.RecipientName = (string)reader["RecipientName"];
			dal.RecipientEmail = (reader["RecipientEmail"].Equals(DBNull.Value) ? null : ((string)reader["RecipientEmail"]));
			dal.Message = (string)reader["Message"];
			dal.Value = (decimal)reader["Value"];
			dal.SaleProductID = (reader["SaleProductID"].Equals(DBNull.Value) ? null : ((long?)reader["SaleProductID"]));
			dal.ShoppingCartProductID = (long)reader["ShoppingCartProductID"];
			dal.RedemptionCode = (string)reader["RedemptionCode"];
			dal.RedemptionDate = (reader["RedemptionDate"].Equals(DBNull.Value) ? null : ((DateTime?)reader["RedemptionDate"]));
			dal.RedeemerAccountID = (reader["RedeemerAccountID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["RedeemerAccountID"])));
			dal.StatusTypeID = (byte)reader["StatusTypeID"];
			dal.ThemeTypeID = (byte)reader["ThemeTypeID"];
			dal.DeliveryDate = (reader["DeliveryDate"].Equals(DBNull.Value) ? null : ((DateTime?)reader["DeliveryDate"]));
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
		queryParameters.Add(new SqlParameter("@PurchaserName", PurchaserName));
		queryParameters.Add(new SqlParameter("@PurchaserEmail", PurchaserEmail));
		queryParameters.Add(new SqlParameter("@RecipientName", RecipientName));
		queryParameters.Add(new SqlParameter("@RecipientEmail", string.IsNullOrEmpty(RecipientEmail) ? ((IConvertible)DBNull.Value) : ((IConvertible)RecipientEmail)));
		queryParameters.Add(new SqlParameter("@Message", Message));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@SaleProductID", SaleProductID.HasValue ? ((object)SaleProductID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@ShoppingCartProductID", ShoppingCartProductID));
		queryParameters.Add(new SqlParameter("@RedemptionCode", string.IsNullOrEmpty(RedemptionCode) ? ((IConvertible)DBNull.Value) : ((IConvertible)RedemptionCode)));
		queryParameters.Add(new SqlParameter("@RedemptionDate", RedemptionDate.HasValue ? ((object)RedemptionDate) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@RedeemerAccountID", RedeemerAccountID.HasValue ? ((object)RedeemerAccountID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@StatusTypeID", StatusTypeID));
		queryParameters.Add(new SqlParameter("@ThemeTypeID", ThemeTypeID));
		queryParameters.Add(new SqlParameter("@DeliveryDate", DeliveryDate.HasValue ? ((object)DeliveryDate) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_GiftCardDAL, "GiftCards_InsertGiftCard", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@PurchaserName", PurchaserName));
		queryParameters.Add(new SqlParameter("@PurchaserEmail", PurchaserEmail));
		queryParameters.Add(new SqlParameter("@RecipientName", RecipientName));
		queryParameters.Add(new SqlParameter("@RecipientEmail", string.IsNullOrEmpty(RecipientEmail) ? ((IConvertible)DBNull.Value) : ((IConvertible)RecipientEmail)));
		queryParameters.Add(new SqlParameter("@Message", Message));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@SaleProductID", SaleProductID.HasValue ? ((object)SaleProductID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@ShoppingCartProductID", ShoppingCartProductID));
		queryParameters.Add(new SqlParameter("@RedemptionCode", string.IsNullOrEmpty(RedemptionCode) ? ((IConvertible)DBNull.Value) : ((IConvertible)RedemptionCode)));
		queryParameters.Add(new SqlParameter("@RedemptionDate", RedemptionDate.HasValue ? ((object)RedemptionDate) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@RedeemerAccountID", RedeemerAccountID.HasValue ? ((object)RedeemerAccountID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@StatusTypeID", StatusTypeID));
		queryParameters.Add(new SqlParameter("@ThemeTypeID", ThemeTypeID));
		queryParameters.Add(new SqlParameter("@DeliveryDate", DeliveryDate.HasValue ? ((object)DeliveryDate) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_GiftCardDAL, "GiftCards_UpdateGiftCardByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_GiftCardDAL, "GiftCards_DeleteGiftCardByID", queryParameters));
	}

	public static GiftCardDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_GiftCardDAL, "GiftCards_GetGiftCardByID", queryParameters), BuildDAL);
	}

	public static GiftCardDAL GetByShoppingCartProductID(long shoppingCartProductId)
	{
		if (shoppingCartProductId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ShoppingCartProductID", shoppingCartProductId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_GiftCardDAL, "GiftCards_GetGiftCardByShoppingCartProductID", queryParameters), BuildDAL);
	}

	public static GiftCardDAL GetBySaleProductID(long saleProductId)
	{
		if (saleProductId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleProductID", saleProductId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_GiftCardDAL, "GiftCards_GetGiftCardBySaleProductID", queryParameters), BuildDAL);
	}

	public static GiftCardDAL GetByRedemptionCode(string redemptionCode)
	{
		if (redemptionCode == null)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@RedemptionCode", string.IsNullOrEmpty(redemptionCode) ? ((IConvertible)DBNull.Value) : ((IConvertible)redemptionCode)));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_GiftCardDAL, "GiftCards_GetGiftCardByRedemptionCode", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetGiftCardIDsByRedeemerAccountID(int count, int redeemerAccountID)
	{
		if (count <= 0)
		{
			return new int[0];
		}
		if (redeemerAccountID == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@RedeemerAccountID", redeemerAccountID));
		queryParameters.Add(new SqlParameter("@Count", count));
		queryParameters.Add(new SqlParameter("@ExclusiveStartID", DBNull.Value));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_GiftCardDAL, "GiftCards_GetGiftCardIDsByRedeemerAccountID_Desc", queryParameters));
	}
}
