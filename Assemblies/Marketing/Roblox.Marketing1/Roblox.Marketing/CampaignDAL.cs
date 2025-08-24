using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class CampaignDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int PartnerID { get; set; }

	internal string Name { get; set; }

	internal bool IsBlacklisted { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxMarketing.Delete("Campaigns_DeleteCampaignByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PartnerID", PartnerID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@IsBlacklisted", IsBlacklisted),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("Campaigns_InsertCampaign", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PartnerID", PartnerID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@IsBlacklisted", IsBlacklisted),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("Campaigns_UpdateCampaignByID", queryParameters);
	}

	private static CampaignDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new CampaignDAL
		{
			ID = id,
			PartnerID = (int)record["PartnerID"],
			Name = (string)record["Name"],
			IsBlacklisted = (bool)record["IsBlacklisted"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal static CampaignDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("Campaigns_GetCampaignByID", id, BuildDAL);
	}

	internal static ICollection<int> GetCampaignIDsByPartnerID_Paged(int partnerId, int startRowIndex, int maximumRows)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@PartnerID", partnerId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("Campaigns_GetCampaignIDsByPartnerID_Paged", queryParameters);
	}
}
