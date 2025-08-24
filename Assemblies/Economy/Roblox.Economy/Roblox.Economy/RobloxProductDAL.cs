using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class RobloxProductDAL
{
	private int _ID;

	private string _Name = string.Empty;

	private string _Description = string.Empty;

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

	public string Name
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

	public string Description
	{
		get
		{
			return _Description;
		}
		set
		{
			_Description = value.Substring(0, (value.Length < 1000) ? value.Length : 1000);
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
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[RobloxProducts_DeleteRobloxProductByID]", queryParameters));
	}

	public void Insert()
	{
		if (_Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
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
		queryParameters.Add(new SqlParameter("@Name", _Name));
		queryParameters.Add(new SqlParameter("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[RobloxProducts_InsertRobloxProduct]", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (_Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
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
		queryParameters.Add(new SqlParameter("@Name", _Name));
		queryParameters.Add(new SqlParameter("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[RobloxProducts_UpdateRobloxProductByID]", queryParameters));
	}

	private static RobloxProductDAL BuildDAL(SqlDataReader reader)
	{
		RobloxProductDAL dal = new RobloxProductDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Name = (string)reader["Name"];
			dal.Description = (reader["Description"].Equals(DBNull.Value) ? string.Empty : ((string)reader["Description"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static RobloxProductDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[RobloxProducts_GetRobloxProductByID]", queryParameters), BuildDAL);
	}

	public static RobloxProductDAL Get(string name)
	{
		if (name.Trim().Length == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[RobloxProducts_GetRobloxProductByName]", queryParameters), BuildDAL);
	}
}
