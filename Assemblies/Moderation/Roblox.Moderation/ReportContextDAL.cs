using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class ReportContextDAL
{
	private long _ID;

	private byte _ReportContextTypeID;

	private long _ReportContextID;

	private DateTime _Created;

	private DateTime _Updated;

	internal long ID
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

	internal byte ReportContextTypeID
	{
		get
		{
			return _ReportContextTypeID;
		}
		set
		{
			_ReportContextTypeID = value;
		}
	}

	internal long ReportContextID
	{
		get
		{
			return _ReportContextID;
		}
		set
		{
			_ReportContextID = value;
		}
	}

	internal DateTime Created
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

	internal DateTime Updated
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

	private static string _DbConnectionString => Settings.Default.dbConnectionString_RobloxModeration;

	internal ReportContextDAL()
	{
	}

	internal void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "ReportContexts_DeleteReportContextByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ReportContextTypeID", ReportContextTypeID),
			new SqlParameter("@ReportContextID", ReportContextID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "ReportContexts_InsertReportContext", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@ReportContextTypeID", ReportContextTypeID),
			new SqlParameter("@ReportContextID", ReportContextID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "ReportContexts_UpdateReportContextByID", queryParameters));
	}

	private static ReportContextDAL BuildDAL(SqlDataReader reader)
	{
		ReportContextDAL dal = new ReportContextDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ReportContextTypeID = (byte)reader["ReportContextTypeID"];
			dal.ReportContextID = (long)reader["ReportContextID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static ReportContextDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ReportContexts_GetReportContextByID", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<ReportContextDAL> GetOrCreate(long reportContextID, byte reportContextTypeID)
	{
		if (reportContextID == 0L)
		{
			throw new ApplicationException("Required value not specified: ReportContextID");
		}
		if (reportContextTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: ReportContextTypeID");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ReportContextID", reportContextID));
		queryParameters.Add(new SqlParameter("@ReportContextTypeID", reportContextTypeID));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "ReportContexts_GetOrCreateReportContextByReportContextIDAndReportContextTypeID", queryParameters), BuildDAL);
	}
}
