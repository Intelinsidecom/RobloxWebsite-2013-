using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class MembershipMigrationStatusDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPremiumFeatures;

	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal int OriginalPremiumFeatureID { get; set; }

	internal int UpdatedPremiumFeatureID { get; set; }

	internal DateTime? PremiumStartDate { get; set; }

	internal int RobuxDistributionAmount { get; set; }

	internal int MigrationStateID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static MembershipMigrationStatusDAL BuildDAL(IDictionary<string, object> record)
	{
		return new MembershipMigrationStatusDAL
		{
			ID = (long)record["ID"],
			AccountID = (long)record["AccountID"],
			OriginalPremiumFeatureID = (int)record["OriginalPremiumFeatureID"],
			UpdatedPremiumFeatureID = (int)record["UpdatedPremiumFeatureID"],
			PremiumStartDate = ((record["PremiumStartDate"] == null) ? null : new DateTime?(DateTime.SpecifyKind((DateTime)record["PremiumStartDate"], DateTimeKind.Local))),
			RobuxDistributionAmount = (int)record["RobuxDistributionAmount"],
			MigrationStateID = (int)record["MigrationStateID"],
			Created = DateTime.SpecifyKind((DateTime)record["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)record["UpdatedUtc"], DateTimeKind.Utc)
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPremiumFeatures.Delete("MembershipMigrationStatuses_DeleteMembershipMigrationStatusByID", ID);
	}

	internal static MembershipMigrationStatusDAL Get(long id)
	{
		return RobloxDatabase.RobloxPremiumFeatures.Get("MembershipMigrationStatuses_GetMembershipMigrationStatusByID", id, BuildDAL);
	}

	internal static MembershipMigrationStatusDAL GetByAccountId(long accountId)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountID", accountId)
		};
		return RobloxDatabase.RobloxPremiumFeatures.Lookup("MembershipMigrationStatuses_GetMembershipMigrationStatusByAccountID", BuildDAL, queryParameters);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@OriginalPremiumFeatureID", OriginalPremiumFeatureID),
			new SqlParameter("@UpdatedPremiumFeatureID", UpdatedPremiumFeatureID),
			new SqlParameter("@PremiumStartDate", PremiumStartDate.HasValue ? ((object)PremiumStartDate.Value.ToLocalTime()) : DBNull.Value),
			new SqlParameter("@RobuxDistributionAmount", RobuxDistributionAmount),
			new SqlParameter("@MigrationStateID", MigrationStateID),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		ID = RobloxDatabase.RobloxPremiumFeatures.Insert<long>("MembershipMigrationStatuses_InsertMembershipMigrationStatus", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@OriginalPremiumFeatureID", OriginalPremiumFeatureID),
			new SqlParameter("@UpdatedPremiumFeatureID", UpdatedPremiumFeatureID),
			new SqlParameter("@PremiumStartDate", PremiumStartDate.HasValue ? ((object)PremiumStartDate.Value.ToLocalTime()) : DBNull.Value),
			new SqlParameter("@RobuxDistributionAmount", RobuxDistributionAmount),
			new SqlParameter("@MigrationStateID", MigrationStateID),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		RobloxDatabase.RobloxPremiumFeatures.Update("MembershipMigrationStatuses_UpdateMembershipMigrationStatusByID", queryParameters);
	}

	internal static ICollection<MembershipMigrationStatusDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxPremiumFeatures.MultiGet("MembershipMigrationStatuses_GetMembershipMigrationStatusesByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<MembershipMigrationStatusDAL> GetOrCreateMembershipMigrationStatus(long accountId, int originalPremiumFeatureId, int updatedPremiumFeatureId, DateTime? premiumStartDate, int robuxDistributionAmount, int migrationStateId)
	{
		if (accountId <= 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountId", accountId),
			new SqlParameter("@OriginalPremiumFeatureId", originalPremiumFeatureId),
			new SqlParameter("@UpdatedPremiumFeatureId", updatedPremiumFeatureId),
			new SqlParameter("@PremiumStartDate", premiumStartDate.HasValue ? ((object)premiumStartDate) : DBNull.Value),
			new SqlParameter("@RobuxDistributionAmount", robuxDistributionAmount),
			new SqlParameter("@MigrationStateId", migrationStateId)
		};
		return RobloxDatabase.RobloxPremiumFeatures.GetOrCreate("MembershipMigrationStatuses_GetOrCreateMembershipMigrationStatus", BuildDAL, queryParameters);
	}
}
