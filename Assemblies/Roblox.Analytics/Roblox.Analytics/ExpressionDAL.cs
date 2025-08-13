using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Analytics;

public class ExpressionDAL
{
	private long _ID;

	private string _Hash = string.Empty;

	private string _Value = string.Empty;

	private DateTime _Created = DateTime.MinValue;

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

	internal string Hash
	{
		get
		{
			return _Hash;
		}
		set
		{
			_Hash = value.Substring(0, (value.Length < 32) ? value.Length : 32);
		}
	}

	internal string Value
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

	internal ExpressionDAL()
	{
	}

	internal void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_DeleteExpressionByID]", queryParameters));
	}

	internal void Insert()
	{
		if (_Hash.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Hash.");
		}
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Hash", _Hash));
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_InsertExpression]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	internal void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_Hash.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Hash.");
		}
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Hash", _Hash));
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_UpdateExpressionByID]", queryParameters));
	}

	private static ExpressionDAL BuildDAL(SqlDataReader reader)
	{
		ExpressionDAL dal = new ExpressionDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.Hash = (string)reader["Hash"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static ExpressionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_GetExpressionByID]", queryParameters), BuildDAL);
	}

	internal static ExpressionDAL Get(string hash)
	{
		if (string.IsNullOrEmpty(hash))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Hash", hash));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_GetExpressionByHash]", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<ExpressionDAL> GetOrCreate(string hash, string value)
	{
		if (string.IsNullOrEmpty(hash))
		{
			throw new ApplicationException("Required value not specified: Hash.");
		}
		if (value == null)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Hash", hash));
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Expressions_GetOrCreateExpression]", queryParameters), BuildDAL);
	}
}
