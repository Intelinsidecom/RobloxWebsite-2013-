using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Assets.Places;

internal class PlaceAttributeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGames;

	internal long ID { get; set; }

	internal long PlaceID { get; set; }

	internal byte PlaceTypeID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal bool? UsePlaceMediaForThumb { get; set; }

	internal bool? OverridesDefaultAvatar { get; set; }

	internal bool? UsePortraitMode { get; set; }

	internal long? UniverseID { get; set; }

	internal bool? IsFilteringEnabled { get; set; }

	private static PlaceAttributeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new PlaceAttributeDAL
		{
			ID = (long)record["ID"],
			PlaceID = (long)record["PlaceID"],
			PlaceTypeID = (byte)record["PlaceTypeID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"],
			UsePlaceMediaForThumb = (bool?)record["UsePlaceMediaForThumb"],
			OverridesDefaultAvatar = (bool?)record["OverridesDefaultAvatar"],
			UsePortraitMode = (bool?)record["UsePortraitMode"],
			UniverseID = (long?)record["UniverseID"],
			IsFilteringEnabled = (bool?)record["IsFilteringEnabled"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxGames.Delete("PlaceAttributes_DeletePlaceAttributeByID", ID);
	}

	internal static PlaceAttributeDAL Get(long id)
	{
		return RobloxDatabase.RobloxGames.Get("PlaceAttributes_GetPlaceAttributeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@PlaceTypeID", PlaceTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@UsePlaceMediaForThumb", UsePlaceMediaForThumb.HasValue ? ((object)UsePlaceMediaForThumb) : DBNull.Value),
			new SqlParameter("@OverridesDefaultAvatar", OverridesDefaultAvatar.HasValue ? ((object)OverridesDefaultAvatar) : DBNull.Value),
			new SqlParameter("@UsePortraitMode", UsePortraitMode.HasValue ? ((object)UsePortraitMode) : DBNull.Value),
			new SqlParameter("@UniverseID", UniverseID.HasValue ? ((object)UniverseID) : DBNull.Value),
			new SqlParameter("@IsFilteringEnabled", IsFilteringEnabled.HasValue ? ((object)IsFilteringEnabled) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxGames.Insert<long>("PlaceAttributes_InsertPlaceAttribute", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@PlaceTypeID", PlaceTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@UsePlaceMediaForThumb", UsePlaceMediaForThumb.HasValue ? ((object)UsePlaceMediaForThumb) : DBNull.Value),
			new SqlParameter("@OverridesDefaultAvatar", OverridesDefaultAvatar.HasValue ? ((object)OverridesDefaultAvatar) : DBNull.Value),
			new SqlParameter("@UsePortraitMode", UsePortraitMode.HasValue ? ((object)UsePortraitMode) : DBNull.Value),
			new SqlParameter("@UniverseID", UniverseID.HasValue ? ((object)UniverseID) : DBNull.Value),
			new SqlParameter("@IsFilteringEnabled", IsFilteringEnabled.HasValue ? ((object)IsFilteringEnabled) : DBNull.Value)
		};
		RobloxDatabase.RobloxGames.Update("PlaceAttributes_UpdatePlaceAttributeByID", queryParameters);
	}

	internal static ICollection<PlaceAttributeDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxGames.MultiGet("PlaceAttributes_GetPlaceAttributesByIDs", ids, BuildDAL);
	}

	internal static PlaceAttributeDAL GetPlaceAttributeByPlaceID(long placeID)
	{
		if (placeID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PlaceID", placeID)
		};
		return RobloxDatabase.RobloxGames.Lookup("PlaceAttributes_GetPlaceAttributeByPlaceID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<PlaceAttributeDAL> GetOrCreatePlaceAttribute(long placeID, byte placeTypeID)
	{
		if (placeID == 0L)
		{
			return null;
		}
		if (placeTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PlaceID", placeID),
			new SqlParameter("@PlaceTypeID", placeTypeID)
		};
		return RobloxDatabase.RobloxGames.GetOrCreate("PlaceAttributes_GetOrCreatePlaceAttribute", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetPlaceAttributeIDsByUniverseIDAndIsFilteringEnabled(long? universeId, bool? isFilteringEnabled, int count, long exclusiveStartId)
	{
		if (universeId == 0)
		{
			throw new ArgumentException("Parameter 'universeId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@UniverseID", universeId.HasValue ? ((object)universeId) : DBNull.Value),
			new SqlParameter("@IsFilteringEnabled", isFilteringEnabled.HasValue ? ((object)isFilteringEnabled) : DBNull.Value),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartID", exclusiveStartId)
		};
		return RobloxDatabase.RobloxGames.GetIDCollection<long>("PlaceAttributes_GetPlaceAttributeIDsByUniverseIDAndIsFilteringEnabled", queryParameters);
	}
}
