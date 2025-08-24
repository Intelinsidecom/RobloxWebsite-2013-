using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Billing;

[ExcludeFromCodeCoverage]
public class MembershipMigrationAuditLogDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxBilling;

	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal int OriginalPremiumFeatureID { get; set; }

	internal int UpdatedPremiumFeatureID { get; set; }

	internal int OriginalProductID { get; set; }

	internal int UpdatedProductID { get; set; }

	internal decimal OriginalPrice { get; set; }

	internal decimal UpdatedPrice { get; set; }

	internal int RobuxGrantAmount { get; set; }

	internal long SaleID { get; set; }

	internal byte CurrencyTypeID { get; set; }

	internal DateTime? LastRobuxDistributionDate { get; set; }

	internal DateTime? UpdatedMembershipStartDate { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static MembershipMigrationAuditLogDAL BuildDAL(IDictionary<string, object> record)
	{
		return new MembershipMigrationAuditLogDAL
		{
			ID = (long)record["ID"],
			AccountID = (long)record["AccountID"],
			OriginalPremiumFeatureID = (int)record["OriginalPremiumFeatureID"],
			UpdatedPremiumFeatureID = (int)record["UpdatedPremiumFeatureID"],
			OriginalProductID = (int)record["OriginalProductID"],
			UpdatedProductID = (int)record["UpdatedProductID"],
			OriginalPrice = (decimal)record["OriginalPrice"],
			UpdatedPrice = (decimal)record["UpdatedPrice"],
			RobuxGrantAmount = (int)record["RobuxGrantAmount"],
			SaleID = (long)record["SaleID"],
			CurrencyTypeID = (byte)record["CurrencyTypeID"],
			LastRobuxDistributionDate = ((record["LastRobuxDistributionDate"] == null) ? null : new DateTime?(DateTime.SpecifyKind((DateTime)record["LastRobuxDistributionDate"], DateTimeKind.Utc))),
			UpdatedMembershipStartDate = ((record["UpdatedMembershipStartDate"] == null) ? null : new DateTime?(DateTime.SpecifyKind((DateTime)record["UpdatedMembershipStartDate"], DateTimeKind.Utc))),
			Created = DateTime.SpecifyKind((DateTime)record["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)record["UpdatedUtc"], DateTimeKind.Utc)
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxBilling.Delete("MembershipMigrationAuditLogs_DeleteMembershipMigrationAuditLogByID", ID);
	}

	internal static MembershipMigrationAuditLogDAL Get(long id)
	{
		return RobloxDatabase.RobloxBilling.Get("MembershipMigrationAuditLogs_GetMembershipMigrationAuditLogByID", id, BuildDAL);
	}

	internal static MembershipMigrationAuditLogDAL GetByAccountId(long accountId)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountID", accountId)
		};
		return RobloxDatabase.RobloxBilling.Lookup("MembershipMigrationAuditLogs_GetMembershipMigrationAuditLogByAccountID", BuildDAL, queryParameters);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[15]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@OriginalPremiumFeatureID", OriginalPremiumFeatureID),
			new SqlParameter("@UpdatedPremiumFeatureID", UpdatedPremiumFeatureID),
			new SqlParameter("@OriginalProductID", OriginalProductID),
			new SqlParameter("@UpdatedProductID", UpdatedProductID),
			new SqlParameter("@OriginalPrice", OriginalPrice),
			new SqlParameter("@UpdatedPrice", UpdatedPrice),
			new SqlParameter("@RobuxGrantAmount", RobuxGrantAmount),
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@CurrencyTypeID", CurrencyTypeID),
			new SqlParameter("@LastRobuxDistributionDate", LastRobuxDistributionDate.HasValue ? ((object)LastRobuxDistributionDate.Value.ToLocalTime()) : DBNull.Value),
			new SqlParameter("@UpdatedMembershipStartDate", UpdatedMembershipStartDate.HasValue ? ((object)UpdatedMembershipStartDate.Value.ToLocalTime()) : DBNull.Value),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		ID = RobloxDatabase.RobloxBilling.Insert<long>("MembershipMigrationAuditLogs_InsertMembershipMigrationAuditLog", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[15]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@OriginalPremiumFeatureID", OriginalPremiumFeatureID),
			new SqlParameter("@UpdatedPremiumFeatureID", UpdatedPremiumFeatureID),
			new SqlParameter("@OriginalProductID", OriginalProductID),
			new SqlParameter("@UpdatedProductID", UpdatedProductID),
			new SqlParameter("@OriginalPrice", OriginalPrice),
			new SqlParameter("@UpdatedPrice", UpdatedPrice),
			new SqlParameter("@RobuxGrantAmount", RobuxGrantAmount),
			new SqlParameter("@SaleID", SaleID),
			new SqlParameter("@CurrencyTypeID", CurrencyTypeID),
			new SqlParameter("@LastRobuxDistributionDate", LastRobuxDistributionDate.HasValue ? ((object)LastRobuxDistributionDate.Value.ToLocalTime()) : DBNull.Value),
			new SqlParameter("@UpdatedMembershipStartDate", UpdatedMembershipStartDate.HasValue ? ((object)UpdatedMembershipStartDate.Value.ToLocalTime()) : DBNull.Value),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		RobloxDatabase.RobloxBilling.Update("MembershipMigrationAuditLogs_UpdateMembershipMigrationAuditLogByID", queryParameters);
	}

	internal static ICollection<MembershipMigrationAuditLogDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxBilling.MultiGet("MembershipMigrationAuditLogs_GetMembershipMigrationAuditLogsByIDs", ids, BuildDAL);
	}
}
