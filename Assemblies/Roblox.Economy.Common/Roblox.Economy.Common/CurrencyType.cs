using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy.Common;

public class CurrencyType : IRobloxEntity<byte, CurrencyTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private CurrencyTypeDAL _EntityDAL;

	public static readonly byte RobuxID;

	public static readonly string RobuxValue;

	public static readonly byte TicketsID;

	public static readonly string TicketsValue;

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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public CurrencyType()
	{
		_EntityDAL = new CurrencyTypeDAL();
	}

	static CurrencyType()
	{
		RobuxValue = "Robux";
		TicketsValue = "Tickets";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "CurrencyType", isNullCacheable: true);
		RobuxID = Get(RobuxValue).ID;
		TicketsID = Get(TicketsValue).ID;
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

	public static CurrencyType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, CurrencyTypeDAL, CurrencyType>(EntityCacheInfo, id, () => CurrencyTypeDAL.Get(id));
	}

	public static CurrencyType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static CurrencyType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, CurrencyTypeDAL, CurrencyType>(EntityCacheInfo, value, () => CurrencyTypeDAL.Get(value));
	}

	public static ICollection<CurrencyType> GetCurrencyTypesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetCurrencyTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => CurrencyTypeDAL.GetCurrencyTypeIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfCurrencyTypes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfCurrencyTypes", CurrencyTypeDAL.GetTotalNumberOfCurrencyTypes);
	}

	public void Construct(CurrencyTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Value;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
