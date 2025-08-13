using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets.Places.Entities;

[ExcludeFromCodeCoverage]
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

	/// <summary>
	/// Irregular GetOrCreate -- GET by placeID only, CREATE by placeID and placeTypeID
	/// </summary>
	internal static EntityHelper.GetOrCreateDALWrapper<PlaceAttributeDAL> GetByPlaceIdOrCreateByPlaceIdAndPlaceTypeId(long placeID, byte placeTypeID)
	{
		if (placeID == 0L)
		{
			throw new PlatformArgumentException("placeID");
		}
		if (placeTypeID == 0)
		{
			throw new PlatformArgumentException("placeTypeID");
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
		SqlParameter[] obj = new SqlParameter[10]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@PlaceTypeID", PlaceTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			null,
			null,
			null,
			null,
			null
		};
		bool? usePlaceMediaForThumb = UsePlaceMediaForThumb;
		obj[5] = new SqlParameter("@UsePlaceMediaForThumb", usePlaceMediaForThumb.HasValue ? ((object)usePlaceMediaForThumb.GetValueOrDefault()) : DBNull.Value);
		usePlaceMediaForThumb = OverridesDefaultAvatar;
		obj[6] = new SqlParameter("@OverridesDefaultAvatar", usePlaceMediaForThumb.HasValue ? ((object)usePlaceMediaForThumb.GetValueOrDefault()) : DBNull.Value);
		usePlaceMediaForThumb = UsePortraitMode;
		obj[7] = new SqlParameter("@UsePortraitMode", usePlaceMediaForThumb.HasValue ? ((object)usePlaceMediaForThumb.GetValueOrDefault()) : DBNull.Value);
		long? universeID = UniverseID;
		obj[8] = new SqlParameter("@UniverseID", universeID.HasValue ? ((object)universeID.GetValueOrDefault()) : DBNull.Value);
		usePlaceMediaForThumb = IsFilteringEnabled;
		obj[9] = new SqlParameter("@IsFilteringEnabled", usePlaceMediaForThumb.HasValue ? ((object)usePlaceMediaForThumb.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		ID = RobloxDatabase.RobloxGames.Insert<long>("PlaceAttributes_InsertPlaceAttribute", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] obj = new SqlParameter[10]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@PlaceTypeID", PlaceTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			null,
			null,
			null,
			null,
			null
		};
		bool? usePlaceMediaForThumb = UsePlaceMediaForThumb;
		obj[5] = new SqlParameter("@UsePlaceMediaForThumb", usePlaceMediaForThumb.HasValue ? ((object)usePlaceMediaForThumb.GetValueOrDefault()) : DBNull.Value);
		usePlaceMediaForThumb = OverridesDefaultAvatar;
		obj[6] = new SqlParameter("@OverridesDefaultAvatar", usePlaceMediaForThumb.HasValue ? ((object)usePlaceMediaForThumb.GetValueOrDefault()) : DBNull.Value);
		usePlaceMediaForThumb = UsePortraitMode;
		obj[7] = new SqlParameter("@UsePortraitMode", usePlaceMediaForThumb.HasValue ? ((object)usePlaceMediaForThumb.GetValueOrDefault()) : DBNull.Value);
		long? universeID = UniverseID;
		obj[8] = new SqlParameter("@UniverseID", universeID.HasValue ? ((object)universeID.GetValueOrDefault()) : DBNull.Value);
		usePlaceMediaForThumb = IsFilteringEnabled;
		obj[9] = new SqlParameter("@IsFilteringEnabled", usePlaceMediaForThumb.HasValue ? ((object)usePlaceMediaForThumb.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		RobloxDatabase.RobloxGames.Update("PlaceAttributes_UpdatePlaceAttributeByID", queryParameters);
	}

	internal static ICollection<PlaceAttributeDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxGames.MultiGet("PlaceAttributes_GetPlaceAttributesByIDs", ids, BuildDAL);
	}

	internal static PlaceAttributeDAL GetPlaceAttributeByPlaceID(long placeId)
	{
		if (placeId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PlaceID", placeId)
		};
		return RobloxDatabase.RobloxGames.Lookup("PlaceAttributes_GetPlaceAttributeByPlaceID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<PlaceAttributeDAL> GetOrCreatePlaceAttribute(long placeId)
	{
		if (placeId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PlaceID", placeId)
		};
		return RobloxDatabase.RobloxGames.GetOrCreate("PlaceAttributes_GetOrCreatePlaceAttribute", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetPlaceAttributeIDsByUniverseIDAndIsFilteringEnabled(long? universeId, bool? isFilteringEnabled, int count, long? exclusiveStartId)
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
		SqlParameter[] array = new SqlParameter[4];
		long? num = universeId;
		array[0] = new SqlParameter("@UniverseID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		bool? flag = isFilteringEnabled;
		array[1] = new SqlParameter("@IsFilteringEnabled", flag.HasValue ? ((object)flag.GetValueOrDefault()) : DBNull.Value);
		array[2] = new SqlParameter("@Count", count);
		num = exclusiveStartId;
		array[3] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = array;
		return RobloxDatabase.RobloxGames.GetIDCollection<long>("PlaceAttributes_GetPlaceAttributeIDsByUniverseIDAndIsFilteringEnabled", queryParameters);
	}
}
