using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class ExperimentDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAbTesting;

	internal int ID { get; set; }

	internal string Name { get; set; }

	internal int Variations { get; set; }

	internal byte Version { get; set; }

	internal bool IsEnrollmentExclusive { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ExperimentDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ExperimentDAL
		{
			ID = (int)record["ID"],
			Name = (string)record["Name"],
			Variations = (int)record["Variations"],
			Version = (byte)record["Version"],
			IsEnrollmentExclusive = (bool)record["IsEnrollmentExclusive"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAbTesting.Delete("Experiments_DeleteExperimentByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Name", Name),
			new SqlParameter("@Variations", Variations),
			new SqlParameter("@Version", Version),
			new SqlParameter("@IsEnrollmentExclusive", IsEnrollmentExclusive),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAbTesting.Insert<int>("Experiments_InsertExperiment", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Variations", Variations),
			new SqlParameter("@Version", Version),
			new SqlParameter("@IsEnrollmentExclusive", IsEnrollmentExclusive),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAbTesting.Update("Experiments_UpdateExperimentByID", queryParameters);
	}

	internal static ExperimentDAL Get(int id)
	{
		return RobloxDatabase.RobloxAbTesting.Get("Experiments_GetExperimentByID", id, BuildDAL);
	}

	internal static ICollection<ExperimentDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxAbTesting.MultiGet("Experiments_GetExperimentsByIDs", ids, BuildDAL);
	}

	internal static ExperimentDAL GetExperimentByName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxAbTesting.Lookup("Experiments_GetExperimentByName", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetExperimentIDsPaged(long startRowIndex, long maximumRows)
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
		return RobloxDatabase.RobloxAbTesting.GetIDCollection<int>("Experiments_GetExperimentIDs_Paged", queryParameters);
	}
}
