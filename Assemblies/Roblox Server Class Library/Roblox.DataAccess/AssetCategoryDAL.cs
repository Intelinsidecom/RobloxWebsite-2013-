using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

public class AssetCategoryDAL
{
	private byte _ID;

	private int _AssetTypeID;

	private byte _BitOrdinal;

	private long _BitMask;

	private string _Name = string.Empty;

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

	public int AssetTypeID
	{
		get
		{
			return _AssetTypeID;
		}
		set
		{
			_AssetTypeID = value;
		}
	}

	public byte BitOrdinal
	{
		get
		{
			return _BitOrdinal;
		}
		set
		{
			_BitOrdinal = value;
		}
	}

	public long BitMask
	{
		get
		{
			return _BitMask;
		}
		set
		{
			_BitMask = value;
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

	private static string ConnectionString => RobloxDatabase.RobloxAssets.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[AssetCategories_DeleteAssetCategoryByID]", queryParameters));
	}

	public void Insert()
	{
		if (_AssetTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
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
		queryParameters.Add(new SqlParameter("@AssetTypeID", _AssetTypeID));
		queryParameters.Add(new SqlParameter("@BitOrdinal", _BitOrdinal));
		queryParameters.Add(new SqlParameter("@Name", _Name));
		queryParameters.Add(new SqlParameter("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(ConnectionString, "[dbo].[AssetCategories_InsertAssetCategory]", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_AssetTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
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
		queryParameters.Add(new SqlParameter("@AssetTypeID", _AssetTypeID));
		queryParameters.Add(new SqlParameter("@BitOrdinal", _BitOrdinal));
		queryParameters.Add(new SqlParameter("@Name", _Name));
		queryParameters.Add(new SqlParameter("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[AssetCategories_UpdateAssetCategoryByID]", queryParameters));
	}

	private static AssetCategoryDAL BuildDAL(SqlDataReader reader)
	{
		AssetCategoryDAL dal = new AssetCategoryDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.AssetTypeID = (int)reader["AssetTypeID"];
			dal.BitOrdinal = (byte)reader["BitOrdinal"];
			dal.BitMask = (long)reader["BitMask"];
			dal.Name = (string)reader["Name"];
			dal.Abbreviation = (string)reader["Abbreviation"];
			dal.Description = (string)reader["Description"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static AssetCategoryDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetCategories_GetAssetCategoryByID]", queryParameters), BuildDAL);
	}

	public static AssetCategoryDAL Get(int assetTypeId, byte bitOrdinal)
	{
		if (assetTypeId == 0)
		{
			return null;
		}
		if (bitOrdinal == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeId));
		queryParameters.Add(new SqlParameter("@BitOrdinal", bitOrdinal));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetCategories_GetAssetCategoryByAssetTypeAndBitOrdinal]", queryParameters), BuildDAL);
	}

	public static AssetCategoryDAL Get(int assetTypeId, string name)
	{
		if (assetTypeId == 0)
		{
			return null;
		}
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeId));
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetCategories_GetAssetCategoryByAssetTypeAndName]", queryParameters), BuildDAL);
	}

	public static ICollection<byte> GetAssetCategoryIDsPaged(int startRowIndex, int maximumRows)
	{
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<byte>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(ConnectionString, "[dbo].[AssetCategories_GetAssetCategoryIDs_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfAssetCategories()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "[dbo].[AssetCategories_GetTotalNumberOfAssetCategories]", queryParameters));
	}
}
