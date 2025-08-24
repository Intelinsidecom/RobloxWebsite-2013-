using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class AffiliateSaleSourceType : IRobloxEntity<byte, AffiliateSaleSourceTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private AffiliateSaleSourceTypeDAL _EntityDAL;

	public static readonly byte PlaceID;

	public static readonly string PlaceValue;

	public static readonly byte GameID;

	public static readonly string GameValue;

	public static CacheInfo EntityCacheInfo;

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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AffiliateSaleSourceType()
	{
		_EntityDAL = new AffiliateSaleSourceTypeDAL();
	}

	static AffiliateSaleSourceType()
	{
		PlaceValue = "Place";
		GameValue = "Game";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AffiliateSaleSourceType", isNullCacheable: true);
		PlaceID = Get(PlaceValue).ID;
		GameID = Get(GameValue).ID;
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

	public static AffiliateSaleSourceType CreateNew(string name)
	{
		AffiliateSaleSourceType affiliateSaleSourceType = new AffiliateSaleSourceType();
		affiliateSaleSourceType.Name = name;
		affiliateSaleSourceType.Save();
		return affiliateSaleSourceType;
	}

	public static AffiliateSaleSourceType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, AffiliateSaleSourceTypeDAL, AffiliateSaleSourceType>(EntityCacheInfo, id, () => AffiliateSaleSourceTypeDAL.Get(id));
	}

	private static AffiliateSaleSourceType Get(string name)
	{
		return EntityHelper.GetEntityByLookup<byte, AffiliateSaleSourceTypeDAL, AffiliateSaleSourceType>(EntityCacheInfo, "Name:" + name, () => AffiliateSaleSourceTypeDAL.Get(name));
	}

	public void Construct(AffiliateSaleSourceTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "Name:" + Name;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
