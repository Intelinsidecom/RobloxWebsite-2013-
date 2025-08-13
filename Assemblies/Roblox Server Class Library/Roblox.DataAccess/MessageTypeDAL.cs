using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class MessageTypeDAL
{
	private string _Value = string.Empty;

	private string _Description = string.Empty;

	private string _Abbreviation = string.Empty;

	private static string ConnectionString => RobloxDatabase.RobloxMessages.GetConnectionString();

	public int ID { get; set; }

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

	public DateTime Created { get; set; } = DateTime.MinValue;


	public DateTime Updated { get; set; } = DateTime.MinValue;


	public void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.ExecuteSQLScalar("[dbo].[MessageTypes_DeleteMessageTypeByID]", CommandType.StoredProcedure);
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
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Value", _Value);
		dbHelper.SQLParameters.AddWithValue("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Created", Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", Updated);
		SqlParameter id = dbHelper.SQLParameters.Add("@ID", SqlDbType.Int);
		id.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[MessageTypes_InsertMessageType]", CommandType.StoredProcedure);
		ID = Convert.ToInt32(id.Value);
	}

	public void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
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
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.SQLParameters.AddWithValue("@Value", _Value);
		dbHelper.SQLParameters.AddWithValue("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Created", Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", Updated);
		dbHelper.ExecuteSQLScalar("[dbo].[MessageTypes_UpdateMessageTypeByID]", CommandType.StoredProcedure);
	}

	private static MessageTypeDAL BuildDAL(SqlDataReader reader)
	{
		MessageTypeDAL dal = new MessageTypeDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Description = (reader["Description"].Equals(DBNull.Value) ? string.Empty : ((string)reader["Description"]));
			dal.Abbreviation = (reader["Abbreviation"].Equals(DBNull.Value) ? string.Empty : ((string)reader["Abbreviation"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.Created == DateTime.MinValue)
		{
			return null;
		}
		return dal;
	}

	public static MessageTypeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[MessageTypes_GetMessageTypeByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static MessageTypeDAL Get(string value)
	{
		if (value.Trim().Length == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Value", value);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[MessageTypes_GetMessageTypeByValue]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ICollection<int> GetMessageTypeIDs()
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[MessageTypes_GetAllMessageTypeIDs]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<int>(reader);
	}
}
