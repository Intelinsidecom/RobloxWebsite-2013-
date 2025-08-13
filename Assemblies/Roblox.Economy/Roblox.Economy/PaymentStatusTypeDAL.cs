using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common.Properties;

namespace Roblox.Economy;

public class PaymentStatusTypeDAL
{
	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.DBConnectionString;

	private static PaymentStatusTypeDAL GetDALFromReader(SqlDataReader reader)
	{
		PaymentStatusTypeDAL dal = new PaymentStatusTypeDAL
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

	private static PaymentStatusTypeDAL BuildDAL(SqlDataReader reader)
	{
		PaymentStatusTypeDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PaymentStatusTypeDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PaymentStatusTypeDAL> dals = new List<PaymentStatusTypeDAL>();
		while (reader.Read())
		{
			PaymentStatusTypeDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PaymentStatusTypes_DeletePaymentStatusTypeByID", queryParameters));
	}

	internal static PaymentStatusTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PaymentStatusTypes_GetPaymentStatusTypeByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PaymentStatusTypes_InsertPaymentStatusType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
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
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PaymentStatusTypes_UpdatePaymentStatusTypeByID", queryParameters));
	}

	internal static ICollection<PaymentStatusTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "PaymentStatusTypes_GetPaymentStatusTypesByIDs"), ids, BuildDALCollection);
	}

	internal static PaymentStatusTypeDAL GetPaymentStatusTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PaymentStatusTypes_GetPaymentStatusTypeByValue", queryParameters), BuildDAL);
	}
}
