using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Demographics;

public class GeopositionDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxDemographics;

	internal long ID { get; set; }

	internal double Latitude { get; set; }

	internal double Longitude { get; set; }

	internal DateTime Created { get; set; }

	private static GeopositionDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GeopositionDAL
		{
			ID = (long)record["ID"],
			Latitude = (double)record["Latitude"],
			Longitude = (double)record["Longitude"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxDemographics.Delete("Geopositions_DeleteGeopositionByID", ID);
	}

	internal static GeopositionDAL Get(long id)
	{
		return RobloxDatabase.RobloxDemographics.Get("Geopositions_GetGeopositionByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Latitude", Latitude),
			new SqlParameter("@Longitude", Longitude),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxDemographics.Insert<long>("Geopositions_InsertGeoposition", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Latitude", Latitude),
			new SqlParameter("@Longitude", Longitude),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxDemographics.Update("Geopositions_UpdateGeopositionByID", queryParameters);
	}

	internal static ICollection<GeopositionDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxDemographics.MultiGet("Geopositions_GetGeopositionsByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<GeopositionDAL> GetOrCreateGeoposition(double latitude, double longitude)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Latitude", latitude),
			new SqlParameter("@Longitude", longitude)
		};
		return RobloxDatabase.RobloxDemographics.GetOrCreate("Geopositions_GetOrCreateGeoposition", BuildDAL, queryParameters);
	}
}
