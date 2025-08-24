using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Demographics;

public class IPAddressCountryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxDemographics;

	internal int ID { get; set; }

	internal int IPAddressID { get; set; }

	internal int? CountryID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		RobloxDatabase.RobloxDemographics.Delete("IPAddressCountries_DeleteIPAddressCountryByID", ID);
	}

	internal static IPAddressCountryDAL Get(int id)
	{
		return RobloxDatabase.RobloxDemographics.Get("IPAddressCountries_GetIPAddressCountryByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@IPAddressID", IPAddressID),
			new SqlParameter("@CountryID", CountryID.HasValue ? ((object)CountryID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxDemographics.Insert<int>("IPAddressCountries_InsertIPAddressCountry", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@IPAddressID", IPAddressID),
			new SqlParameter("@CountryID", CountryID.HasValue ? ((object)CountryID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxDemographics.Update("IPAddressCountries_UpdateIPAddressCountryByID", queryParameters);
	}

	internal static ICollection<int> GetIPAddressCountryIDsByCountryID_Paged(int? countryID, int startRowIndex, int maximumRows)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CountryID", countryID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxDemographics.GetIDCollection<int>("IPAddressCountries_GetIPAddressCountryIDsByCountryID_Paged", queryParameters);
	}

	internal static IPAddressCountryDAL GetIPAddressCountryByIPAddressID(int ipAddressID)
	{
		if (ipAddressID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@IPAddressID", ipAddressID)
		};
		return RobloxDatabase.RobloxDemographics.Lookup("IPAddressCountries_GetIPAddressCountryByIPAddressID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<IPAddressCountryDAL> GetOrCreateIPAddressCountryByIPAddressIDAndCountryID(int ipAddressID, int? countryID)
	{
		if (ipAddressID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@IPAddressID", ipAddressID),
			new SqlParameter("@CountryID", countryID.HasValue ? ((object)countryID) : DBNull.Value)
		};
		return RobloxDatabase.RobloxDemographics.GetOrCreate("IPAddressCountries_GetOrCreateIPAddressCountryByIPAddressIDAndCountryID", BuildDAL, queryParameters);
	}

	private static IPAddressCountryDAL BuildDAL(IDictionary<string, object> record)
	{
		return new IPAddressCountryDAL
		{
			ID = (int)record["ID"],
			IPAddressID = (int)record["IPAddressID"],
			CountryID = (int?)record["CountryID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}
}
