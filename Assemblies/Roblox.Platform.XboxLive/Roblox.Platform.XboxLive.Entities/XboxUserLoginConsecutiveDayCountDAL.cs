using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.XboxLive.Entities;

internal class XboxUserLoginConsecutiveDayCountDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxXbox;

	internal int ID { get; set; }

	internal long UserID { get; set; }

	internal int Count { get; set; }

	internal DateTime? ClientLastSeen { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static XboxUserLoginConsecutiveDayCountDAL BuildDAL(IDictionary<string, object> record)
	{
		return new XboxUserLoginConsecutiveDayCountDAL
		{
			ID = (int)record["ID"],
			UserID = Convert.ToInt64(record["UserID"]),
			Count = (int)record["Count"],
			ClientLastSeen = (DateTime?)record["ClientLastSeen"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxXbox.Delete("XboxUserLoginConsecutiveDayCounts_DeleteXboxUserLoginConsecutiveDayCountByID", ID);
	}

	internal static XboxUserLoginConsecutiveDayCountDAL Get(int id)
	{
		return RobloxDatabase.RobloxXbox.Get("XboxUserLoginConsecutiveDayCounts_GetXboxUserLoginConsecutiveDayCountByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Count", Count),
			new SqlParameter("@ClientLastSeen", ClientLastSeen.HasValue ? ((object)ClientLastSeen) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxXbox.Insert<int>("XboxUserLoginConsecutiveDayCounts_InsertXboxUserLoginConsecutiveDayCount", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Count", Count),
			new SqlParameter("@ClientLastSeen", ClientLastSeen.HasValue ? ((object)ClientLastSeen) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxXbox.Update("XboxUserLoginConsecutiveDayCounts_UpdateXboxUserLoginConsecutiveDayCountByID", queryParameters);
	}

	internal void Increment()
	{
		SqlParameter outputCount = new SqlParameter("@OutputCount", SqlDbType.Int)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter outputUpdated = new SqlParameter("@OutputUpdated", SqlDbType.DateTime)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			outputCount,
			outputUpdated
		};
		RobloxDatabase.RobloxXbox.ExecuteNonQuery("XboxUserLoginConsecutiveDayCounts_IncrementXboxUserLoginConsecutiveDayCountByID", queryParameters);
		Count = (int)outputCount.Value;
		Updated = (DateTime)outputUpdated.Value;
	}

	internal static ICollection<XboxUserLoginConsecutiveDayCountDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxXbox.MultiGet("XboxUserLoginConsecutiveDayCounts_GetXboxUserLoginConsecutiveDayCountsByIDs", ids, BuildDAL);
	}

	internal static XboxUserLoginConsecutiveDayCountDAL GetXboxUserLoginConsecutiveDayCountByUserID(long userId)
	{
		if (userId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return RobloxDatabase.RobloxXbox.Lookup("XboxUserLoginConsecutiveDayCounts_GetXboxUserLoginConsecutiveDayCountByUserID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<XboxUserLoginConsecutiveDayCountDAL> GetOrCreateXboxUserLoginConsecutiveDayCount(long userId)
	{
		if (userId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", userId)
		};
		return RobloxDatabase.RobloxXbox.GetOrCreate("XboxUserLoginConsecutiveDayCounts_GetOrCreateXboxUserLoginConsecutiveDayCount", BuildDAL, queryParameters);
	}
}
