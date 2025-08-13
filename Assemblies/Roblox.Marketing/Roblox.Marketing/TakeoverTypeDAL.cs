using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class TakeoverTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("TakeoverTypes_DeleteTakeoverTypeByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<byte>("TakeoverTypes_InsertTakeoverType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("TakeoverTypes_UpdateTakeoverTypeByID", queryParameters);
	}

	private static TakeoverTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		byte id = (byte)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new TakeoverTypeDAL
		{
			ID = id,
			Value = (string)record["Value"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal static TakeoverTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("TakeoverTypes_GetTakeoverTypeByID", id, BuildDAL);
	}

	internal static TakeoverTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("TakeoverTypes_GetTakeoverTypeByValue", BuildDAL, queryParameters);
	}

	internal static ICollection<byte> GetTakeoverTypeIDs_Paged(byte startRowIndex, byte maximumRows)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<byte>("TakeoverTypes_GetTakeoverTypeIDs_Paged", queryParameters);
	}

	internal static byte GetTotalNumberOfTakeoverTypes()
	{
		SqlParameter[] queryParameters = new SqlParameter[0];
		return RobloxDatabase.RobloxMarketing.GetCount<byte>("TakeoverTypes_GetTotalNumberOfTakeoverTypes", queryParameters);
	}
}
