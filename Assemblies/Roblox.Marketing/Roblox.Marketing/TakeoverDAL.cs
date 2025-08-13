using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class TakeoverDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal string Name { get; set; }

	internal byte TakeoverTypeID { get; set; }

	internal DateTime StartTime { get; set; }

	internal DateTime EndTime { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal int? FrequencyCap { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxMarketing.Delete("Takeovers_DeleteTakeoverByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Name", Name),
			new SqlParameter("@TakeoverTypeID", TakeoverTypeID),
			new SqlParameter("@StartTime", StartTime.ToLocalTime()),
			new SqlParameter("@EndTime", EndTime.ToLocalTime()),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime()),
			new SqlParameter("@FrequencyCap", FrequencyCap.HasValue ? ((object)FrequencyCap) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("Takeovers_InsertTakeover", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@TakeoverTypeID", TakeoverTypeID),
			new SqlParameter("@StartTime", StartTime.ToLocalTime()),
			new SqlParameter("@EndTime", EndTime.ToLocalTime()),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime()),
			new SqlParameter("@FrequencyCap", FrequencyCap.HasValue ? ((object)FrequencyCap) : DBNull.Value)
		};
		RobloxDatabase.RobloxMarketing.Update("Takeovers_UpdateTakeoverByID", queryParameters);
	}

	private static TakeoverDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new TakeoverDAL
		{
			ID = id,
			Name = (string)record["Name"],
			TakeoverTypeID = (byte)record["TakeoverTypeID"],
			StartTime = DateTime.SpecifyKind((DateTime)record["StartTime"], DateTimeKind.Local),
			EndTime = DateTime.SpecifyKind((DateTime)record["EndTime"], DateTimeKind.Local),
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local),
			FrequencyCap = (int?)record["FrequencyCap"]
		};
	}

	internal static TakeoverDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("Takeovers_GetTakeoverByID", id, BuildDAL);
	}

	internal static ICollection<int> GetActiveTakeoverIDs(DateTime currentTime)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@CurrentTime", currentTime)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("Takeovers_GetActiveTakeoverIDs", queryParameters);
	}

	internal static ICollection<int> GetTakeoverIDs_Paged(int startRowIndex, int maximumRows)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("Takeovers_GetTakeoverIDs_Paged", queryParameters);
	}

	internal static int GetTotalNumberOfTakeovers()
	{
		SqlParameter[] queryParameters = new SqlParameter[0];
		return RobloxDatabase.RobloxMarketing.GetCount<int>("Takeovers_GetTotalNumberOfTakeovers", queryParameters);
	}
}
