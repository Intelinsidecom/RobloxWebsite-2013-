using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class EmailAddressDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxEmailAddresses.GetConnectionString();

	public int ID { get; set; }

	public string Address { get; set; }

	public bool IsBlacklisted { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	/// <summary>
	/// Whether this email address has been Verified by external service
	/// </summary>
	public bool IsApproved { get; set; }

	/// <summary>
	/// Whether this email address is valid, as determined by external
	/// service
	/// </summary>
	public bool IsReviewed { get; set; }

	/// <summary>
	/// The dateTime of when this email has been Verified.
	/// </summary>
	public DateTime ReviewedUtc { get; set; }

	/// <summary>
	/// UTC migration
	/// </summary>
	public DateTime CreatedUtc { get; set; }

	/// <summary>
	/// UTC migration
	/// </summary>
	public DateTime UpdatedUtc { get; set; }

	public void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[EmailAddresses_DeleteEmailAddressByID]", queryParameters));
	}

	public void Insert()
	{
		if (Created == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: Created");
		}
		if (Updated == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: Updated");
		}
		if (CreatedUtc == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: CreatedUtc");
		}
		if (UpdatedUtc == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: UpdatedUtc");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@Address", Address),
			new SqlParameter("@IsBlacklisted", IsBlacklisted),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@CreatedUtc", CreatedUtc),
			new SqlParameter("@UpdatedUtc", UpdatedUtc)
		};
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "[dbo].[EmailAddresses_InsertEmailAddress]", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (Created == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		if (CreatedUtc == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: CreatedUtc.");
		}
		if (UpdatedUtc == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: UpdatedUtc.");
		}
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Address", Address),
			new SqlParameter("@IsBlacklisted", IsBlacklisted),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@IsApproved", IsApproved),
			new SqlParameter("@IsReviewed", IsReviewed),
			new SqlParameter("@ReviewedUtc", ReviewedUtc.Equals(DateTime.MinValue) ? DBNull.Value : ((object)ReviewedUtc)),
			new SqlParameter("@CreatedUtc", CreatedUtc),
			new SqlParameter("@UpdatedUtc", UpdatedUtc)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[EmailAddresses_UpdateEmailAddressByID]", queryParameters));
	}

	private static EmailAddressDAL BuildDAL(SqlDataReader reader)
	{
		EmailAddressDAL dal = new EmailAddressDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Address = (string)reader["Address"];
			dal.IsBlacklisted = (bool)reader["IsBlacklisted"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.IsApproved = (reader["IsApproved"] as bool?) ?? false;
			dal.IsReviewed = (reader["IsReviewed"] as bool?) ?? false;
			dal.ReviewedUtc = (reader["ReviewedUtc"] as DateTime?) ?? DateTime.MinValue;
			dal.CreatedUtc = (reader["CreatedUtc"] as DateTime?) ?? DateTime.MinValue;
			dal.UpdatedUtc = (reader["UpdatedUtc"] as DateTime?) ?? DateTime.MinValue;
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static EmailAddressDAL Get(int id)
	{
		if (id == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[EmailAddresses_GetEmailAddressByID]", queryParameters), BuildDAL);
	}

	public static ICollection<EmailAddressDAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "[dbo].[EmailAddresses_GetEmailAddressesByIDs]"), ids, BuildDALCollection);
	}

	public static EmailAddressDAL Get(string address)
	{
		if (string.IsNullOrEmpty(address))
		{
			throw new ApplicationException("Required value not specified: Address.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Address", address)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[EmailAddresses_GetEmailAddressByAddress]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<EmailAddressDAL> GetOrCreate(string address)
	{
		if (string.IsNullOrEmpty(address))
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Address", address)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[EmailAddresses_GetOrCreateEmailAddress]", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetBlacklistedEmailAddressIDsPaged(int startRowIndex, int maximumRows)
	{
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<int>();
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[EmailAddresses_GetBlacklistedEmailAddressIDs_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfBlacklistedEmailAddresses()
	{
		SqlParameter[] queryParameters = new SqlParameter[0];
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "[dbo].[EmailAddresses_GetTotalNumberOfBlacklistedEmailAddresses]", queryParameters));
	}

	private static List<EmailAddressDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<EmailAddressDAL> dals = new List<EmailAddressDAL>();
		while (reader.HasRows)
		{
			EmailAddressDAL dal = BuildDAL(reader);
			dals.Add(dal);
		}
		return dals;
	}
}
