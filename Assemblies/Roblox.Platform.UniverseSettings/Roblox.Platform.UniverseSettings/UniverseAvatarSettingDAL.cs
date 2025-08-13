using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarSettingDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAvatars;

	internal long ID { get; set; }

	internal long UniverseID { get; set; }

	internal byte UniverseAvatarTypeID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal byte? UniverseScaleTypeID { get; set; }

	internal byte? UniverseAvatarAnimationTypeID { get; set; }

	internal byte? UniverseAvatarCollisionTypeID { get; set; }

	internal byte? UniverseAvatarJointPositioningTypeID { get; set; }

	internal byte? UniverseAvatarBodyTypeID { get; set; }

	internal int? UniverseAvatarMinScaleID { get; set; }

	internal int? UniverseAvatarMaxScaleID { get; set; }

	private static UniverseAvatarSettingDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UniverseAvatarSettingDAL
		{
			ID = (long)record["ID"],
			UniverseID = (long)record["UniverseID"],
			UniverseAvatarTypeID = (byte)record["UniverseAvatarTypeID"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local),
			UniverseScaleTypeID = (byte?)record["UniverseScaleTypeID"],
			UniverseAvatarAnimationTypeID = (byte?)record["UniverseAvatarAnimationTypeID"],
			UniverseAvatarCollisionTypeID = (byte?)record["UniverseAvatarCollisionTypeID"],
			UniverseAvatarJointPositioningTypeID = (byte?)record["UniverseAvatarJointPositioningTypeID"],
			UniverseAvatarBodyTypeID = (byte?)record["UniverseAvatarBodyTypeID"],
			UniverseAvatarMinScaleID = (int?)record["UniverseAvatarMinScaleID"],
			UniverseAvatarMaxScaleID = (int?)record["UniverseAvatarMaxScaleID"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAvatars.Delete("UniverseAvatarSettings_DeleteUniverseAvatarSettingByID", ID);
	}

	internal static UniverseAvatarSettingDAL Get(long id)
	{
		return RobloxDatabase.RobloxAvatars.Get("UniverseAvatarSettings_GetUniverseAvatarSettingByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[12]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@UniverseAvatarTypeID", UniverseAvatarTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@UniverseScaleTypeID", UniverseScaleTypeID.HasValue ? ((object)UniverseScaleTypeID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarAnimationTypeID", UniverseAvatarAnimationTypeID.HasValue ? ((object)UniverseAvatarAnimationTypeID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarCollisionTypeID", UniverseAvatarCollisionTypeID.HasValue ? ((object)UniverseAvatarCollisionTypeID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarJointPositioningTypeID", UniverseAvatarJointPositioningTypeID.HasValue ? ((object)UniverseAvatarJointPositioningTypeID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarBodyTypeID", UniverseAvatarBodyTypeID.HasValue ? ((object)UniverseAvatarBodyTypeID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarMinScaleID", UniverseAvatarMinScaleID.HasValue ? ((object)UniverseAvatarMinScaleID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarMaxScaleID", UniverseAvatarMaxScaleID.HasValue ? ((object)UniverseAvatarMaxScaleID) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxAvatars.Insert<long>("UniverseAvatarSettings_InsertUniverseAvatarSetting", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[12]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@UniverseAvatarTypeID", UniverseAvatarTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@UniverseScaleTypeID", UniverseScaleTypeID.HasValue ? ((object)UniverseScaleTypeID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarAnimationTypeID", UniverseAvatarAnimationTypeID.HasValue ? ((object)UniverseAvatarAnimationTypeID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarCollisionTypeID", UniverseAvatarCollisionTypeID.HasValue ? ((object)UniverseAvatarCollisionTypeID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarJointPositioningTypeID", UniverseAvatarJointPositioningTypeID.HasValue ? ((object)UniverseAvatarJointPositioningTypeID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarBodyTypeID", UniverseAvatarBodyTypeID.HasValue ? ((object)UniverseAvatarBodyTypeID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarMinScaleID", UniverseAvatarMinScaleID.HasValue ? ((object)UniverseAvatarMinScaleID) : DBNull.Value),
			new SqlParameter("@UniverseAvatarMaxScaleID", UniverseAvatarMaxScaleID.HasValue ? ((object)UniverseAvatarMaxScaleID) : DBNull.Value)
		};
		RobloxDatabase.RobloxAvatars.Update("UniverseAvatarSettings_UpdateUniverseAvatarSettingByID", queryParameters);
	}

	internal static ICollection<UniverseAvatarSettingDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAvatars.MultiGet("UniverseAvatarSettings_GetUniverseAvatarSettingsByIDs", ids, BuildDAL);
	}

	internal static UniverseAvatarSettingDAL GetUniverseAvatarSettingByUniverseID(long universeId)
	{
		if (universeId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UniverseID", universeId)
		};
		return RobloxDatabase.RobloxAvatars.Lookup("UniverseAvatarSettings_GetUniverseAvatarSettingByUniverseID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<UniverseAvatarSettingDAL> GetOrCreateUniverseAvatarSetting(long universeId, byte universeAvatarTypeId, byte? universeScaleTypeId, byte? universeAvatarAnimationTypeId, byte? universeAvatarCollisionTypeId, byte? universeAvatarBodyTypeId, byte? universeAvatarJointPositioningTypeId, int? universeAvatarMinScaleId, int? universeAvatarMaxScaleId)
	{
		if (universeId == 0L)
		{
			return null;
		}
		SqlParameter[] obj = new SqlParameter[10]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UniverseID", universeId),
			new SqlParameter("@UniverseAvatarTypeID", universeAvatarTypeId),
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		byte? b = universeScaleTypeId;
		obj[3] = new SqlParameter("@UniverseScaleTypeID", b.HasValue ? ((object)b.GetValueOrDefault()) : DBNull.Value);
		b = universeAvatarAnimationTypeId;
		obj[4] = new SqlParameter("@UniverseAvatarAnimationTypeID", b.HasValue ? ((object)b.GetValueOrDefault()) : DBNull.Value);
		b = universeAvatarCollisionTypeId;
		obj[5] = new SqlParameter("@UniverseAvatarCollisionTypeID", b.HasValue ? ((object)b.GetValueOrDefault()) : DBNull.Value);
		b = universeAvatarBodyTypeId;
		obj[6] = new SqlParameter("@UniverseAvatarBodyTypeID", b.HasValue ? ((object)b.GetValueOrDefault()) : DBNull.Value);
		b = universeAvatarJointPositioningTypeId;
		obj[7] = new SqlParameter("@UniverseAvatarJointPositioningTypeID", b.HasValue ? ((object)b.GetValueOrDefault()) : DBNull.Value);
		int? num = universeAvatarMinScaleId;
		obj[8] = new SqlParameter("@UniverseAvatarMinScaleID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		num = universeAvatarMaxScaleId;
		obj[9] = new SqlParameter("@UniverseAvatarMaxScaleID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAvatars.GetOrCreate("UniverseAvatarSettings_GetOrCreateUniverseAvatarSetting", BuildDAL, queryParameters);
	}
}
