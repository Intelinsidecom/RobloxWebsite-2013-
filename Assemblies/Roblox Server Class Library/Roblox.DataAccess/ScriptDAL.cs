using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

public class ScriptDAL
{
	private int _ID;

	private string _Hash = string.Empty;

	private float _Safety;

	private long _AuthorAgentID;

	private int _SuccessCount;

	private int _FailureCount;

	private int? _LineNumber;

	private int? _ScriptErrorID;

	private string _CallStackHash = string.Empty;

	private bool _IsTentativeAuthor;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	public int ID
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

	public string Hash
	{
		get
		{
			return _Hash;
		}
		set
		{
			_Hash = value;
		}
	}

	public long AuthorAgentID
	{
		get
		{
			return _AuthorAgentID;
		}
		set
		{
			_AuthorAgentID = value;
		}
	}

	public float Safety
	{
		get
		{
			return _Safety;
		}
		set
		{
			_Safety = value;
		}
	}

	public int SuccessCount
	{
		get
		{
			return _SuccessCount;
		}
		set
		{
			_SuccessCount = value;
		}
	}

	public int FailureCount
	{
		get
		{
			return _FailureCount;
		}
		set
		{
			_FailureCount = value;
		}
	}

	public int? ScriptErrorID
	{
		get
		{
			return _ScriptErrorID;
		}
		set
		{
			_ScriptErrorID = value;
		}
	}

	public int? LineNumber
	{
		get
		{
			return _LineNumber;
		}
		set
		{
			_LineNumber = value;
		}
	}

	public string CallStackHash
	{
		get
		{
			return _CallStackHash;
		}
		set
		{
			_CallStackHash = value;
		}
	}

	public bool IsTentativeAuthor
	{
		get
		{
			return _IsTentativeAuthor;
		}
		set
		{
			_IsTentativeAuthor = value;
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
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[RobloxScripts_DeleteScriptByID]", queryParameters));
	}

	public void Insert()
	{
		if (_AuthorAgentID == 0L)
		{
			throw new ApplicationException("Invalid AuthorAgentID");
		}
		if (_Hash == null)
		{
			throw new ApplicationException("Invalid Hash!");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Hash", _Hash));
		queryParameters.Add(new SqlParameter("@AuthorAgentID", _AuthorAgentID));
		queryParameters.Add(new SqlParameter("@Safety", _Safety));
		queryParameters.Add(new SqlParameter("@SuccessCount", _SuccessCount));
		queryParameters.Add(new SqlParameter("@FailureCount", _FailureCount));
		int? lineNumber = _LineNumber;
		queryParameters.Add(new SqlParameter("@LineNumber", lineNumber.HasValue ? ((object)lineNumber.GetValueOrDefault()) : DBNull.Value));
		lineNumber = _ScriptErrorID;
		queryParameters.Add(new SqlParameter("@ScriptErrorID", lineNumber.HasValue ? ((object)lineNumber.GetValueOrDefault()) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CallStackHash", (!string.IsNullOrEmpty(_CallStackHash)) ? ((IConvertible)_CallStackHash) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@IsTentativeAuthor", _IsTentativeAuthor));
		queryParameters.Add(new SqlParameter("@Created", _Created.ToLocalTime()));
		queryParameters.Add(new SqlParameter("@Updated", _Updated.ToLocalTime()));
		_ID = (int)EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[RobloxScripts_InsertScript]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (_AuthorAgentID == 0L)
		{
			throw new ApplicationException("Invalid AuthorAgentID");
		}
		if (_Hash == null)
		{
			throw new ApplicationException("Invalid Hash!");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Hash", _Hash));
		queryParameters.Add(new SqlParameter("@AuthorAgentID", _AuthorAgentID));
		queryParameters.Add(new SqlParameter("@Safety", _Safety));
		queryParameters.Add(new SqlParameter("@FailureCount", _FailureCount));
		queryParameters.Add(new SqlParameter("@SuccessCount", _SuccessCount));
		int? lineNumber = _LineNumber;
		queryParameters.Add(new SqlParameter("@LineNumber", lineNumber.HasValue ? ((object)lineNumber.GetValueOrDefault()) : DBNull.Value));
		lineNumber = _ScriptErrorID;
		queryParameters.Add(new SqlParameter("@ScriptErrorID", lineNumber.HasValue ? ((object)lineNumber.GetValueOrDefault()) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CallStackHash", (!string.IsNullOrEmpty(_CallStackHash)) ? ((IConvertible)_CallStackHash) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@IsTentativeAuthor", _IsTentativeAuthor));
		queryParameters.Add(new SqlParameter("@Created", _Created.ToLocalTime()));
		queryParameters.Add(new SqlParameter("@Updated", _Updated.ToLocalTime()));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[RobloxScripts_UpdateScriptByID]", queryParameters));
	}

	private static ScriptDAL BuildDAL(SqlDataReader reader)
	{
		ScriptDAL dal = new ScriptDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt32(reader["ID"]);
			dal.Hash = (string)reader["Hash"];
			dal.AuthorAgentID = Convert.ToInt64(reader["AuthorAgentID"]);
			dal.Safety = float.Parse(reader["Safety"].ToString());
			dal.SuccessCount = (int)reader["SuccessCount"];
			dal.FailureCount = (int)reader["FailureCount"];
			dal.LineNumber = (reader["LineNumber"].Equals(DBNull.Value) ? null : ((int?)reader["LineNumber"]));
			dal.ScriptErrorID = (reader["ScriptErrorID"].Equals(DBNull.Value) ? null : ((int?)reader["ScriptErrorID"]));
			dal.CallStackHash = (reader["CallStackHash"].Equals(DBNull.Value) ? string.Empty : ((string)reader["CallStackHash"]));
			dal.IsTentativeAuthor = (bool)reader["IsTentativeAuthor"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static ScriptDAL Get(int id)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobloxScripts_GetScriptByID]", queryParameters), BuildDAL);
	}

	public static ScriptDAL Get(string hash)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Hash", hash));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobloxScripts_GetScriptByHash]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<ScriptDAL> GetOrCreate(string hash, long authorAgentId, float safety, int failureCount, int successCount, int? lineNumber, int? scriptErrorId, string callStackHash, bool isTentativeAuthor)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Hash", hash));
		queryParameters.Add(new SqlParameter("@AuthorAgentID", authorAgentId));
		queryParameters.Add(new SqlParameter("@Safety", safety));
		queryParameters.Add(new SqlParameter("@SuccessCount", successCount));
		queryParameters.Add(new SqlParameter("@FailureCount", failureCount));
		int? num = lineNumber;
		queryParameters.Add(new SqlParameter("@LineNumber", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value));
		num = scriptErrorId;
		queryParameters.Add(new SqlParameter("@ScriptErrorID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CallStackHash", (!string.IsNullOrEmpty(callStackHash)) ? ((IConvertible)callStackHash) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@IsTentativeAuthor", isTentativeAuthor));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobloxScripts_GetOrCreateScriptByHash]", queryParameters), BuildDAL);
	}

	public static IEnumerable<string> GetInterestingScriptHashes()
	{
		string storedproc = "[dbo].[RobloxScripts_GetInterestingScriptHashes]";
		using SqlConnection connection = new SqlConnection(ConnectionString);
		connection.Open();
		using SqlCommand command = new SqlCommand(storedproc, connection);
		command.CommandType = CommandType.StoredProcedure;
		command.Parameters.Add(new SqlParameter("@MaximumRows", 100000));
		using SqlDataReader reader = command.ExecuteReader();
		while (reader.Read())
		{
			yield return reader.GetString(0);
		}
	}

	public static ICollection<int> GetScriptIDsByAuthorAgentID(long authorAgentId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AuthorAgentID", authorAgentId));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[RobloxScripts_GetScriptIDsByAuthorAgentID]", queryParameters));
	}

	public static ICollection<int> GetTopReportedScriptIDs(int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[ReportedScripts_GetTopReportedScriptIDs]", queryParameters));
	}

	public static ICollection<int> GetTopInstancesReportedScriptIDs(int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[ReportedScripts_GetTopInstancesReportedScriptIDs]", queryParameters));
	}
}
