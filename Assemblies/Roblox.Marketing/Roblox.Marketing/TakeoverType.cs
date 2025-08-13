using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class TakeoverType : IRobloxEntity<byte, TakeoverTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private TakeoverTypeDAL _EntityDAL;

	public static readonly TakeoverType Takeover;

	public static readonly TakeoverType Roadblock;

	public static readonly TakeoverType MyHomeTakeover;

	public static readonly TakeoverType FilmStrip;

	public static readonly TakeoverType MyHomeTakeoverSpecial;

	public static readonly TakeoverType GameDetailsTakeover;

	public static readonly TakeoverType CatalogTakeover;

	public static readonly TakeoverType ItemTakeover;

	public static readonly TakeoverType ItemRoadblock;

	public static readonly TakeoverType GameRoadblock;

	public static CacheInfo EntityCacheInfo;

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

	public TakeoverType()
	{
		_EntityDAL = new TakeoverTypeDAL();
	}

	static TakeoverType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(TakeoverType).ToString(), isNullCacheable: true);
		Takeover = GetByValue("Takeover");
		Roadblock = GetByValue("Roadblock");
		MyHomeTakeover = GetByValue("MyHomeTakeover");
		FilmStrip = GetByValue("Film Strip");
		MyHomeTakeoverSpecial = GetByValue("MyHomeTakeover Special");
		GameDetailsTakeover = GetByValue("GameDetailsTakeover");
		CatalogTakeover = GetByValue("CatalogTakeover");
		ItemTakeover = GetByValue("ItemTakeover");
		ItemRoadblock = GetByValue("ItemRoadblock");
		GameRoadblock = GetByValue("GameRoadblock");
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

	internal static TakeoverType CreateNew(string value)
	{
		TakeoverType takeoverType = new TakeoverType();
		takeoverType.Value = value;
		takeoverType.Save();
		return takeoverType;
	}

	internal static TakeoverType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, TakeoverTypeDAL, TakeoverType>(EntityCacheInfo, id, () => TakeoverTypeDAL.Get(id));
	}

	public static TakeoverType GetByValue(string value)
	{
		TakeoverType takeoverType = EntityHelper.GetEntityByLookup<byte, TakeoverTypeDAL, TakeoverType>(EntityCacheInfo, $"Value:{value}", () => TakeoverTypeDAL.GetByValue(value));
		if (takeoverType == null)
		{
			takeoverType = CreateNew(value);
		}
		return takeoverType;
	}

	public static ICollection<TakeoverType> GetTakeoverTypes_Paged(byte startIndex, byte maxRows)
	{
		string collectionId = $"GetTakeoverTypes_Paged_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => TakeoverTypeDAL.GetTakeoverTypeIDs_Paged((byte)(startIndex + 1), maxRows), Get);
	}

	public static byte GetTotalNumberOfTakeoverTypes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), string.Empty, TakeoverTypeDAL.GetTotalNumberOfTakeoverTypes);
	}

	public void Construct(TakeoverTypeDAL dal)
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
