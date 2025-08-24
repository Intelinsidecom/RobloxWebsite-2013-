using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.DataAccess;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetsAuditEntryEntityFactory : IAssetsAuditEntryEntityFactory, IAuditEntryEntityFactory<IAssetsAuditEntryEntity>, IDomainFactory<AssetDomainFactories>, IDomainObject<AssetDomainFactories>
{
	public AssetDomainFactories DomainFactories { get; }

	public IAssetsAuditEntryEntity Create(AssetDAL sourceDAL)
	{
		AssetsAuditEntryCAL assetsAuditEntryCAL = new AssetsAuditEntryCAL();
		assetsAuditEntryCAL.Audit_AssetCategories = sourceDAL.AssetCategories;
		assetsAuditEntryCAL.Audit_AssetGenres = sourceDAL.AssetGenres;
		assetsAuditEntryCAL.Audit_AssetHashID = sourceDAL.AssetHashID;
		assetsAuditEntryCAL.Audit_AssetTypeID = sourceDAL.AssetTypeID;
		assetsAuditEntryCAL.Audit_Created = sourceDAL.Created;
		assetsAuditEntryCAL.Audit_CreatorID = sourceDAL.CreatorID;
		assetsAuditEntryCAL.Audit_CurrentVersionID = sourceDAL.CurrentVersionID;
		assetsAuditEntryCAL.Audit_Description = sourceDAL.Description;
		assetsAuditEntryCAL.Audit_Hash = sourceDAL.Hash;
		assetsAuditEntryCAL.Audit_ID = sourceDAL.ID;
		assetsAuditEntryCAL.Audit_Name = sourceDAL.Name;
		assetsAuditEntryCAL.Audit_Updated = sourceDAL.Updated;
		assetsAuditEntryCAL.Audit_IsArchived = sourceDAL.IsArchived;
		assetsAuditEntryCAL.Save();
		return CalToCachedMssql(assetsAuditEntryCAL);
	}

	public ICollection<IAssetsAuditEntryEntity> GetByPublicIds(ICollection<Guid> publicIds)
	{
		return publicIds.Select(AssetsAuditEntryCAL.GetByPublicID).Select(CalToCachedMssql).ToArray();
	}

	public AssetsAuditEntryEntityFactory(AssetDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAssetsAuditEntryEntity Get(long id)
	{
		return CalToCachedMssql(AssetsAuditEntryCAL.Get(id));
	}

	public IAssetsAuditEntryEntity GetByPublicId(Guid publicId)
	{
		return CalToCachedMssql(AssetsAuditEntryCAL.GetByPublicID(publicId));
	}

	private static IAssetsAuditEntryEntity CalToCachedMssql(AssetsAuditEntryCAL cal)
	{
		if (cal != null)
		{
			return new AssetsAuditEntryEntity
			{
				Id = cal.ID,
				PublicId = cal.PublicID,
				Audit_Id = cal.Audit_ID,
				Audit_AssetTypeId = cal.Audit_AssetTypeID,
				Audit_Hash = cal.Audit_Hash,
				Audit_Name = cal.Audit_Name,
				Audit_Description = cal.Audit_Description,
				Audit_Created = cal.Audit_Created,
				Audit_Updated = cal.Audit_Updated,
				Audit_CreatorId = cal.Audit_CreatorID,
				Audit_CurrentVersionId = cal.Audit_CurrentVersionID,
				Audit_AssetHashId = cal.Audit_AssetHashID,
				Audit_AssetGenres = cal.Audit_AssetGenres,
				Audit_AssetCategories = cal.Audit_AssetCategories,
				Audit_IsArchived = cal.Audit_IsArchived,
				Created = cal.Created
			};
		}
		return null;
	}
}
