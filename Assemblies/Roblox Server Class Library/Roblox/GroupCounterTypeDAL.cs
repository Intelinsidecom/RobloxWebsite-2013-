using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class GroupCounterTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroupCounters;

	private string _Value = string.Empty;

	public byte ID { get; set; }

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

	public DateTime Created { get; set; } = DateTime.MinValue;


	public DateTime Updated { get; set; } = DateTime.MinValue;


	public void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		new List<SqlParameter>().Add(new SqlParameter("@ID", ID));
		RobloxDatabase.RobloxGroupCounters.Delete("GroupCounterTypes_DeleteGroupCounterTypeByID", ID);
	}

	public void Insert()
	{
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", _Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroupCounters.Insert<byte>("GroupCounterTypes_InsertGroupCounterType", queryParameters);
	}

	public void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", _Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroupCounters.Update("GroupCounterTypes_UpdateGroupCounterTypeByID", queryParameters);
	}

	private static GroupCounterTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GroupCounterTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	public static GroupCounterTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		new List<SqlParameter>().Add(new SqlParameter("@ID", id));
		return RobloxDatabase.RobloxGroupCounters.Get("GroupCounterTypes_GetGroupCounterTypeByID", id, BuildDAL);
	}

	public static GroupCounterTypeDAL Get(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxGroupCounters.Lookup("GroupCounterTypes_GetGroupCounterTypeByValue", BuildDAL, queryParameters);
	}
}
