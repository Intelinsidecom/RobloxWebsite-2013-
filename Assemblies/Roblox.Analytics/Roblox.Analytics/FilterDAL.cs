using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Analytics;

public class FilterDAL
{
	private int _ID;

	private string _Name = string.Empty;

	private string _Value = string.Empty;

	private DateTime _Created = DateTime.MinValue;

	internal int ID
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

	internal string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			_Name = value.Substring(0, (value.Length < 50) ? value.Length : 50);
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
			_Value = value.Substring(0, (value.Length < 50) ? value.Length : 50);
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

	internal FilterDAL()
	{
	}

	internal void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[Filters_DeleteFilterByID]", queryParameters));
	}

	internal void Insert()
	{
		if (_Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
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
		queryParameters.Add(new SqlParameter("@Name", _Name));
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		_ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[Filters_InsertFilter]", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	internal void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
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
		queryParameters.Add(new SqlParameter("@Name", _Name));
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[Filters_UpdateFilterByID]", queryParameters));
	}

	private static FilterDAL BuildDAL(SqlDataReader reader)
	{
		FilterDAL dal = new FilterDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Name = (string)reader["Name"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static FilterDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Filters_GetFilterByID]", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<FilterDAL> GetOrCreate(string name, string value)
	{
		if (name == null)
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		if (value == null)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Filters_GetOrCreateFilter]", queryParameters), BuildDAL);
	}
}
