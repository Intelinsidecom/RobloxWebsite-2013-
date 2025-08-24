using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets.Entities;

internal class CreationDAL
{
	internal long ID { get; set; }

	internal long CreationContextId { get; set; }

	internal long AssetId { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime? Updated { get; set; }

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
		EntityHelper.DoEntityDALDelete(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[Creations_DeleteCreationByID]", queryParameters));
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@CreationContextID", CreationContextId),
			new SqlParameter("@AssetID", AssetId),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated.HasValue ? ((object)Updated.Value) : DBNull.Value)
		};
		DbInfo dbInfo = new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[Creations_InsertCreation]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@CreationContextID", CreationContextId),
			new SqlParameter("@AssetID", AssetId),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated.HasValue ? ((object)Updated.Value) : DBNull.Value)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[Creations_UpdateCreationByID]", queryParameters));
	}

	private static CreationDAL GetDALFromReader(SqlDataReader reader)
	{
		CreationDAL dal = new CreationDAL
		{
			ID = (long)reader["ID"],
			CreationContextId = (long)reader["CreationContextID"],
			AssetId = (long)reader["AssetID"],
			Created = (DateTime)reader["Created"],
			Updated = (reader["Updated"].Equals(DBNull.Value) ? null : ((DateTime?)reader["Updated"]))
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static CreationDAL BuildDAL(SqlDataReader reader)
	{
		CreationDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<CreationDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<CreationDAL> dals = new List<CreationDAL>();
		while (reader.Read())
		{
			CreationDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal static CreationDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[Creations_GetCreationByID]", queryParameters), BuildDAL);
	}

	internal static ICollection<CreationDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[Creations_GetCreationsByIDs]"), ids, BuildDALCollection);
	}

	internal static CreationDAL GetByAssetId(long assetId)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AssetID", assetId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[Creations_GetCreationByAssetID]", queryParameters), BuildDAL);
	}

	internal static CreationDAL GetByCreationContextIdAndAssetId(long creationContextId, long assetId)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreationContextID", creationContextId),
			new SqlParameter("@AssetID", assetId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[Creations_GetCreationByCreationContextIDAndAssetID]", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetCreationIdsByCreationContextIdPaged(long creationContextId, long startRowIndex, long maximumRows)
	{
		if (creationContextId == 0L)
		{
			throw new ApplicationException("Required value not specified: CreationContextID.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreationContextID", creationContextId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[Creations_GetCreationIDsByCreationContextID_Paged]", queryParameters));
	}

	internal static EntityHelper.GetOrCreateDALWrapper<CreationDAL> GetOrCreate(long creationContextId, long assetId)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreationContextID", creationContextId),
			new SqlParameter("@AssetID", assetId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[Creations_GetOrCreateCreation]", queryParameters), BuildDAL);
	}

	internal static long GetTotalNumberOfCreationsByCreationContextId(long creationContextId)
	{
		if (creationContextId == 0L)
		{
			throw new ApplicationException("Required value not specified: CreationContextID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@CreationContextID", creationContextId)
		};
		return EntityHelper.GetDataCount<long>(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[Creations_GetTotalNumberOfCreationsByCreationContextID]", queryParameters));
	}
}
