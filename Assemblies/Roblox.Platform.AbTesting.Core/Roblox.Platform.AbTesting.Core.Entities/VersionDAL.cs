using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class VersionDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAbTesting;

	internal int ID { get; set; }

	internal int ExperimentID { get; set; }

	internal byte VersionNumber { get; set; }

	internal int EnrollmentPeriodInHours { get; set; }

	internal DateTime Started { get; set; }

	internal DateTime EndDate { get; set; }

	internal bool IsActive { get; set; }

	internal byte PercentOfSubjectsToEnroll { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static VersionDAL BuildDAL(IDictionary<string, object> record)
	{
		return new VersionDAL
		{
			ID = (int)record["ID"],
			ExperimentID = (int)record["ExperimentID"],
			VersionNumber = (byte)record["Version"],
			EnrollmentPeriodInHours = (int)record["EnrollmentPeriodInHours"],
			Started = (DateTime)record["Started"],
			EndDate = (DateTime)record["EndDate"],
			IsActive = (bool)record["IsActive"],
			PercentOfSubjectsToEnroll = (byte)record["PercentOfSubjectsToEnroll"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAbTesting.Delete("Versions_DeleteVersionByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ExperimentID", ExperimentID),
			new SqlParameter("@Version", VersionNumber),
			new SqlParameter("@EnrollmentPeriodInHours", EnrollmentPeriodInHours),
			new SqlParameter("@Started", Started),
			new SqlParameter("@EndDate", EndDate),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@PercentOfSubjectsToEnroll", PercentOfSubjectsToEnroll),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAbTesting.Insert<int>("Versions_InsertVersion", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ExperimentID", ExperimentID),
			new SqlParameter("@Version", VersionNumber),
			new SqlParameter("@EnrollmentPeriodInHours", EnrollmentPeriodInHours),
			new SqlParameter("@Started", Started),
			new SqlParameter("@EndDate", EndDate),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@PercentOfSubjectsToEnroll", PercentOfSubjectsToEnroll),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAbTesting.Update("Versions_UpdateVersionByID", queryParameters);
	}

	internal static VersionDAL Get(int id)
	{
		return RobloxDatabase.RobloxAbTesting.Get("Versions_GetVersionByID", id, BuildDAL);
	}

	internal static ICollection<VersionDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxAbTesting.MultiGet("Versions_GetVersionsByIDs", ids, BuildDAL);
	}

	internal static VersionDAL GetVersionByExperimentIDAndVersion(int experimentID, byte versionNumber)
	{
		if (experimentID == 0)
		{
			return null;
		}
		if (versionNumber == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@ExperimentID", experimentID),
			new SqlParameter("@Version", versionNumber)
		};
		return RobloxDatabase.RobloxAbTesting.Lookup("Versions_GetVersionByExperimentIDAndVersion", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetVersionIDsByExperimentIDAndIsActivePaged(int experimentID, bool isActive, long startRowIndex, long maximumRows)
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
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ExperimentID", experimentID),
			new SqlParameter("@IsActive", isActive),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxAbTesting.GetIDCollection<int>("Versions_GetVersionIDsByExperimentIDAndIsActive_Paged", queryParameters);
	}

	internal static ICollection<int> GetVersionIDsByIsActivePaged(bool isActive, long startRowIndex, long maximumRows)
	{
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
			new SqlParameter("@IsActive", isActive),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxAbTesting.GetIDCollection<int>("Versions_GetVersionIDsByIsActive_Paged", queryParameters);
	}

	internal static ICollection<int> GetVersionIDsByExperimentIDPaged(int experimentID, long startRowIndex, long maximumRows)
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
		return RobloxDatabase.RobloxAbTesting.GetIDCollection<int>("Versions_GetVersionIDsByExperimentID_Paged", queryParameters);
	}
}
