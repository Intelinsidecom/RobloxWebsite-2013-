using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarAssetOverrideDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAvatars;

	internal long ID { get; set; }

	internal long UniverseID { get; set; }

	internal long AssetID { get; set; }

	internal int AssetTypeID { get; set; }

	internal bool IsPlayerChoice { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static UniverseAvatarAssetOverrideDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UniverseAvatarAssetOverrideDAL
		{
			ID = (long)record["ID"],
			UniverseID = (long)record["UniverseID"],
			AssetID = (long)record["AssetID"],
			AssetTypeID = (int)record["AssetTypeID"],
			IsPlayerChoice = (bool)record["IsPlayerChoice"],
			Created = DateTime.SpecifyKind((DateTime)record["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)record["UpdatedUtc"], DateTimeKind.Utc)
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAvatars.Delete("UniverseAvatarAssetOverrides_DeleteUniverseAvatarAssetOverrideByID", ID);
	}

	internal static UniverseAvatarAssetOverrideDAL Get(long id)
	{
		return RobloxDatabase.RobloxAvatars.Get("UniverseAvatarAssetOverrides_GetUniverseAvatarAssetOverrideByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@AssetTypeID", AssetTypeID),
			new SqlParameter("@IsPlayerChoice", IsPlayerChoice),
			new SqlParameter("@CreatedUtc", Created),
			new SqlParameter("@UpdatedUtc", Updated)
		};
		ID = RobloxDatabase.RobloxAvatars.Insert<long>("UniverseAvatarAssetOverrides_InsertUniverseAvatarAssetOverride", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@AssetTypeID", AssetTypeID),
			new SqlParameter("@IsPlayerChoice", IsPlayerChoice),
			new SqlParameter("@CreatedUtc", Created),
			new SqlParameter("@UpdatedUtc", Updated)
		};
		RobloxDatabase.RobloxAvatars.Update("UniverseAvatarAssetOverrides_UpdateUniverseAvatarAssetOverrideByID", queryParameters);
	}

	internal static ICollection<UniverseAvatarAssetOverrideDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAvatars.MultiGet("UniverseAvatarAssetOverrides_GetUniverseAvatarAssetOverridesByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetUniverseAvatarAssetOverridesByUniverseIDPaged(long universeId, int count, long exclusiveStartUniverseInstanceId)
	{
		if (universeId == 0L)
		{
			throw new ArgumentException("Parameter 'universeId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartUniverseInstanceId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartUniverseInstanceID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@UniverseID", universeId),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartUniverseInstanceID", exclusiveStartUniverseInstanceId)
		};
		return RobloxDatabase.RobloxAvatars.GetIDCollection<long>("UniverseAvatarAssetOverrides_GetUniverseAvatarAssetOverridesByUniverseID_Paged", queryParameters);
	}
}
