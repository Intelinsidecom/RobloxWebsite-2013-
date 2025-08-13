using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ImbursementDAL
{
	private int _ID;

	private long _UserID;

	private int _AccountPayableID;

	private byte _CurrencyTypeID;

	private byte _ImbursementStatusTypeID;

	private byte? _ImbursementRejectionTypeID;

	private decimal _Amount;

	private int _Robux;

	private string _EscrowID;

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

	internal long UserID
	{
		get
		{
			return _UserID;
		}
		set
		{
			_UserID = value;
		}
	}

	internal int AccountPayableID
	{
		get
		{
			return _AccountPayableID;
		}
		set
		{
			_AccountPayableID = value;
		}
	}

	internal byte CurrencyTypeID
	{
		get
		{
			return _CurrencyTypeID;
		}
		set
		{
			_CurrencyTypeID = value;
		}
	}

	internal byte ImbursementStatusTypeID
	{
		get
		{
			return _ImbursementStatusTypeID;
		}
		set
		{
			_ImbursementStatusTypeID = value;
		}
	}

	internal byte? ImbursementRejectionTypeID
	{
		get
		{
			return _ImbursementRejectionTypeID;
		}
		set
		{
			_ImbursementRejectionTypeID = value;
		}
	}

	internal decimal Amount
	{
		get
		{
			return _Amount;
		}
		set
		{
			_Amount = value;
		}
	}

	internal int Robux
	{
		get
		{
			return _Robux;
		}
		set
		{
			_Robux = value;
		}
	}

	internal string EscrowID
	{
		get
		{
			return _EscrowID;
		}
		set
		{
			_EscrowID = value;
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "Imbursements_DeleteImbursementByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@AccountPayableID", AccountPayableID),
			new SqlParameter("@CurrencyTypeID", CurrencyTypeID),
			new SqlParameter("@ImbursementStatusTypeID", ImbursementStatusTypeID),
			new SqlParameter("@ImbursementRejectionTypeID", ImbursementRejectionTypeID.HasValue ? ((object)ImbursementRejectionTypeID) : DBNull.Value),
			new SqlParameter("@Amount", Amount),
			new SqlParameter("@Robux", Robux),
			new SqlParameter("@EscrowID", EscrowID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "Imbursements_InsertImbursement", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@AccountPayableID", AccountPayableID),
			new SqlParameter("@CurrencyTypeID", CurrencyTypeID),
			new SqlParameter("@ImbursementStatusTypeID", ImbursementStatusTypeID),
			new SqlParameter("@ImbursementRejectionTypeID", ImbursementRejectionTypeID.HasValue ? ((object)ImbursementRejectionTypeID) : DBNull.Value),
			new SqlParameter("@Amount", Amount),
			new SqlParameter("@Robux", Robux),
			new SqlParameter("@EscrowID", EscrowID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "Imbursements_UpdateImbursementByID", queryParameters));
	}

	private static ImbursementDAL GetDALFromReader(SqlDataReader reader)
	{
		ImbursementDAL dal = new ImbursementDAL
		{
			ID = (int)reader["ID"],
			UserID = Convert.ToInt64(reader["UserID"]),
			AccountPayableID = (int)reader["AccountPayableID"],
			CurrencyTypeID = (byte)reader["CurrencyTypeID"],
			ImbursementStatusTypeID = (byte)reader["ImbursementStatusTypeID"],
			Amount = (decimal)reader["Amount"],
			Robux = (int)reader["Robux"],
			EscrowID = (string)reader["EscrowID"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"],
			ImbursementRejectionTypeID = (reader["ImbursementRejectionTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["ImbursementRejectionTypeID"]))
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static ImbursementDAL BuildDAL(SqlDataReader reader)
	{
		ImbursementDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<ImbursementDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<ImbursementDAL> dals = new List<ImbursementDAL>();
		while (reader.Read())
		{
			ImbursementDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal static ImbursementDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "Imbursements_GetImbursementByID", queryParameters), BuildDAL);
	}

	internal static ICollection<ImbursementDAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "Imbursements_GetImbursementsByIDs"), ids, BuildDALCollection);
	}

	internal static ICollection<int> GetImbursementIDsByAccountPayableID(int accountPayableID, int startRowIndex, int maxRows)
	{
		if (accountPayableID == 0)
		{
			throw new ApplicationException("Required value not specified: AccountPayableID.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountPayableID", accountPayableID));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "Imbursements_GetImbursementIDsByAccountPayableID_Paged", queryParameters));
	}

	internal static ICollection<int> GetImbursementIDsByUserID(long userId, int startRowIndex, int maxRows)
	{
		if (userId == 0L || maxRows == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "Imbursements_GetImbursementIDsByUserID_Paged", queryParameters));
	}

	internal static ICollection<int> GetImbursementIDsByUserIDBetweenDates(long userId, DateTime startDate, DateTime endDate, int startRowIndex, int maxRows)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: userId.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@StartDate", startDate));
		queryParameters.Add(new SqlParameter("@EndDate", endDate));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "Imbursements_GetImbursementIDsByUserIDBetweenDates_Paged", queryParameters));
	}

	internal static ICollection<int> GetImbursementIDsByImbursementStatusTypeID(byte statusTypeID, int startRowIndex, int maxRows)
	{
		if (statusTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: statusTypeID.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ImbursementStatusTypeID", statusTypeID));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "Imbursements_GetImbursementIDsByImbursementStatusTypeID_Paged", queryParameters));
	}

	internal static ICollection<int> GetImbursementIDsByUserIDAndImbursementStatusTypeID(byte statusTypeID, long userID, int startRowIndex, int maxRows)
	{
		if (statusTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: statusTypeID.");
		}
		if (userID == 0L)
		{
			throw new ApplicationException("Required value not specified: userID.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ImbursementStatusTypeID", statusTypeID));
		queryParameters.Add(new SqlParameter("@UserID", userID));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "Imbursements_GetImbursementIDsByUserIDAndImbursementStatusTypeID_Paged", queryParameters));
	}

	internal static int GetTotalNumberOfImbursementIDsByImbursementStatusTypeID(byte statusTypeID)
	{
		if (statusTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: statusTypeID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ImbursementStatusTypeID", statusTypeID));
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "Imbursements_GetTotalNumberOfImbursementIDsByImbursementStatusTypeID", queryParameters));
	}

	internal static int GetTotalNumberOfImbursementsByUserIDBetweenDates(long userId, DateTime startDate, DateTime endDate)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: userId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@StartDate", startDate));
		queryParameters.Add(new SqlParameter("@EndDate", endDate));
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "Imbursements_GetTotalNumberOfImbursementsByUserIDBetweenDates", queryParameters));
	}

	internal static int GetTotalNumberOfImbursementsByUserID(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: userId.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "Imbursements_GetTotalNumberOfImbursementsByUserID", queryParameters));
	}

	internal static int GetTotalNumberOfImbursementsByAccountPayableID(int accountPayableID)
	{
		if (accountPayableID == 0)
		{
			throw new ApplicationException("Required value not specified: accountPayableID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountPayableID", accountPayableID));
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "Imbursements_GetTotalNumberOfImbursementsByAccountPayableID", queryParameters));
	}

	internal static int GetTotalNumberOfImbursementsByUserIDAndImbursementStatusTypeID(long userID, byte statusTypeID)
	{
		if (statusTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: statusTypeID.");
		}
		if (userID == 0L)
		{
			throw new ApplicationException("Required value not specified: userID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ImbursementStatusTypeID", statusTypeID));
		queryParameters.Add(new SqlParameter("@UserID", userID));
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "Imbursements_GetTotalNumberOfImbursementsByUserIDAndImbursementStatusTypeID", queryParameters));
	}
}
