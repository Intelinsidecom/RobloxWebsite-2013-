using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

public class AbuseTypeDAL
{
	private byte _ID;

	private string _Value = string.Empty;

	private byte _SortOrder;

	private double? _AutoReportThreshhold;

	private double? _AutoReviewThreshhold;

	private double? _AutoPunishThreshhold;

	private byte _MinimumPunishmentTypeID;

	private byte _MaximumPunishmentTypeID;

	private double _PunishmentStep;

	private byte _SeverityRank;

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

	public byte SortOrder
	{
		get
		{
			return _SortOrder;
		}
		set
		{
			_SortOrder = value;
		}
	}

	public double? AutoReportThreshhold
	{
		get
		{
			return _AutoReportThreshhold;
		}
		set
		{
			_AutoReportThreshhold = value;
		}
	}

	public double? AutoReviewThreshhold
	{
		get
		{
			return _AutoReviewThreshhold;
		}
		set
		{
			_AutoReviewThreshhold = value;
		}
	}

	public double? AutoPunishThreshhold
	{
		get
		{
			return _AutoPunishThreshhold;
		}
		set
		{
			_AutoPunishThreshhold = value;
		}
	}

	public byte MinimumPunishmentTypeID
	{
		get
		{
			return _MinimumPunishmentTypeID;
		}
		set
		{
			_MinimumPunishmentTypeID = value;
		}
	}

	public byte MaximumPunishmentTypeID
	{
		get
		{
			return _MaximumPunishmentTypeID;
		}
		set
		{
			_MaximumPunishmentTypeID = value;
		}
	}

	public double PunishmentStep
	{
		get
		{
			return _PunishmentStep;
		}
		set
		{
			_PunishmentStep = value;
		}
	}

	public byte SeverityRank
	{
		get
		{
			return _SeverityRank;
		}
		set
		{
			_SeverityRank = value;
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
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[AbuseTypes_DeleteAbuseTypeByID]", queryParameters));
	}

	public void Insert()
	{
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (_MinimumPunishmentTypeID == 0)
		{
			throw new ApplicationException("Required value was not specified: MinimumPunishmentTypeID.");
		}
		if (_MaximumPunishmentTypeID == 0)
		{
			throw new ApplicationException("Required value was not specified: MaximumPunishmentTypeID.");
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
		queryParameters.Add(new SqlParameter("@SortOrder", _SortOrder));
		queryParameters.Add(new SqlParameter("@AutoReportThreshhold", _AutoReportThreshhold.HasValue ? ((object)_AutoReportThreshhold.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@AutoReviewThreshhold", _AutoReviewThreshhold.HasValue ? ((object)_AutoReviewThreshhold.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@AutoPunishThreshhold", _AutoPunishThreshhold.HasValue ? ((object)_AutoPunishThreshhold.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@MinimumPunishmentTypeID", _MinimumPunishmentTypeID));
		queryParameters.Add(new SqlParameter("@MaximumPunishmentTypeID", _MaximumPunishmentTypeID));
		queryParameters.Add(new SqlParameter("@PunishmentStep", _PunishmentStep));
		queryParameters.Add(new SqlParameter("@SeverityRank", _SeverityRank));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(Helper.DBConnectionString, "[dbo].[AbuseTypes_InsertAbuseType]", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
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
		if (_MinimumPunishmentTypeID == 0)
		{
			throw new ApplicationException("Required value was not specified: MinimumPunishmentTypeID.");
		}
		if (_MaximumPunishmentTypeID == 0)
		{
			throw new ApplicationException("Required value was not specified: MaximumPunishmentTypeID.");
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
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@SortOrder", _SortOrder));
		queryParameters.Add(new SqlParameter("@AutoReportThreshhold", _AutoReportThreshhold.HasValue ? ((object)_AutoReportThreshhold.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@AutoReviewThreshhold", _AutoReviewThreshhold.HasValue ? ((object)_AutoReviewThreshhold.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@AutoPunishThreshhold", _AutoPunishThreshhold.HasValue ? ((object)_AutoPunishThreshhold.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@MinimumPunishmentTypeID", _MinimumPunishmentTypeID));
		queryParameters.Add(new SqlParameter("@MaximumPunishmentTypeID", _MaximumPunishmentTypeID));
		queryParameters.Add(new SqlParameter("@PunishmentStep", _PunishmentStep));
		queryParameters.Add(new SqlParameter("@SeverityRank", _SeverityRank));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[AbuseTypes_UpdateAbuseTypeByID]", queryParameters));
	}

	private static AbuseTypeDAL BuildDAL(SqlDataReader reader)
	{
		AbuseTypeDAL dal = new AbuseTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.SortOrder = (byte)reader["SortOrder"];
			dal.AutoReportThreshhold = (reader["AutoReportThreshhold"].Equals(DBNull.Value) ? null : ((double?)reader["AutoReportThreshhold"]));
			dal.AutoReviewThreshhold = (reader["AutoReviewThreshhold"].Equals(DBNull.Value) ? null : ((double?)reader["AutoReviewThreshhold"]));
			dal.AutoPunishThreshhold = (reader["AutoPunishThreshhold"].Equals(DBNull.Value) ? null : ((double?)reader["AutoPunishThreshhold"]));
			dal.MinimumPunishmentTypeID = (byte)reader["MinimumPunishmentTypeID"];
			dal.MaximumPunishmentTypeID = (byte)reader["MaximumPunishmentTypeID"];
			dal.PunishmentStep = (double)reader["PunishmentStep"];
			dal.SeverityRank = (byte)reader["SeverityRank"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static AbuseTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[AbuseTypes_GetAbuseTypeByID]", queryParameters), BuildDAL);
	}

	public static AbuseTypeDAL Get(string value)
	{
		if (value.Trim().Length == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[AbuseTypes_GetAbuseTypeByValue]", queryParameters), BuildDAL);
	}

	public static ICollection<byte> GetAbuseTypeIDsPaged(int startRowIndex, int maximumRows)
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
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(Helper.DBConnectionString, "[dbo].[AbuseTypes_GetAbuseTypeIDs_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfAbuseTypes()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[AbuseTypes_GetTotalNumberOfAbuseTypes]", queryParameters));
	}
}
