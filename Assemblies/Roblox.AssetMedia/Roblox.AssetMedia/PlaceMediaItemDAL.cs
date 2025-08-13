using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.AssetMedia;

internal class PlaceMediaItemDAL
{
	public int ID { get; set; }

	public long PlaceID { get; set; }

	public long MediaAssetID { get; set; }

	public long UploaderUserID { get; set; }

	public int SortOrder { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxAssetMedia.GetConnectionString();

	public static PlaceMediaItemDAL BuildDAL(SqlDataReader reader)
	{
		PlaceMediaItemDAL dal = new PlaceMediaItemDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt32(reader["ID"]);
			dal.PlaceID = (long)reader["PlaceID"];
			dal.MediaAssetID = (long)reader["MediaAssetID"];
			dal.UploaderUserID = (long)reader["UploaderUserID"];
			dal.SortOrder = ((reader["SortOrder"] != DBNull.Value) ? ((int)reader["SortOrder"]) : 0);
			dal.Created = DateTime.SpecifyKind((DateTime)reader["CreatedUtc"], DateTimeKind.Utc);
			dal.Updated = DateTime.SpecifyKind((DateTime)reader["UpdatedUtc"], DateTimeKind.Utc);
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@MediaAssetID", MediaAssetID),
			new SqlParameter("@UploaderUserID", UploaderUserID),
			new SqlParameter("@SortOrder", SortOrder),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		ID = (int)EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "PlaceMediaItemsV2_InsertPlaceMediaItem", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@MediaAssetID", MediaAssetID),
			new SqlParameter("@UploaderUserID", UploaderUserID),
			new SqlParameter("@SortOrder", SortOrder),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "PlaceMediaItemsV2_UpdatePlaceMediaItemByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "PlaceMediaItemsV2_DeletePlaceMediaItemByID", queryParameters));
	}

	public static PlaceMediaItemDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "PlaceMediaItemsV2_GetPlaceMediaItemByID", queryParameters), BuildDAL);
	}

	/// <summary>
	/// This sorts by IsPrimary DESC
	/// </summary>
	public static ICollection<int> GetPlaceMediaItemIDsByPlaceID_Paged(long placeId, int startRowIndex, int maximumRows)
	{
		if (placeId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PlaceID", placeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "PlaceMediaItemsV2_GetPlaceMediaItemIDsByPlaceID_Paged", queryParameters));
	}

	public static int GetTotalNumberOfPlaceMediaItemsByPlaceID(long placeId)
	{
		if (placeId == 0L)
		{
			throw new ApplicationException("Required value not specified: PlaceID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PlaceID", placeId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "PlaceMediaItemsV2_GetTotalNumberOfPlaceMediaItemsByPlaceID", queryParameters));
	}
}
