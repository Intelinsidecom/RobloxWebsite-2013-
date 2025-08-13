using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class ProductGenreMappingDAL
{
	private long _ID;

	public long ProductID;

	public byte AssetGenreID;

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

	private static string ConnectionString => RobloxDatabase.RobloxAssets.GetConnectionString();

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "ProductGenreMappings_DeleteProductGenreMappingByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@AssetGenreID", AssetGenreID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "ProductGenreMappings_InsertProductGenreMapping", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@AssetGenreID", AssetGenreID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "ProductGenreMappings_UpdateProductGenreMappingByID", queryParameters));
	}

	private static ProductGenreMappingDAL BuildDAL(SqlDataReader reader)
	{
		ProductGenreMappingDAL dal = new ProductGenreMappingDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ProductID = (long)reader["ProductID"];
			dal.AssetGenreID = (byte)reader["AssetGenreID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static ProductGenreMappingDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ProductGenreMappings_GetProductGenreMappingByID", queryParameters), BuildDAL);
	}

	public static ProductGenreMappingDAL GetByProductID(long productId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", productId));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ProductGenreMappings_GetProductGenreMappingByProductID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetProductGenreIDsByGenreSortedAndPaged(byte assetGenreId, int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetGenreID", assetGenreId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[ProductGenreMappings_GetProductGenreMappingsByGenreSortedAndPaged]", queryParameters));
	}

	public static long GetTotalNumberOfProductGenreMappingsByGenre(byte assetGenreId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetGenreID", assetGenreId));
		return EntityHelper.GetDataCount<long>(new DbInfo(ConnectionString, "[dbo].[ProductGenreMappings_GetTotalNumberOfProductGenreMappingsByGenre]", queryParameters));
	}
}
