using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

public class RobuxStipendQuantityTypeDAL
{
	private string _Value = string.Empty;

	private static string ConnectionString => RobloxDatabase.RobloxRobuxStipends.GetConnectionString();

	internal byte ID { get; set; }

	internal string Value
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

	internal long Amount { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[RobuxStipendQuantityTypes_DeleteRobuxStipendQuantityTypeByID]", queryParameters));
	}

	internal void Insert()
	{
		if (Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (Amount == 0L)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@Value", _Value),
			new SqlParameter("@Amount", Amount),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(ConnectionString, "[dbo].[RobuxStipendQuantityTypes_InsertRobuxStipendQuantityType]", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
	}

	internal void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (Amount == 0L)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", _Value),
			new SqlParameter("@Amount", Amount),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[RobuxStipendQuantityTypes_UpdateRobuxStipendQuantityTypeByID]", queryParameters));
	}

	private static RobuxStipendQuantityTypeDAL BuildDAL(SqlDataReader reader)
	{
		RobuxStipendQuantityTypeDAL dal = new RobuxStipendQuantityTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Amount = (long)reader["Amount"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static RobuxStipendQuantityTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobuxStipendQuantityTypes_GetRobuxStipendQuantityTypeByID]", queryParameters), BuildDAL);
	}

	internal static RobuxStipendQuantityTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobuxStipendQuantityTypes_GetRobuxStipendQuantityTypeByValue]", queryParameters), BuildDAL);
	}
}
