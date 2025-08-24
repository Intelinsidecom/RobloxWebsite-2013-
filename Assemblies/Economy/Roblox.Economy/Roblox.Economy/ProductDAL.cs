using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Economy;

[Serializable]
public class ProductDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxEconomy.GetConnectionString();

	public long ID { get; set; }

	public byte ProductTypeID { get; set; }

	public bool IsPublicDomain { get; set; }

	public bool IsForSale { get; set; }

	public long? PriceInRobux { get; set; }

	public long? PriceInTickets { get; set; }

	public int? RobloxProductID { get; set; }

	public long? AssetID { get; set; }

	public int? AssetTypeID { get; set; }

	public long? CreatorID { get; set; }

	public long AssetGenres { get; set; }

	public long AssetCategories { get; set; }

	public int? AffiliateFeePercentage { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Insert()
	{
		if (ProductTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: ProductTypeID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] obj = new SqlParameter[14]
		{
			new SqlParameter("@ProductTypeID", ProductTypeID),
			new SqlParameter("@IsPublicDomain", IsPublicDomain),
			new SqlParameter("@IsForSale", IsForSale),
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		long? priceInRobux = PriceInRobux;
		obj[3] = new SqlParameter("@PriceInRobux", priceInRobux.HasValue ? ((object)priceInRobux.GetValueOrDefault()) : DBNull.Value);
		priceInRobux = PriceInTickets;
		obj[4] = new SqlParameter("@PriceInTickets", priceInRobux.HasValue ? ((object)priceInRobux.GetValueOrDefault()) : DBNull.Value);
		int? robloxProductID = RobloxProductID;
		obj[5] = new SqlParameter("@RobloxProductID", robloxProductID.HasValue ? ((object)robloxProductID.GetValueOrDefault()) : DBNull.Value);
		priceInRobux = AssetID;
		obj[6] = new SqlParameter("@AssetID", priceInRobux.HasValue ? ((object)priceInRobux.GetValueOrDefault()) : DBNull.Value);
		robloxProductID = AssetTypeID;
		obj[7] = new SqlParameter("@AssetTypeID", robloxProductID.HasValue ? ((object)robloxProductID.GetValueOrDefault()) : DBNull.Value);
		priceInRobux = CreatorID;
		obj[8] = new SqlParameter("@CreatorID", priceInRobux.HasValue ? ((object)priceInRobux.GetValueOrDefault()) : DBNull.Value);
		obj[9] = new SqlParameter("@AssetGenres", AssetGenres);
		obj[10] = new SqlParameter("@AssetCategories", AssetCategories);
		obj[11] = new SqlParameter("@AffiliateFeePercentage", AffiliateFeePercentage.HasValue ? ((object)AffiliateFeePercentage.Value) : DBNull.Value);
		obj[12] = new SqlParameter("@Created", Created);
		obj[13] = new SqlParameter("@Updated", Updated);
		SqlParameter[] queryParameters = obj;
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[Products_InsertProduct]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (ProductTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: ProductTypeID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] obj = new SqlParameter[15]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ProductTypeID", ProductTypeID),
			new SqlParameter("@IsPublicDomain", IsPublicDomain),
			new SqlParameter("@IsForSale", IsForSale),
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		long? priceInRobux = PriceInRobux;
		obj[4] = new SqlParameter("@PriceInRobux", priceInRobux.HasValue ? ((object)priceInRobux.GetValueOrDefault()) : DBNull.Value);
		priceInRobux = PriceInTickets;
		obj[5] = new SqlParameter("@PriceInTickets", priceInRobux.HasValue ? ((object)priceInRobux.GetValueOrDefault()) : DBNull.Value);
		int? robloxProductID = RobloxProductID;
		obj[6] = new SqlParameter("@RobloxProductID", robloxProductID.HasValue ? ((object)robloxProductID.GetValueOrDefault()) : DBNull.Value);
		priceInRobux = AssetID;
		obj[7] = new SqlParameter("@AssetID", priceInRobux.HasValue ? ((object)priceInRobux.GetValueOrDefault()) : DBNull.Value);
		robloxProductID = AssetTypeID;
		obj[8] = new SqlParameter("@AssetTypeID", robloxProductID.HasValue ? ((object)robloxProductID.GetValueOrDefault()) : DBNull.Value);
		priceInRobux = CreatorID;
		obj[9] = new SqlParameter("@CreatorID", priceInRobux.HasValue ? ((object)priceInRobux.GetValueOrDefault()) : DBNull.Value);
		obj[10] = new SqlParameter("@AssetGenres", AssetGenres);
		obj[11] = new SqlParameter("@AssetCategories", AssetCategories);
		obj[12] = new SqlParameter("@AffiliateFeePercentage", AffiliateFeePercentage.HasValue ? ((object)AffiliateFeePercentage.Value) : DBNull.Value);
		obj[13] = new SqlParameter("@Created", Created);
		obj[14] = new SqlParameter("@Updated", Updated);
		SqlParameter[] queryParameters = obj;
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[Products_UpdateProductByID]", queryParameters));
	}

	private static ProductDAL BuildDAL(SqlDataReader reader)
	{
		ProductDAL dal = new ProductDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ProductTypeID = (byte)reader["ProductTypeID"];
			dal.IsPublicDomain = (bool)reader["IsPublicDomain"];
			dal.IsForSale = (bool)reader["IsForSale"];
			dal.PriceInRobux = (reader["PriceInRobux"].Equals(DBNull.Value) ? null : ((long?)reader["PriceInRobux"]));
			dal.PriceInTickets = (reader["PriceInTickets"].Equals(DBNull.Value) ? null : ((long?)reader["PriceInTickets"]));
			dal.RobloxProductID = (reader["RobloxProductID"].Equals(DBNull.Value) ? null : ((int?)reader["RobloxProductID"]));
			dal.AssetID = (reader["AssetID"].Equals(DBNull.Value) ? null : ((long?)reader["AssetID"]));
			dal.AssetTypeID = (reader["AssetTypeID"].Equals(DBNull.Value) ? null : ((int?)reader["AssetTypeID"]));
			dal.CreatorID = (reader["CreatorID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["CreatorID"])));
			dal.AssetGenres = (long)reader["AssetGenres"];
			dal.AssetCategories = (long)reader["AssetCategories"];
			dal.AffiliateFeePercentage = (reader["AffiliateFeePercentage"].Equals(DBNull.Value) ? null : ((byte?)reader["AffiliateFeePercentage"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static List<ProductDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<ProductDAL> dals = new List<ProductDAL>();
		while (reader.Read())
		{
			ProductDAL dal = BuildDAL(reader);
			dals.Add(dal);
		}
		return dals;
	}

	public static ProductDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[Products_GetProductByID]", queryParameters), BuildDAL);
	}

	internal static ProductDAL GetByProductTypeIDAndTargetID(int productTypeId, long targetId)
	{
		if (productTypeId == 0)
		{
			return null;
		}
		if (targetId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@ProductTypeID", productTypeId),
			new SqlParameter("@AssetID", targetId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "Products_GetProductByProductTypeIDAndTargetID", queryParameters), BuildDAL);
	}

	internal static ProductDAL GetByRobloxProductID(int robloxProductId)
	{
		if (robloxProductId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@RobloxProductID", robloxProductId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "Products_GetProductByRobloxProductID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetProductIdsByProductTypeIDAndTargetID(int productTypeId, long targetId)
	{
		if (productTypeId == 0)
		{
			throw new ApplicationException(string.Format("Required value not specified: {0}", "productTypeId"));
		}
		if (targetId == 0L)
		{
			throw new ApplicationException(string.Format("Required value not specified: {0}", "targetId"));
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@ProductTypeID", productTypeId),
			new SqlParameter("@AssetID", targetId)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[Products_GetProductByProductTypeIDAndTargetID]", queryParameters));
	}
}
