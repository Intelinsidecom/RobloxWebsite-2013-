using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

internal class SponsoredPageDeviceTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int SponsoredPageID { get; set; }

	internal long DeviceTypesBitMask { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static SponsoredPageDeviceTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new SponsoredPageDeviceTypeDAL
		{
			ID = (int)record["ID"],
			SponsoredPageID = (int)record["SponsoredPageID"],
			DeviceTypesBitMask = (long)record["DeviceTypesBitMask"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("SponsoredPageDeviceTypes_DeleteSponsoredPageDeviceTypeByID", ID);
	}

	internal static SponsoredPageDeviceTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxMarketing.Get("SponsoredPageDeviceTypes_GetSponsoredPageDeviceTypeByID", id, BuildDAL);
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
			new SqlParameter("@DeviceTypesBitMask", DeviceTypesBitMask),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("SponsoredPageDeviceTypes_InsertSponsoredPageDeviceType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@DeviceTypesBitMask", DeviceTypesBitMask),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxMarketing.Update("SponsoredPageDeviceTypes_UpdateSponsoredPageDeviceTypeByID", queryParameters);
	}

	internal static ICollection<SponsoredPageDeviceTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxMarketing.MultiGet("SponsoredPageDeviceTypes_GetSponsoredPageDeviceTypesByIDs", ids, BuildDAL);
	}

	internal static SponsoredPageDeviceTypeDAL GetSponsoredPageDeviceTypeBySponsoredPageID(int sponsoredPageId)
	{
		if (sponsoredPageId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@SponsoredPageID", sponsoredPageId)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("SponsoredPageDeviceTypes_GetSponsoredPageDeviceTypeBySponsoredPageID", BuildDAL, queryParameters);
	}
}
