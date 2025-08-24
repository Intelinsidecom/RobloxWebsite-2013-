using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.DataV2.Core;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class GameAttributesDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGameAttributes;

	internal long ID { get; set; }

	internal long UniverseID { get; set; }

	internal bool IsSecure { get; set; }

	internal bool IsTrusted { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static GameAttributesDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GameAttributesDAL
		{
			ID = (long)record["ID"],
			UniverseID = (long)record["UniverseID"],
			IsSecure = (bool)record["IsSecure"],
			IsTrusted = (bool)record["IsTrusted"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxGameAttributes.Delete("GameAttributes_DeleteGameAttributeByID", ID);
	}

	internal static GameAttributesDAL Get(long id)
	{
		return RobloxDatabase.RobloxGameAttributes.Get("GameAttributes_GetGameAttributeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@IsSecure", IsSecure),
			new SqlParameter("@IsTrusted", IsTrusted),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGameAttributes.Insert<long>("GameAttributes_InsertGameAttribute", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@IsSecure", IsSecure),
			new SqlParameter("@IsTrusted", IsTrusted),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGameAttributes.Update("GameAttributes_UpdateGameAttributeByID", queryParameters);
	}

	internal static ICollection<GameAttributesDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxGameAttributes.MultiGet("GameAttributes_GetGameAttributesByIDs", ids, BuildDAL);
	}

	internal static GameAttributesDAL GetGameAttributeByUniverseID(long universeId)
	{
		if (universeId <= 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UniverseID", universeId)
		};
		return RobloxDatabase.RobloxGameAttributes.Lookup("GameAttributes_GetGameAttributeByUniverseID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<GameAttributesDAL> GetOrCreateGameAttribute(long universeId)
	{
		if (universeId <= 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UniverseID", universeId)
		};
		return RobloxDatabase.RobloxGameAttributes.GetOrCreate("GameAttributes_GetOrCreateGameAttribute", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetGameAttributeIDsByIsTrusted(bool isTrusted, long exclusiveStartUniverseId, int count, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		if (count <= 0)
		{
			throw new ApplicationException(string.Format("Required value not specified: {0}.", "count"));
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@IsTrusted", isTrusted),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartUniverseID", exclusiveStartUniverseId)
		};
		string storedProcedureName = (sortOrder.Equals(Roblox.DataV2.Core.SortOrder.Asc) ? "GameAttributes_GetGameAttributeIDsByIsTrusted" : "GameAttributes_GetGameAttributeIDsByIsTrusted_Desc");
		return RobloxDatabase.RobloxGameAttributes.GetIDCollection<long>(storedProcedureName, queryParameters);
	}
}
