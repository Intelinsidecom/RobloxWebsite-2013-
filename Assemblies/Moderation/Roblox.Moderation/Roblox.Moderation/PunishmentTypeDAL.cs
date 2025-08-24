using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Moderation;

public class PunishmentTypeDAL
{
	private byte _ID;

	private string _Value = string.Empty;

	private byte _AccountStatusID;

	private byte? _DurationInDays;

	private byte _SortOrder;

	private string _IconName = string.Empty;

	private bool? _IsActive = false;

	private byte? _SeverityRank = 0;

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

	public byte AccountStatusID
	{
		get
		{
			return _AccountStatusID;
		}
		set
		{
			_AccountStatusID = value;
		}
	}

	public byte? DurationInDays
	{
		get
		{
			return _DurationInDays;
		}
		set
		{
			_DurationInDays = value;
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

	public string IconName
	{
		get
		{
			return _IconName;
		}
		set
		{
			_IconName = value.Substring(0, (value.Length < 50) ? value.Length : 50);
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

	public bool? IsActive
	{
		get
		{
			return _IsActive;
		}
		set
		{
			_IsActive = value;
		}
	}

	public byte? SeverityRank
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

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentTypes_DeletePunishmentTypeByID]", queryParameters));
	}

	public void Insert()
	{
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (_AccountStatusID == 0)
		{
			throw new ApplicationException("Required value not specified: AccountStatusID.");
		}
		if (_IconName.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: IconName.");
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
		queryParameters.Add(new SqlParameter("@AccountStatusID", _AccountStatusID));
		queryParameters.Add(new SqlParameter("@DurationInDays", _DurationInDays.HasValue ? ((object)_DurationInDays.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@SortOrder", _SortOrder));
		queryParameters.Add(new SqlParameter("@IconName", _IconName));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		queryParameters.Add(new SqlParameter("@IsActive", _IsActive.HasValue ? ((object)_IsActive.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@SeverityRank", _SeverityRank.HasValue ? ((object)_SeverityRank.Value) : DBNull.Value));
		_ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentTypes_InsertPunishmentType]", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
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
		if (_AccountStatusID == 0)
		{
			throw new ApplicationException("Required value not specified: AccountStatusID.");
		}
		if (_IconName.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: IconName.");
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
		queryParameters.Add(new SqlParameter("@AccountStatusID", _AccountStatusID));
		queryParameters.Add(new SqlParameter("@DurationInDays", _DurationInDays.HasValue ? ((object)_DurationInDays.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@SortOrder", _SortOrder));
		queryParameters.Add(new SqlParameter("@IconName", _IconName));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		queryParameters.Add(new SqlParameter("@IsActive", _IsActive.HasValue ? ((object)_IsActive.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@SeverityRank", _SeverityRank.HasValue ? ((object)_SeverityRank.Value) : DBNull.Value));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentTypes_UpdatePunishmentTypeByID]", queryParameters));
	}

	private static PunishmentTypeDAL BuildDAL(SqlDataReader reader)
	{
		PunishmentTypeDAL dal = new PunishmentTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.AccountStatusID = (byte)reader["AccountStatusID"];
			dal.DurationInDays = (reader["DurationInDays"].Equals(DBNull.Value) ? null : ((byte?)reader["DurationInDays"]));
			dal.SortOrder = (byte)reader["SortOrder"];
			dal.IconName = (string)reader["IconName"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.IsActive = (reader["IsActive"].Equals(DBNull.Value) ? null : ((bool?)reader["IsActive"]));
			dal.SeverityRank = (reader["SeverityRank"].Equals(DBNull.Value) ? null : ((byte?)reader["SeverityRank"]));
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static PunishmentTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentTypes_GetPunishmentTypeByID]", queryParameters), BuildDAL);
	}

	public static PunishmentTypeDAL Get(string value)
	{
		if (value.Trim().Length == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentTypes_GetPunishmentTypeByValue]", queryParameters), BuildDAL);
	}

	public static ICollection<byte> GetPunishmentTypeIDsPaged(int startRowIndex, int maximumRows)
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
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentTypes_GetPunishmentTypeIDs_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfPunishmentTypes()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(Helper.DBConnectionString, "[dbo].[PunishmentTypes_GetTotalNumberOfPunishmentTypes]", queryParameters));
	}
}
