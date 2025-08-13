using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class LiveGamerPaymentStatusType : IRobloxEntity<byte, LiveGamerPaymentStatusTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private LiveGamerPaymentStatusTypeDAL _EntityDAL;

	public static readonly LiveGamerPaymentStatusType Charged;

	public static readonly LiveGamerPaymentStatusType NotValid;

	public static readonly LiveGamerPaymentStatusType Pending;

	public static readonly LiveGamerPaymentStatusType Refunded;

	public static readonly LiveGamerPaymentStatusType ChargedBack;

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

	public LiveGamerPaymentStatusType()
	{
		_EntityDAL = new LiveGamerPaymentStatusTypeDAL();
	}

	static LiveGamerPaymentStatusType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "LiveGamerPaymentStatusType", isNullCacheable: true);
		Charged = GetByValue("CHARGED");
		NotValid = GetByValue("NOT_VALID");
		Pending = GetByValue("PENDING");
		Refunded = GetByValue("REFUNDED");
		ChargedBack = GetByValue("CHARGED_BACK");
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

	private static LiveGamerPaymentStatusType CreateNew(string value)
	{
		LiveGamerPaymentStatusType liveGamerPaymentStatusType = new LiveGamerPaymentStatusType();
		liveGamerPaymentStatusType.Value = value;
		liveGamerPaymentStatusType.Save();
		return liveGamerPaymentStatusType;
	}

	public static LiveGamerPaymentStatusType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, LiveGamerPaymentStatusTypeDAL, LiveGamerPaymentStatusType>(EntityCacheInfo, id, () => LiveGamerPaymentStatusTypeDAL.Get(id));
	}

	public static LiveGamerPaymentStatusType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, LiveGamerPaymentStatusTypeDAL, LiveGamerPaymentStatusType>(EntityCacheInfo, $"Value:{value}", () => LiveGamerPaymentStatusTypeDAL.GetByValue(value));
	}

	public void Construct(LiveGamerPaymentStatusTypeDAL dal)
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
