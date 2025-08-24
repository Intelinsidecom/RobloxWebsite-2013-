using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class SponsoredPagePlaceDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int SponsoredPageID { get; set; }

	internal long PlaceID { get; set; }

	internal int SortOrder { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal string Description { get; set; }

	private static SponsoredPagePlaceDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new SponsoredPagePlaceDAL
		{
			ID = id,
			SponsoredPageID = (int)record["SponsoredPageID"],
			PlaceID = (long)record["PlaceID"],
			SortOrder = (int)record["SortOrder"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local),
			Description = (string)record["Description"]
		};
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@SortOrder", SortOrder),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime()),
			new SqlParameter("@Description", string.IsNullOrWhiteSpace(Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Description))
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("SponsoredPagePlaces_InsertSponsoredPagePlace", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@SortOrder", SortOrder),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime()),
			new SqlParameter("@Description", string.IsNullOrWhiteSpace(Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Description))
		};
		RobloxDatabase.RobloxMarketing.Update("SponsoredPagePlaces_UpdateSponsoredPagePlaceByID", queryParameters);
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("SponsoredPagePlaces_DeleteSponsoredPagePlaceByID", ID);
	}

	internal static SponsoredPagePlaceDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("SponsoredPagePlaces_GetSponsoredPagePlaceByID", id, BuildDAL);
	}

	internal static ICollection<int> GetSponsoredPagePlaceIDsBySponsoredPageID_Paged(int sponsoredPageId, int startRowIndex, int maximumRows)
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
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("SponsoredPagePlaces_GetSponsoredPagePlaceIDsBySponsoredPageID_Paged", queryParameters);
	}
}
