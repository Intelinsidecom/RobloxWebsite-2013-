using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class PaymentStatusTypeChangeReasonTypeDAL
{
	private int _ID;

	private byte _PaymentStatusTypeID;

	private byte _PaymentStatusChangeReasonTypeID;

	private DateTime _Created;

	private DateTime _Updated;

	internal int ID
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

	internal byte PaymentStatusTypeID
	{
		get
		{
			return _PaymentStatusTypeID;
		}
		set
		{
			_PaymentStatusTypeID = value;
		}
	}

	internal byte PaymentStatusChangeReasonTypeID
	{
		get
		{
			return _PaymentStatusChangeReasonTypeID;
		}
		set
		{
			_PaymentStatusChangeReasonTypeID = value;
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

	internal PaymentStatusTypeChangeReasonTypeDAL()
	{
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PaymentStatusTypeChangeReasonTypes_DeletePaymentStatusTypeChangeReasonTypeByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PaymentStatusTypeID", PaymentStatusTypeID),
			new SqlParameter("@PaymentStatusChangeReasonTypeID", PaymentStatusChangeReasonTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PaymentStatusTypeChangeReasonTypes_InsertPaymentStatusTypeChangeReasonType", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@PaymentStatusTypeID", PaymentStatusTypeID),
			new SqlParameter("@PaymentStatusChangeReasonTypeID", PaymentStatusChangeReasonTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PaymentStatusTypeChangeReasonTypes_UpdatePaymentStatusTypeChangeReasonTypeByID", queryParameters));
	}

	private static PaymentStatusTypeChangeReasonTypeDAL BuildDAL(SqlDataReader reader)
	{
		PaymentStatusTypeChangeReasonTypeDAL dal = new PaymentStatusTypeChangeReasonTypeDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.PaymentStatusTypeID = (byte)reader["PaymentStatusTypeID"];
			dal.PaymentStatusChangeReasonTypeID = (byte)reader["PaymentStatusChangeReasonTypeID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static PaymentStatusTypeChangeReasonTypeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PaymentStatusTypeChangeReasonTypes_GetPaymentStatusTypeChangeReasonTypeByID", queryParameters), BuildDAL);
	}

	internal static ICollection<int> GetPaymentStatusTypeChangeReasonTypeIDsByPaymentStatusTypeID(byte paymentStatusTypeId, int startRowIndex, int maxRows)
	{
		if (paymentStatusTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: PaymentStatusTypeID.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", paymentStatusTypeId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "PaymentStatusTypeChangeReasonTypes_GetPaymentStatusTypeChangeReasonTypeIDsByPaymentStatusTypeID_Paged", queryParameters));
	}

	internal static int GetTotalNumberOfPaymentStatusTypeChangeReasonTypesByPaymentStatusTypeID(byte paymentStatusTypeId)
	{
		if (paymentStatusTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: PaymentStatusTypeID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", paymentStatusTypeId));
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PaymentStatusTypeChangeReasonTypes_GetTotalNumberOfPaymentStatusTypeChangeReasonTypeIDsByPaymentStatusTypeID", queryParameters));
	}
}
