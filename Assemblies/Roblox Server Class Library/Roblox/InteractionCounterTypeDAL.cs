using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class InteractionCounterTypeDAL
{
	private byte _ID;

	private string _Value = string.Empty;

	private byte _GroupID;

	private byte _GroupIndex;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	public byte ID
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
			_Value = value.Substring(0, (value.Length < 50) ? value.Length : 50);
		}
	}

	public byte GroupID
	{
		get
		{
			return _GroupID;
		}
		set
		{
			_GroupID = value;
		}
	}

	public byte GroupIndex
	{
		get
		{
			return _GroupIndex;
		}
		set
		{
			_GroupIndex = value;
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

	private static string ConnectionString => RobloxDatabase.RobloxInteractionCounters.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[InteractionCounterTypes_DeleteInteractionCounterTypeByID]", queryParameters));
	}

	public void Insert()
	{
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (_GroupID == 0)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (_GroupIndex == 0)
		{
			throw new ApplicationException("Required value not specified: GroupIndex.");
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
		queryParameters.Add(new SqlParameter("@GroupID", _GroupID));
		queryParameters.Add(new SqlParameter("@GroupIndex", _GroupIndex));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		DbInfo dbInfo = new DbInfo(ConnectionString, "[dbo].[InteractionCounterTypes_InsertInteractionCounterType]", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
	}

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (_GroupID == 0)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (_GroupIndex == 0)
		{
			throw new ApplicationException("Required value not specified: GroupIndex.");
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
		queryParameters.Add(new SqlParameter("@GroupID", _GroupID));
		queryParameters.Add(new SqlParameter("@GroupIndex", _GroupIndex));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[InteractionCounterTypes_UpdateInteractionCounterTypeByID]", queryParameters));
	}

	private static InteractionCounterTypeDAL BuildDAL(SqlDataReader reader)
	{
		InteractionCounterTypeDAL dal = new InteractionCounterTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.GroupID = (byte)reader["GroupID"];
			dal.GroupIndex = (byte)reader["GroupIndex"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static InteractionCounterTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[InteractionCounterTypes_GetInteractionCounterTypeByID]", queryParameters), BuildDAL);
	}

	public static InteractionCounterTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[InteractionCounterTypes_GetInteractionCounterTypeByValue]", queryParameters), BuildDAL);
	}
}
