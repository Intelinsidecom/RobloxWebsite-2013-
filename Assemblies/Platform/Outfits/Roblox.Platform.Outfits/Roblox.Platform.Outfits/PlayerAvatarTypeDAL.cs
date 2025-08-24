using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Outfits;

internal class PlayerAvatarTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAvatars;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static PlayerAvatarTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new PlayerAvatarTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAvatars.Delete("PlayerAvatarTypes_DeletePlayerAvatarTypeByID", ID);
	}

	internal static PlayerAvatarTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAvatars.Get("PlayerAvatarTypes_GetPlayerAvatarTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxAvatars.Insert<byte>("PlayerAvatarTypes_InsertPlayerAvatarType", queryParameters);
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
		RobloxDatabase.RobloxAvatars.Update("PlayerAvatarTypes_UpdatePlayerAvatarTypeByID", queryParameters);
	}

	internal static ICollection<PlayerAvatarTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAvatars.MultiGet("PlayerAvatarTypes_GetPlayerAvatarTypesByIDs", ids, BuildDAL);
	}

	internal static PlayerAvatarTypeDAL GetPlayerAvatarTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAvatars.Lookup("PlayerAvatarTypes_GetPlayerAvatarTypeByValue", BuildDAL, queryParameters);
	}
}
