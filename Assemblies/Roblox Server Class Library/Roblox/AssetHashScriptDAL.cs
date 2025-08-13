using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class AssetHashScriptDAL
{
	private long _ID;

	private int _ScriptID;

	private long _AssetHashID;

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

	public long AssetHashID
	{
		get
		{
			return _AssetHashID;
		}
		set
		{
			_AssetHashID = value;
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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[AssetHashScripts_DeleteAssetHashScriptByID]", queryParameters));
	}

	public void Insert()
	{
		if (_ScriptID == 0)
		{
			throw new ApplicationException("Required value not specified: ScriptID");
		}
		if (_AssetHashID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetHashID");
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
		queryParameters.Add(new SqlParameter("@ScriptID", _ScriptID));
		queryParameters.Add(new SqlParameter("@AssetHashID", _AssetHashID));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[AssetHashScripts_InsertAssetHashScript]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (_ScriptID == 0)
		{
			throw new ApplicationException("Required value not specified: ScriptID");
		}
		if (_AssetHashID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetHashID");
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
		queryParameters.Add(new SqlParameter("@ScriptID", _ScriptID));
		queryParameters.Add(new SqlParameter("@AssetHashID", _AssetHashID));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[AssetHashScripts_UpdateAssetHashScriptByID]", queryParameters));
	}

	private static AssetHashScriptDAL BuildDAL(SqlDataReader reader)
	{
		AssetHashScriptDAL dal = new AssetHashScriptDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ScriptID = (int)reader["ScriptID"];
			dal.AssetHashID = (long)reader["AssetHashID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static AssetHashScriptDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetHashScripts_GetAssetHashScriptByID]", queryParameters), BuildDAL);
	}

	public static AssetHashScriptDAL Get(int scriptId, long assetHashId)
	{
		if (scriptId == 0)
		{
			throw new ApplicationException("Required value not specified: ScriptID.");
		}
		if (assetHashId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetHashID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ScriptID", scriptId));
		queryParameters.Add(new SqlParameter("@AssetHashID", assetHashId));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetHashScripts_GetAssetHashScriptByScriptIDAndAssetHashID]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<AssetHashScriptDAL> GetOrCreate(int scriptId, long assetHashId)
	{
		if (scriptId == 0)
		{
			throw new ApplicationException("Required value not specified: ScriptID.");
		}
		if (assetHashId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetHashID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ScriptID", scriptId));
		queryParameters.Add(new SqlParameter("@AssetHashID", assetHashId));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetHashScripts_GetOrCreateAssetHashScriptByScriptIDAndAssetHashID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetAssetHashScriptIDsByAssetHashIDPaged(long assetHashId, int startRowIndex, int maximumRows)
	{
		if (assetHashId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetHashID.");
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
		queryParameters.Add(new SqlParameter("@AssetHashID", assetHashId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[AssetHashScripts_GetAssetHashScriptIDsByAssetHashID_Paged]", queryParameters));
	}

	public static ICollection<long> GetAssetHashScriptIDsByScriptIDPaged(int scriptId, int startRowIndex, int maximumRows)
	{
		if (scriptId == 0)
		{
			throw new ApplicationException("Required value not specified: ScriptID.");
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
		queryParameters.Add(new SqlParameter("@ScriptID", scriptId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[AssetHashScripts_GetAssetHashScriptIDsByScriptID_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfAssetHashScriptsByAssetHashID(long assetHashId)
	{
		if (assetHashId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetHashID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetHashID", assetHashId));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "[dbo].[AssetHashScripts_GetTotalNumberOfAssetHashScriptsByAssetHashID]", queryParameters));
	}

	public static int GetTotalNumberOfAssetHashScriptsByScriptID(int scriptId)
	{
		if (scriptId == 0)
		{
			throw new ApplicationException("Required value not specified: ScriptID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ScriptID", scriptId));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "[dbo].[AssetHashScripts_GetTotalNumberOfAssetHashScriptsByScriptID]", queryParameters));
	}
}
