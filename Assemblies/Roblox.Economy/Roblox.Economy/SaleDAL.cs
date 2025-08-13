using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

[Serializable]
public class SaleDAL
{
	private long _ID;

	private long _PurchaserID;

	private long? _SellerID;

	private long _ProductID;

	private int _Quantity;

	private byte _CurrencyTypeID;

	private long _UnitPrice;

	private long _Discount;

	private long _TotalPrice;

	private long _MarketplaceFee;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

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

	public long PurchaserID
	{
		get
		{
			return _PurchaserID;
		}
		set
		{
			_PurchaserID = value;
		}
	}

	public long? SellerID
	{
		get
		{
			return _SellerID;
		}
		set
		{
			_SellerID = value;
		}
	}

	public long ProductID
	{
		get
		{
			return _ProductID;
		}
		set
		{
			_ProductID = value;
		}
	}

	public int Quantity
	{
		get
		{
			return _Quantity;
		}
		set
		{
			_Quantity = value;
		}
	}

	public byte CurrencyTypeID
	{
		get
		{
			return _CurrencyTypeID;
		}
		set
		{
			_CurrencyTypeID = value;
		}
	}

	public long UnitPrice
	{
		get
		{
			return _UnitPrice;
		}
		set
		{
			_UnitPrice = value;
		}
	}

	public long Discount
	{
		get
		{
			return _Discount;
		}
		set
		{
			_Discount = value;
		}
	}

	public long TotalPrice
	{
		get
		{
			return _TotalPrice;
		}
		set
		{
			_TotalPrice = value;
		}
	}

	public long MarketplaceFee
	{
		get
		{
			return _MarketplaceFee;
		}
		set
		{
			_MarketplaceFee = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _Created;
		}
		set
		{
			_Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _Updated;
		}
		set
		{
			_Updated = value;
		}
	}

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_DeleteSaleByID]", queryParameters));
	}

	public void Insert()
	{
		if (_PurchaserID == 0L)
		{
			throw new ApplicationException("Required value not specified: PurchaserID.");
		}
		if (_ProductID == 0L)
		{
			throw new ApplicationException("Required value not specified: ProductID.");
		}
		if (_CurrencyTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: CurrencyTypeID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PurchaserID", _PurchaserID));
		queryParameters.Add(new SqlParameter("@SellerID", (_SellerID > 0) ? ((object)_SellerID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@ProductID", _ProductID));
		queryParameters.Add(new SqlParameter("@Quantity", _Quantity));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", _CurrencyTypeID));
		queryParameters.Add(new SqlParameter("@UnitPrice", _UnitPrice));
		queryParameters.Add(new SqlParameter("@Discount", _Discount));
		queryParameters.Add(new SqlParameter("@TotalPrice", _TotalPrice));
		queryParameters.Add(new SqlParameter("@MarketplaceFee", _MarketplaceFee));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_InsertSale]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (_PurchaserID == 0L)
		{
			throw new ApplicationException("Required value not specified: PurchaserID.");
		}
		if (_ProductID == 0L)
		{
			throw new ApplicationException("Required value not specified: ProductID.");
		}
		if (_CurrencyTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: CurrencyTypeID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@PurchaserID", _PurchaserID));
		queryParameters.Add(new SqlParameter("@SellerID", (_SellerID > 0) ? ((object)_SellerID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@ProductID", _ProductID));
		queryParameters.Add(new SqlParameter("@Quantity", _Quantity));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", _CurrencyTypeID));
		queryParameters.Add(new SqlParameter("@UnitPrice", _UnitPrice));
		queryParameters.Add(new SqlParameter("@Discount", _Discount));
		queryParameters.Add(new SqlParameter("@TotalPrice", _TotalPrice));
		queryParameters.Add(new SqlParameter("@MarketplaceFee", _MarketplaceFee));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_UpdateSaleByID]", queryParameters));
	}

	private static SaleDAL BuildDAL(SqlDataReader reader)
	{
		SaleDAL dal = new SaleDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.PurchaserID = Convert.ToInt64(reader["PurchaserID"]);
			dal.SellerID = (reader["SellerID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["SellerID"])));
			dal.ProductID = (long)reader["ProductID"];
			dal.Quantity = (int)reader["Quantity"];
			dal.CurrencyTypeID = (byte)reader["CurrencyTypeID"];
			dal.UnitPrice = (long)reader["UnitPrice"];
			dal.Discount = (long)reader["Discount"];
			dal.TotalPrice = (long)reader["TotalPrice"];
			dal.MarketplaceFee = (long)reader["MarketplaceFee"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static SaleDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_GetSaleByID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetSaleIDsByPurchaserPaged(long purchaserId, int startRowIndex, int maximumRows)
	{
		if (purchaserId == 0L)
		{
			throw new ApplicationException("Required value purchaserId not supplied: " + purchaserId);
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PurchaserID", purchaserId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_GetSaleIDsByPurchaserID_Paged]", queryParameters));
	}

	public static ICollection<long> GetSaleIDsByProductIDPaged(long productId, int startRowIndex, int maxRows)
	{
		if (productId == 0L)
		{
			throw new ApplicationException("Required value not specified: ProductID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: MaxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", productId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_GetSaleIDsByProductID_Paged]", queryParameters));
	}

	public static ICollection<long> GetSaleIDs(long exclusiveStartId, int maxRows)
	{
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: MaxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ExclusiveStartID", exclusiveStartId));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_GetSaleIDs]", queryParameters));
	}

	public static ICollection<long> GetSaleIDsBySellerPaged(long sellerId, int startRowIndex, int maximumRows)
	{
		if (sellerId == 0L)
		{
			throw new ApplicationException("Required value sellerId not supplied: " + sellerId);
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SellerID", sellerId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_GetSaleIDsBySellerID_Paged]", queryParameters));
	}

	public static long GetTotalNumberOfSalesBySellerID(long sellerId)
	{
		if (sellerId == 0L)
		{
			throw new ApplicationException("Required value sellerId not supplied: " + sellerId);
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SellerID", sellerId));
		return GetLongFromObject(EntityHelper.GetDataCount<object>(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_GetTotalNumberOfSalesBySellerID]", queryParameters)));
	}

	public static long GetTotalNumberOfSalesByPurchaserID(long purchaserId)
	{
		if (purchaserId == 0L)
		{
			throw new ApplicationException("Required value purchaserId not supplied: " + purchaserId);
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PurchaserID", purchaserId));
		return GetLongFromObject(EntityHelper.GetDataCount<object>(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_GetTotalNumberOfSalesByPurchaserID]", queryParameters)));
	}

	private static long GetLongFromObject(object result)
	{
		if (result != null)
		{
			object obj;
			if ((obj = result) is int)
			{
				_ = (int)obj;
				return Convert.ToInt32(result);
			}
			if ((obj = result) is long)
			{
				_ = (long)obj;
				return Convert.ToInt64(result);
			}
			throw new ArgumentException("result");
		}
		return 0L;
	}

	public static long GetSumOfTotalPriceByProductIDCurrencyTypeIDFromDate(long productId, byte currencyTypeID, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", productId));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", currencyTypeID));
		queryParameters.Add(new SqlParameter("@FromDateTime", fromDateTime));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[SalesV2_GetSumOfTotalPriceByProductIDCurrencyTypeIDFromDate]", queryParameters));
	}
}
