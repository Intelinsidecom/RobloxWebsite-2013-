using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

public class ReportedScriptDAL
{
	private long _ID;

	private int _ScriptID;

	private int _NumberOfInstancesInAsset;

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

	public int ScriptID
	{
		get
		{
			return _ScriptID;
		}
		set
		{
			_ScriptID = value;
		}
	}

	public int NumberOfInstancesInAsset
	{
		get
		{
			return _NumberOfInstancesInAsset;
		}
		set
		{
			_NumberOfInstancesInAsset = value;
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

	private static string ConnectionString => RobloxDatabase.RobloxAssetSecurity.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[ReportedScripts_DeleteReportedScriptByID]", queryParameters));
	}

	public void Insert()
	{
		if (_ScriptID == 0)
		{
			throw new ApplicationException("Required value not specified: ScriptID.");
		}
		if (_NumberOfInstancesInAsset == 0)
		{
			throw new ApplicationException("Required value not specified: NumberOfInstancesInAsset.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ScriptID", _ScriptID));
		queryParameters.Add(new SqlParameter("@NumberOfInstancesInAsset", _NumberOfInstancesInAsset));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[ReportedScripts_InsertReportedScript]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (_ScriptID == 0)
		{
			throw new ApplicationException("Required value not specified: ScriptID.");
		}
		if (_NumberOfInstancesInAsset == 0)
		{
			throw new ApplicationException("Required value not specified: NumberOfInstancesInAsset.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@ScriptID", _ScriptID));
		queryParameters.Add(new SqlParameter("@NumberOfInstancesInAsset", _NumberOfInstancesInAsset));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[ReportedScripts_UpdateReportedScriptByID]", queryParameters));
	}

	private static ReportedScriptDAL BuildDAL(SqlDataReader reader)
	{
		ReportedScriptDAL dal = new ReportedScriptDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ScriptID = (int)reader["ScriptID"];
			dal.NumberOfInstancesInAsset = (int)reader["NumberOfInstancesInAsset"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static ReportedScriptDAL Get(long id)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[ReportedScripts_GetReportedScriptByID]", queryParameters), BuildDAL);
	}

	public static int GetTotalNumberOfReportedScriptInstancesByScriptID(int scriptId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ScriptID", scriptId));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "[dbo].[ReportedScripts_GetTotalNumberOfReportedScriptInstancesByScriptID]", queryParameters));
	}

	public static int GetTotalNumberOfReportedScriptsByScriptID(int scriptId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ScriptID", scriptId));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "[dbo].[ReportedScripts_GetTotalNumberOfReportedScriptsByScriptID]", queryParameters));
	}
}
