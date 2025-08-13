using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AbTesting.Core.Entities;

[ExcludeFromCodeCoverage]
internal class EnrollmentDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAbTesting;

	internal long ID { get; set; }

	internal int SubjectTypeID { get; set; }

	internal long SubjectTargetID { get; set; }

	internal int VersionID { get; set; }

	internal int VariationID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static EnrollmentDAL BuildDAL(IDictionary<string, object> record)
	{
		return new EnrollmentDAL
		{
			ID = (long)record["ID"],
			SubjectTypeID = (int)record["SubjectTypeID"],
			SubjectTargetID = (long)record["SubjectTargetID"],
			VersionID = (int)record["VersionID"],
			VariationID = (int)record["VariationID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAbTesting.Delete("Enrollments_DeleteEnrollmentByID", ID);
	}

	internal static EnrollmentDAL Get(long id)
	{
		return RobloxDatabase.RobloxAbTesting.Get("Enrollments_GetEnrollmentByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@SubjectTypeID", SubjectTypeID),
			new SqlParameter("@SubjectTargetID", SubjectTargetID),
			new SqlParameter("@VersionID", VersionID),
			new SqlParameter("@VariationID", VariationID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAbTesting.Insert<long>("Enrollments_InsertEnrollment", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SubjectTypeID", SubjectTypeID),
			new SqlParameter("@SubjectTargetID", SubjectTargetID),
			new SqlParameter("@VersionID", VersionID),
			new SqlParameter("@VariationID", VariationID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAbTesting.Update("Enrollments_UpdateEnrollmentByID", queryParameters);
	}

	internal static ICollection<EnrollmentDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAbTesting.MultiGet("Enrollments_GetEnrollmentsByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<EnrollmentDAL> GetOrCreateEnrollment(int subjectTypeId, long subjectTargetId, int versionId, int variationId)
	{
		if (subjectTypeId <= 0)
		{
			return null;
		}
		if (subjectTargetId <= 0)
		{
			return null;
		}
		if (versionId <= 0)
		{
			return null;
		}
		if (variationId <= 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@SubjectTypeID", subjectTypeId),
			new SqlParameter("@SubjectTargetID", subjectTargetId),
			new SqlParameter("@VersionID", versionId),
			new SqlParameter("@VariationID", variationId)
		};
		return RobloxDatabase.RobloxAbTesting.GetOrCreate("Enrollments_GetOrCreateEnrollment", BuildDAL, queryParameters);
	}

	internal static EnrollmentDAL GetEnrollmentBySubjectTypeIDSubjectTargetIDAndVersionID(int subjectTypeId, long subjectTargetId, int versionId)
	{
		if (subjectTypeId <= 0)
		{
			return null;
		}
		if (subjectTargetId <= 0)
		{
			return null;
		}
		if (versionId <= 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@SubjectTypeID", subjectTypeId),
			new SqlParameter("@SubjectTargetID", subjectTargetId),
			new SqlParameter("@VersionID", versionId)
		};
		return RobloxDatabase.RobloxAbTesting.Lookup("Enrollments_GetEnrollmentBySubjectTypeIDSubjectTargetIDAndVersionID", BuildDAL, queryParameters);
	}
}
