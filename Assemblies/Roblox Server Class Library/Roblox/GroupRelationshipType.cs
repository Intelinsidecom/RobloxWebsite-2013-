using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupRelationshipType : IRobloxEntity<byte, GroupRelationshipTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private GroupRelationshipTypeDAL _EntityDAL;

	private static readonly LazyWithRetry<byte> _AllyLazy = LazyGetter("Ally");

	private static readonly LazyWithRetry<byte> _EnemyLazy = LazyGetter("Enemy");

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.GroupRelationshipType", isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

	public string Value
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

	public bool IsReciprocal
	{
		get
		{
			return _EntityDAL.IsReciprocal;
		}
		set
		{
			_EntityDAL.IsReciprocal = value;
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

	public static byte AllyID => _AllyLazy.Value;

	public static byte EnemyID => _EnemyLazy.Value;

	public CacheInfo CacheInfo => EntityCacheInfo;

	private static LazyWithRetry<byte> LazyGetter(string value)
	{
		return new LazyWithRetry<byte>(() => Get(value).ID);
	}

	public GroupRelationshipType()
	{
		_EntityDAL = new GroupRelationshipTypeDAL();
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

	public static GroupRelationshipType CreateNew(string value, bool isReciprocal)
	{
		GroupRelationshipType groupRelationshipType = new GroupRelationshipType();
		groupRelationshipType.Value = value;
		groupRelationshipType.IsReciprocal = isReciprocal;
		groupRelationshipType.Save();
		return groupRelationshipType;
	}

	public static GroupRelationshipType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, GroupRelationshipTypeDAL, GroupRelationshipType>(EntityCacheInfo, id, () => GroupRelationshipTypeDAL.Get(id));
	}

	public static GroupRelationshipType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, GroupRelationshipTypeDAL, GroupRelationshipType>(EntityCacheInfo, $"Value:{value}", () => GroupRelationshipTypeDAL.Get(value));
	}

	public void Construct(GroupRelationshipTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Value:{Value}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
