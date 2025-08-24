using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class EligibilityCriterionDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAbTesting;

	internal int ID { get; set; }

	internal int ExperimentID { get; set; }

	internal int EligibilityCriterionTypeID { get; set; }

	internal DateTime Created { get; set; }

	private static EligibilityCriterionDAL BuildDAL(IDictionary<string, object> record)
	{
		return new EligibilityCriterionDAL
		{
			ID = (int)record["ID"],
			ExperimentID = (int)record["ExperimentID"],
			EligibilityCriterionTypeID = (int)record["EligibilityCriterionTypeID"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAbTesting.Delete("EligibilityCriteria_DeleteEligibilityCriterionByID", ID);
	}

	internal static EligibilityCriterionDAL Get(int id)
	{
		return RobloxDatabase.RobloxAbTesting.Get("EligibilityCriteria_GetEligibilityCriterionByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ExperimentID", ExperimentID),
			new SqlParameter("@EligibilityCriterionTypeID", EligibilityCriterionTypeID),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAbTesting.Insert<int>("EligibilityCriteria_InsertEligibilityCriterion", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ExperimentID", ExperimentID),
			new SqlParameter("@EligibilityCriterionTypeID", EligibilityCriterionTypeID),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxAbTesting.Update("EligibilityCriteria_UpdateEligibilityCriterionByID", queryParameters);
	}

	internal static ICollection<EligibilityCriterionDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxAbTesting.MultiGet("EligibilityCriteria_GetEligibilityCriteriaByIDs", ids, BuildDAL);
	}

	internal static ICollection<int> GetEligibilityCriterionIDsByExperimentIDPaged(int experimentID, long startRowIndex, long maximumRows)
	{
		if (experimentID == 0)
		{
			throw new ArgumentException("Parameter 'experimentID' cannot be null, empty or the default value.");
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
			new SqlParameter("@ExperimentID", experimentID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxAbTesting.GetIDCollection<int>("EligibilityCriteria_GetEligibilityCriterionIDsByExperimentID_Paged", queryParameters);
	}

	internal static EligibilityCriterionDAL GetEligibilityCriterionByExperimentIDAndEligibilityCriterionTypeID(int experimentID, int eligibilityCriterionTypeID)
	{
		if (experimentID == 0)
		{
			return null;
		}
		if (eligibilityCriterionTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@ExperimentID", experimentID),
			new SqlParameter("@EligibilityCriterionTypeID", eligibilityCriterionTypeID)
		};
		return RobloxDatabase.RobloxAbTesting.Lookup("EligibilityCriteria_GetEligibilityCriterionByExperimentIDAndEligibilityCriterionTypeID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<EligibilityCriterionDAL> GetOrCreateEligibilityCriterion(int experimentID, int eligibilityCriterionTypeID)
	{
		if (experimentID == 0)
		{
			return null;
		}
		if (eligibilityCriterionTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ExperimentID", experimentID),
			new SqlParameter("@EligibilityCriterionTypeID", eligibilityCriterionTypeID)
		};
		return RobloxDatabase.RobloxAbTesting.GetOrCreate("EligibilityCriteria_GetOrCreateEligibilityCriterion", BuildDAL, queryParameters);
	}
}
