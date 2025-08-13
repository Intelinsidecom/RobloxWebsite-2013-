using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class AccountEmailAddressDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxEmailAddresses;

	public int ID { get; set; }

	public long AccountID { get; set; }

	public int EmailAddressID { get; set; }

	public bool IsVerified { get; set; }

	public bool IsValid { get; set; } = true;


	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public bool Newsletter { get; set; }

	public void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(RobloxDatabase.RobloxEmailAddresses.GetConnectionString());
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.ExecuteSQLScalar("[dbo].[AccountEmailAddresses_DeleteAccountEmailAddressByID]", CommandType.StoredProcedure);
	}

	public void Insert()
	{
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (EmailAddressID == 0)
		{
			throw new ApplicationException("Required value not specified: EmailAddressID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		using DbHelper dbHelper = new DbHelper(RobloxDatabase.RobloxEmailAddresses.GetConnectionString());
		dbHelper.SQLParameters.AddWithValue("@AccountID", AccountID);
		dbHelper.SQLParameters.AddWithValue("@EmailAddressID", EmailAddressID);
		dbHelper.SQLParameters.AddWithValue("@IsVerified", IsVerified);
		dbHelper.SQLParameters.AddWithValue("@IsValid", IsValid);
		dbHelper.SQLParameters.AddWithValue("@Created", Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", Updated);
		dbHelper.SQLParameters.AddWithValue("@Newsletter", Newsletter);
		SqlParameter id = dbHelper.SQLParameters.Add("@ID", SqlDbType.Int);
		id.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[AccountEmailAddresses_InsertAccountEmailAddress]", CommandType.StoredProcedure);
		ID = Convert.ToInt32(id.Value);
	}

	public void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (EmailAddressID == 0)
		{
			throw new ApplicationException("Required value not specified: EmailAddressID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		using DbHelper dbHelper = new DbHelper(RobloxDatabase.RobloxEmailAddresses.GetConnectionString());
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.SQLParameters.AddWithValue("@AccountID", AccountID);
		dbHelper.SQLParameters.AddWithValue("@EmailAddressID", EmailAddressID);
		dbHelper.SQLParameters.AddWithValue("@IsVerified", IsVerified);
		dbHelper.SQLParameters.AddWithValue("@IsValid", IsValid);
		dbHelper.SQLParameters.AddWithValue("@Created", Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", Updated);
		dbHelper.SQLParameters.AddWithValue("@Newsletter", Newsletter);
		dbHelper.ExecuteSQLScalar("[dbo].[AccountEmailAddresses_UpdateAccountEmailAddressByID]", CommandType.StoredProcedure);
	}

	private static AccountEmailAddressDAL BuildDALFromReader(SqlDataReader reader)
	{
		return new AccountEmailAddressDAL
		{
			ID = (int)reader["ID"],
			AccountID = Convert.ToInt64(reader["AccountID"]),
			EmailAddressID = (int)reader["EmailAddressID"],
			IsVerified = (bool)reader["IsVerified"],
			IsValid = (bool)reader["IsValid"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"],
			Newsletter = (bool)reader["Newsletter"]
		};
	}

	private static AccountEmailAddressDAL BuildDAL(SqlDataReader reader)
	{
		AccountEmailAddressDAL dal = null;
		while (reader.Read())
		{
			dal = BuildDALFromReader(reader);
		}
		return dal;
	}

	public static AccountEmailAddressDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(RobloxDatabase.RobloxEmailAddresses.GetConnectionString());
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AccountEmailAddresses_GetAccountEmailAddressByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static int GetTotalNumberOfValidAccountEmailAddresses(long accountId)
	{
		if (accountId == 0L)
		{
			return 0;
		}
		object count;
		using (DbHelper dbHelper = new DbHelper(RobloxDatabase.RobloxEmailAddresses.GetConnectionString()))
		{
			dbHelper.SQLParameters.AddWithValue("@AccountID", accountId);
			count = dbHelper.ExecuteSQLScalar("[dbo].[AccountEmailAddresses_GetTotalNumberOfValidAccountEmailAddressesByAccountID]", CommandType.StoredProcedure);
		}
		return Convert.ToInt32(count);
	}

	public static int GetTotalNumberOfAccountsByValidEmailAddressID(int emailAddressId)
	{
		if (emailAddressId == 0)
		{
			return 0;
		}
		object count;
		using (DbHelper dbHelper = new DbHelper(RobloxDatabase.RobloxEmailAddresses.GetConnectionString()))
		{
			dbHelper.SQLParameters.AddWithValue("@EmailAddressID", emailAddressId);
			count = dbHelper.ExecuteSQLScalar("[dbo].[AccountEmailAddresses_GetTotalNumberOfAccountsByValidEmailAddressID]", CommandType.StoredProcedure);
		}
		return Convert.ToInt32(count);
	}

	public static ICollection<int> GetValidAccountEmailAddressIDs(int emailAddressId)
	{
		if (emailAddressId == 0)
		{
			return new List<int>();
		}
		using DbHelper dbHelper = new DbHelper(RobloxDatabase.RobloxEmailAddresses.GetConnectionString());
		dbHelper.SQLParameters.AddWithValue("@EmailAddressID", emailAddressId);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AccountEmailAddresses_GetValidAccountEmailAddressIDsByEmailAddressID]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<int>(reader);
	}

	public static ICollection<int> GetValidAccountEmailAddressIDsPaged(long accountId, int startRowIndex, int maximumRows)
	{
		return GetEmailAddressIDsPaged(accountId, startRowIndex, maximumRows, "[dbo].[AccountEmailAddresses_GetValidAccountEmailAddressIDsByAccountID_Paged]");
	}

	public static ICollection<int> GetValidAccountEmailAddressIDsByIsVerifiedPaged(long accountId, bool isVerified, int startRowIndex, int maximumRows)
	{
		if (accountId == 0L)
		{
			return new List<int>();
		}
		using DbHelper dbHelper = new DbHelper(RobloxDatabase.RobloxEmailAddresses.GetConnectionString());
		dbHelper.SQLParameters.AddWithValue("@AccountID", accountId);
		dbHelper.SQLParameters.AddWithValue("@IsVerified", isVerified);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AccountEmailAddresses_GetValidAccountEmailAddressIDsByAccountIDAndIsVerified_Paged]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<int>(reader);
	}

	public static ICollection<int> GetAccountEmailAddressIDsPaged(long accountId, int startRowIndex, int maximumRows)
	{
		return GetEmailAddressIDsPaged(accountId, startRowIndex, maximumRows, "[dbo].[AccountEmailAddresses_GetAccountEmailAddressIDsByAccountID_Paged]");
	}

	private static ICollection<int> GetEmailAddressIDsPaged(long accountId, int startRowIndex, int maximumRows, string storedProcedure)
	{
		if (accountId == 0L)
		{
			return new List<int>();
		}
		using DbHelper dbHelper = new DbHelper(RobloxDatabase.RobloxEmailAddresses.GetConnectionString());
		dbHelper.SQLParameters.AddWithValue("@AccountID", accountId);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader(storedProcedure, CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<int>(reader);
	}

	internal static ICollection<int> GetAccountEmailAddressIDsByEmailAddressID(int emailAddressId, int count, int exclusiveStartAccountEmailAddressId)
	{
		if (emailAddressId == 0)
		{
			throw new ArgumentException("Parameter 'emailAddressID' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartAccountEmailAddressId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartAccountEmailAddressID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@EmailAddressID", emailAddressId),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartAccountEmailAddressID", exclusiveStartAccountEmailAddressId)
		};
		return RobloxDatabase.RobloxEmailAddresses.GetIDCollection<int>("AccountEmailAddresses_GetAccountEmailAddressIDsByEmailAddressID", queryParameters);
	}

	internal static int GetTotalNumberOfAccountEmailAddressesByEmailAddressID(int emailAddressId)
	{
		if (emailAddressId == 0)
		{
			throw new ArgumentException("Parameter 'emailAddressID' cannot be null, empty or the default value.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@EmailAddressID", emailAddressId)
		};
		return RobloxDatabase.RobloxEmailAddresses.GetCount<int>("AccountEmailAddresses_GetTotalNumberOfAccountEmailAddressesByEmailAddressID", queryParameters);
	}

	internal static ICollection<int> GetAccountEmailAddressIDsByEmailAddressIDAndIsValid(int emailAddressId, bool isValid, int count, int exclusiveStartId)
	{
		if (emailAddressId == 0)
		{
			throw new ArgumentException("Parameter 'emailAddressId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@EmailAddressID", emailAddressId),
			new SqlParameter("@IsValid", isValid),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartID", exclusiveStartId)
		};
		return RobloxDatabase.RobloxEmailAddresses.GetIDCollection<int>("AccountEmailAddresses_GetAccountEmailAddressIDsByEmailAddressIDAndIsValid", queryParameters);
	}

	internal static ICollection<int> GetAccountEmailAddressIDsByEmailAddressIDIsVerifiedAndIsValid(int emailAddressId, bool isVerified, bool isValid, int count, int? exclusiveStartId)
	{
		if (emailAddressId == 0)
		{
			throw new ArgumentException(string.Format("Parameter {0} can not be the default value.", "emailAddressId"));
		}
		if (count < 1)
		{
			throw new ApplicationException(string.Format("Parameter {0} can not be less than 1", "count"));
		}
		if (exclusiveStartId.HasValue && exclusiveStartId < 0)
		{
			throw new ApplicationException(string.Format("Parameter {0} can not be negative.", "exclusiveStartId"));
		}
		SqlParameter[] obj = new SqlParameter[5]
		{
			new SqlParameter("@EmailAddressID", emailAddressId),
			new SqlParameter("@IsVerified", isVerified),
			new SqlParameter("@IsValid", isValid),
			new SqlParameter("@Count", count),
			null
		};
		int? num = exclusiveStartId;
		obj[4] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxEmailAddresses.GetIDCollection<int>("AccountEmailAddresses_GetAccountEmailAddressIDsByEmailAddressIDIsVerifiedAndIsValid", queryParameters);
	}

	public static ICollection<AccountEmailAddressDAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(RobloxDatabase.RobloxEmailAddresses.GetConnectionString(), "[dbo].[AccountEmailAddresses_GetAccountEmailAddressesByIDs]"), ids, BuildDALCollection);
	}

	private static List<AccountEmailAddressDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<AccountEmailAddressDAL> dals = new List<AccountEmailAddressDAL>();
		while (reader.Read())
		{
			AccountEmailAddressDAL dal = BuildDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}
}
