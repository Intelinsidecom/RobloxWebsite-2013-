using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Economy;

public class AssetSaleDAL
{
	private static readonly string _ConnectionString = RobloxDatabase.RobloxAssetSales.GetConnectionString();

	private long _ID;

	public long SaleID;

	public long AssetID;

	public int AssetTypeID;

	public DateTime SaleDate;

	public long TotalPrice;

	public int CurrencyTypeID;

	public long? SellerID;

	public DateTime Created;

	public DateTime Updated;

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

	private static AssetSaleDAL GetDALFromReader(SqlDataReader reader)
	{
		AssetSaleDAL dal = new AssetSaleDAL();
		dal.ID = (long)reader["ID"];
		dal.SaleID = (long)reader["SaleID"];
		dal.AssetID = (long)reader["AssetID"];
		dal.AssetTypeID = (int)reader["AssetTypeID"];
		dal.SaleDate = (DateTime)reader["SaleDate"];
		dal.TotalPrice = (long)reader["TotalPrice"];
		dal.CurrencyTypeID = (int)reader["CurrencyTypeID"];
		dal.SellerID = (reader["SellerID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["SellerID"])));
		dal.Created = (DateTime)reader["Created"];
		dal.Updated = (DateTime)reader["Updated"];
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static AssetSaleDAL BuildDAL(SqlDataReader reader)
	{
		AssetSaleDAL dal = new AssetSaleDAL();
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", AssetTypeID));
		queryParameters.Add(new SqlParameter("@SaleDate", SaleDate));
		queryParameters.Add(new SqlParameter("@TotalPrice", TotalPrice));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID));
		queryParameters.Add(new SqlParameter("@SellerID", SellerID.HasValue ? ((object)SellerID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(_ConnectionString, "AssetSales_InsertAssetSale", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", AssetTypeID));
		queryParameters.Add(new SqlParameter("@SaleDate", SaleDate));
		queryParameters.Add(new SqlParameter("@TotalPrice", TotalPrice));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID));
		queryParameters.Add(new SqlParameter("@SellerID", SellerID.HasValue ? ((object)SellerID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(_ConnectionString, "AssetSales_UpdateAssetSaleByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(_ConnectionString, "AssetSales_DeleteAssetSaleByID", queryParameters));
	}

	public static AssetSaleDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(_ConnectionString, "AssetSales_GetAssetSaleByID", queryParameters), BuildDAL);
	}

	public static long GetSumOfTotalPriceByAssetIDCurrencyTypeIDFromDate(long assetId, byte currencyTypeId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", assetId));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", currencyTypeId));
		queryParameters.Add(new SqlParameter("@FromDateTime", fromDateTime));
		return EntityHelper.GetDataCount<long>(new DbInfo(_ConnectionString, "[AssetSales_GetSumOfTotalPriceByAssetIDCurrencyTypeIDFromDate]", queryParameters));
	}

	public static ICollection<long> GetAssetSaleIDsByAssetID(long assetId, int maximumRows, long exclusiveStartAssetSaleId)
	{
		if (assetId == 0L)
		{
			throw new ApplicationException(string.Format("Required value not specified: {0}", "assetId"));
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", assetId));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		queryParameters.Add(new SqlParameter("@ExclusiveStartID", exclusiveStartAssetSaleId));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_ConnectionString, "[dbo].[AssetSales_GetAssetSaleIDsByAssetID]", queryParameters));
	}

	public static ICollection<AssetSaleDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_ConnectionString, "[dbo].[AssetSales_GetAssetSalesByIDs]"), ids, BuildDALCollection);
	}

	private static List<AssetSaleDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<AssetSaleDAL> dals = new List<AssetSaleDAL>();
		while (reader.Read())
		{
			AssetSaleDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}
}
