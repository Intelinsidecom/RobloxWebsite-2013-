using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

public class ExpressionDAL
{
	private long _ID;

	private string _Hash = string.Empty;

	private string _HashUnicode = string.Empty;

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

	public string Hash
	{
		get
		{
			return _Hash;
		}
		set
		{
			_Hash = value?.Substring(0, (value.Length < 32) ? value.Length : 32);
		}
	}

	public string HashUnicode
	{
		get
		{
			return _HashUnicode;
		}
		set
		{
			_HashUnicode = value?.Substring(0, (value.Length < 32) ? value.Length : 32);
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
			_Value = value;
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
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_DeleteExpressionByID]", queryParameters));
	}

	public void Insert()
	{
		if (_Hash.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Hash.");
		}
		string hashUnicode = _HashUnicode;
		if (hashUnicode != null && hashUnicode.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: HashUnicode.");
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
		queryParameters.Add(new SqlParameter("@Hash", _Hash));
		queryParameters.Add(new SqlParameter("@HashUnicode", _HashUnicode));
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_InsertExpression]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_Hash.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Hash.");
		}
		string hashUnicode = _HashUnicode;
		if (hashUnicode != null && hashUnicode.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: HashUnicode.");
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
		queryParameters.Add(new SqlParameter("@Hash", _Hash));
		queryParameters.Add(new SqlParameter("@HashUnicode", _HashUnicode));
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_UpdateExpressionByID]", queryParameters));
	}

	private static ExpressionDAL BuildDAL(SqlDataReader reader)
	{
		ExpressionDAL dal = new ExpressionDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.Hash = (reader["Hash"].Equals(DBNull.Value) ? null : ((string)reader["Hash"]));
			dal.HashUnicode = (reader["HashUnicode"].Equals(DBNull.Value) ? null : ((string)reader["HashUnicode"]));
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

	public static ExpressionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_GetExpressionByID]", queryParameters), BuildDAL);
	}

	public static ExpressionDAL Get(string hash)
	{
		if (string.IsNullOrEmpty(hash))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Hash", hash));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_GetExpressionByHash]", queryParameters), BuildDAL);
	}

	public static ExpressionDAL GetByHashUnicode(string hashUnicode)
	{
		if (string.IsNullOrEmpty(hashUnicode))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@HashUnicode", hashUnicode));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_GetExpressionByHashUnicode]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<ExpressionDAL> GetOrCreate(string hash, string hashUnicode, string value)
	{
		if (string.IsNullOrEmpty(hash))
		{
			throw new ApplicationException("Required value not specified: Hash.");
		}
		if (string.IsNullOrEmpty(hashUnicode))
		{
			throw new ApplicationException("Required value not specified: HashUnicode.");
		}
		if (value == null)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Hash", hash));
		queryParameters.Add(new SqlParameter("@HashUnicode", hashUnicode));
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_GetOrCreateExpressionByHashAndValue]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<ExpressionDAL> GetOrCreateByHashUnicode(string hashUnicode, string value)
	{
		if (string.IsNullOrEmpty(hashUnicode))
		{
			throw new ApplicationException("Required value not specified: HashUnicode.");
		}
		if (value == null)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@HashUnicode", hashUnicode));
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_GetOrCreateExpressionByHashUnicodeAndValue]", queryParameters), BuildDAL);
	}
}
