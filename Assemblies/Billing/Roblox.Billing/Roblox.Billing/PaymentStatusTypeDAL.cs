using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class PaymentStatusTypeDAL
{
	private byte _ID;

	private string _Value = "";

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	public static readonly string DBConnectionString = Settings.Default.BillingConnectionString;

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
		EntityHelper.DoEntityDALDelete(new DbInfo(DBConnectionString, "PaymentStatusTypes_DeletePaymentStatusTypeByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(DBConnectionString, "PaymentStatusTypes_InsertPaymentStatusType", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters);
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
		EntityHelper.DoEntityDALUpdate(new DbInfo(DBConnectionString, "PaymentStatusTypes_UpdatePaymentStatusTypeByID", queryParameters));
	}

	public static PaymentStatusTypeDAL BuildDAL(SqlDataReader reader)
	{
		PaymentStatusTypeDAL dal = new PaymentStatusTypeDAL();
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	internal static PaymentStatusTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(DBConnectionString, "PaymentStatusTypes_GetPaymentStatusTypeByID", queryParameters), BuildDAL);
	}

	public static PaymentStatusTypeDAL Get(string paymentStatusType)
	{
		if (paymentStatusType.Trim().Length == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", paymentStatusType));
		return EntityHelper.GetEntityDAL(new DbInfo(DBConnectionString, "[dbo].[PaymentStatusTypes_GetPaymentStatusTypeByValue]", queryParameters), BuildDAL);
	}

	private static PaymentStatusTypeDAL GetDALFromReader(SqlDataReader reader)
	{
		PaymentStatusTypeDAL dal = new PaymentStatusTypeDAL
		{
			ID = (byte)reader["ID"],
			Value = (string)reader["Value"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static List<PaymentStatusTypeDAL> BuildDalCollection(SqlDataReader reader)
	{
		List<PaymentStatusTypeDAL> dals = new List<PaymentStatusTypeDAL>();
		while (reader.Read())
		{
			PaymentStatusTypeDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal static ICollection<PaymentStatusTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(DBConnectionString, "PaymentStatusTypes_GetPaymentStatusTypesByIDs"), ids, BuildDalCollection);
	}
}
