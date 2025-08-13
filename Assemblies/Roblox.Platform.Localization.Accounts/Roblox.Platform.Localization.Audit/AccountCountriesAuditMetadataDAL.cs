using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;
using Roblox.Platform.Core;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesAuditMetadataDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountCountriesAudit;

	internal long ID { get; set; }

	internal Guid AccountCountriesAuditEntryPublicId { get; set; }

	internal long AccountCountriesAuditEntryAuditId { get; set; }

	internal byte AccountCountriesAuditMetadataTypeId { get; set; }

	internal byte ChangeAgentTypeId { get; set; }

	internal long? ChangeAgentTargetId { get; set; }

	internal DateTime Created { get; set; }

	private static AccountCountriesAuditMetadataDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountCountriesAuditMetadataDAL
		{
			ID = (long)record["ID"],
			AccountCountriesAuditEntryPublicId = (Guid)record["AccountCountriesAuditEntryPublicID"],
			AccountCountriesAuditEntryAuditId = (long)record["AccountCountriesAuditEntryAudit-ID"],
			AccountCountriesAuditMetadataTypeId = (byte)record["AccountCountriesAuditMetadataTypeID"],
			ChangeAgentTypeId = (byte)record["ChangeAgentTypeID"],
			ChangeAgentTargetId = (long?)record["ChangeAgentTargetID"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountCountriesAudit.Delete("AccountCountriesAuditMetadata_DeleteAccountCountriesAuditMetadataByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountCountriesAuditEntryPublicID", AccountCountriesAuditEntryPublicId),
			new SqlParameter("@AccountCountriesAuditEntryAudit_ID", AccountCountriesAuditEntryAuditId),
			new SqlParameter("@AccountCountriesAuditMetadataTypeID", AccountCountriesAuditMetadataTypeId),
			new SqlParameter("@ChangeAgentTypeID", ChangeAgentTypeId),
			new SqlParameter("@ChangeAgentTargetID", ChangeAgentTargetId.HasValue ? ((object)ChangeAgentTargetId) : DBNull.Value),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccountCountriesAudit.Insert<long>("AccountCountriesAuditMetadata_InsertAccountCountriesAuditMetadata", queryParameters);
	}

	internal static AccountCountriesAuditMetadataDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountCountriesAudit.Get("AccountCountriesAuditMetadata_GetAccountCountriesAuditMetadataByID", id, BuildDAL);
	}

	internal static ICollection<AccountCountriesAuditMetadataDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountCountriesAudit.MultiGet("AccountCountriesAuditMetadata_GetAccountCountriesAuditMetadataByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetAccountCountriesAuditMetadataIDsByAuditIDAndMetadataTypeID(long accountCountriesAuditEntryAuditId, byte accountCountriesAuditMetadataTypeId, int count, long? exclusiveStartId)
	{
		if (accountCountriesAuditEntryAuditId == 0L)
		{
			throw new PlatformArgumentException("Parameter 'accountCountriesAuditEntryAudit_Id' cannot be null, empty or the default value.");
		}
		if (accountCountriesAuditMetadataTypeId == 0)
		{
			throw new PlatformArgumentException("Parameter 'accountCountriesAuditMetadataTypeId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new PlatformArgumentException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new PlatformArgumentException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		SqlParameter[] obj = new SqlParameter[4]
		{
			new SqlParameter("@AccountCountriesAuditEntryAudit_ID", accountCountriesAuditEntryAuditId),
			new SqlParameter("@AccountCountriesAuditMetadataTypeID", accountCountriesAuditMetadataTypeId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartId;
		obj[3] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAccountCountriesAudit.GetIDCollection<long>("AccountCountriesAuditMetadata_GetAccountCountriesAuditMetadataIDsByAudit-IDAndMetadataTypeID", queryParameters);
	}
}
