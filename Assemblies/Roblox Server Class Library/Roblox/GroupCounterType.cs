using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupCounterType : IRobloxEntity<byte, GroupCounterTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private GroupCounterTypeDAL _EntityDAL;

	private static readonly LazyWithRetry<byte> _MembersLazy = LazyGetter("Members");

	private static readonly LazyWithRetry<byte> _AdminsLazy = LazyGetter("Admins");

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GroupCounterType", isNullCacheable: true);

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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public static byte MembersID => _MembersLazy.Value;

	public static byte AdminsID => _AdminsLazy.Value;

	public CacheInfo CacheInfo => EntityCacheInfo;

	private static LazyWithRetry<byte> LazyGetter(string value)
	{
		return new LazyWithRetry<byte>(() => Get(value).ID);
	}

	public GroupCounterType()
	{
		_EntityDAL = new GroupCounterTypeDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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

	public static GroupCounterType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, GroupCounterTypeDAL, GroupCounterType>(EntityCacheInfo, id, () => GroupCounterTypeDAL.Get(id));
	}

	public static GroupCounterType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static GroupCounterType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, GroupCounterTypeDAL, GroupCounterType>(EntityCacheInfo, value, () => GroupCounterTypeDAL.Get(value));
	}

	public void Construct(GroupCounterTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add(Value);
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
