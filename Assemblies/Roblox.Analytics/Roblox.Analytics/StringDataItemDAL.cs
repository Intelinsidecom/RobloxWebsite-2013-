using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Analytics;

public class StringDataItemDAL
{
	private long _ID;

	private long _MeasurementID;

	private long _KeyExpressionID;

	private long _ValueExpressionID;

	private DateTime _Created = DateTime.MinValue;

	internal long ID
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

	internal long MeasurementID
	{
		get
		{
			return _MeasurementID;
		}
		set
		{
			_MeasurementID = value;
		}
	}

	internal long KeyExpressionID
	{
		get
		{
			return _KeyExpressionID;
		}
		set
		{
			_KeyExpressionID = value;
		}
	}

	internal long ValueExpressionID
	{
		get
		{
			return _ValueExpressionID;
		}
		set
		{
			_ValueExpressionID = value;
		}
	}

	internal DateTime Created
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

	internal StringDataItemDAL()
	{
	}

	internal void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[StringDataItems_DeleteStringDataItemByID]", queryParameters));
	}

	internal void Insert()
	{
		if (_MeasurementID == 0L)
		{
			throw new ApplicationException("Required value not specified: MeasurementID.");
		}
		if (_KeyExpressionID == 0L)
		{
			throw new ApplicationException("Required value not specified: KeyExpressionID.");
		}
		if (_ValueExpressionID == 0L)
		{
			throw new ApplicationException("Required value not specified: ValueExpressionID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MeasurementID", _MeasurementID));
		queryParameters.Add(new SqlParameter("@KeyExpressionID", _KeyExpressionID));
		queryParameters.Add(new SqlParameter("@ValueExpressionID", _ValueExpressionID));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[StringDataItems_InsertStringDataItem]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	internal void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_MeasurementID == 0L)
		{
			throw new ApplicationException("Required value not specified: MeasurementID.");
		}
		if (_KeyExpressionID == 0L)
		{
			throw new ApplicationException("Required value not specified: KeyExpressionID.");
		}
		if (_ValueExpressionID == 0L)
		{
			throw new ApplicationException("Required value not specified: ValueExpressionID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@MeasurementID", _MeasurementID));
		queryParameters.Add(new SqlParameter("@KeyExpressionID", _KeyExpressionID));
		queryParameters.Add(new SqlParameter("@ValueExpressionID", _ValueExpressionID));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[StringDataItems_UpdateStringDataItemByID]", queryParameters));
	}

	private static StringDataItemDAL BuildDAL(SqlDataReader reader)
	{
		StringDataItemDAL dal = new StringDataItemDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.MeasurementID = (long)reader["MeasurementID"];
			dal.KeyExpressionID = (long)reader["KeyExpressionID"];
			dal.ValueExpressionID = (long)reader["ValueExpressionID"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static StringDataItemDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[StringDataItems_GetStringDataItemByID]", queryParameters), BuildDAL);
	}
}
