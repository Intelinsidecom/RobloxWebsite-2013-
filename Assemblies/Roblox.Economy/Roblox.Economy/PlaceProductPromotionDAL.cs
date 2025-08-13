using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class PlaceProductPromotionDAL
{
	private long _ID;

	public long PlaceID;

	public long ProductID;

	public int SortOrder;

	public DateTime Created = DateTime.MinValue;

	public DateTime Updated = DateTime.MinValue;

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

	private static string dbConnectionString_PlaceProductPromotionDAL => Helper.DBConnectionString;

	private static PlaceProductPromotionDAL BuildDAL(SqlDataReader reader)
	{
		PlaceProductPromotionDAL dal = new PlaceProductPromotionDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.PlaceID = (long)reader["PlaceID"];
			dal.ProductID = (long)reader["ProductID"];
			dal.SortOrder = (int)reader["SortOrder"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		if (PlaceID == 0L)
		{
			throw new ApplicationException("Required value not specified: PlaceID.");
		}
		if (ProductID == 0L)
		{
			throw new ApplicationException("Required value not specified: ProductID.");
		}
		if (SortOrder == 0)
		{
			throw new ApplicationException("Required value not specified: SortOrder.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PlaceID", PlaceID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@SortOrder", SortOrder));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_PlaceProductPromotionDAL, "PlaceProductPromotions_InsertPlaceProductPromotion", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: _ID.");
		}
		if (PlaceID == 0L)
		{
			throw new ApplicationException("Required value not specified: PlaceID.");
		}
		if (ProductID == 0L)
		{
			throw new ApplicationException("Required value not specified: ProductID.");
		}
		if (SortOrder == 0)
		{
			throw new ApplicationException("Required value not specified: SortOrder.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@PlaceID", PlaceID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@SortOrder", SortOrder));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_PlaceProductPromotionDAL, "PlaceProductPromotions_UpdatePlaceProductPromotionByID", queryParameters));
	}

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: _ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_PlaceProductPromotionDAL, "PlaceProductPromotions_DeletePlaceProductPromotionByID", queryParameters));
	}

	public static PlaceProductPromotionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_PlaceProductPromotionDAL, "PlaceProductPromotions_GetPlaceProductPromotionByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetPlaceProductPromotionIDsByPlaceID_Paged(long placeId, int startRowIndex, int maximumRows)
	{
		if (placeId == 0L)
		{
			throw new ApplicationException("Required value not specified: placeId.");
		}
		if (maximumRows == 0)
		{
			throw new ApplicationException("Required value not specified: maximumRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PlaceID", placeId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_PlaceProductPromotionDAL, "[dbo].[PlaceProductPromotions_GetPlaceProductPromotionIDsByPlaceID_Paged]", queryParameters));
	}

	public static long GetTotalNumberOfProductPromotionIDsByPlaceID(long placeId)
	{
		if (placeId == 0L)
		{
			throw new ApplicationException("Required value not specified: placeId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PlaceID", placeId));
		return EntityHelper.GetDataCount<long>(new DbInfo(dbConnectionString_PlaceProductPromotionDAL, "[dbo].[PlaceProductPromotions_GetTotalNumberOfPlaceProductPromotionsByPlaceID]", queryParameters));
	}

	public static PlaceProductPromotionDAL GetPlaceProductPromotionByPlaceIDAndProductID(long placeId, long productId)
	{
		if (placeId == 0L)
		{
			throw new ApplicationException("Required value not specified: placeId.");
		}
		if (productId == 0L)
		{
			throw new ApplicationException("Required value not specified: productId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PlaceID", placeId));
		queryParameters.Add(new SqlParameter("@ProductID", productId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_PlaceProductPromotionDAL, "PlaceProductPromotions_GetPlaceProductPromotionByPlaceIDAndProductID", queryParameters), BuildDAL);
	}
}
