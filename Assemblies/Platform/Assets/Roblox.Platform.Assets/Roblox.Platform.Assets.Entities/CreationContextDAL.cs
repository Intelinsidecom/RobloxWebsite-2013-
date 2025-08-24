using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets.Entities;

internal class CreationContextDAL
{
	internal long ID { get; set; }

	internal byte ContextTypeId { get; set; }

	internal byte CreatorTypeId { get; set; }

	internal long CreatorTargetId { get; set; }

	internal int AssetTypeId { get; set; }

	internal long? UniverseId { get; set; }

	internal DateTime Created { get; set; }

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[CreationContexts_DeleteCreationContextByID]", queryParameters));
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ContextTypeID", ContextTypeId),
			new SqlParameter("@CreatorTypeID", CreatorTypeId),
			new SqlParameter("@CreatorTargetID", CreatorTargetId),
			new SqlParameter("@AssetTypeID", AssetTypeId),
			new SqlParameter("@UniverseID", UniverseId.HasValue ? ((object)UniverseId.Value) : DBNull.Value),
			new SqlParameter("@Created", Created)
		};
		DbInfo dbInfo = new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[CreationContexts_InsertCreationContext]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ContextTypeID", ContextTypeId),
			new SqlParameter("@CreatorTypeID", CreatorTypeId),
			new SqlParameter("@CreatorTargetID", CreatorTargetId),
			new SqlParameter("@AssetTypeID", AssetTypeId),
			new SqlParameter("@UniverseID", UniverseId.HasValue ? ((object)UniverseId.Value) : DBNull.Value),
			new SqlParameter("@Created", Created)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[CreationContexts_UpdateCreationContextByID]", queryParameters));
	}

	private static CreationContextDAL GetDALFromReader(SqlDataReader reader)
	{
		CreationContextDAL dal = new CreationContextDAL
		{
			ID = (long)reader["ID"],
			ContextTypeId = (byte)reader["ContextTypeID"],
			CreatorTypeId = (byte)reader["CreatorTypeID"],
			CreatorTargetId = (long)reader["CreatorTargetID"],
			AssetTypeId = (int)reader["AssetTypeID"],
			UniverseId = (reader["UniverseID"].Equals(DBNull.Value) ? null : ((long?)reader["UniverseID"])),
			Created = (DateTime)reader["Created"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static CreationContextDAL BuildDAL(SqlDataReader reader)
	{
		CreationContextDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<CreationContextDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<CreationContextDAL> dals = new List<CreationContextDAL>();
		while (reader.Read())
		{
			CreationContextDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal static CreationContextDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[CreationContexts_GetCreationContextByID]", queryParameters), BuildDAL);
	}

	internal static ICollection<CreationContextDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "CreationContexts_GetCreationContextsByIDs"), ids, BuildDALCollection);
	}

	internal static CreationContextDAL GetByContextTypeIdCreatorTypeIdCreatorTargetIdAssetTypeIdAndUniverseId(byte contextTypeId, byte creatorTypeId, long creatorTargetId, int assetTypeId, long? universeId)
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ContextTypeID", contextTypeId),
			new SqlParameter("@CreatorTypeID", creatorTypeId),
			new SqlParameter("@CreatorTargetID", creatorTargetId),
			new SqlParameter("@AssetTypeID", assetTypeId),
			new SqlParameter("@UniverseID", universeId.HasValue ? ((object)universeId.Value) : DBNull.Value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[CreationContexts_GetCreationContextByContextTypeIDCreatorTypeIDCreatorTargetIDAssetTypeIDAndUniverseID]", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetCreationContextIdsByContextTypeIdCreatorTypeIdCreatorTargetIdAssetTypeIdPaged(byte contextTypeId, byte creatorTypeId, long creatorTargetId, int assetTypeId, long startRowIndex, long maximumRows)
	{
		if (contextTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: ContextTypeID.");
		}
		if (creatorTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: CreatorTypeID.");
		}
		if (creatorTargetId == 0L)
		{
			throw new ApplicationException("Required value not specified: CreatorTargetID.");
		}
		if (assetTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ContextTypeID", contextTypeId),
			new SqlParameter("@CreatorTypeID", creatorTypeId),
			new SqlParameter("@CreatorTargetID", creatorTargetId),
			new SqlParameter("@AssetTypeID", assetTypeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[CreationContexts_GetCreationContextIDsByContextTypeIDCreatorTypeIDCreatorTargetIDAndAssetTypeID_Paged]", queryParameters));
	}

	internal static EntityHelper.GetOrCreateDALWrapper<CreationContextDAL> GetOrCreate(byte contextTypeId, byte creatorTypeId, long creatorTargetId, int assetTypeId, long? universeId)
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ContextTypeID", contextTypeId),
			new SqlParameter("@CreatorTypeID", creatorTypeId),
			new SqlParameter("@CreatorTargetID", creatorTargetId),
			new SqlParameter("@AssetTypeID", assetTypeId),
			new SqlParameter("@UniverseID", universeId.HasValue ? ((object)universeId.Value) : DBNull.Value)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[CreationContexts_GetOrCreateCreationContext]", queryParameters), BuildDAL);
	}

	internal static long GetTotalNumberOfCreationContextsByContextTypeIdCreatorTypeIdCreatorTargetIdAndAssetTypeId(byte contextTypeId, byte creatorTypeId, long creatorTargetId, int assetTypeId)
	{
		if (contextTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: CreationContextID.");
		}
		if (creatorTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: CreatorTypeID.");
		}
		if (creatorTargetId == 0L)
		{
			throw new ApplicationException("Required value not specified: CreatorTargetID.");
		}
		if (assetTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ContextTypeID", contextTypeId),
			new SqlParameter("@CreatorTypeID", creatorTypeId),
			new SqlParameter("@CreatorTargetID", creatorTargetId),
			new SqlParameter("@AssetTypeID", assetTypeId)
		};
		return EntityHelper.GetDataCount<long>(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[CreationContexts_GetTotalNumberOfCreationContextsByContextTypeIDCreatorTypeIDCreatorTargetIDAndAssetTypeID]", queryParameters));
	}
}
