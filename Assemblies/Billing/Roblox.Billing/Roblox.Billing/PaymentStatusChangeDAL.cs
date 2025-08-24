using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class PaymentStatusChangeDAL
{
	private long _ID;

	private long _PaymentID;

	private byte? _OldPaymentStatusTypeID;

	private byte _NewPaymentStatusTypeID;

	private DateTime _Created;

	private DateTime _Updated;

	internal long ID
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

	internal long PaymentID
	{
		get
		{
			return _PaymentID;
		}
		set
		{
			_PaymentID = value;
		}
	}

	internal byte? OldPaymentStatusTypeID
	{
		get
		{
			return _OldPaymentStatusTypeID;
		}
		set
		{
			_OldPaymentStatusTypeID = value;
		}
	}

	internal byte NewPaymentStatusTypeID
	{
		get
		{
			return _NewPaymentStatusTypeID;
		}
		set
		{
			_NewPaymentStatusTypeID = value;
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

	internal PaymentStatusChangeDAL()
	{
	}

	internal void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PaymentStatusChanges_DeletePaymentStatusChangeByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PaymentID", PaymentID),
			new SqlParameter("@OldPaymentStatusTypeID", OldPaymentStatusTypeID.HasValue ? ((object)OldPaymentStatusTypeID) : DBNull.Value),
			new SqlParameter("@NewPaymentStatusTypeID", NewPaymentStatusTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PaymentStatusChanges_InsertPaymentStatusChange", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@PaymentID", PaymentID),
			new SqlParameter("@OldPaymentStatusTypeID", OldPaymentStatusTypeID.HasValue ? ((object)OldPaymentStatusTypeID) : DBNull.Value),
			new SqlParameter("@NewPaymentStatusTypeID", NewPaymentStatusTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PaymentStatusChanges_UpdatePaymentStatusChangeByID", queryParameters));
	}

	private static PaymentStatusChangeDAL BuildDAL(SqlDataReader reader)
	{
		PaymentStatusChangeDAL dal = new PaymentStatusChangeDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.PaymentID = (long)reader["PaymentID"];
			dal.OldPaymentStatusTypeID = (reader["OldPaymentStatusTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["OldPaymentStatusTypeID"]));
			dal.NewPaymentStatusTypeID = (byte)reader["NewPaymentStatusTypeID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static PaymentStatusChangeDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PaymentStatusChanges_GetPaymentStatusChangeByID", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetPaymentStatusChangeIDsByPaymentID(long paymentId, long startRowIndex, int maxRows)
	{
		if (paymentId == 0L)
		{
			throw new ApplicationException("Required value not specified: PaymentID.");
		}
		if (maxRows == 0L)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PaymentID", paymentId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PaymentStatusChanges_GetPaymentStatusChangeIDsByPaymentID_Paged", queryParameters));
	}

	internal static long GetTotalNumberOfPaymentStatusChangesByPaymentID(long paymentId)
	{
		if (paymentId == 0L)
		{
			throw new ApplicationException("Required value not specified: statusTypeID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PaymentID", paymentId));
		return EntityHelper.GetDataCount<long>(new DbInfo(_DbConnectionString, "PaymentStatusChanges_GetTotalNumberOfPaymentStatusChangeIDsByPaymentID", queryParameters));
	}
}
