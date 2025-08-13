using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class SponsoredPageImageDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal string Key { get; set; }

	internal string Md5Hash { get; set; }

	internal int SponsoredPageID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static SponsoredPageImageDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new SponsoredPageImageDAL
		{
			ID = id,
			Key = (string)record["Key"],
			Md5Hash = (string)record["Md5Hash"],
			SponsoredPageID = (int)record["SponsoredPageID"],
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
			new SqlParameter("@Key", Key),
			new SqlParameter("@Md5Hash", Md5Hash),
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("SponsoredPageImages_InsertSponsoredPageImage", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Key", Key),
			new SqlParameter("@Md5Hash", Md5Hash),
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("SponsoredPageImages_UpdateSponsoredPageImageByID", queryParameters);
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("SponsoredPageImages_DeleteSponsoredPageImageByID", ID);
	}

	internal static SponsoredPageImageDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("SponsoredPageImages_GetSponsoredPageImageByID", id, BuildDAL);
	}

	internal static SponsoredPageImageDAL GetByKeyAndSponsoredPageID(string key, int sponsoredPageId)
	{
		if (string.IsNullOrWhiteSpace(key))
		{
			return null;
		}
		if (sponsoredPageId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@Key", key),
			new SqlParameter("@SponsoredPageID", sponsoredPageId)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("SponsoredPageImages_GetSponsoredPageImageByKeyAndSponsoredPageID", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetSponsoredPageImageIDsBySponsoredPageID_Paged(int sponsoredPageId, int startRowIndex, int maximumRows)
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
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("SponsoredPageImages_GetSponsoredPageImageIDsBySponsoredPageID_Paged", queryParameters);
	}
}
