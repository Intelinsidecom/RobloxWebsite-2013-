using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.Properties;

namespace Roblox.DataAccess;

[Serializable]
public class BadgeTypeDAL
{
	private int _ID;

	private string _Value = string.Empty;

	private string _Description = string.Empty;

	private string _Abbreviation = string.Empty;

	private string _ImageName = string.Empty;

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

	public string ImageName
	{
		get
		{
			return _ImageName;
		}
		set
		{
			_ImageName = value.Substring(0, (value.Length < 100) ? value.Length : 100);
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

	private static string _DbConnectionString => Settings.Default.RobloxBadges;

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.ExecuteSQLScalar("[dbo].[BadgeTypes_DeleteBadgeTypeByID]", CommandType.StoredProcedure);
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
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Value", _Value);
		dbHelper.SQLParameters.AddWithValue("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@ImageName", (_ImageName.Trim().Length > 0) ? ((IConvertible)_ImageName) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Created", _Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", _Updated);
		SqlParameter id = dbHelper.SQLParameters.Add("@ID", SqlDbType.Int);
		id.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[BadgeTypes_InsertBadgeType]", CommandType.StoredProcedure);
		_ID = Convert.ToInt32(id.Value);
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
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.SQLParameters.AddWithValue("@Value", _Value);
		dbHelper.SQLParameters.AddWithValue("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@ImageName", (_ImageName.Trim().Length > 0) ? ((IConvertible)_ImageName) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Created", _Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", _Updated);
		dbHelper.ExecuteSQLScalar("[dbo].[BadgeTypes_UpdateBadgeTypeByID]", CommandType.StoredProcedure);
	}

	private static BadgeTypeDAL BuildDAL(SqlDataReader reader)
	{
		BadgeTypeDAL dal = new BadgeTypeDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Description = (reader["Description"].Equals(DBNull.Value) ? string.Empty : ((string)reader["Description"]));
			dal.Abbreviation = (reader["Abbreviation"].Equals(DBNull.Value) ? string.Empty : ((string)reader["Abbreviation"]));
			dal.ImageName = (reader["ImageName"].Equals(DBNull.Value) ? string.Empty : ((string)reader["ImageName"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.Created == DateTime.MinValue)
		{
			return null;
		}
		return dal;
	}

	public static BadgeTypeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[BadgeTypes_GetBadgeTypeByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static BadgeTypeDAL Get(string value)
	{
		if (value.Trim().Length == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Value", value);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[BadgeTypes_GetBadgeTypeByValue]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ICollection<int> GetBadgeTypeIDs()
	{
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[BadgeTypes_GetAllBadgeTypeIDs]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<int>(reader);
	}
}
