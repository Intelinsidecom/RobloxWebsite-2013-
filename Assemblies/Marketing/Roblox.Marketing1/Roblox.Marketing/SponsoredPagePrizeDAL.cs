using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class SponsoredPagePrizeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int SponsoredPageID { get; set; }

	internal long AssetID { get; set; }

	internal int SortOrder { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static SponsoredPagePrizeDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new SponsoredPagePrizeDAL
		{
			ID = id,
			SponsoredPageID = (int)record["SponsoredPageID"],
			AssetID = (long)record["AssetID"],
			SortOrder = (int)record["SortOrder"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
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
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@SortOrder", SortOrder),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("SponsoredPagePrizes_InsertSponsoredPagePrize", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@SortOrder", SortOrder),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("SponsoredPagePrizes_UpdateSponsoredPagePrizeByID", queryParameters);
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("SponsoredPagePrizes_DeleteSponsoredPagePrizeByID", ID);
	}

	internal static SponsoredPagePrizeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("SponsoredPagePrizes_GetSponsoredPagePrizeByID", id, BuildDAL);
	}

	internal static ICollection<int> GetSponsoredPagePrizeIDsBySponsoredPageID_Paged(int sponsoredPageId, int startRowIndex, int maximumRows)
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
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("SponsoredPagePrizes_GetSponsoredPagePrizeIDsBySponsoredPageID_Paged", queryParameters);
	}
}
