using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class PaymentProviderTypeDAL
{
	private byte _ID;

	private string _Value = "";

	private bool _SupportsRecurringCharges;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	public static readonly string DBConnectionString = Settings.Default.BillingConnectionString;

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
			_Value = value;
		}
	}

	public bool SupportsRecurringCharges
	{
		get
		{
			return _SupportsRecurringCharges;
		}
		set
		{
			_SupportsRecurringCharges = value;
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

	public static PaymentProviderTypeDAL BuildDAL(SqlDataReader reader)
	{
		PaymentProviderTypeDAL dal = new PaymentProviderTypeDAL();
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	public static PaymentProviderTypeDAL Get(string paymentProviderType)
	{
		if (paymentProviderType.Trim().Length == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", paymentProviderType));
		return EntityHelper.GetEntityDAL(new DbInfo(DBConnectionString, "[dbo].[PaymentProviderTypes_GetPaymentProviderTypeByValue]", queryParameters), BuildDAL);
	}

	internal static byte GetTotalNumberOfPaymentProviderTypes()
	{
		SqlParameter[] queryParameters = new SqlParameter[0];
		return EntityHelper.GetDataCount<byte>(new DbInfo(DBConnectionString, "dbo.PaymentProviderTypes_GetTotalNumberOfPaymentProviderTypes", queryParameters));
	}

	public static ICollection<byte> GetPaymentProviderTypesByID_Paged(byte startRowIndex, byte maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(DBConnectionString, "[dbo].[PaymentProviderTypes_GetPaymentProviderTypeIDs_Paged]", queryParameters));
	}

	public static PaymentProviderTypeDAL Get(byte id)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(DBConnectionString, "[dbo].[PaymentProviderTypes_GetPaymentProviderTypeById]", queryParameters), BuildDAL);
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@SupportsRecurringCharges", SupportsRecurringCharges),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(DBConnectionString, "PaymentProviderTypes_InsertPaymentProviderType", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@SupportsRecurringCharges", SupportsRecurringCharges),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(DBConnectionString, "PaymentProviderTypes_UpdatePaymentProviderTypeByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(DBConnectionString, "PaymentProviderTypes_DeletePaymentProviderTypeByID", queryParameters));
	}

	private static PaymentProviderTypeDAL GetDALFromReader(SqlDataReader reader)
	{
		PaymentProviderTypeDAL dal = new PaymentProviderTypeDAL
		{
			ID = (byte)reader["ID"],
			Value = (string)reader["Value"],
			SupportsRecurringCharges = (bool)reader["SupportsRecurringCharges"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static List<PaymentProviderTypeDAL> BuildDalCollection(SqlDataReader reader)
	{
		List<PaymentProviderTypeDAL> dals = new List<PaymentProviderTypeDAL>();
		while (reader.Read())
		{
			PaymentProviderTypeDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal static ICollection<PaymentProviderTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(DBConnectionString, "PaymentProviderTypes_GetPaymentProviderTypesByIDs"), ids, BuildDalCollection);
	}
}
