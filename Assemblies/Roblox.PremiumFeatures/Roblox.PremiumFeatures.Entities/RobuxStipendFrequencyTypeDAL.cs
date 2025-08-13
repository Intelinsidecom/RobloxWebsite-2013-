using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures.Entities;

internal class RobuxStipendFrequencyTypeDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxRobuxStipends.GetConnectionString();

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime? CreatedUtc { get; set; }

	internal DateTime? UpdatedUtc { get; set; }

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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[RobuxStipendFrequencyTypes_DeleteRobuxStipendFrequencyTypeByID]", queryParameters));
	}

	internal void Insert()
	{
		if (Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (CreatedUtc.Equals(DateTime.MinValue) || !CreatedUtc.HasValue)
		{
			throw new ApplicationException("Required value not specified: CreatedUtc.");
		}
		if (UpdatedUtc.Equals(DateTime.MinValue) || !UpdatedUtc.HasValue)
		{
			throw new ApplicationException("Required value not specified: UpdatedUtc.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@CreatedUtc", CreatedUtc),
			new SqlParameter("@UpdatedUtc", UpdatedUtc)
		};
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(ConnectionString, "[dbo].[RobuxStipendFrequencyTypes_InsertRobuxStipendFrequencyType]", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
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
		if (CreatedUtc.Equals(DateTime.MinValue) || !CreatedUtc.HasValue)
		{
			throw new ApplicationException("Required value not specified: CreatedUtc.");
		}
		if (UpdatedUtc.Equals(DateTime.MinValue) || !UpdatedUtc.HasValue)
		{
			throw new ApplicationException("Required value not specified: UpdatedUtc.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@CreatedUtc", CreatedUtc),
			new SqlParameter("@UpdatedUtc", UpdatedUtc)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[RobuxStipendFrequencyTypes_UpdateRobuxStipendFrequencyTypeByID]", queryParameters));
	}

	private static RobuxStipendFrequencyTypeDAL BuildDAL(SqlDataReader reader)
	{
		RobuxStipendFrequencyTypeDAL dal = new RobuxStipendFrequencyTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.CreatedUtc = (DateTime?)reader["CreatedUtc"];
			dal.UpdatedUtc = (DateTime?)reader["UpdatedUtc"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static RobuxStipendFrequencyTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobuxStipendFrequencyTypes_GetRobuxStipendFrequencyTypeByID]", queryParameters), BuildDAL);
	}

	internal static RobuxStipendFrequencyTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobuxStipendFrequencyTypes_GetRobuxStipendFrequencyTypeByValue]", queryParameters), BuildDAL);
	}
}
