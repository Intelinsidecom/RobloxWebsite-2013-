using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class ThumbnailFormatDAL
{
	private int _ID;

	private string _Format = string.Empty;

	private int _Width;

	private int _Height;

	private const int maxFormatLength = 50;

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

	public string Format
	{
		get
		{
			return _Format;
		}
		set
		{
			_Format = value.Substring(0, (value.Length < 50) ? value.Length : 50);
		}
	}

	public int Width
	{
		get
		{
			return _Width;
		}
		set
		{
			_Width = value;
		}
	}

	public int Height
	{
		get
		{
			return _Height;
		}
		set
		{
			_Height = value;
		}
	}

	private static string ConnectionString => RobloxDatabase.RobloxThumbnails.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.ExecuteSQLScalar("[dbo].[ThumbnailFormats_DeleteThumbnailFormatByID]", CommandType.StoredProcedure);
	}

	public void Insert()
	{
		if (_Format.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Format.");
		}
		if (_Width == 0)
		{
			throw new ApplicationException("Required value not specified: Width.");
		}
		if (_Height == 0)
		{
			throw new ApplicationException("Required value not specified: Height.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Format", _Format);
		dbHelper.SQLParameters.AddWithValue("@Width", _Width);
		dbHelper.SQLParameters.AddWithValue("@Height", _Height);
		SqlParameter id = dbHelper.SQLParameters.Add("@ID", SqlDbType.Int);
		id.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[ThumbnailFormats_InsertThumbnailFormat]", CommandType.StoredProcedure);
		_ID = Convert.ToInt32(id.Value);
	}

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (_Format.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Format.");
		}
		if (_Width == 0)
		{
			throw new ApplicationException("Required value not specified: Width.");
		}
		if (_Height == 0)
		{
			throw new ApplicationException("Required value not specified: Height.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.SQLParameters.AddWithValue("@Format", _Format);
		dbHelper.SQLParameters.AddWithValue("@Width", _Width);
		dbHelper.SQLParameters.AddWithValue("@Height", _Height);
		dbHelper.ExecuteSQLScalar("[dbo].[ThumbnailFormats_UpdateThumbnailFormatByID]", CommandType.StoredProcedure);
	}

	private static ThumbnailFormatDAL BuildDAL(SqlDataReader reader)
	{
		ThumbnailFormatDAL dal = new ThumbnailFormatDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Width = (int)reader["Width"];
			dal.Height = (int)reader["Height"];
			dal.Format = (string)reader["Format"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static ThumbnailFormatDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[ThumbnailFormats_GetThumbnailFormatByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ThumbnailFormatDAL Get(string format, int width, int height)
	{
		if (string.IsNullOrEmpty(format))
		{
			return null;
		}
		if (width == 0 || height == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@Format", format);
		dbHelper.SQLParameters.AddWithValue("@Width", width);
		dbHelper.SQLParameters.AddWithValue("@Height", height);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[ThumbnailFormats_GetThumbnailFormatByFormatAndWidthAndHeight]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static EntityHelper.GetOrCreateDALWrapper<ThumbnailFormatDAL> GetOrCreate(string format, int width, int height)
	{
		if (string.IsNullOrEmpty(format))
		{
			return null;
		}
		if (width == 0 || height == 0)
		{
			return null;
		}
		ThumbnailFormatDAL dal;
		using (DbHelper dbHelper = new DbHelper(ConnectionString))
		{
			dbHelper.SQLParameters.AddWithValue("@Format", format);
			dbHelper.SQLParameters.AddWithValue("@Width", width);
			dbHelper.SQLParameters.AddWithValue("@Height", height);
			using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[ThumbnailFormats_GetOrCreateThumbnailFormatByFormatAndWidthAndHeight]", CommandType.StoredProcedure);
			dal = BuildDAL(reader);
		}
		return new EntityHelper.GetOrCreateDALWrapper<ThumbnailFormatDAL>(createdNewEntity: false, dal);
	}
}
