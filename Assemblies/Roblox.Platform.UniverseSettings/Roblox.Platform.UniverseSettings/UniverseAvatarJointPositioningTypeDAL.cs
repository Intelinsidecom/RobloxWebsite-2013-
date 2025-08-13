using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarJointPositioningTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAvatars;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static UniverseAvatarJointPositioningTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UniverseAvatarJointPositioningTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAvatars.Delete("UniverseAvatarJointPositioningTypes_DeleteUniverseAvatarJointPositioningTypeByID", ID);
	}

	internal static UniverseAvatarJointPositioningTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAvatars.Get("UniverseAvatarJointPositioningTypes_GetUniverseAvatarJointPositioningTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxAvatars.Insert<byte>("UniverseAvatarJointPositioningTypes_InsertUniverseAvatarJointPositioningType", queryParameters);
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
		RobloxDatabase.RobloxAvatars.Update("UniverseAvatarJointPositioningTypes_UpdateUniverseAvatarJointPositioningTypeByID", queryParameters);
	}

	internal static ICollection<UniverseAvatarJointPositioningTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAvatars.MultiGet("UniverseAvatarJointPositioningTypes_GetUniverseAvatarJointPositioningTypesByIDs", ids, BuildDAL);
	}

	internal static UniverseAvatarJointPositioningTypeDAL GetUniverseAvatarJointPositioningTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAvatars.Lookup("UniverseAvatarJointPositioningTypes_GetUniverseAvatarJointPositioningTypeByValue", BuildDAL, queryParameters);
	}
}
