using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

public class RobuxStipendDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxRobuxStipends.GetConnectionString();

	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal byte RobuxStipendQuantityTypeID { get; set; }

	internal DateTime? LastAwarded { get; set; }

	internal DateTime Expiration { get; set; }

	internal DateTime? LeaseExpiration { get; set; }

	internal Guid? WorkerID { get; set; }

	internal DateTime? Completed { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal byte? RobuxStipendFrequencyTypeID { get; set; }

	internal DateTime? NextDistribution { get; set; }

	internal RobuxStipendDAL()
	{
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[RobuxStipends_DeleteRobuxStipendByID]", queryParameters));
	}

	internal void Insert()
	{
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (RobuxStipendQuantityTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: RobuxStipendQuantityTypeID.");
		}
		if (Expiration.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Expiration.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		if (!NextDistribution.HasValue || NextDistribution.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: NextDistribution.");
		}
		SqlParameter[] obj = new SqlParameter[11]
		{
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@RobuxStipendQuantityTypeID", RobuxStipendQuantityTypeID),
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		DateTime? lastAwarded = LastAwarded;
		obj[2] = new SqlParameter("@LastAwarded", lastAwarded.HasValue ? ((object)lastAwarded.GetValueOrDefault()) : DBNull.Value);
		obj[3] = new SqlParameter("@Expiration", Expiration);
		lastAwarded = LeaseExpiration;
		obj[4] = new SqlParameter("@LeaseExpiration", lastAwarded.HasValue ? ((object)lastAwarded.GetValueOrDefault()) : DBNull.Value);
		Guid? workerID = WorkerID;
		obj[5] = new SqlParameter("@WorkerID", workerID.HasValue ? ((object)workerID.GetValueOrDefault()) : DBNull.Value);
		lastAwarded = Completed;
		obj[6] = new SqlParameter("@Completed", lastAwarded.HasValue ? ((object)lastAwarded.GetValueOrDefault()) : DBNull.Value);
		obj[7] = new SqlParameter("@Created", Created);
		obj[8] = new SqlParameter("@Updated", Updated);
		byte? robuxStipendFrequencyTypeID = RobuxStipendFrequencyTypeID;
		obj[9] = new SqlParameter("@RobuxStipendFrequencyTypeID", robuxStipendFrequencyTypeID.HasValue ? ((object)robuxStipendFrequencyTypeID.GetValueOrDefault()) : DBNull.Value);
		lastAwarded = NextDistribution;
		obj[10] = new SqlParameter("@NextDistribution", lastAwarded.HasValue ? ((object)lastAwarded.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[RobuxStipends_InsertRobuxStipend]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	internal void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (RobuxStipendQuantityTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: RobuxStipendQuantityTypeID.");
		}
		if (Expiration.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Expiration.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] obj = new SqlParameter[12]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@RobuxStipendQuantityTypeID", RobuxStipendQuantityTypeID),
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		DateTime? lastAwarded = LastAwarded;
		obj[3] = new SqlParameter("@LastAwarded", lastAwarded.HasValue ? ((object)lastAwarded.GetValueOrDefault()) : DBNull.Value);
		obj[4] = new SqlParameter("@Expiration", Expiration);
		lastAwarded = LeaseExpiration;
		obj[5] = new SqlParameter("@LeaseExpiration", lastAwarded.HasValue ? ((object)lastAwarded.GetValueOrDefault()) : DBNull.Value);
		Guid? workerID = WorkerID;
		obj[6] = new SqlParameter("@WorkerID", workerID.HasValue ? ((object)workerID.GetValueOrDefault()) : DBNull.Value);
		lastAwarded = Completed;
		obj[7] = new SqlParameter("@Completed", lastAwarded.HasValue ? ((object)lastAwarded.GetValueOrDefault()) : DBNull.Value);
		obj[8] = new SqlParameter("@Created", Created);
		obj[9] = new SqlParameter("@Updated", Updated);
		byte? robuxStipendFrequencyTypeID = RobuxStipendFrequencyTypeID;
		obj[10] = new SqlParameter("@RobuxStipendFrequencyTypeID", robuxStipendFrequencyTypeID.HasValue ? ((object)robuxStipendFrequencyTypeID.GetValueOrDefault()) : DBNull.Value);
		lastAwarded = NextDistribution;
		obj[11] = new SqlParameter("@NextDistribution", lastAwarded.HasValue ? ((object)lastAwarded.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[RobuxStipends_UpdateRobuxStipendByID]", queryParameters));
	}

	private static RobuxStipendDAL BuildDAL(SqlDataReader reader)
	{
		RobuxStipendDAL dal = new RobuxStipendDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.RobuxStipendQuantityTypeID = (byte)reader["RobuxStipendQuantityTypeID"];
			dal.LastAwarded = (reader["LastAwarded"].Equals(DBNull.Value) ? null : ((DateTime?)reader["LastAwarded"]));
			dal.Expiration = (DateTime)reader["Expiration"];
			dal.LeaseExpiration = (reader["LeaseExpiration"].Equals(DBNull.Value) ? null : ((DateTime?)reader["LeaseExpiration"]));
			dal.WorkerID = (reader["WorkerID"].Equals(DBNull.Value) ? null : ((Guid?)reader["WorkerID"]));
			dal.Completed = (reader["Completed"].Equals(DBNull.Value) ? null : ((DateTime?)reader["Completed"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.RobuxStipendFrequencyTypeID = (reader["RobuxStipendFrequencyTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["RobuxStipendFrequencyTypeID"]));
			dal.NextDistribution = (reader["NextDistribution"].Equals(DBNull.Value) ? null : ((DateTime?)reader["NextDistribution"]));
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static RobuxStipendDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobuxStipends_GetRobuxStipendByID]", queryParameters), BuildDAL);
	}

	internal static ICollection<long> LeaseRobuxStipendsToAward(Guid workerId, int numberOfItems, int leaseDurationInMinutes)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@WorkerID", workerId),
			new SqlParameter("@NumberOfItems", numberOfItems),
			new SqlParameter("@LeaseDurationInMinutes", leaseDurationInMinutes)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[RobuxStipends_LeaseRobuxStipendsToAward]", queryParameters));
	}

	internal static ICollection<long> LeaseRobuxStipendsToAwardV2(Guid workerId, int numberOfItems, int leaseDurationInMinutes)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@WorkerID", workerId),
			new SqlParameter("@NumberOfItems", numberOfItems),
			new SqlParameter("@LeaseDurationInMinutes", leaseDurationInMinutes)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[RobuxStipends_LeaseRobuxStipendsToAwardV2]", queryParameters));
	}

	internal static RobuxStipendDAL LeaseRobuxStipendToAward(long id, Guid workerId, int leaseDurationInMinutes)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", id),
			new SqlParameter("@WorkerID", workerId),
			new SqlParameter("@LeaseDurationInMinutes", leaseDurationInMinutes)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[RobuxStipends_LeaseRobuxStipendToAward]", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetByAccountId(long accountId)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountID", accountId)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[RobuxStipends_GetRobuxStipendIDsByAccountID]", queryParameters));
	}
}
