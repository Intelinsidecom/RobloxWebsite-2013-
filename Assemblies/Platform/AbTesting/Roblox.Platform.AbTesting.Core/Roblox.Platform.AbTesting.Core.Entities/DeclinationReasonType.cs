using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class DeclinationReasonType : IRobloxEntity<int, DeclinationReasonTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private DeclinationReasonTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(DeclinationReasonType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public DeclinationReasonType()
	{
		_EntityDAL = new DeclinationReasonTypeDAL();
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

	internal static DeclinationReasonType Get(int id)
	{
		return EntityHelper.GetEntity<int, DeclinationReasonTypeDAL, DeclinationReasonType>(EntityCacheInfo, id, () => DeclinationReasonTypeDAL.Get(id));
	}

	internal static ICollection<DeclinationReasonType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, DeclinationReasonTypeDAL, DeclinationReasonType>(ids, EntityCacheInfo, DeclinationReasonTypeDAL.MultiGet);
	}

	private static DeclinationReasonType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, DeclinationReasonTypeDAL, DeclinationReasonType>(() => DeclinationReasonTypeDAL.GetOrCreateDeclinationReasonType(value));
	}

	public static DeclinationReasonType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, DeclinationReasonType>(EntityCacheInfo, $"Value:{value}", () => DoGetOrCreate(value));
	}

	public static DeclinationReasonType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, DeclinationReasonTypeDAL, DeclinationReasonType>(EntityCacheInfo, $"Value:{value}", () => DeclinationReasonTypeDAL.GetDeclinationReasonTypeByValue(value));
	}

	public void Construct(DeclinationReasonTypeDAL dal)
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
