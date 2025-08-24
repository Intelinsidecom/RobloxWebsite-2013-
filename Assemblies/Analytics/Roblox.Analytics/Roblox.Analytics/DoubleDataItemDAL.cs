using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Analytics;

public class DoubleDataItemDAL
{
	private long _ID;

	private long _MeasurementID;

	private long _KeyExpressionID;

	private double _Value;

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

	internal double Value
	{
		get
		{
			return _Value;
		}
		set
		{
			_Value = value;
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

	internal DoubleDataItemDAL()
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
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[DoubleDataItems_DeleteDoubleDataItemByID]", queryParameters));
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
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MeasurementID", _MeasurementID));
		queryParameters.Add(new SqlParameter("@KeyExpressionID", _KeyExpressionID));
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[DoubleDataItems_InsertDoubleDataItem]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
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
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@MeasurementID", _MeasurementID));
		queryParameters.Add(new SqlParameter("@KeyExpressionID", _KeyExpressionID));
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[DoubleDataItems_UpdateDoubleDataItemByID]", queryParameters));
	}

	private static DoubleDataItemDAL BuildDAL(SqlDataReader reader)
	{
		DoubleDataItemDAL dal = new DoubleDataItemDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.MeasurementID = (long)reader["MeasurementID"];
			dal.KeyExpressionID = (long)reader["KeyExpressionID"];
			dal.Value = (double)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static DoubleDataItemDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[DoubleDataItems_GetDoubleDataItemByID]", queryParameters), BuildDAL);
	}
}
