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
internal class GrantedItemListActivationTaskDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPremiumFeatures;

	internal long ID { get; set; }

	internal byte GrantedItemTypeID { get; set; }

	internal long PremiumFeatureActivationTaskID { get; set; }

	internal Guid? WorkerID { get; set; }

	internal DateTime? Completed { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal DateTime? LeaseExpiration { get; set; }

	private static GrantedItemListActivationTaskDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GrantedItemListActivationTaskDAL
		{
			ID = (long)record["ID"],
			GrantedItemTypeID = (byte)record["GrantedItemTypeID"],
			PremiumFeatureActivationTaskID = (long)record["PremiumFeatureActivationTaskID"],
			WorkerID = (Guid?)record["WorkerID"],
			Completed = ((record["CompletedUtc"] == null) ? null : new DateTime?(DateTime.SpecifyKind((DateTime)record["CompletedUtc"], DateTimeKind.Utc))),
			Created = DateTime.SpecifyKind((DateTime)record["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)record["UpdatedUtc"], DateTimeKind.Utc),
			LeaseExpiration = ((record["LeaseExpirationUtc"] == null) ? null : new DateTime?(DateTime.SpecifyKind((DateTime)record["LeaseExpirationUtc"], DateTimeKind.Utc)))
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPremiumFeatures.Delete("GrantedItemListActivationTasks_DeleteGrantedItemListActivationTaskByID", ID);
	}

	internal static GrantedItemListActivationTaskDAL Get(long id)
	{
		return RobloxDatabase.RobloxPremiumFeatures.Get("GrantedItemListActivationTasks_GetGrantedItemListActivationTaskByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@GrantedItemTypeID", GrantedItemTypeID),
			new SqlParameter("@PremiumFeatureActivationTaskID", PremiumFeatureActivationTaskID),
			new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID) : DBNull.Value),
			new SqlParameter("@CompletedUtc", Completed.HasValue ? ((object)Completed.Value.ToUniversalTime()) : DBNull.Value),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime()),
			new SqlParameter("@LeaseExpirationUtc", LeaseExpiration.HasValue ? ((object)LeaseExpiration.Value.ToUniversalTime()) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxPremiumFeatures.Insert<long>("GrantedItemListActivationTasks_InsertGrantedItemListActivationTask", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@GrantedItemTypeID", GrantedItemTypeID),
			new SqlParameter("@PremiumFeatureActivationTaskID", PremiumFeatureActivationTaskID),
			new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID) : DBNull.Value),
			new SqlParameter("@CompletedUtc", Completed.HasValue ? ((object)Completed.Value.ToUniversalTime()) : DBNull.Value),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime()),
			new SqlParameter("@LeaseExpirationUtc", LeaseExpiration.HasValue ? ((object)LeaseExpiration.Value.ToUniversalTime()) : DBNull.Value)
		};
		RobloxDatabase.RobloxPremiumFeatures.Update("GrantedItemListActivationTasks_UpdateGrantedItemListActivationTaskByID", queryParameters);
	}

	internal static ICollection<GrantedItemListActivationTaskDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxPremiumFeatures.MultiGet("GrantedItemListActivationTasks_GetGrantedItemListActivationTasksByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<GrantedItemListActivationTaskDAL> GetOrCreateGrantedItemListActivationTask(byte grantedItemTypeId, long premiumFeatureActivationTaskId)
	{
		if (grantedItemTypeId == 0)
		{
			return null;
		}
		if (premiumFeatureActivationTaskId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@GrantedItemTypeID", grantedItemTypeId),
			new SqlParameter("@PremiumFeatureActivationTaskID", premiumFeatureActivationTaskId)
		};
		return RobloxDatabase.RobloxPremiumFeatures.GetOrCreate("GrantedItemListActivationTasks_GetOrCreateGrantedItemListActivationTask", BuildDAL, queryParameters);
	}

	internal static ICollection<long> LeaseTasks(byte grantedItemTypeId, Guid workerId, int leaseDurationInMinutes, int maxToLease)
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@GrantedItemTypeID", grantedItemTypeId),
			new SqlParameter("@WorkerID", workerId),
			new SqlParameter("@NumberOfTasks", maxToLease),
			new SqlParameter("@DurationInMinutes", leaseDurationInMinutes)
		};
		return RobloxDatabase.RobloxPremiumFeatures.GetIDCollection<long>("GrantedItemListActivationTasks_LeaseTasks", queryParameters);
	}
}
