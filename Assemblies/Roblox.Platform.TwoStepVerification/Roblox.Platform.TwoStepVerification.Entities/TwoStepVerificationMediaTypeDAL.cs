using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.TwoStepVerification.Entities;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationMediaTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAuthentication;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static TwoStepVerificationMediaTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new TwoStepVerificationMediaTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAuthentication.Delete("TwoStepVerificationMediaTypes_DeleteTwoStepVerificationMediaTypeByID", ID);
	}

	internal static TwoStepVerificationMediaTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAuthentication.Get("TwoStepVerificationMediaTypes_GetTwoStepVerificationMediaTypeByID", id, BuildDAL);
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
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAuthentication.Insert<byte>("TwoStepVerificationMediaTypes_InsertTwoStepVerificationMediaType", queryParameters);
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
		RobloxDatabase.RobloxAuthentication.Update("TwoStepVerificationMediaTypes_UpdateTwoStepVerificationMediaTypeByID", queryParameters);
	}

	internal static ICollection<TwoStepVerificationMediaTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAuthentication.MultiGet("TwoStepVerificationMediaTypes_GetTwoStepVerificationMediaTypesByIDs", ids, BuildDAL);
	}

	internal static TwoStepVerificationMediaTypeDAL GetTwoStepVerificationMediaTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAuthentication.Lookup("TwoStepVerificationMediaTypes_GetTwoStepVerificationMediaTypeByValue", BuildDAL, queryParameters);
	}
}
