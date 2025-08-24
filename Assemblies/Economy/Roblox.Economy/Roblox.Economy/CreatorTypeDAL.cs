using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class CreatorTypeDAL
{
	private int _ID;

	private string _Value;

	private DateTime _Created;

	private DateTime _Updated;

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

	private static string _DbConnectionString => Helper.DBConnectionString_Shops;

	internal CreatorTypeDAL()
	{
	}

	internal void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "CreatorTypes_DeleteCreatorTypeByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "CreatorTypes_InsertCreatorType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "CreatorTypes_UpdateCreatorTypeByID", queryParameters));
	}

	private static CreatorTypeDAL BuildDAL(SqlDataReader reader)
	{
		CreatorTypeDAL dal = new CreatorTypeDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static CreatorTypeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "CreatorTypes_GetCreatorTypeByID", queryParameters), BuildDAL);
	}

	internal static CreatorTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "CreatorTypes_GetCreatorTypeByValue", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<CreatorTypeDAL> GetOrCreate(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			throw new ApplicationException("Required value not specified: value.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "CreatorTypes_GetOrCreateCreatorTypeByValue", queryParameters), BuildDAL);
	}
}
