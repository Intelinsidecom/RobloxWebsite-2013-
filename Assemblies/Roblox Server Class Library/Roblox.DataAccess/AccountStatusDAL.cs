using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class AccountStatusDAL
{
	private byte _ID;

	private string _Value = string.Empty;

	private string _Description = string.Empty;

	private string _Abbreviation = string.Empty;

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

	public string Abbreviation
	{
		get
		{
			return _Abbreviation;
		}
		set
		{
			_Abbreviation = value.Substring(0, (value.Length < 10) ? value.Length : 10);
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

	private static string DbConnectionString => RobloxDatabase.RobloxAccounts.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.ExecuteSQLScalar("[dbo].[AccountStatuses_DeleteAccountStatusByID]", CommandType.StoredProcedure);
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
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Value", _Value);
		dbHelper.SQLParameters.AddWithValue("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Created", _Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", _Updated);
		SqlParameter ID = dbHelper.SQLParameters.Add("@ID", SqlDbType.TinyInt);
		ID.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[AccountStatuses_InsertAccountStatus]", CommandType.StoredProcedure);
		_ID = Convert.ToByte(ID.Value);
	}

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
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
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.SQLParameters.AddWithValue("@Value", _Value);
		dbHelper.SQLParameters.AddWithValue("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Created", _Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", _Updated);
		dbHelper.ExecuteSQLScalar("[dbo].[AccountStatuses_UpdateAccountStatusByID]", CommandType.StoredProcedure);
	}

	private static AccountStatusDAL BuildDAL(SqlDataReader reader)
	{
		AccountStatusDAL dal = new AccountStatusDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Description = (reader["Description"].Equals(DBNull.Value) ? string.Empty : ((string)reader["Description"]));
			dal.Abbreviation = (reader["Abbreviation"].Equals(DBNull.Value) ? string.Empty : ((string)reader["Abbreviation"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static AccountStatusDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AccountStatuses_GetAccountStatusByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static AccountStatusDAL Get(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Value", value);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AccountStatuses_GetAccountStatusByValue]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ICollection<byte> GetAccountStatusIDs()
	{
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AccountStatuses_GetAllAccountStatusIDs]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<byte>(reader);
	}
}
