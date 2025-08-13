using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class AssetTypeDAL
{
	private int _ID;

	private string _Value = string.Empty;

	private string _Description = string.Empty;

	private string _Abbreviation = string.Empty;

	private bool _RequiresReview;

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

	public bool RequiresReview
	{
		get
		{
			return _RequiresReview;
		}
		set
		{
			_RequiresReview = value;
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

	private static string ConnectionString => RobloxDatabase.RobloxAssets.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.ExecuteSQLScalar("[dbo].[AssetTypes_DeleteAssetTypeByID]", CommandType.StoredProcedure);
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
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Value", _Value);
		dbHelper.SQLParameters.AddWithValue("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@RequiresReview", _RequiresReview);
		dbHelper.SQLParameters.AddWithValue("@Created", _Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", _Updated);
		SqlParameter ID = dbHelper.SQLParameters.Add("@ID", SqlDbType.Int);
		ID.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[AssetTypes_InsertAssetType]", CommandType.StoredProcedure);
		_ID = Convert.ToInt32(ID.Value);
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
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.SQLParameters.AddWithValue("@Value", _Value);
		dbHelper.SQLParameters.AddWithValue("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@RequiresReview", _RequiresReview);
		dbHelper.SQLParameters.AddWithValue("@Created", _Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", _Updated);
		dbHelper.ExecuteSQLScalar("[dbo].[AssetTypes_UpdateAssetTypeByID]", CommandType.StoredProcedure);
	}

	private static AssetTypeDAL BuildDAL(SqlDataReader reader)
	{
		AssetTypeDAL dal = new AssetTypeDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Description = (reader["Description"].Equals(DBNull.Value) ? string.Empty : ((string)reader["Description"]));
			dal.Abbreviation = (reader["Abbreviation"].Equals(DBNull.Value) ? string.Empty : ((string)reader["Abbreviation"]));
			dal.RequiresReview = (bool)reader["RequiresReview"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.Created == DateTime.MinValue)
		{
			return null;
		}
		return dal;
	}

	public static AssetTypeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetTypes_GetAssetTypeByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static AssetTypeDAL Get(string value)
	{
		if (value.Trim().Length == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Value", value);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetTypes_GetAssetTypeByValue]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ICollection<int> GetAssetTypeIDs()
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AssetTypes_GetAllAssetTypeIDs]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<int>(reader);
	}
}
