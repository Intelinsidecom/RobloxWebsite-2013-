using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class TakeoverAgeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int TakeoverID { get; set; }

	internal byte? MinAgeInYears { get; set; }

	internal byte? MaxAgeInYears { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxMarketing.Delete("TakeoverAges_DeleteTakeoverAgeByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] obj = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@TakeoverID", TakeoverID),
			null,
			null,
			null,
			null
		};
		byte? minAgeInYears = MinAgeInYears;
		obj[2] = new SqlParameter("@MinAgeInYears", minAgeInYears.HasValue ? ((object)minAgeInYears.GetValueOrDefault()) : DBNull.Value);
		minAgeInYears = MaxAgeInYears;
		obj[3] = new SqlParameter("@MaxAgeInYears", minAgeInYears.HasValue ? ((object)minAgeInYears.GetValueOrDefault()) : DBNull.Value);
		obj[4] = new SqlParameter("@Created", Created.ToLocalTime());
		obj[5] = new SqlParameter("@Updated", Updated.ToLocalTime());
		SqlParameter[] queryParameters = obj;
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("TakeoverAges_InsertTakeoverAge", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] obj = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@TakeoverID", TakeoverID),
			null,
			null,
			null,
			null
		};
		byte? minAgeInYears = MinAgeInYears;
		obj[2] = new SqlParameter("@MinAgeInYears", minAgeInYears.HasValue ? ((object)minAgeInYears.GetValueOrDefault()) : DBNull.Value);
		minAgeInYears = MaxAgeInYears;
		obj[3] = new SqlParameter("@MaxAgeInYears", minAgeInYears.HasValue ? ((object)minAgeInYears.GetValueOrDefault()) : DBNull.Value);
		obj[4] = new SqlParameter("@Created", Created.ToLocalTime());
		obj[5] = new SqlParameter("@Updated", Updated.ToLocalTime());
		SqlParameter[] queryParameters = obj;
		RobloxDatabase.RobloxMarketing.Update("TakeoverAges_UpdateTakeoverAgeByID", queryParameters);
	}

	private static TakeoverAgeDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new TakeoverAgeDAL
		{
			ID = id,
			TakeoverID = (int)record["TakeoverID"],
			MinAgeInYears = (byte?)record["MinAgeInYears"],
			MaxAgeInYears = (byte?)record["MaxAgeInYears"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal static TakeoverAgeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("TakeoverAges_GetTakeoverAgeByID", id, BuildDAL);
	}

	internal static TakeoverAgeDAL GetByTakeoverID(int takeoverId)
	{
		if (takeoverId == 0)
		{
			throw new ApplicationException("Required value not specified: TakeoverID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@TakeoverID", takeoverId)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("TakeoverAges_GetTakeoverAgeByTakeoverID", BuildDAL, queryParameters);
	}
}
