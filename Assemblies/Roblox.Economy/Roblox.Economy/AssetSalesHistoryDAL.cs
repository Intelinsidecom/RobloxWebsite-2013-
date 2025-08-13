using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class AssetSalesHistoryDAL
{
	public long ID;

	public long AssetID;

	public string ThirtyDaySalesChart;

	public string ThirtyDayVolumeChart;

	public int ThirtyDayAveragePrice;

	public int ThirtyDaySalesVolume;

	public string NinetyDaySalesChart;

	public string NinetyDayVolumeChart;

	public int NinetyDayAveragePrice;

	public int NinetyDaySalesVolume;

	public string HundredEightyDaySalesChart;

	public string HundredEightyDayVolumeChart;

	public int HundredEightyDayAveragePrice;

	public int HundredEightyDaySalesVolume;

	public int RecentAveragePrice;

	public DateTime Created;

	public DateTime Updated;

	public DateTime UpdatedCharts;

	private static readonly string dbConnectionString_AssetSalesHistoryDAL = Helper.DBConnectionString_AssetSales;

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@ThirtyDaySalesChart", ThirtyDaySalesChart));
		queryParameters.Add(new SqlParameter("@ThirtyDayVolumeChart", ThirtyDayVolumeChart));
		queryParameters.Add(new SqlParameter("@ThirtyDayAveragePrice", ThirtyDayAveragePrice));
		queryParameters.Add(new SqlParameter("@ThirtyDaySalesVolume", ThirtyDaySalesVolume));
		queryParameters.Add(new SqlParameter("@NinetyDaySalesChart", NinetyDaySalesChart));
		queryParameters.Add(new SqlParameter("@NinetyDayVolumeChart", NinetyDayVolumeChart));
		queryParameters.Add(new SqlParameter("@NinetyDayAveragePrice", NinetyDayAveragePrice));
		queryParameters.Add(new SqlParameter("@NinetyDaySalesVolume", NinetyDaySalesVolume));
		queryParameters.Add(new SqlParameter("@HundredEightyDaySalesChart", HundredEightyDaySalesChart));
		queryParameters.Add(new SqlParameter("@HundredEightyDayVolumeChart", HundredEightyDayVolumeChart));
		queryParameters.Add(new SqlParameter("@HundredEightyDayAveragePrice", HundredEightyDayAveragePrice));
		queryParameters.Add(new SqlParameter("@HundredEightyDaySalesVolume", HundredEightyDaySalesVolume));
		queryParameters.Add(new SqlParameter("@RecentAveragePrice", RecentAveragePrice));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@UpdatedCharts", UpdatedCharts));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_AssetSalesHistoryDAL, "AssetSalesHistory_InsertAssetSalesHistory", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@ThirtyDaySalesChart", ThirtyDaySalesChart));
		queryParameters.Add(new SqlParameter("@ThirtyDayVolumeChart", ThirtyDayVolumeChart));
		queryParameters.Add(new SqlParameter("@ThirtyDayAveragePrice", ThirtyDayAveragePrice));
		queryParameters.Add(new SqlParameter("@ThirtyDaySalesVolume", ThirtyDaySalesVolume));
		queryParameters.Add(new SqlParameter("@NinetyDaySalesChart", NinetyDaySalesChart));
		queryParameters.Add(new SqlParameter("@NinetyDayVolumeChart", NinetyDayVolumeChart));
		queryParameters.Add(new SqlParameter("@NinetyDayAveragePrice", NinetyDayAveragePrice));
		queryParameters.Add(new SqlParameter("@NinetyDaySalesVolume", NinetyDaySalesVolume));
		queryParameters.Add(new SqlParameter("@HundredEightyDaySalesChart", HundredEightyDaySalesChart));
		queryParameters.Add(new SqlParameter("@HundredEightyDayVolumeChart", HundredEightyDayVolumeChart));
		queryParameters.Add(new SqlParameter("@HundredEightyDayAveragePrice", HundredEightyDayAveragePrice));
		queryParameters.Add(new SqlParameter("@HundredEightyDaySalesVolume", HundredEightyDaySalesVolume));
		queryParameters.Add(new SqlParameter("@RecentAveragePrice", RecentAveragePrice));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@UpdatedCharts", UpdatedCharts));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_AssetSalesHistoryDAL, "AssetSalesHistory_UpdateAssetSalesHistoryByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_AssetSalesHistoryDAL, "AssetSalesHistory_DeleteAssetSalesHistoryByID", queryParameters));
	}

	public static AssetSalesHistoryDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AssetSalesHistoryDAL, "AssetSalesHistory_GetAssetSalesHistoryByID", queryParameters), BuildDAL);
	}

	public static AssetSalesHistoryDAL GetByAssetID(long assetId)
	{
		if (assetId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", assetId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AssetSalesHistoryDAL, "AssetSalesHistory_GetAssetSalesHistoryByAssetID", queryParameters), BuildDAL);
	}

	public static int GetAveragePrice(long assetId, DateTime start, DateTime end)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", assetId));
		queryParameters.Add(new SqlParameter("@StartDate", start));
		queryParameters.Add(new SqlParameter("@EndDate", end));
		return EntityHelper.GetDataCount<int>(new DbInfo(dbConnectionString_AssetSalesHistoryDAL, "[dbo].[AssetSalesHistory_GetAveragePrice]", queryParameters));
	}

	public static int GetVolume(long assetId, DateTime start, DateTime end)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", assetId));
		queryParameters.Add(new SqlParameter("@StartDate", start));
		queryParameters.Add(new SqlParameter("@EndDate", end));
		return EntityHelper.GetDataCount<int>(new DbInfo(dbConnectionString_AssetSalesHistoryDAL, "[dbo].[AssetSalesHistory_GetVolume]", queryParameters));
	}

	public static List<Tuple<DateTime, int>> GetAverageDailySalesPrices(long assetId, DateTime start, DateTime end)
	{
		List<Tuple<DateTime, int>> results = new List<Tuple<DateTime, int>>();
		DataSet ds;
		using (DbHelper dbHelper = new DbHelper(dbConnectionString_AssetSalesHistoryDAL))
		{
			dbHelper.SQLParameters.Add(new SqlParameter("@AssetID", assetId));
			dbHelper.SQLParameters.Add(new SqlParameter("@StartDate", start));
			dbHelper.SQLParameters.Add(new SqlParameter("@EndDate", end));
			ds = dbHelper.ExecuteSQLDataset("[dbo].[AssetSalesHistory_GetDailyAveragePrice]", CommandType.StoredProcedure, "");
		}
		if (ds.Tables[0] != null)
		{
			foreach (DataRow row in ds.Tables[0].Rows)
			{
				DateTime o0 = (DateTime)row[0];
				int o1 = int.Parse(row[1].ToString());
				results.Add(new Tuple<DateTime, int>(o0, o1));
			}
		}
		return results;
	}

	public static List<Tuple<DateTime, int>> GetDailyVolume(long assetId, DateTime start, DateTime end)
	{
		List<Tuple<DateTime, int>> results = new List<Tuple<DateTime, int>>();
		DataSet ds;
		using (DbHelper dbHelper = new DbHelper(dbConnectionString_AssetSalesHistoryDAL))
		{
			dbHelper.SQLParameters.Add(new SqlParameter("@AssetID", assetId));
			dbHelper.SQLParameters.Add(new SqlParameter("@StartDate", start));
			dbHelper.SQLParameters.Add(new SqlParameter("@EndDate", end));
			ds = dbHelper.ExecuteSQLDataset("[dbo].[AssetSalesHistory_GetDailyVolume]", CommandType.StoredProcedure, "");
		}
		if (ds.Tables[0] != null)
		{
			foreach (DataRow row in ds.Tables[0].Rows)
			{
				DateTime o0 = (DateTime)row[0];
				int o1 = int.Parse(row[1].ToString());
				results.Add(new Tuple<DateTime, int>(o0, o1));
			}
		}
		return results;
	}

	private static AssetSalesHistoryDAL BuildDAL(SqlDataReader reader)
	{
		AssetSalesHistoryDAL dal = new AssetSalesHistoryDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.ThirtyDaySalesChart = (reader["ThirtyDaySalesChart"].Equals(DBNull.Value) ? "" : ((string)reader["ThirtyDaySalesChart"]));
			dal.ThirtyDayVolumeChart = (reader["ThirtyDayVolumeChart"].Equals(DBNull.Value) ? "" : ((string)reader["ThirtyDayVolumeChart"]));
			dal.ThirtyDayAveragePrice = (int)reader["ThirtyDayAveragePrice"];
			dal.ThirtyDaySalesVolume = (int)reader["ThirtyDaySalesVolume"];
			dal.NinetyDaySalesChart = (reader["NinetyDaySalesChart"].Equals(DBNull.Value) ? "" : ((string)reader["NinetyDaySalesChart"]));
			dal.NinetyDayVolumeChart = (reader["NinetyDayVolumeChart"].Equals(DBNull.Value) ? "" : ((string)reader["NinetyDayVolumeChart"]));
			dal.NinetyDayAveragePrice = (int)reader["NinetyDayAveragePrice"];
			dal.NinetyDaySalesVolume = (int)reader["NinetyDaySalesVolume"];
			dal.HundredEightyDaySalesChart = (reader["HundredEightyDaySalesChart"].Equals(DBNull.Value) ? "" : ((string)reader["HundredEightyDaySalesChart"]));
			dal.HundredEightyDayVolumeChart = (reader["HundredEightyDayVolumeChart"].Equals(DBNull.Value) ? "" : ((string)reader["HundredEightyDayVolumeChart"]));
			dal.HundredEightyDayAveragePrice = (int)reader["HundredEightyDayAveragePrice"];
			dal.HundredEightyDaySalesVolume = (int)reader["HundredEightyDaySalesVolume"];
			dal.RecentAveragePrice = (int)reader["RecentAveragePrice"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.UpdatedCharts = (reader["UpdatedCharts"].Equals(DBNull.Value) ? default(DateTime) : ((DateTime)reader["UpdatedCharts"]));
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}
}
