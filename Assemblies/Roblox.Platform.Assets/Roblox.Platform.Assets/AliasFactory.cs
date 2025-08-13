using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Roblox.Paging;
using Roblox.Platform.Assets.Entities;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets;

internal class AliasFactory : IAliasFactory
{
	private IAlias Build(INamespace ns, Name nameEntity)
	{
		AliasType type;
		long targetId;
		if (!Settings.Default.NameTypeIDAndNameTargetIDContainInvalidValues && nameEntity.NameTypeID.HasValue && nameEntity.NameTargetID.HasValue)
		{
			type = (AliasType)nameEntity.NameTypeID.Value;
			targetId = nameEntity.NameTargetID.Value;
		}
		else if (nameEntity.AssetVersion.HasValue)
		{
			IAssetVersion byAssetIdAndVersionNumber = AssetVersionFactory.GetByAssetIdAndVersionNumber(nameEntity.AssetID, nameEntity.AssetVersion.Value);
			byAssetIdAndVersionNumber.VerifyIsNotNull();
			type = AliasType.AssetVersion;
			targetId = byAssetIdAndVersionNumber.Id;
		}
		else
		{
			type = AliasType.Asset;
			targetId = nameEntity.AssetID;
		}
		return new Alias(ns, nameEntity.ID, nameEntity.NameValue, type, targetId);
	}

	private long GetNamespaceIdByLookup(INamespace ns)
	{
		NamespaceType namespaceTypeEntity = NamespaceType.GetByValue(ns.Type);
		if (namespaceTypeEntity == null)
		{
			throw new UnknownNamespaceTypeException(ns.Type);
		}
		Namespace namespaceEntity = Namespace.GetByNamespaceTypeIDNamespaceTargetID(namespaceTypeEntity.ID, ns.TargetId);
		if (namespaceEntity == null)
		{
			namespaceEntity = Namespace.CreateNew(namespaceTypeEntity.ID, ns.TargetId);
		}
		if (namespaceEntity == null)
		{
			throw new UnknownNamespaceException(ns.Type, ns.TargetId);
		}
		return namespaceEntity.ID;
	}

	private long GetOrCreateNamespaceId(INamespace ns)
	{
		return Namespace.GetOrCreate(NamespaceType.GetOrCreate(ns.Type).ID, ns.TargetId).ID;
	}

	public string GetDefaultAliasForDeveloperProductName(string entityName)
	{
		return "Products/" + entityName.Trim().Replace("/", string.Empty).Replace("\\", string.Empty);
	}

	public INamespace GetUniverseNamespace(long universeId)
	{
		return new UniverseRelativeNamespace(universeId);
	}

	[Obsolete("Use CreateAlias(INamespace, string name, AliasType, long id)")]
	public IAlias Create(INamespace ns, string name, IAsset asset)
	{
		asset.VerifyIsNotNull();
		long namespaceId = GetOrCreateNamespaceId(ns);
		Name nameEntity = Name.GetByNamespaceIDName(namespaceId, name);
		if (nameEntity != null)
		{
			throw new DuplicateAliasException(namespaceId, name);
		}
		nameEntity = Name.CreateNew(namespaceId, name, asset.Id, null, NameType.GetByValue("AssetID").ID, asset.Id);
		return Build(ns, nameEntity);
	}

	[Obsolete("Use CreateAlias(INamespace, string name, AliasType, long id)")]
	public IAlias Create(INamespace ns, string name, IAssetVersion assetVersion)
	{
		assetVersion.VerifyIsNotNull();
		long namespaceId = GetOrCreateNamespaceId(ns);
		Name nameEntity = Name.GetByNamespaceIDName(namespaceId, name);
		if (nameEntity != null)
		{
			throw new DuplicateAliasException(namespaceId, name);
		}
		nameEntity = Name.CreateNew(namespaceId, name, assetVersion.AssetId, assetVersion.VersionNumber, NameType.GetByValue("AssetVersionID").ID, assetVersion.Id);
		return Build(ns, nameEntity);
	}

	public IAlias CreateAlias(INamespace ns, string name, AliasType type, long targetId)
	{
		long namespaceId = GetOrCreateNamespaceId(ns);
		long assetId = 0L;
		int? assetVersionNumber = null;
		switch (type)
		{
		case AliasType.Asset:
			assetId = targetId;
			assetVersionNumber = null;
			break;
		case AliasType.AssetVersion:
		{
			IAssetVersion assetVersion = AssetVersionFactory.Get(targetId);
			if (assetVersion != null)
			{
				assetId = assetVersion.AssetId;
				assetVersionNumber = assetVersion.VersionNumber;
			}
			break;
		}
		}
		Name nameEntity = null;
		try
		{
			nameEntity = Name.CreateNew(namespaceId, name, assetId, assetVersionNumber, (byte)type, targetId);
		}
		catch (SqlException ex)
		{
			if (ex.Number == 2601)
			{
				throw new DuplicateAliasException();
			}
			throw;
		}
		return Build(ns, nameEntity);
	}

	public IAlias GetAlias(INamespace ns, string name)
	{
		Name nameEntity = Name.GetByNamespaceIDName(GetNamespaceIdByLookup(ns), name);
		if (nameEntity == null)
		{
			return null;
		}
		return Build(ns, nameEntity);
	}

	public IPagedResult<int, IAlias> GetAliases(INamespace ns, int offset, int count)
	{
		PagedResult<int, IAlias> pagedResult = new PagedResult<int, IAlias>();
		long namespaceIdByLookup = GetNamespaceIdByLookup(ns);
		ICollection<Name> nameEntities = Name.GetNamesByNamespaceIdPaged(namespaceIdByLookup, offset, count);
		int totalCount = Name.GetTotalNumberOfNamesByNamespaceId(namespaceIdByLookup);
		pagedResult.PageItems = nameEntities.Select((Name entity) => Build(ns, entity)).ToArray();
		pagedResult.Count = totalCount;
		return pagedResult;
	}
}
