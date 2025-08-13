using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Entities;

internal class Name : IRobloxEntity<long, NameDAL>, ICacheableObject<long>, ICacheableObject
{
	private NameDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Name).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long NamespaceID
	{
		get
		{
			return _EntityDAL.NamespaceID;
		}
		set
		{
			_EntityDAL.NamespaceID = value;
		}
	}

	internal string NameValue
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

	internal long AssetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		set
		{
			_EntityDAL.AssetID = value;
		}
	}

	internal int? AssetVersion
	{
		get
		{
			return _EntityDAL.AssetVersion;
		}
		set
		{
			_EntityDAL.AssetVersion = value;
		}
	}

	internal DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	internal DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	internal byte? NameTypeID
	{
		get
		{
			return _EntityDAL.NameTypeID;
		}
		set
		{
			_EntityDAL.NameTypeID = value;
		}
	}

	internal long? NameTargetID
	{
		get
		{
			return _EntityDAL.NameTargetID;
		}
		set
		{
			_EntityDAL.NameTargetID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Name()
	{
		_EntityDAL = new NameDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static Name CreateNew(long namespaceId, string name, long assetId, int? assetVersion, byte? nameTypeId, long? nameTargetId)
	{
		Name name2 = new Name();
		name2.NamespaceID = namespaceId;
		name2.NameValue = name;
		name2.AssetID = assetId;
		name2.AssetVersion = assetVersion;
		name2.NameTypeID = nameTypeId;
		name2.NameTargetID = nameTargetId;
		name2.Save();
		return name2;
	}

	internal static Name Get(long id)
	{
		return EntityHelper.GetEntity<long, NameDAL, Name>(EntityCacheInfo, id, () => NameDAL.Get(id));
	}

	internal static ICollection<Name> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, NameDAL, Name>(ids, EntityCacheInfo, NameDAL.MultiGet);
	}

	public static Name GetByNamespaceIDName(long namespaceID, string name)
	{
		return EntityHelper.GetEntityByLookup<long, NameDAL, Name>(EntityCacheInfo, $"NamespaceID:{namespaceID}_Name:{name}", () => NameDAL.GetNameByNamespaceIDAndName(namespaceID, name));
	}

	internal static ICollection<Name> GetNamesByNamespaceIdPaged(long namespaceId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetAssetNamesByNamespaceIdPaged_NamespaceID:{namespaceId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"NamespaceID:{namespaceId}"), collectionId, () => NameDAL.GetNameIDsByNamespaceIDPaged(namespaceId, startRowIndex + 1, maximumRows), Get);
	}

	internal static int GetTotalNumberOfNamesByNamespaceId(long namespaceId)
	{
		string countId = "GetTotalNumberOfAssetNamesByNamespaceID_NamespaceID:" + namespaceId;
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"NamespaceID:{namespaceId}"), countId, () => NameDAL.GetTotalNumberOfNamesByNamespaceID(namespaceId));
	}

	internal static ICollection<Name> GetNamesByNamespaceIdNameTypeIdAndNameTargetIdPaged(long namespaceId, byte nameTypeId, long nameTargetId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetNamesByNamespaceIDNameTypeIDAndNameTargetIDPaged_NamespaceID:{namespaceId}_NameTypeID:{nameTypeId}_NameTargetID:{nameTargetId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"NamespaceID:{namespaceId}_NameTypeID:{nameTypeId}_NameTargetID:{nameTargetId}"), collectionId, () => NameDAL.GetNameIDsByNamespaceIDNameTypeIDAndNameTargetIDPaged(namespaceId, nameTypeId, nameTargetId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static long GetTotalNumberOfNamesByNamespaceIdNameTypeIdAndNameTargetId(long namespaceId, byte nameTypeId, long nameTargetId)
	{
		string countId = $"GetTotalNumberOfNamesByNamespaceIDNameTypeIDAndNameTargetID_NamespaceID:{namespaceId}_NameTypeID:{nameTypeId}_NameTargetID:{nameTargetId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"NamespaceID:{namespaceId}_NameTypeID:{nameTypeId}_NameTargetID:{nameTargetId}"), countId, () => NameDAL.GetTotalNumberOfNamesByNamespaceIDNameTypeIDAndNameTargetID(namespaceId, nameTypeId, nameTargetId));
	}

	public void Construct(NameDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"NamespaceID:{NamespaceID}_Name:{NameValue}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"NamespaceID:{NamespaceID}");
		yield return new StateToken($"NamespaceID:{NamespaceID}_NameTypeID:{NameTypeID}_NameTargetID:{NameTargetID}");
	}
}
