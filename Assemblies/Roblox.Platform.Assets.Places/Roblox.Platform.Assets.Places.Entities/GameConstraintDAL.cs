using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Assets.Places.Entities;

/// <summary>
/// This class contains code that cannot be overwritten by files generated from the dbwireup tool
/// </summary>
[ExcludeFromCodeCoverage]
internal class GameConstraintDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGames;

	internal long ID { get; set; }

	internal long PlaceID { get; set; }

	internal int MaxPlayers { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal int? SocialSlots { get; set; }

	internal int? SocialSlotTypeID { get; set; }

	private static GameConstraintDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GameConstraintDAL
		{
			ID = (long)record["ID"],
			PlaceID = (long)record["PlaceID"],
			MaxPlayers = (int)record["MaxPlayers"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"],
			SocialSlots = (int?)record["SocialSlots"],
			SocialSlotTypeID = (int?)record["SocialSlotTypeID"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxGames.Delete("GameConstraints_DeleteGameConstraintByID", ID);
	}

	internal static GameConstraintDAL Get(long id)
	{
		return RobloxDatabase.RobloxGames.Get("GameConstraints_GetGameConstraintByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@MaxPlayers", MaxPlayers),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@SocialSlots", SocialSlots.HasValue ? ((object)SocialSlots) : DBNull.Value),
			new SqlParameter("@SocialSlotTypeID", SocialSlotTypeID.HasValue ? ((object)SocialSlotTypeID) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxGames.Insert<long>("GameConstraints_InsertGameConstraint", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@MaxPlayers", MaxPlayers),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@SocialSlots", SocialSlots.HasValue ? ((object)SocialSlots) : DBNull.Value),
			new SqlParameter("@SocialSlotTypeID", SocialSlotTypeID.HasValue ? ((object)SocialSlotTypeID) : DBNull.Value)
		};
		RobloxDatabase.RobloxGames.Update("GameConstraints_UpdateGameConstraintByID", queryParameters);
	}

	internal static GameConstraintDAL GetGameConstraintByPlaceID(long placeID)
	{
		if (placeID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PlaceID", placeID)
		};
		return RobloxDatabase.RobloxGames.Lookup("GameConstraints_GetGameConstraintByPlaceID", BuildDAL, queryParameters);
	}

	internal static ICollection<GameConstraintDAL> MultiGet(ICollection<long> ids)
	{
		throw new NotImplementedException();
	}

	internal static EntityHelper.GetOrCreateDALWrapper<GameConstraintDAL> GetOrCreateGameConstraint(long placeID, int defaultMaxPlayers)
	{
		if (placeID <= 0 || defaultMaxPlayers <= 0)
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
			new SqlParameter("@MaxPlayers", defaultMaxPlayers)
		};
		return RobloxDatabase.RobloxGames.GetOrCreate("GameConstraints_GetOrCreateGameConstraintByPlaceID", BuildDAL, queryParameters);
	}
}
