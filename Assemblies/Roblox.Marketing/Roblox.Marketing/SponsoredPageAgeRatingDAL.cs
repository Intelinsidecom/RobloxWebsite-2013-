using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

internal class SponsoredPageAgeRatingDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int SponsoredPageID { get; set; }

	internal byte MinAge { get; set; }

	internal byte MaxAge { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static SponsoredPageAgeRatingDAL BuildDAL(IDictionary<string, object> record)
	{
		return new SponsoredPageAgeRatingDAL
		{
			ID = (int)record["ID"],
			SponsoredPageID = (int)record["SponsoredPageID"],
			MinAge = (byte)record["MinAge"],
			MaxAge = (byte)record["MaxAge"],
			Created = (DateTime)record["CreatedUtc"],
			Updated = (DateTime)record["UpdatedUtc"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("SponsoredPageAgeRating_DeleteSponsoredPageAgeRatingByID", ID);
	}

	internal static SponsoredPageAgeRatingDAL Get(int id)
	{
		return RobloxDatabase.RobloxMarketing.Get("SponsoredPageAgeRating_GetSponsoredPageAgeRatingByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@MinAge", MinAge),
			new SqlParameter("@MaxAge", MaxAge),
			new SqlParameter("@CreatedUtc", Created),
			new SqlParameter("@UpdatedUtc", Updated)
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("SponsoredPageAgeRating_InsertSponsoredPageAgeRating", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@MinAge", MinAge),
			new SqlParameter("@MaxAge", MaxAge),
			new SqlParameter("@CreatedUtc", Created),
			new SqlParameter("@UpdatedUtc", Updated)
		};
		RobloxDatabase.RobloxMarketing.Update("SponsoredPageAgeRating_UpdateSponsoredPageAgeRatingByID", queryParameters);
	}

	internal static ICollection<SponsoredPageAgeRatingDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxMarketing.MultiGet("SponsoredPageAgeRating_GetSponsoredPageAgeRatingByIDs", ids, BuildDAL);
	}

	internal static SponsoredPageAgeRatingDAL GetSponsoredPageAgeRatingBySponsoredPageID(int sponsoredPageId)
	{
		if (sponsoredPageId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@SponsoredPageID", sponsoredPageId)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("SponsoredPageAgeRating_GetSponsoredPageAgeRatingBySponsoredPageID", BuildDAL, queryParameters);
	}
}
