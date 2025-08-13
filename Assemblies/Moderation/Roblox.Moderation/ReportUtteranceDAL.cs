using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

public class ReportUtteranceDAL
{
	private long _ID;

	private long _ReportID;

	private long _UtteranceID;

	private byte? _AbuseTypeID;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	public long ID
	{
		get
		{
			return _ID;
		}
		set
		{
			_ID = value;
		}
	}

	public long ReportID
	{
		get
		{
			return _ReportID;
		}
		set
		{
			_ReportID = value;
		}
	}

	public long UtteranceID
	{
		get
		{
			return _UtteranceID;
		}
		set
		{
			_UtteranceID = value;
		}
	}

	public byte? AbuseTypeID
	{
		get
		{
			return _AbuseTypeID;
		}
		set
		{
			_AbuseTypeID = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _Created;
		}
		set
		{
			_Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _Updated;
		}
		set
		{
			_Updated = value;
		}
	}

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportUtterances_DeleteReportUtteranceByID]", queryParameters));
	}

	public void Insert()
	{
		if (_ReportID == 0L)
		{
			throw new ApplicationException("Required value not specified: ReportID.");
		}
		if (_UtteranceID == 0L)
		{
			throw new ApplicationException("Required value not specified: UtteranceID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ReportID", _ReportID));
		queryParameters.Add(new SqlParameter("@UtteranceID", _UtteranceID));
		queryParameters.Add(new SqlParameter("@AbuseTypeID", _AbuseTypeID.HasValue ? ((object)_AbuseTypeID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportUtterances_InsertReportUtterance]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_ReportID == 0L)
		{
			throw new ApplicationException("Required value not specified: ReportID.");
		}
		if (_UtteranceID == 0L)
		{
			throw new ApplicationException("Required value not specified: UtteranceID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@ReportID", _ReportID));
		queryParameters.Add(new SqlParameter("@UtteranceID", _UtteranceID));
		queryParameters.Add(new SqlParameter("@AbuseTypeID", _AbuseTypeID.HasValue ? ((object)_AbuseTypeID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportUtterances_UpdateReportUtteranceByID]", queryParameters));
	}

	private static ReportUtteranceDAL BuildDAL(SqlDataReader reader)
	{
		ReportUtteranceDAL dal = new ReportUtteranceDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ReportID = (long)reader["ReportID"];
			dal.UtteranceID = (long)reader["UtteranceID"];
			dal.AbuseTypeID = (reader["AbuseTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["AbuseTypeID"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static ReportUtteranceDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportUtterances_GetReportUtteranceByID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetReportUtteranceIDsByReportIDPaged(long reportId, int startRowIndex, int maximumRows)
	{
		if (reportId == 0L)
		{
			throw new ApplicationException("Required value not specified: ReportID.");
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
		queryParameters.Add(new SqlParameter("@ReportID", reportId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportUtterances_GetReportUtteranceIDsByReportID_Paged]", queryParameters));
	}

	public static ICollection<long> GetReportUtteranceIDsByUtteranceIDPaged(long utteranceId, int startRowIndex, int maximumRows)
	{
		if (utteranceId == 0L)
		{
			return new List<long>();
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
		queryParameters.Add(new SqlParameter("@UtteranceId", utteranceId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportUtterances_GetReportUtteranceIDsByUtteranceID_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfReportUtterancesByReportID(long reportId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("ReportID", reportId));
		return EntityHelper.GetDataCount<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportUtterances_GetTotalNumberOfReportUtterancesByReportID]", queryParameters));
	}

	public static int GetTotalNumberOfReportUtterancesByUtteranceID(long utteranceId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("UtteranceID", utteranceId));
		return EntityHelper.GetDataCount<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportUtterances_GetTotalNumberOfReportUtterancesByUtteranceID]", queryParameters));
	}

	public static int GetTotalNumberOfReportUtterancesByUtteranceIDAndAbuseTypeID(long utteranceId, byte abuseTypeId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("UtteranceID", utteranceId));
		queryParameters.Add(new SqlParameter("AbuseTypeID", abuseTypeId));
		return EntityHelper.GetDataCount<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[ReportUtterances_GetTotalNumberOfReportUtterancesByUtteranceIDAndAbuseTypeID]", queryParameters));
	}
}
