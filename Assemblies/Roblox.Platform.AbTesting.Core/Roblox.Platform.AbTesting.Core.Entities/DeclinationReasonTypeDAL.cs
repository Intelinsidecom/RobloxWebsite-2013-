using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class DeclinationReasonTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAbTesting;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static DeclinationReasonTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new DeclinationReasonTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAbTesting.Delete("DeclinationReasonTypes_DeleteDeclinationReasonTypeByID", ID);
	}

	internal static DeclinationReasonTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxAbTesting.Get("DeclinationReasonTypes_GetDeclinationReasonTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAbTesting.Insert<int>("DeclinationReasonTypes_InsertDeclinationReasonType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAbTesting.Update("DeclinationReasonTypes_UpdateDeclinationReasonTypeByID", queryParameters);
	}

	internal static ICollection<DeclinationReasonTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxAbTesting.MultiGet("DeclinationReasonTypes_GetDeclinationReasonTypesByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<DeclinationReasonTypeDAL> GetOrCreateDeclinationReasonType(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAbTesting.GetOrCreate("DeclinationReasonTypes_GetOrCreateDeclinationReasonType", BuildDAL, queryParameters);
	}

	internal static DeclinationReasonTypeDAL GetDeclinationReasonTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAbTesting.Lookup("DeclinationReasonTypes_GetDeclinationReasonTypeByValue", BuildDAL, queryParameters);
	}
}
