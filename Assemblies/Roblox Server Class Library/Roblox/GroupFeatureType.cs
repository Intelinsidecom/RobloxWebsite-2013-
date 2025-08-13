using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupFeatureType : IRobloxEntity<byte, GroupFeatureTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private GroupFeatureTypeDAL _EntityDAL;

	private static readonly LazyWithRetry<byte> _AllowEnemiesIDLazy = LazyGetter("AllowEnemies");

	private static readonly LazyWithRetry<byte> _AllowVisibleGroupFundsIDLazy = LazyGetter("AllowVisibleGroupFunds");

	private static readonly LazyWithRetry<byte> _ClanIDLazy = LazyGetter("Clan");

	private static readonly LazyWithRetry<byte> _GroupGamesVisibleIDLazy = LazyGetter("GroupGamesVisible");

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.GroupFeatureType", isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

	public string Name
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

	public DateTime Created
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

	public DateTime Updated
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

	public static byte AllowEnemiesID => _AllowEnemiesIDLazy.Value;

	public static byte AllowVisibleGroupFundsID => _AllowVisibleGroupFundsIDLazy.Value;

	public static byte ClanID => _ClanIDLazy.Value;

	public static byte GroupGamesVisibleID => _GroupGamesVisibleIDLazy.Value;

	public CacheInfo CacheInfo => EntityCacheInfo;

	private static LazyWithRetry<byte> LazyGetter(string value)
	{
		return new LazyWithRetry<byte>(() => Get(value).ID);
	}

	public GroupFeatureType()
	{
		_EntityDAL = new GroupFeatureTypeDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static GroupFeatureType CreateNew(string name)
	{
		GroupFeatureType groupFeatureType = new GroupFeatureType();
		groupFeatureType.Name = name;
		groupFeatureType.Save();
		return groupFeatureType;
	}

	public static GroupFeatureType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, GroupFeatureTypeDAL, GroupFeatureType>(EntityCacheInfo, id, () => GroupFeatureTypeDAL.Get(id));
	}

	public static GroupFeatureType Get(string name)
	{
		return EntityHelper.GetEntityByLookup<byte, GroupFeatureTypeDAL, GroupFeatureType>(EntityCacheInfo, $"Name:{name}", () => GroupFeatureTypeDAL.Get(name));
	}

	public void Construct(GroupFeatureTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Name:{Name}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
