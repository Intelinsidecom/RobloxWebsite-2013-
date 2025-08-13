using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

internal class ReportProbabilityDAL
{
	internal long ID { get; set; }

	internal long ReportID { get; set; }

	internal double Value { get; set; }

	internal DateTime Created { get; set; }

	internal bool? IsAutoClosed { get; set; }

	internal bool? ModeratorConcurred { get; set; }

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "ReportProbabilities_DeleteReportProbabilityByID", queryParameters));
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ReportID", ReportID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@IsAutoClosed", IsAutoClosed),
			new SqlParameter("@ModeratorConcurred", ModeratorConcurred)
		};
		DbInfo dbInfo = new DbInfo(Helper.DBConnectionString, "ReportProbabilities_InsertReportProbability", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ReportID", ReportID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@IsAutoClosed", IsAutoClosed),
			new SqlParameter("@ModeratorConcurred", ModeratorConcurred)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "ReportProbabilities_UpdateReportProbabilityByID", queryParameters));
	}

	private static ReportProbabilityDAL BuildDAL(SqlDataReader reader)
	{
		ReportProbabilityDAL dal = new ReportProbabilityDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ReportID = (long)reader["ReportID"];
			dal.Value = (double)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.IsAutoClosed = (reader["IsAutoClosed"].Equals(DBNull.Value) ? null : ((bool?)reader["IsAutoClosed"]));
			dal.ModeratorConcurred = (reader["ModeratorConcurred"].Equals(DBNull.Value) ? null : ((bool?)reader["ModeratorConcurred"]));
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static ReportProbabilityDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "ReportProbabilities_GetReportProbabilityByID", queryParameters), BuildDAL);
	}

	internal static ReportProbabilityDAL GetByReportId(long reportId)
	{
		if (reportId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ReportID", reportId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "ReportProbabilities_GetReportProbabilityByReportID", queryParameters), BuildDAL);
	}
}
