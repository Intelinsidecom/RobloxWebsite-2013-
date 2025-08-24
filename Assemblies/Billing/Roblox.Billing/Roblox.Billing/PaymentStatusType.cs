using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class PaymentStatusType : IRobloxEntity<byte, PaymentStatusTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PaymentStatusTypeDAL _EntityDAL;

	public static readonly PaymentStatusType Complete;

	public static readonly PaymentStatusType Error;

	public static readonly PaymentStatusType Pending;

	public static readonly PaymentStatusType Refunded;

	public static readonly PaymentStatusType ChargedBack;

	public static readonly PaymentStatusType Blocked;

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

	public PaymentStatusType()
	{
		_EntityDAL = new PaymentStatusTypeDAL();
	}

	static PaymentStatusType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "PaymentStatusType", isNullCacheable: true);
		Complete = Get("Complete");
		Error = Get("Error");
		Pending = Get("Pending");
		Refunded = Get("Refunded");
		ChargedBack = Get("ChargedBack");
		Blocked = Get("Blocked");
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

	private static PaymentStatusType CreateNew(string value)
	{
		PaymentStatusType paymentStatusType = new PaymentStatusType();
		paymentStatusType.Value = value;
		paymentStatusType.Save();
		return paymentStatusType;
	}

	private static ICollection<PaymentStatusType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, PaymentStatusTypeDAL, PaymentStatusType>(ids, EntityCacheInfo, PaymentStatusTypeDAL.MultiGet);
	}

	public static PaymentStatusType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PaymentStatusTypeDAL, PaymentStatusType>(EntityCacheInfo, id, () => PaymentStatusTypeDAL.Get(id));
	}

	private static PaymentStatusType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<byte, PaymentStatusTypeDAL, PaymentStatusType>(() => PaymentStatusTypeDAL.Get(value), $"Value:{value}");
	}

	public static PaymentStatusType Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<byte, PaymentStatusType>(EntityCacheInfo, $"Value:{value}", () => DoGet(value));
	}

	public void Construct(PaymentStatusTypeDAL dal)
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
