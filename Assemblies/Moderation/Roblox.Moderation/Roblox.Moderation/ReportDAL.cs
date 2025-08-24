using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

public class ReportDAL
{
	public long ID { get; set; }

	public long SubmitterID { get; set; }

	public long AllegedAbuserID { get; set; }

	public long? ContextUrlID { get; set; }

	public long? CommentExpressionID { get; set; }

	public long? PunishmentID { get; set; }

	public byte? ReportCategoryID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public long? ReportContextID { get; set; }

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportsV2_DeleteReportV2ByID]", queryParameters));
	}

	public void Insert()
	{
		if (SubmitterID == 0L)
		{
			throw new ApplicationException("Required value not specified: SubmitterID.");
		}
		if (AllegedAbuserID == 0L)
		{
			throw new ApplicationException("Required value not specified: AllegedAbuserID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SubmitterID", SubmitterID));
		queryParameters.Add(new SqlParameter("@AllegedAbuserID", AllegedAbuserID));
		queryParameters.Add(new SqlParameter("@ContextUrlID", ContextUrlID.HasValue ? ((object)ContextUrlID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CommentExpressionID", CommentExpressionID.HasValue ? ((object)CommentExpressionID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@PunishmentID", PunishmentID.HasValue ? ((object)PunishmentID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@ReportCategoryID", ReportCategoryID.HasValue ? ((object)ReportCategoryID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@ReportContextID", ReportContextID.HasValue ? ((object)ReportContextID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportsV2_InsertReportV2]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (SubmitterID == 0L)
		{
			throw new ApplicationException("Required value not specified: SubmitterID.");
		}
		if (AllegedAbuserID == 0L)
		{
			throw new ApplicationException("Required value not specified: AllegedAbuserID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@SubmitterID", SubmitterID));
		queryParameters.Add(new SqlParameter("@AllegedAbuserID", AllegedAbuserID));
		queryParameters.Add(new SqlParameter("@ContextUrlID", ContextUrlID.HasValue ? ((object)ContextUrlID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CommentExpressionID", CommentExpressionID.HasValue ? ((object)CommentExpressionID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@PunishmentID", PunishmentID.HasValue ? ((object)PunishmentID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@ReportCategoryID", ReportCategoryID.HasValue ? ((object)ReportCategoryID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@ReportContextID", ReportContextID.HasValue ? ((object)ReportContextID) : DBNull.Value));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportsV2_UpdateReportV2ByID]", queryParameters));
	}

	private static ReportDAL BuildDAL(SqlDataReader reader)
	{
		ReportDAL dal = new ReportDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.SubmitterID = (long)reader["SubmitterID"];
			dal.AllegedAbuserID = (long)reader["AllegedAbuserID"];
			dal.ContextUrlID = (reader["ContextUrlID"].Equals(DBNull.Value) ? null : ((long?)reader["ContextUrlID"]));
			dal.CommentExpressionID = (reader["CommentExpressionID"].Equals(DBNull.Value) ? null : ((long?)reader["CommentExpressionID"]));
			dal.PunishmentID = (reader["PunishmentID"].Equals(DBNull.Value) ? null : ((long?)reader["PunishmentID"]));
			dal.ReportCategoryID = (reader["ReportCategoryID"].Equals(DBNull.Value) ? null : ((byte?)reader["ReportCategoryID"]));
			dal.ReportContextID = (reader["ReportContextID"].Equals(DBNull.Value) ? null : ((long?)reader["ReportContextID"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	public static ReportDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportsV2_GetReportV2ByID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetOpenReportIDsByAllegedAbuserID(long allegedAbuserId)
	{
		if (allegedAbuserId == 0L)
		{
			return new List<long>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AllegedAbuserID", allegedAbuserId));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportsV2_GetOpenReportV2IDsByAllegedAbuserID]", queryParameters));
	}

	public static ICollection<long> GetOpenReportIDsBySubmitterID(long submitterId)
	{
		if (submitterId == 0L)
		{
			return new List<long>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SubmitterID", submitterId));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportsV2_GetOpenReportV2IDsBySubmitterID]", queryParameters));
	}

	public static ICollection<long> GetPunishmentReportIDsPaged(long punishmentId, int startRowIndex, int maximumRows)
	{
		if (punishmentId == 0L)
		{
			throw new ApplicationException("Required value not specified: PunishmentID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PunishmentID", punishmentId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportsV2_GetReportV2IDsByPunishmentID_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfPunishmentReports(long punishmentId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PunishmentID", punishmentId));
		return EntityHelper.GetDataCount<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportsV2_GetTotalNumberOfReportsV2ByPunishmentID]", queryParameters));
	}
}
