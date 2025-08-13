using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class EligibilityCriterionTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAbTesting;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static EligibilityCriterionTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new EligibilityCriterionTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAbTesting.Delete("EligibilityCriterionTypes_DeleteEligibilityCriterionTypeByID", ID);
	}

	internal static EligibilityCriterionTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxAbTesting.Get("EligibilityCriterionTypes_GetEligibilityCriterionTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAbTesting.Insert<int>("EligibilityCriterionTypes_InsertEligibilityCriterionType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAbTesting.Update("EligibilityCriterionTypes_UpdateEligibilityCriterionTypeByID", queryParameters);
	}

	internal static ICollection<EligibilityCriterionTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxAbTesting.MultiGet("EligibilityCriterionTypes_GetEligibilityCriterionTypesByIDs", ids, BuildDAL);
	}

	internal static ICollection<int> GetEligibilityCriterionTypeIDsPaged(int startRowIndex, int maximumRows)
	{
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxAbTesting.GetIDCollection<int>("EligibilityCriterionTypes_GetEligibilityCriterionTypeIDs_Paged", queryParameters);
	}
}
