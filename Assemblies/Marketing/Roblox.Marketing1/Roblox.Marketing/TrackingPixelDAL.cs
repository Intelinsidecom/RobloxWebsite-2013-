using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class TrackingPixelDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int PartnerID { get; set; }

	internal string PixelHTML { get; set; }

	internal int TrackingEventID { get; set; }

	internal bool IsActive { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxMarketing.Delete("TrackingPixels_DeleteTrackingPixelByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PartnerID", PartnerID),
			new SqlParameter("@PixelHTML", PixelHTML),
			new SqlParameter("@TrackingEventID", TrackingEventID),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("TrackingPixels_InsertTrackingPixel", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PartnerID", PartnerID),
			new SqlParameter("@PixelHTML", PixelHTML),
			new SqlParameter("@TrackingEventID", TrackingEventID),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("TrackingPixels_UpdateTrackingPixelByID", queryParameters);
	}

	private static TrackingPixelDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new TrackingPixelDAL
		{
			ID = id,
			PartnerID = (int)record["PartnerID"],
			PixelHTML = (string)record["PixelHTML"],
			TrackingEventID = (int)record["TrackingEventID"],
			IsActive = (bool)record["IsActive"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal static TrackingPixelDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("TrackingPixels_GetTrackingPixelByID", id, BuildDAL);
	}

	internal static ICollection<int> GetTrackingPixelIDsByPartnerID_Paged(int partnerId, int startRowIndex, int maximumRows)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@PartnerID", partnerId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("TrackingPixels_GetTrackingPixelIDsByPartnerID_Paged", queryParameters);
	}

	internal static TrackingPixelDAL GetByPartnerIDAndTrackingEventID(int partnerId, int trackingEventId)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@PartnerID", partnerId),
			new SqlParameter("@TrackingEventID", trackingEventId)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("TrackingPixels_GetTrackingPixelByPartnerIDAndTrackingEventID", BuildDAL, queryParameters);
	}
}
