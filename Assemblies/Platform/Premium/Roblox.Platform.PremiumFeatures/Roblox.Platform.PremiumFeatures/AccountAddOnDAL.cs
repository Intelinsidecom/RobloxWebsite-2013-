using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;
using Roblox.Properties;

namespace Roblox.PremiumFeatures;

[Serializable]
public class AccountAddOnDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPremiumFeatures;

	private static int _AccountAddOnCommandTimeoutInSeconds => Settings.Default.AccountAddOnCommandTimeoutInSeconds;

	private static bool _IsPremiumFeatureApplicationIntentEnabled => Settings.Default.IsPremiumFeatureApplicationIntentEnabled;

	internal int ID { get; set; }

	internal long AccountID { get; set; }

	internal int PremiumFeatureID { get; set; }

	internal DateTime? Renewal { get; set; }

	internal DateTime Expiration { get; set; }

	internal long? RobuxStipendID { get; set; }

	internal DateTime? LeaseExpiration { get; set; }

	internal Guid? WorkerID { get; set; }

	internal DateTime? Completed { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal DateTime? RenewedSince { get; set; }

	internal AccountAddOnDAL()
	{
	}

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxPremiumFeatures.Delete("AccountAddOns_DeleteAccountAddOnByID", ID, _AccountAddOnCommandTimeoutInSeconds, _IsPremiumFeatureApplicationIntentEnabled);
	}

	internal void Insert()
	{
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (PremiumFeatureID == 0)
		{
			throw new ApplicationException("Required value not specified: PremiumFeatureID.");
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
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@PremiumFeatureID", PremiumFeatureID),
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
		DateTime? renewal = Renewal;
		obj[3] = new SqlParameter("@Renewal", renewal.HasValue ? ((object)renewal.GetValueOrDefault()) : DBNull.Value);
		obj[4] = new SqlParameter("@Expiration", Expiration);
		long? robuxStipendID = RobuxStipendID;
		obj[5] = new SqlParameter("@RobuxStipendID", robuxStipendID.HasValue ? ((object)robuxStipendID.GetValueOrDefault()) : DBNull.Value);
		renewal = LeaseExpiration;
		obj[6] = new SqlParameter("@LeaseExpiration", renewal.HasValue ? ((object)renewal.GetValueOrDefault()) : DBNull.Value);
		Guid? workerID = WorkerID;
		obj[7] = new SqlParameter("@WorkerID", workerID.HasValue ? ((object)workerID.GetValueOrDefault()) : DBNull.Value);
		renewal = Completed;
		obj[8] = new SqlParameter("@Completed", renewal.HasValue ? ((object)renewal.GetValueOrDefault()) : DBNull.Value);
		obj[9] = new SqlParameter("@Created", Created);
		obj[10] = new SqlParameter("@Updated", Updated);
		renewal = RenewedSince;
		obj[11] = new SqlParameter("@RenewedSince", renewal.HasValue ? ((object)renewal.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		ID = RobloxDatabase.RobloxPremiumFeatures.Insert<int>("AccountAddOns_InsertAccountAddOn", _AccountAddOnCommandTimeoutInSeconds, _IsPremiumFeatureApplicationIntentEnabled, queryParameters);
	}

	internal void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (PremiumFeatureID == 0)
		{
			throw new ApplicationException("Required value not specified: PremiumFeatureID.");
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
			new SqlParameter("@PremiumFeatureID", PremiumFeatureID),
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
		DateTime? renewal = Renewal;
		obj[3] = new SqlParameter("@Renewal", renewal.HasValue ? ((object)renewal.GetValueOrDefault()) : DBNull.Value);
		obj[4] = new SqlParameter("@Expiration", Expiration);
		long? robuxStipendID = RobuxStipendID;
		obj[5] = new SqlParameter("@RobuxStipendID", robuxStipendID.HasValue ? ((object)robuxStipendID.GetValueOrDefault()) : DBNull.Value);
		renewal = LeaseExpiration;
		obj[6] = new SqlParameter("@LeaseExpiration", renewal.HasValue ? ((object)renewal.GetValueOrDefault()) : DBNull.Value);
		Guid? workerID = WorkerID;
		obj[7] = new SqlParameter("@WorkerID", workerID.HasValue ? ((object)workerID.GetValueOrDefault()) : DBNull.Value);
		renewal = Completed;
		obj[8] = new SqlParameter("@Completed", renewal.HasValue ? ((object)renewal.GetValueOrDefault()) : DBNull.Value);
		obj[9] = new SqlParameter("@Created", Created);
		obj[10] = new SqlParameter("@Updated", Updated);
		renewal = RenewedSince;
		obj[11] = new SqlParameter("@RenewedSince", renewal.HasValue ? ((object)renewal.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		RobloxDatabase.RobloxPremiumFeatures.Update("AccountAddOns_UpdateAccountAddOnByID", _AccountAddOnCommandTimeoutInSeconds, _IsPremiumFeatureApplicationIntentEnabled, queryParameters);
	}

	private static AccountAddOnDAL BuildDAL(IDictionary<string, object> record)
	{
		AccountAddOnDAL dal = new AccountAddOnDAL
		{
			ID = (int)record["ID"],
			AccountID = Convert.ToInt64(record["AccountID"]),
			PremiumFeatureID = (int)record["PremiumFeatureID"],
			Renewal = ((record["Renewal"] == null) ? null : ((DateTime?)record["Renewal"])),
			Expiration = (DateTime)record["Expiration"],
			RobuxStipendID = ((record["RobuxStipendID"] == null) ? null : ((long?)record["RobuxStipendID"])),
			LeaseExpiration = ((record["LeaseExpiration"] == null) ? null : ((DateTime?)record["LeaseExpiration"])),
			WorkerID = ((record["WorkerID"] == null) ? null : ((Guid?)record["WorkerID"])),
			Completed = ((record["Completed"] == null) ? null : ((DateTime?)record["Completed"])),
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"],
			RenewedSince = ((record["RenewedSince"] == null) ? null : ((DateTime?)record["RenewedSince"]))
		};
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static ICollection<AccountAddOnDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxPremiumFeatures.MultiGet("AccountAddOns_GetAccountAddOnsByIDs", ids, BuildDAL, _AccountAddOnCommandTimeoutInSeconds, _IsPremiumFeatureApplicationIntentEnabled);
	}

	internal static AccountAddOnDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxPremiumFeatures.Get("AccountAddOns_GetAccountAddOnByID", id, BuildDAL, _AccountAddOnCommandTimeoutInSeconds, _IsPremiumFeatureApplicationIntentEnabled);
	}

	internal static AccountAddOnDAL GetSubscriptionByAccountId(long accountId)
	{
		if (accountId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@Now", DateTime.Now)
		};
		return RobloxDatabase.RobloxPremiumFeatures.Lookup("AccountAddOns_GetActiveSubscriptionByAccountID", BuildDAL, _AccountAddOnCommandTimeoutInSeconds, _IsPremiumFeatureApplicationIntentEnabled, queryParameters);
	}

	internal static ICollection<int> AccountAddOns_GetAccountAddOnIDsByPremiumFeatureIDRenewalIsNullAndExpirationRange_Paged(int premiumFeatureId, DateTime minimumExpiration, DateTime maximumExpiration, bool renewalIsNull, int startRowIndex, int maximumRows)
	{
		if (premiumFeatureId == 0)
		{
			throw new ApplicationException("Required value not specified: PremiumFeatureID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex");
		}
		if (maximumRows == 0)
		{
			throw new ApplicationException("Required value not specified: MaximumRows");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@PremiumFeatureId", premiumFeatureId),
			new SqlParameter("@MinimumExpiration", minimumExpiration),
			new SqlParameter("@MaximumExpiration", maximumExpiration),
			new SqlParameter("@RenewalIsNull", renewalIsNull),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxPremiumFeatures.GetIDCollection<int>("AccountAddOns_GetAccountAddOnIDsByPremiumFeatureIDRenewalIsNullAndExpirationRange_Paged", _AccountAddOnCommandTimeoutInSeconds, _IsPremiumFeatureApplicationIntentEnabled, queryParameters);
	}

	internal static ICollection<int> GetAccountAddOnIDsByAccountID(long accountId)
	{
		if (accountId == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountID", accountId)
		};
		return RobloxDatabase.RobloxPremiumFeatures.GetIDCollection<int>("AccountAddOns_GetAccountAddOnIDsByAccountID", _AccountAddOnCommandTimeoutInSeconds, _IsPremiumFeatureApplicationIntentEnabled, queryParameters);
	}

	internal static ICollection<int> LeaseAccountAddOnsToExpire(Guid workerId, int numberOfItems, int leaseDurationInMinutes)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@WorkerID", workerId),
			new SqlParameter("@NumberOfItems", numberOfItems),
			new SqlParameter("@LeaseDurationInMinutes", leaseDurationInMinutes)
		};
		return RobloxDatabase.RobloxPremiumFeatures.ExecuteReader("AccountAddOns_LeaseAccountAddOnsToExpire", queryParameters, CommandType.StoredProcedure, _AccountAddOnCommandTimeoutInSeconds, ApplicationIntent.ReadWrite).Select(BuildAccountAddOnId).ToList();
	}

	internal static AccountAddOnDAL LeaseAccountAddOnToMigrate(int id, Guid workerId, int leaseDurationInMinutes)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", id),
			new SqlParameter("@WorkerID", workerId),
			new SqlParameter("@LeaseDurationInMinutes", leaseDurationInMinutes)
		};
		return RobloxDatabase.RobloxPremiumFeatures.Lookup("AccountAddOns_LeaseAccountAddOnToMigrate", BuildDAL, _AccountAddOnCommandTimeoutInSeconds, includeApplicationIntent: false, queryParameters);
	}

	private static int BuildAccountAddOnId(IDictionary<string, object> row)
	{
		return (int)row["ID"];
	}
}
