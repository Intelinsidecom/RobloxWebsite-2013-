using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;
using Roblox.Platform.Avatar.Properties;

namespace Roblox.Platform.Avatar;

[ExcludeFromCodeCoverage]
internal class EmoteConfigurationDAL
{
	private static RobloxDatabase _Database
	{
		get
		{
			if (!Settings.Default.IsAvatarEmotesDatabaseEnabled)
			{
				return RobloxDatabase.RobloxAvatars;
			}
			return RobloxDatabase.RobloxAvatarEmotes;
		}
	}

	internal long ID { get; set; }

	internal long AssetID { get; set; }

	internal long UserID { get; set; }

	internal byte Position { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static EmoteConfigurationDAL BuildDAL(IDictionary<string, object> record)
	{
		return new EmoteConfigurationDAL
		{
			ID = (long)record["ID"],
			AssetID = (long)record["AssetID"],
			UserID = (long)record["UserID"],
			Position = (byte)record["Position"],
			Created = DateTime.SpecifyKind((DateTime)record["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)record["UpdatedUtc"], DateTimeKind.Utc)
		};
	}

	internal void Delete()
	{
		_Database.Delete("EmoteConfigurations_DeleteEmoteConfigurationByID", ID);
	}

	internal static EmoteConfigurationDAL Get(long id)
	{
		return _Database.Get("EmoteConfigurations_GetEmoteConfigurationByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Position", Position),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		ID = _Database.Insert<long>("EmoteConfigurations_InsertEmoteConfiguration", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Position", Position),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		_Database.Update("EmoteConfigurations_UpdateEmoteConfigurationByID", queryParameters);
	}

	internal static ICollection<EmoteConfigurationDAL> MultiGet(ICollection<long> ids)
	{
		return _Database.MultiGet("EmoteConfigurations_GetEmoteConfigurationsByIDs", ids, BuildDAL);
	}

	internal static EmoteConfigurationDAL GetEmoteConfigurationByUserIDAndPosition(long userId, byte position)
	{
		if (userId == 0L)
		{
			return null;
		}
		if (position == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@Position", position)
		};
		return _Database.Lookup("EmoteConfigurations_GetEmoteConfigurationByUserIDAndPosition", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetEmoteConfigurationIDsByUserID(long userId, int count, byte? exclusiveStartPosition)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("Parameter 'userId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartPosition < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartPosition' cannot be negative.");
		}
		SqlParameter[] obj = new SqlParameter[3]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@Count", count),
			null
		};
		byte? b = exclusiveStartPosition;
		obj[2] = new SqlParameter("@ExclusiveStartPosition", b.HasValue ? ((object)b.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return _Database.GetIDCollection<long>("EmoteConfigurations_GetEmoteConfigurationIDsByUserID", queryParameters);
	}
}
