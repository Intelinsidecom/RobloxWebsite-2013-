using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

public class ReportCategoryAutoCloseProbabilityThresholdDAL
{
	internal byte ID { get; set; }

	internal byte ReportCategoryID { get; set; }

	internal double LowLoadMinimumProbability { get; set; }

	internal double HighLoadMinimumProbability { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ReportCategoryAutoCloseProbabilityThresholdDAL BuildDAL(SqlDataReader reader)
	{
		ReportCategoryAutoCloseProbabilityThresholdDAL dal = new ReportCategoryAutoCloseProbabilityThresholdDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.ReportCategoryID = (byte)reader["ReportCategoryID"];
			dal.LowLoadMinimumProbability = (double)reader["LowLoadMinimumProbability"];
			dal.HighLoadMinimumProbability = (double)reader["HighLoadMinimumProbability"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "ReportCategoryAutoCloseProbabilityThresholds_DeleteReportCategoryAutoCloseProbabilityThresholdByID", queryParameters));
	}

	internal static ReportCategoryAutoCloseProbabilityThresholdDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "ReportCategoryAutoCloseProbabilityThresholds_GetReportCategoryAutoCloseProbabilityThresholdByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ReportCategoryID", ReportCategoryID),
			new SqlParameter("@LowLoadMinimumProbability", LowLoadMinimumProbability),
			new SqlParameter("@HighLoadMinimumProbability", HighLoadMinimumProbability),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(Helper.DBConnectionString, "ReportCategoryAutoCloseProbabilityThresholds_InsertReportCategoryAutoCloseProbabilityThreshold", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ReportCategoryID", ReportCategoryID),
			new SqlParameter("@LowLoadMinimumProbability", LowLoadMinimumProbability),
			new SqlParameter("@HighLoadMinimumProbability", HighLoadMinimumProbability),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "ReportCategoryAutoCloseProbabilityThresholds_UpdateReportCategoryAutoCloseProbabilityThresholdByID", queryParameters));
	}

	internal static ReportCategoryAutoCloseProbabilityThresholdDAL GetReportCategoryAutoCloseProbabilityThresholdByReportCategoryID(byte reportCategoryID)
	{
		if (reportCategoryID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ReportCategoryID", reportCategoryID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "ReportCategoryAutoCloseProbabilityThresholds_GetReportCategoryAutoCloseProbabilityThresholdByReportCategoryID", queryParameters), BuildDAL);
	}
}
