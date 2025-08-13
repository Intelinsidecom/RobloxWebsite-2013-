using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.AssetMedia.Entities;

internal class PlaceIconDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxAssetMedia.GetConnectionString();

	internal long ID { get; set; }

	internal long PlaceID { get; set; }

	internal long ImageID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static PlaceIconDAL GetDALFromReader(SqlDataReader reader)
	{
		PlaceIconDAL dal = new PlaceIconDAL
		{
			ID = (long)reader["ID"],
			PlaceID = (long)reader["PlaceID"],
			ImageID = (long)reader["ImageID"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static PlaceIconDAL BuildDAL(SqlDataReader reader)
	{
		PlaceIconDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PlaceIconDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PlaceIconDAL> dals = new List<PlaceIconDAL>();
		while (reader.Read())
		{
			PlaceIconDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "PlaceIcons_DeletePlaceIconByID", queryParameters));
	}

	internal static PlaceIconDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "PlaceIcons_GetPlaceIconByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@ImageID", ImageID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "PlaceIcons_InsertPlaceIcon", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@ImageID", ImageID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "PlaceIcons_UpdatePlaceIconByID", queryParameters));
	}

	internal static ICollection<PlaceIconDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "PlaceIcons_GetPlaceIconsByIDs"), ids, BuildDALCollection);
	}

	internal static PlaceIconDAL GetPlaceIconByPlaceID(long placeID)
	{
		if (placeID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PlaceID", placeID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "PlaceIcons_GetPlaceIconByPlaceID", queryParameters), BuildDAL);
	}
}
