using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

public class ContextUrlDAL
{
	private long _ID;

	private string _Value = string.Empty;

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

	public string Value
	{
		get
		{
			return _Value;
		}
		set
		{
			_Value = value.Substring(0, (value.Length < 100) ? value.Length : 100);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[ContextUrls_DeleteContextUrlByID]", queryParameters));
	}

	public void Insert()
	{
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
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
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[ContextUrls_InsertContextUrl]", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
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
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[ContextUrls_UpdateContextUrlByID]", queryParameters));
	}

	private static ContextUrlDAL BuildDAL(SqlDataReader reader)
	{
		ContextUrlDAL dal = new ContextUrlDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static ContextUrlDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[ContextUrls_GetContextUrlByID]", queryParameters), BuildDAL);
	}

	public static ContextUrlDAL Get(string value)
	{
		if (value.Trim().Length == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[ContextUrls_GetContextUrlByValue]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<ContextUrlDAL> GetOrCreate(string value)
	{
		if (value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[ContextUrls_GetOrCreateContextUrlByValue]", queryParameters), BuildDAL);
	}
}
