using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Entities;

internal class Namespace : IRobloxEntity<long, NamespaceDAL>, ICacheableObject<long>, ICacheableObject
{
	private NamespaceDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Namespace).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal byte NamespaceTypeID
	{
		get
		{
			return _EntityDAL.NamespaceTypeID;
		}
		set
		{
			_EntityDAL.NamespaceTypeID = value;
		}
	}

	internal long NamespaceTargetID
	{
		get
		{
			return _EntityDAL.NamespaceTargetID;
		}
		set
		{
			_EntityDAL.NamespaceTargetID = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Namespace()
	{
		_EntityDAL = new NamespaceDAL();
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

	private static Namespace DoGetOrCreate(byte namespaceTypeId, long namespaceTargetId)
	{
		return EntityHelper.DoGetOrCreate<long, NamespaceDAL, Namespace>(() => NamespaceDAL.GetOrCreate(namespaceTypeId, namespaceTargetId));
	}

	internal static Namespace GetOrCreate(byte namespaceTypeId, long namespaceTargetId)
	{
		return EntityHelper.GetOrCreateEntity<long, Namespace>(EntityCacheInfo, "NamespaceTypeID:" + namespaceTypeId + "_NamespaceTargetID:" + namespaceTargetId, () => DoGetOrCreate(namespaceTypeId, namespaceTargetId));
	}

	internal static Namespace CreateNew(byte namespaceTypeId, long namespaceTargetId)
	{
		Namespace @namespace = new Namespace();
		@namespace.NamespaceTypeID = namespaceTypeId;
		@namespace.NamespaceTargetID = namespaceTargetId;
		@namespace.Save();
		return @namespace;
	}

	internal static Namespace Get(long id)
	{
		return EntityHelper.GetEntity<long, NamespaceDAL, Namespace>(EntityCacheInfo, id, () => NamespaceDAL.Get(id));
	}

	public static Namespace GetByNamespaceTypeIDNamespaceTargetID(byte namespaceTypeID, long namespaceTargetID)
	{
		return EntityHelper.GetEntityByLookup<long, NamespaceDAL, Namespace>(EntityCacheInfo, $"NamespaceTypeID:{namespaceTypeID}_NamespaceTargetID:{namespaceTargetID}", () => NamespaceDAL.GetNamespaceByNamespaceTypeIDNamespaceTargetID(namespaceTypeID, namespaceTargetID));
	}

	public void Construct(NamespaceDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"NamespaceTypeID:{NamespaceTypeID}_NamespaceTargetID:{NamespaceTargetID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
