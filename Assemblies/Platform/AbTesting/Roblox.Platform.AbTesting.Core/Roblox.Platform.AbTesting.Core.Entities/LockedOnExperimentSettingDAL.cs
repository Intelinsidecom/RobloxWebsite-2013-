using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class LockedOnExperimentSettingDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAbTesting;

	internal int ID { get; set; }

	internal int ExperimentID { get; set; }

	internal byte? LockedOnVariationValue { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static LockedOnExperimentSettingDAL BuildDAL(IDictionary<string, object> record)
	{
		return new LockedOnExperimentSettingDAL
		{
			ID = (int)record["ID"],
			ExperimentID = (int)record["ExperimentID"],
			LockedOnVariationValue = (byte?)record["LockedOnVariationValue"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAbTesting.Delete("LockedOnExperimentSettings_DeleteLockedOnExperimentSettingByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ExperimentID", ExperimentID),
			new SqlParameter("@LockedOnVariationValue", LockedOnVariationValue.HasValue ? ((object)LockedOnVariationValue) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAbTesting.Insert<int>("LockedOnExperimentSettings_InsertLockedOnExperimentSetting", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ExperimentID", ExperimentID),
			new SqlParameter("@LockedOnVariationValue", LockedOnVariationValue.HasValue ? ((object)LockedOnVariationValue) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAbTesting.Update("LockedOnExperimentSettings_UpdateLockedOnExperimentSettingByID", queryParameters);
	}

	internal static LockedOnExperimentSettingDAL Get(int id)
	{
		return RobloxDatabase.RobloxAbTesting.Get("LockedOnExperimentSettings_GetLockedOnExperimentSettingByID", id, BuildDAL);
	}

	internal static ICollection<LockedOnExperimentSettingDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxAbTesting.MultiGet("LockedOnExperimentSettings_GetLockedOnExperimentSettingsByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<LockedOnExperimentSettingDAL> GetOrCreateLockedOnExperimentSetting(int experimentID)
	{
		if (experimentID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ExperimentID", experimentID)
		};
		return RobloxDatabase.RobloxAbTesting.GetOrCreate("LockedOnExperimentSettings_GetOrCreateLockedOnExperimentSetting", BuildDAL, queryParameters);
	}
}
