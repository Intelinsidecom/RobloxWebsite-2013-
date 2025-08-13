using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

public class AssetGenreDAL
{
	private byte _ID;

	private byte _BitOrdinal;

	private long _BitMask;

	private string _Name = string.Empty;

	private string _DisplayName = string.Empty;

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

	public string DisplayName
	{
		get
		{
			return _DisplayName;
		}
		set
		{
			_DisplayName = value.Substring(0, (value.Length < 50) ? value.Length : 50);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[AssetGenres_DeleteAssetGenreByID]", queryParameters));
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
		queryParameters.Add(new SqlParameter("@BitOrdinal", _BitOrdinal));
		queryParameters.Add(new SqlParameter("@Name", _Name));
		queryParameters.Add(new SqlParameter("@DisplayName", _DisplayName));
		queryParameters.Add(new SqlParameter("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(ConnectionString, "[dbo].[AssetGenres_InsertAssetGenre]", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
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
		queryParameters.Add(new SqlParameter("@BitOrdinal", _BitOrdinal));
		queryParameters.Add(new SqlParameter("@Name", _Name));
		queryParameters.Add(new SqlParameter("@DisplayName", _DisplayName));
		queryParameters.Add(new SqlParameter("@Description", (_Description.Trim().Length > 0) ? ((IConvertible)_Description) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Abbreviation", (_Abbreviation.Trim().Length > 0) ? ((IConvertible)_Abbreviation) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[AssetGenres_UpdateAssetGenreByID]", queryParameters));
	}

	private static AssetGenreDAL BuildDAL(SqlDataReader reader)
	{
		AssetGenreDAL dal = new AssetGenreDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.BitOrdinal = (byte)reader["BitOrdinal"];
			dal.BitMask = (long)reader["BitMask"];
			dal.Name = (string)reader["Name"];
			dal.DisplayName = (string)reader["DisplayName"];
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

	public static AssetGenreDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetGenres_GetAssetGenreByID]", queryParameters), BuildDAL);
	}

	public static AssetGenreDAL GetByBitOrdinal(byte bitOrdinal)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@BitOrdinal", bitOrdinal));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetGenres_GetAssetGenreByBitOrdinal]", queryParameters), BuildDAL);
	}

	public static AssetGenreDAL GetByName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetGenres_GetAssetGenreByName]", queryParameters), BuildDAL);
	}

	public static ICollection<byte> GetAssetGenreIDsPaged(int startRowIndex, int maximumRows)
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
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(ConnectionString, "[dbo].[AssetGenres_GetAssetGenreIDs_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfAssetGenres()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "[dbo].[AssetGenres_GetTotalNumberOfAssetGenres]", queryParameters));
	}
}
