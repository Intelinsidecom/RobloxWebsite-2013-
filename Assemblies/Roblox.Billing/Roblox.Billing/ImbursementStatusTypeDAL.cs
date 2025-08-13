using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ImbursementStatusTypeDAL
{
	private byte _ID;

	private string _Value;

	private DateTime _Created;

	private DateTime _Updated;

	internal byte ID
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

	internal string Value
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

	internal DateTime Updated
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

	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	internal void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "ImbursementStatusTypes_DeleteImbursementStatusTypeByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "ImbursementStatusTypes_InsertImbursementStatusType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "ImbursementStatusTypes_UpdateImbursementStatusTypeByID", queryParameters));
	}

	private static ImbursementStatusTypeDAL BuildDAL(SqlDataReader reader)
	{
		ImbursementStatusTypeDAL dal = new ImbursementStatusTypeDAL();
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

	internal static ImbursementStatusTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ImbursementStatusTypes_GetImbursementStatusTypeByID", queryParameters), BuildDAL);
	}

	internal static ImbursementStatusTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ImbursementStatusTypes_GetImbursementStatusTypeByValue", queryParameters), BuildDAL);
	}

	internal static byte GetTotalNumberOfImbursementStatusTypes()
	{
		return EntityHelper.GetDataCount<byte>(new DbInfo(_DbConnectionString, "ImbursementStatusTypes_GetTotalNumberOfImbursementStatusTypes"));
	}

	internal static ICollection<byte> GetImbursementStatusTypes_Paged(byte startRowIndex, byte maxRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maxRows)
		};
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(_DbConnectionString, "ImbursementStatusTypes_GetImbursementStatusTypes_Paged", queryParameters));
	}
}
