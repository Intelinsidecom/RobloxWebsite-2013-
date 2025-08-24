using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class SponsoredPageCountryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int SponsoredPageID { get; set; }

	internal int CountryID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxMarketing.Delete("SponsoredPageCountries_DeleteSponsoredPageCountryByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@CountryID", CountryID),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("SponsoredPageCountries_InsertSponsoredPageCountry", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@CountryID", CountryID),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("SponsoredPageCountries_UpdateSponsoredPageCountryByID", queryParameters);
	}

	private static SponsoredPageCountryDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new SponsoredPageCountryDAL
		{
			ID = id,
			SponsoredPageID = (int)record["SponsoredPageID"],
			CountryID = (int)record["CountryID"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal static SponsoredPageCountryDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("SponsoredPageCountries_GetSponsoredPageCountryByID", id, BuildDAL);
	}

	internal static ICollection<int> GetSponsoredPageCountryIDsBySponsoredPageID_Paged(int sponsoredPageId, int startRowIndex, int maximumRows)
	{
		if (sponsoredPageId == 0)
		{
			throw new ApplicationException("Required value not specified: SponsoredPageID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@SponsoredPageID", sponsoredPageId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("SponsoredPageCountries_GetSponsoredPageCountryIDsBySponsoredPageID_Paged", queryParameters);
	}

	internal static ICollection<int> GetSponsoredPageCountryIDsByCountryID_Paged(int countryId, int startRowIndex, int maximumRows)
	{
		if (countryId == 0)
		{
			throw new ApplicationException("Required value not specified: CountryID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CountryID", countryId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("SponsoredPageCountries_GetSponsoredPageCountryIDsByCountryID_Paged", queryParameters);
	}
}
