using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Assets.Places;

public class PlaceTypes : IRobloxEntity<byte, PlaceTypesDAL>, ICacheableObject<byte>, ICacheableObject
{
	public static readonly PlaceTypes PublicServer;

	private PlaceTypesDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string PlaceType
	{
		get
		{
			return _EntityDAL.PlaceType;
		}
		set
		{
			_EntityDAL.PlaceType = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	static PlaceTypes()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Assets.Places.PlaceType", isNullCacheable: true);
		PublicServer = Get("Public Server");
	}

	public PlaceTypes()
	{
		_EntityDAL = new PlaceTypesDAL();
	}

	private static PlaceTypes Get(string placeType)
	{
		return EntityHelper.GetEntityByLookup<byte, PlaceTypesDAL, PlaceTypes>(EntityCacheInfo, $"PlaceType:{placeType}", () => PlaceTypesDAL.Get(placeType));
	}

	public void Construct(PlaceTypesDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PlaceType:{PlaceType}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
