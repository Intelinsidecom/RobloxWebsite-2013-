using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarCollisionTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAvatars;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static UniverseAvatarCollisionTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UniverseAvatarCollisionTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAvatars.Delete("UniverseAvatarCollisionTypes_DeleteUniverseAvatarCollisionTypeByID", ID);
	}

	internal static UniverseAvatarCollisionTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAvatars.Get("UniverseAvatarCollisionTypes_GetUniverseAvatarCollisionTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxAvatars.Insert<byte>("UniverseAvatarCollisionTypes_InsertUniverseAvatarCollisionType", queryParameters);
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
		RobloxDatabase.RobloxAvatars.Update("UniverseAvatarCollisionTypes_UpdateUniverseAvatarCollisionTypeByID", queryParameters);
	}

	internal static ICollection<UniverseAvatarCollisionTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAvatars.MultiGet("UniverseAvatarCollisionTypes_GetUniverseAvatarCollisionTypesByIDs", ids, BuildDAL);
	}

	internal static UniverseAvatarCollisionTypeDAL GetUniverseAvatarCollisionTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAvatars.Lookup("UniverseAvatarCollisionTypes_GetUniverseAvatarCollisionTypeByValue", BuildDAL, queryParameters);
	}
}
