using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Assets.Places.Entities;

[ExcludeFromCodeCoverage]
internal class SocialSlotTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGames;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime CreatedUtc { get; set; }

	internal DateTime UpdatedUtc { get; set; }

	private static SocialSlotTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new SocialSlotTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			CreatedUtc = DateTime.SpecifyKind((DateTime)record["CreatedUtc"], DateTimeKind.Utc),
			UpdatedUtc = DateTime.SpecifyKind((DateTime)record["UpdatedUtc"], DateTimeKind.Utc)
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxGames.Delete("SocialSlotTypes_DeleteSocialSlotTypeByID", ID);
	}

	internal static SocialSlotTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxGames.Get("SocialSlotTypes_GetSocialSlotTypeByID", id, BuildDAL);
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
			new SqlParameter("@CreatedUtc", CreatedUtc),
			new SqlParameter("@UpdatedUtc", UpdatedUtc)
		};
		ID = RobloxDatabase.RobloxGames.Insert<int>("SocialSlotTypes_InsertSocialSlotType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@CreatedUtc", CreatedUtc),
			new SqlParameter("@UpdatedUtc", UpdatedUtc)
		};
		RobloxDatabase.RobloxGames.Update("SocialSlotTypes_UpdateSocialSlotTypeByID", queryParameters);
	}

	internal static ICollection<SocialSlotTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxGames.MultiGet("SocialSlotTypes_GetSocialSlotTypesByIDs", ids, BuildDAL);
	}

	internal static SocialSlotTypeDAL GetSocialSlotTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxGames.Lookup("SocialSlotTypes_GetSocialSlotTypeByValue", BuildDAL, queryParameters);
	}
}
