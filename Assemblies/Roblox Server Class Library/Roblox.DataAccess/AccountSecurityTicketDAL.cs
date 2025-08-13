using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class AccountSecurityTicketDAL
{
	private static string ConnectionString = RobloxDatabase.RobloxAccountSecurity.GetConnectionString();

	public int ID { get; set; }

	public Guid GUID { get; set; } = Guid.Empty;


	public long AccountID { get; set; }

	public int? AccountEmailAddressID { get; set; } = 0;


	public int? AccountPasswordHashID { get; set; } = 0;


	public bool IsValid { get; set; } = true;


	public DateTime Created { get; set; } = DateTime.MinValue;


	public DateTime Updated { get; set; } = DateTime.MinValue;


	public void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.ExecuteSQLScalar("[dbo].[AccountSecurityTickets_DeleteAccountSecurityTicketByID]", CommandType.StoredProcedure);
	}

	public void Insert()
	{
		if (GUID.Equals(Guid.Empty))
		{
			throw new ApplicationException("Required value not specified: GUID.");
		}
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (AccountPasswordHashID == 0)
		{
			throw new ApplicationException("Required value not specified: AccountPasswordHashID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@GUID", GUID);
		dbHelper.SQLParameters.AddWithValue("@AccountID", AccountID);
		dbHelper.SQLParameters.AddWithValue("@AccountEmailAddressID", AccountEmailAddressID.HasValue ? ((object)AccountEmailAddressID.Value) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@AccountPasswordHashID", AccountPasswordHashID.HasValue ? ((object)AccountPasswordHashID.Value) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@IsValid", IsValid);
		dbHelper.SQLParameters.AddWithValue("@Created", Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", Updated);
		SqlParameter ID = dbHelper.SQLParameters.Add("@ID", SqlDbType.Int);
		ID.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[AccountSecurityTickets_InsertAccountSecurityTicket]", CommandType.StoredProcedure);
		this.ID = Convert.ToInt32(ID.Value);
	}

	public void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (GUID.Equals(Guid.Empty))
		{
			throw new ApplicationException("Required value not specified: GUID.");
		}
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (AccountPasswordHashID == 0)
		{
			throw new ApplicationException("Required value not specified: AccountPasswordHashID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.SQLParameters.AddWithValue("@GUID", GUID);
		dbHelper.SQLParameters.AddWithValue("@AccountID", AccountID);
		dbHelper.SQLParameters.AddWithValue("@AccountEmailAddressID", AccountEmailAddressID.HasValue ? ((object)AccountEmailAddressID.Value) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@AccountPasswordHashID", AccountPasswordHashID.HasValue ? ((object)AccountPasswordHashID.Value) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@IsValid", IsValid);
		dbHelper.SQLParameters.AddWithValue("@Created", Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", Updated);
		dbHelper.ExecuteSQLScalar("[dbo].[AccountSecurityTickets_UpdateAccountSecurityTicketByID]", CommandType.StoredProcedure);
	}

	private static AccountSecurityTicketDAL BuildDAL(SqlDataReader reader)
	{
		AccountSecurityTicketDAL dal = new AccountSecurityTicketDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.GUID = (Guid)reader["GUID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.AccountEmailAddressID = (reader["AccountEmailAddressID"].Equals(DBNull.Value) ? null : ((int?)reader["AccountEmailAddressID"]));
			dal.AccountPasswordHashID = (reader["AccountPasswordHashID"].Equals(DBNull.Value) ? null : ((int?)reader["AccountPasswordHashID"]));
			dal.IsValid = (bool)reader["IsValid"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static AccountSecurityTicketDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		AccountSecurityTicketDAL dal = null;
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AccountSecurityTickets_GetAccountSecurityTicketByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static AccountSecurityTicketDAL Get(string guid)
	{
		if (guid.Trim().Length == 0)
		{
			return null;
		}
		AccountSecurityTicketDAL dal = null;
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@GUID", guid);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AccountSecurityTickets_GetAccountSecurityTicketByGUID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static int GetTotalNumberOfValidAccountSecurityTickets(long accountId)
	{
		if (accountId == 0L)
		{
			return 0;
		}
		object count;
		using (DbHelper dbHelper = new DbHelper(ConnectionString))
		{
			dbHelper.SQLParameters.AddWithValue("@AccountID", accountId);
			count = dbHelper.ExecuteSQLScalar("[dbo].[AccountSecurityTickets_GetTotalNumberOfValidAccountSecurityTicketsByAccountID]", CommandType.StoredProcedure);
		}
		return Convert.ToInt32(count);
	}

	public static ICollection<int> GetValidAccountSecurityTicketIDsPaged(long accountId, int startRowIndex, int maximumRows)
	{
		if (accountId == 0L)
		{
			return new List<int>();
		}
		ICollection<int> ids = new List<int>();
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AccountID", accountId);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[AccountSecurityTickets_GetValidAccountSecurityTicketIDsByAccountID_Paged]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<int>(reader);
	}
}
