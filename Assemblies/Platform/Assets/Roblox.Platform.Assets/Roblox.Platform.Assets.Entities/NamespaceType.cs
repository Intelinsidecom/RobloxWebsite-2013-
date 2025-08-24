using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Entities;

internal class NamespaceType : IRobloxEntity<byte, NamespaceTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private NamespaceTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(NamespaceType).ToString(), isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

	internal string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
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

	public NamespaceType()
	{
		_EntityDAL = new NamespaceTypeDAL();
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

	private static NamespaceType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<byte, NamespaceTypeDAL, NamespaceType>(() => NamespaceTypeDAL.GetOrCreate(value));
	}

	internal static NamespaceType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, NamespaceTypeDAL, NamespaceType>(EntityCacheInfo, id, () => NamespaceTypeDAL.Get(id));
	}

	internal static NamespaceType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<byte, NamespaceType>(EntityCacheInfo, "Value:" + value, () => DoGetOrCreate(value));
	}

	public static NamespaceType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, NamespaceTypeDAL, NamespaceType>(EntityCacheInfo, $"Value:{value}", () => NamespaceTypeDAL.GetNamespaceTypeByValue(value));
	}

	public void Construct(NamespaceTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
