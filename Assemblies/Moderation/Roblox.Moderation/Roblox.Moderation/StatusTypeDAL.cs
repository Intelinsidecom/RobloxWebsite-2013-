using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class StatusTypeDAL
{
	private byte _ID;

	private string _Value;

	private byte _Rank;

	private DateTime _Created;

	private DateTime _Updated;

	internal byte ID
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

	internal byte Rank
	{
		get
		{
			return _Rank;
		}
		set
		{
			_Rank = value;
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

	internal StatusTypeDAL()
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "StatusTypes_DeleteStatusTypeByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Rank", Rank),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "StatusTypes_InsertStatusType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Rank", Rank),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "StatusTypes_UpdateStatusTypeByID", queryParameters));
	}

	private static StatusTypeDAL BuildDAL(SqlDataReader reader)
	{
		StatusTypeDAL dal = new StatusTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Rank = (byte)reader["Rank"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static StatusTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "StatusTypes_GetStatusTypeByID", queryParameters), BuildDAL);
	}

	internal static StatusTypeDAL Get(string value)
	{
		if (value == null)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "StatusTypes_GetStatusTypeByValue", queryParameters), BuildDAL);
	}
}
