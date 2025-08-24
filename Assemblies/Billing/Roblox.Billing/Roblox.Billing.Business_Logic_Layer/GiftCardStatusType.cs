using System;
using System.Collections.Generic;
using Roblox.Billing.Data_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Business_Logic_Layer;

public class GiftCardStatusType : IRobloxEntity<byte, GiftCardStatusTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private GiftCardStatusTypeDAL _EntityDAL;

	public static GiftCardStatusType Pending;

	public static GiftCardStatusType Active;

	public static GiftCardStatusType Redeemed;

	public static GiftCardStatusType Deactivated;

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

	static GiftCardStatusType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.GiftCardStatusType", isNullCacheable: true);
		Pending = GetByValue("Pending");
		Active = GetByValue("Active");
		Redeemed = GetByValue("Redeemed");
		Deactivated = GetByValue("Deactivated");
	}

	public GiftCardStatusType()
	{
		_EntityDAL = new GiftCardStatusTypeDAL();
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

	public static GiftCardStatusType CreateNew(string value)
	{
		GiftCardStatusType giftCardStatusType = new GiftCardStatusType();
		giftCardStatusType.Value = value;
		giftCardStatusType.Save();
		return giftCardStatusType;
	}

	public static GiftCardStatusType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, GiftCardStatusTypeDAL, GiftCardStatusType>(EntityCacheInfo, id, () => GiftCardStatusTypeDAL.Get(id));
	}

	public static GiftCardStatusType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, GiftCardStatusTypeDAL, GiftCardStatusType>(EntityCacheInfo, $"Value:{value}", () => GiftCardStatusTypeDAL.GetByValue(value));
	}

	public void Construct(GiftCardStatusTypeDAL dal)
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
