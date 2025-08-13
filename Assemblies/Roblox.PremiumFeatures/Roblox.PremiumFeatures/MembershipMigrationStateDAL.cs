using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class MembershipMigrationStateDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPremiumFeatures;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static MembershipMigrationStateDAL BuildDAL(IDictionary<string, object> record)
	{
		return new MembershipMigrationStateDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = DateTime.SpecifyKind((DateTime)record["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)record["UpdatedUtc"], DateTimeKind.Utc)
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPremiumFeatures.Delete("MembershipMigrationStates_DeleteMembershipMigrationStateByID", ID);
	}

	internal static MembershipMigrationStateDAL Get(int id)
	{
		return RobloxDatabase.RobloxPremiumFeatures.Get("MembershipMigrationStates_GetMembershipMigrationStateByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		ID = RobloxDatabase.RobloxPremiumFeatures.Insert<int>("MembershipMigrationStates_InsertMembershipMigrationState", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		RobloxDatabase.RobloxPremiumFeatures.Update("MembershipMigrationStates_UpdateMembershipMigrationStateByID", queryParameters);
	}

	internal static ICollection<MembershipMigrationStateDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxPremiumFeatures.MultiGet("MembershipMigrationStates_GetMembershipMigrationStatesByIDs", ids, BuildDAL);
	}

	internal static MembershipMigrationStateDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxPremiumFeatures.Lookup("MembershipMigrationStates_GetMembershipMigrationStateByValue", BuildDAL, queryParameters);
	}
}
