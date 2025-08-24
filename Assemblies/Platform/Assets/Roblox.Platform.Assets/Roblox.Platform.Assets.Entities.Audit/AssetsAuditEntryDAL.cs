using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetsAuditEntryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAssetsAudit;

	internal long ID { get; set; }

	internal Guid PublicID { get; set; }

	internal long Audit_ID { get; set; }

	internal int Audit_AssetTypeID { get; set; }

	internal string Audit_Hash { get; set; }

	internal string Audit_Name { get; set; }

	internal string Audit_Description { get; set; }

	internal DateTime Audit_Created { get; set; }

	internal DateTime Audit_Updated { get; set; }

	internal long Audit_CreatorID { get; set; }

	internal long Audit_CurrentVersionID { get; set; }

	internal long? Audit_AssetHashID { get; set; }

	internal long Audit_AssetGenres { get; set; }

	internal long Audit_AssetCategories { get; set; }

	internal bool? Audit_IsArchived { get; set; }

	internal DateTime Created { get; set; }

	private static AssetsAuditEntryDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AssetsAuditEntryDAL
		{
			ID = (long)record["ID"],
			PublicID = (Guid)record["PublicID"],
			Audit_ID = (long)record["Audit-ID"],
			Audit_AssetTypeID = (int)record["Audit-AssetTypeID"],
			Audit_Hash = (string)record["Audit-Hash"],
			Audit_Name = (string)record["Audit-Name"],
			Audit_Description = (string)record["Audit-Description"],
			Audit_Created = (DateTime)record["Audit-Created"],
			Audit_Updated = (DateTime)record["Audit-Updated"],
			Audit_CreatorID = (long)record["Audit-CreatorID"],
			Audit_CurrentVersionID = (long)record["Audit-CurrentVersionID"],
			Audit_AssetHashID = (long?)record["Audit-AssetHashID"],
			Audit_AssetGenres = (long)record["Audit-AssetGenres"],
			Audit_AssetCategories = (long)record["Audit-AssetCategories"],
			Audit_IsArchived = (bool?)record["Audit-IsArchived"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAssetsAudit.Delete("AssetsAuditEntries_DeleteAssetsAuditEntryByID", ID);
	}

	internal static AssetsAuditEntryDAL Get(long id)
	{
		return RobloxDatabase.RobloxAssetsAudit.Get("AssetsAuditEntries_GetAssetsAuditEntryByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] obj = new SqlParameter[16]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PublicID", PublicID),
			new SqlParameter("@Audit_ID", Audit_ID),
			new SqlParameter("@Audit_AssetTypeID", Audit_AssetTypeID),
			new SqlParameter("@Audit_Hash", Audit_Hash),
			new SqlParameter("@Audit_Name", Audit_Name),
			new SqlParameter("@Audit_Description", string.IsNullOrEmpty(Audit_Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Audit_Description)),
			new SqlParameter("@Audit_Created", Audit_Created),
			new SqlParameter("@Audit_Updated", Audit_Updated),
			new SqlParameter("@Audit_CreatorID", Audit_CreatorID),
			new SqlParameter("@Audit_CurrentVersionID", Audit_CurrentVersionID),
			new SqlParameter("@Audit_AssetHashID", Audit_AssetHashID.HasValue ? ((object)Audit_AssetHashID) : DBNull.Value),
			new SqlParameter("@Audit_AssetGenres", Audit_AssetGenres),
			new SqlParameter("@Audit_AssetCategories", Audit_AssetCategories),
			null,
			null
		};
		bool? audit_IsArchived = Audit_IsArchived;
		obj[14] = new SqlParameter("@Audit_IsArchived", audit_IsArchived.HasValue ? ((object)audit_IsArchived.GetValueOrDefault()) : DBNull.Value);
		obj[15] = new SqlParameter("@Created", Created);
		SqlParameter[] queryParameters = obj;
		ID = RobloxDatabase.RobloxAssetsAudit.Insert<long>("AssetsAuditEntries_InsertAssetsAuditEntry", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] obj = new SqlParameter[16]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PublicID", PublicID),
			new SqlParameter("@Audit_ID", Audit_ID),
			new SqlParameter("@Audit_AssetTypeID", Audit_AssetTypeID),
			new SqlParameter("@Audit_Hash", Audit_Hash),
			new SqlParameter("@Audit_Name", Audit_Name),
			new SqlParameter("@Audit_Description", string.IsNullOrEmpty(Audit_Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Audit_Description)),
			new SqlParameter("@Audit_Created", Audit_Created),
			new SqlParameter("@Audit_Updated", Audit_Updated),
			new SqlParameter("@Audit_CreatorID", Audit_CreatorID),
			new SqlParameter("@Audit_CurrentVersionID", Audit_CurrentVersionID),
			new SqlParameter("@Audit_AssetHashID", Audit_AssetHashID.HasValue ? ((object)Audit_AssetHashID) : DBNull.Value),
			new SqlParameter("@Audit_AssetGenres", Audit_AssetGenres),
			new SqlParameter("@Audit_AssetCategories", Audit_AssetCategories),
			null,
			null
		};
		bool? audit_IsArchived = Audit_IsArchived;
		obj[14] = new SqlParameter("@Audit_IsArchived", audit_IsArchived.HasValue ? ((object)audit_IsArchived.GetValueOrDefault()) : DBNull.Value);
		obj[15] = new SqlParameter("@Created", Created);
		SqlParameter[] queryParameters = obj;
		RobloxDatabase.RobloxAssetsAudit.Update("AssetsAuditEntries_UpdateAssetsAuditEntryByID", queryParameters);
	}

	internal static ICollection<AssetsAuditEntryDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAssetsAudit.MultiGet("AssetsAuditEntries_GetAssetsAuditEntriesByIDs", ids, BuildDAL);
	}

	internal static AssetsAuditEntryDAL GetAssetsAuditEntryByPublicID(Guid publicId)
	{
		if (publicId == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PublicID", publicId)
		};
		return RobloxDatabase.RobloxAssetsAudit.Lookup("AssetsAuditEntries_GetAssetsAuditEntryByPublicID", BuildDAL, queryParameters);
	}
}
