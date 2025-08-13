using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Analytics;

public class MeasurementDAL
{
	private long _ID;

	private int _MeasurementTypeID;

	private int? _FilterID;

	private int? _SecondaryFilterID;

	private DateTime _MeasurementDateTime = DateTime.MinValue;

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

	internal int MeasurementTypeID
	{
		get
		{
			return _MeasurementTypeID;
		}
		set
		{
			_MeasurementTypeID = value;
		}
	}

	internal int? FilterID
	{
		get
		{
			return _FilterID;
		}
		set
		{
			_FilterID = value;
		}
	}

	internal int? SecondaryFilterID
	{
		get
		{
			return _SecondaryFilterID;
		}
		set
		{
			_SecondaryFilterID = value;
		}
	}

	internal DateTime MeasurementDateTime
	{
		get
		{
			return _MeasurementDateTime;
		}
		set
		{
			_MeasurementDateTime = value;
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

	internal MeasurementDAL()
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
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[Measurements_DeleteMeasurementByID]", queryParameters));
	}

	internal void Insert()
	{
		if (_MeasurementTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: MeasurementTypeID.");
		}
		if (_MeasurementDateTime.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: MeasurementDateTime.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MeasurementTypeID", _MeasurementTypeID));
		queryParameters.Add(new SqlParameter("@FilterID", _FilterID.HasValue ? ((object)_FilterID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@SecondaryFilterID", _SecondaryFilterID.HasValue ? ((object)_SecondaryFilterID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@MeasurementDateTime", _MeasurementDateTime));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString, "[dbo].[Measurements_InsertMeasurement]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	internal void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_MeasurementTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: MeasurementTypeID.");
		}
		if (_MeasurementDateTime.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: MeasurementDateTime.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@MeasurementTypeID", _MeasurementTypeID));
		queryParameters.Add(new SqlParameter("@FilterID", _FilterID.HasValue ? ((object)_FilterID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@SecondaryFilterID", _SecondaryFilterID.HasValue ? ((object)_SecondaryFilterID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@MeasurementDateTime", _MeasurementDateTime));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[Measurements_UpdateMeasurementByID]", queryParameters));
	}

	private static MeasurementDAL BuildDAL(SqlDataReader reader)
	{
		MeasurementDAL dal = new MeasurementDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.MeasurementTypeID = (int)reader["MeasurementTypeID"];
			dal.FilterID = (reader["FilterID"].Equals(DBNull.Value) ? null : ((int?)reader["FilterID"]));
			dal.SecondaryFilterID = (reader["SecondaryFilterID"].Equals(DBNull.Value) ? null : ((int?)reader["SecondaryFilterID"]));
			dal.MeasurementDateTime = (DateTime)reader["MeasurementDateTime"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static MeasurementDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[Measurements_GetMeasurementByID]", queryParameters), BuildDAL);
	}
}
