using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class TakeoverCountryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int TakeoverID { get; set; }

	internal int CountryID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxMarketing.Delete("TakeoverCountries_DeleteTakeoverCountryByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@TakeoverID", TakeoverID),
			new SqlParameter("@CountryID", CountryID),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("TakeoverCountries_InsertTakeoverCountry", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@TakeoverID", TakeoverID),
			new SqlParameter("@CountryID", CountryID),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("TakeoverCountries_UpdateTakeoverCountryByID", queryParameters);
	}

	private static TakeoverCountryDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new TakeoverCountryDAL
		{
			ID = id,
			TakeoverID = (int)record["TakeoverID"],
			CountryID = (int)record["CountryID"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal static TakeoverCountryDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("TakeoverCountries_GetTakeoverCountryByID", id, BuildDAL);
	}

	internal static TakeoverCountryDAL GetByTakeoverIDAndCountryID(int takeoverId, int? countryId)
	{
		if (takeoverId == 0)
		{
			throw new ApplicationException("Required value not specified: TakeoverID.");
		}
		if (countryId == 0)
		{
			throw new ApplicationException("Required value not specified: CountryID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@TakeoverID", takeoverId),
			new SqlParameter("@CountryID", countryId.HasValue ? ((object)countryId) : DBNull.Value)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("TakeoverCountries_GetTakeoverCountryByTakeoverIDAndCountryID", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetTakeoverCountryIDsByTakeoverID_Paged(int takeoverId, int startRowIndex, int maximumRows)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@TakeoverID", takeoverId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("TakeoverCountries_GetTakeoverCountryIDsByTakeoverID_Paged", queryParameters);
	}

	internal static int GetTotalNumberOfTakeoverCountriesByTakeoverID(int takeoverId)
	{
		if (takeoverId == 0)
		{
			throw new ApplicationException("Required value not specified: takeoverId.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@TakeoverID", takeoverId)
		};
		return RobloxDatabase.RobloxMarketing.GetCount<int>("TakeoverCountries_GetTotalNumberOfTakeoverCountriesByTakeoverID", queryParameters);
	}
}
