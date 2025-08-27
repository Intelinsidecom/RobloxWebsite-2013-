using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class GrantedBadgeList : IRobloxEntity<byte, GrantedBadgeListDAL>, ICacheableObject<byte>, ICacheableObject
{
	private GrantedBadgeListDAL _EntityDAL;

	public const string NoneValue = "None";

	public static readonly byte NoneID;

	internal static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	internal string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		private set
		{
			_EntityDAL.Value = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GrantedBadgeList()
	{
		_EntityDAL = new GrantedBadgeListDAL();
	}

	static GrantedBadgeList()
	{
		NoneID = 0;
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GrantedBadgeList", isNullCacheable: true);
		NoneID = GetByValue("None").ID;
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static GrantedBadgeList Get(byte id)
	{
		return EntityHelper.GetEntity<byte, GrantedBadgeListDAL, GrantedBadgeList>(EntityCacheInfo, id, () => GrantedBadgeListDAL.Get(id));
	}

	public static GrantedBadgeList Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static GrantedBadgeList GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, GrantedBadgeListDAL, GrantedBadgeList>(EntityCacheInfo, $"Value:{value}", () => GrantedBadgeListDAL.GetByValue(value));
	}

	public void Construct(GrantedBadgeListDAL dal)
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
