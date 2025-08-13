using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Demographics;

public class IPAddressGeopositionDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxDemographics;

	internal long ID { get; set; }

	internal int IPAddressID { get; set; }

	internal long? GeopositionID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		RobloxDatabase.RobloxDemographics.Delete("IPAddressGeopositions_DeleteIPAddressGeopositionByID", ID);
	}

	internal static IPAddressGeopositionDAL Get(long id)
	{
		return RobloxDatabase.RobloxDemographics.Get("IPAddressGeopositions_GetIPAddressGeopositionByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@IPAddressID", IPAddressID),
			new SqlParameter("@GeopositionID", GeopositionID.HasValue ? ((object)GeopositionID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxDemographics.Insert<long>("IPAddressGeopositions_InsertIPAddressGeoposition", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@IPAddressID", IPAddressID),
			new SqlParameter("@GeopositionID", GeopositionID.HasValue ? ((object)GeopositionID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxDemographics.Update("IPAddressGeopositions_UpdateIPAddressGeopositionByID", queryParameters);
	}

	internal static ICollection<IPAddressGeopositionDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxDemographics.MultiGet("IPAddressGeopositions_GetIPAddressGeopositionsByIDs", ids, BuildDAL);
	}

	internal static IPAddressGeopositionDAL GetIPAddressGeopositionByIPAddressID(int ipAddressID)
	{
		if (ipAddressID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@IPAddressID", ipAddressID)
		};
		return RobloxDatabase.RobloxDemographics.Lookup("IPAddressGeopositions_GetIPAddressGeopositionByIPAddressID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<IPAddressGeopositionDAL> GetOrCreateIPAddressGeoposition(int iPAddressID, long? geopositionID)
	{
		if (iPAddressID == 0)
		{
			return null;
		}
		if (geopositionID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@IPAddressID", iPAddressID),
			new SqlParameter("@GeopositionID", geopositionID.HasValue ? ((object)geopositionID) : DBNull.Value)
		};
		return RobloxDatabase.RobloxDemographics.GetOrCreate("IPAddressGeopositions_GetOrCreateIPAddressGeoposition", BuildDAL, queryParameters);
	}

	private static IPAddressGeopositionDAL BuildDAL(IDictionary<string, object> record)
	{
		return new IPAddressGeopositionDAL
		{
			ID = (long)record["ID"],
			IPAddressID = (int)record["IPAddressID"],
			GeopositionID = (long?)record["GeopositionID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}
}
