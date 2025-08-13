using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class PaymentStatusType : IRobloxEntity<byte, PaymentStatusTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	public PaymentStatusTypeDAL _EntityDAL;

	public static PaymentStatusType Success;

	public static PaymentStatusType Failure;

	public static PaymentStatusType Unknown;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

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

	static PaymentStatusType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(PaymentStatusType).ToString(), isNullCacheable: true);
		Success = GetByValue("Success");
		Failure = GetByValue("Failure");
		Unknown = GetByValue("Unknown");
	}

	public PaymentStatusType()
	{
		_EntityDAL = new PaymentStatusTypeDAL();
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

	internal static PaymentStatusType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PaymentStatusTypeDAL, PaymentStatusType>(EntityCacheInfo, id, () => PaymentStatusTypeDAL.Get(id));
	}

	internal static ICollection<PaymentStatusType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, PaymentStatusTypeDAL, PaymentStatusType>(ids, EntityCacheInfo, PaymentStatusTypeDAL.MultiGet);
	}

	public static PaymentStatusType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, PaymentStatusTypeDAL, PaymentStatusType>(EntityCacheInfo, $"Value:{value}", () => PaymentStatusTypeDAL.GetPaymentStatusTypeByValue(value));
	}

	public void Construct(PaymentStatusTypeDAL dal)
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
