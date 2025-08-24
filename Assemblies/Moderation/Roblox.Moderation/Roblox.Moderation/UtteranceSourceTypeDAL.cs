using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

public class UtteranceSourceTypeDAL
{
	private byte _ID;

	private string _Value = string.Empty;

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

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[UtteranceSourceTypes_DeleteUtteranceSourceTypeByID]", queryParameters));
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
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(Helper.DBConnectionString, "[dbo].[UtteranceSourceTypes_InsertUtteranceSourceType]", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
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
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@Value", _Value),
			new SqlParameter("@Created", _Created),
			new SqlParameter("@Updated", _Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[UtteranceSourceTypes_UpdateUtteranceSourceTypeByID]", queryParameters));
	}

	private static UtteranceSourceTypeDAL BuildDAL(SqlDataReader reader)
	{
		UtteranceSourceTypeDAL dal = new UtteranceSourceTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static UtteranceSourceTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[UtteranceSourceTypes_GetUtteranceSourceTypeByID]", queryParameters), BuildDAL);
	}

	public static UtteranceSourceTypeDAL Get(string value)
	{
		if (value.Trim().Length == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[UtteranceSourceTypes_GetUtteranceSourceTypeByValue]", queryParameters), BuildDAL);
	}

	public static ICollection<byte> GetUtteranceSourceTypeIDsPaged(int startRowIndex, int maximumRows)
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
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(Helper.DBConnectionString, "[dbo].[UtteranceSourceTypes_GetUtteranceSourceTypeIDs_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfUtteranceSourceTypes()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[UtteranceSourceTypes_GetTotalNumberOfUtteranceSourceTypes]", queryParameters));
	}
}
