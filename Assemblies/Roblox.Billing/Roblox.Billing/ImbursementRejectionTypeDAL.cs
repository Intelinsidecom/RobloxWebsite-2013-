using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ImbursementRejectionTypeDAL
{
	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	internal ImbursementRejectionTypeDAL()
	{
	}

	private static ImbursementRejectionTypeDAL GetDALFromReader(SqlDataReader reader)
	{
		ImbursementRejectionTypeDAL dal = new ImbursementRejectionTypeDAL
		{
			ID = (byte)reader["ID"],
			Value = (string)reader["Value"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if ((ulong)dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static ImbursementRejectionTypeDAL BuildDAL(SqlDataReader reader)
	{
		ImbursementRejectionTypeDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<ImbursementRejectionTypeDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<ImbursementRejectionTypeDAL> dals = new List<ImbursementRejectionTypeDAL>();
		while (reader.Read())
		{
			ImbursementRejectionTypeDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "ImbursementRejectionTypes_DeleteImbursementRejectionTypeByID", queryParameters));
	}

	internal static ImbursementRejectionTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ImbursementRejectionTypes_GetImbursementRejectionTypeByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "ImbursementRejectionTypes_InsertImbursementRejectionType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "ImbursementRejectionTypes_UpdateImbursementRejectionTypeByID", queryParameters));
	}

	internal static ICollection<ImbursementRejectionTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "ImbursementRejectionTypes_GetImbursementRejectionTypesByIDs"), ids, BuildDALCollection);
	}

	internal static ImbursementRejectionTypeDAL GetImbursementRejectionTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ImbursementRejectionTypes_GetImbursementRejectionTypeByValue", queryParameters), BuildDAL);
	}

	internal static byte GetTotalNumberOfImbursementRejectionTypes()
	{
		return EntityHelper.GetDataCount<byte>(new DbInfo(_DbConnectionString, "ImbursementRejectionTypes_GetTotalNumberOfImbursementRejectionTypes"));
	}

	internal static ICollection<byte> GetImbursementRejectionTypes_Paged(int startRowIndex, int maxRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maxRows)
		};
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(_DbConnectionString, "ImbursementRejectionTypes_GetImbursementRejectionTypes_Paged", queryParameters));
	}
}
