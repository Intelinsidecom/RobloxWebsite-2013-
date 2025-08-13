using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class AccountPayableDAL
{
	private int _ID;

	private string _FirstName;

	private string _LastName;

	private int? _PhoneNumberID = 0;

	private int? _AddressID = 0;

	private int _PaypalEmailAddressID;

	private int _IPAddressID;

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

	internal string FirstName
	{
		get
		{
			return _FirstName;
		}
		set
		{
			_FirstName = value;
		}
	}

	internal string LastName
	{
		get
		{
			return _LastName;
		}
		set
		{
			_LastName = value;
		}
	}

	internal int? PhoneNumberID
	{
		get
		{
			return _PhoneNumberID;
		}
		set
		{
			_PhoneNumberID = value;
		}
	}

	internal int? AddressID
	{
		get
		{
			return _AddressID;
		}
		set
		{
			_AddressID = value;
		}
	}

	internal int PaypalEmailAddressID
	{
		get
		{
			return _PaypalEmailAddressID;
		}
		set
		{
			_PaypalEmailAddressID = value;
		}
	}

	internal int IPAddressID
	{
		get
		{
			return _IPAddressID;
		}
		set
		{
			_IPAddressID = value;
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

	internal AccountPayableDAL()
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "AccountsPayable_DeleteAccountPayableByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@FirstName", FirstName),
			new SqlParameter("@LastName", LastName),
			new SqlParameter("@PaypalEmailAddressID", PaypalEmailAddressID),
			new SqlParameter("@IPAddressID", IPAddressID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "AccountsPayable_InsertAccountPayableV2", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@FirstName", FirstName),
			new SqlParameter("@LastName", LastName),
			new SqlParameter("@PhoneNumberID", ((object)PhoneNumberID) ?? DBNull.Value),
			new SqlParameter("@AddressID", ((object)AddressID) ?? DBNull.Value),
			new SqlParameter("@PaypalEmailAddressID", PaypalEmailAddressID),
			new SqlParameter("@IPAddressID", IPAddressID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "AccountsPayable_UpdateAccountPayableByID", queryParameters));
	}

	private static AccountPayableDAL BuildDAL(SqlDataReader reader)
	{
		AccountPayableDAL dal = new AccountPayableDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.FirstName = (string)reader["FirstName"];
			dal.LastName = (string)reader["LastName"];
			dal.PhoneNumberID = ((reader["PhoneNumberID"] == DBNull.Value) ? null : new int?((int)reader["PhoneNumberID"]));
			dal.AddressID = ((reader["AddressID"] == DBNull.Value) ? null : new int?((int)reader["AddressID"]));
			dal.PaypalEmailAddressID = (int)reader["PaypalEmailAddressID"];
			dal.IPAddressID = (int)reader["IPAddressID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static AccountPayableDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "AccountsPayable_GetAccountPayableByID", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<AccountPayableDAL> GetOrCreateAccountPayable(string firstName, string lastName, int IPAddressId, int paypalEmailId)
	{
		if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || IPAddressId == 0 || paypalEmailId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@FirstName", firstName),
			new SqlParameter("@LastName", lastName),
			new SqlParameter("@IPAddressID", IPAddressId),
			new SqlParameter("@PaypalEmailAddressID", paypalEmailId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "AccountsPayable_GetOrCreateAccountPayableV2", queryParameters), BuildDAL);
	}
}
