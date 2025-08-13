using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class SaleStatusType : IRobloxEntity<byte, SaleStatusTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private SaleStatusTypeDAL _EntityDAL;

	public static readonly SaleStatusType Complete;

	public static readonly SaleStatusType Error;

	public static readonly SaleStatusType Pending;

	public static readonly SaleStatusType Recurring;

	public static readonly SaleStatusType Cancelled;

	public static readonly SaleStatusType Blocked;

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

	public SaleStatusType()
	{
		_EntityDAL = new SaleStatusTypeDAL();
	}

	static SaleStatusType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "SaleStatusType", isNullCacheable: true);
		Complete = Get("Complete");
		Error = Get("Error");
		Pending = Get("Pending");
		Recurring = Get("Recurring");
		Cancelled = Get("Cancelled");
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

	private static SaleStatusType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<byte, SaleStatusTypeDAL, SaleStatusType>(() => SaleStatusTypeDAL.Get(value), $"Value:{value}");
	}

	public static SaleStatusType Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<byte, SaleStatusType>(EntityCacheInfo, $"Value:{value}", () => DoGet(value));
	}

	internal static SaleStatusType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, SaleStatusTypeDAL, SaleStatusType>(EntityCacheInfo, id, () => SaleStatusTypeDAL.Get(id));
	}

	private static ICollection<SaleStatusType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, SaleStatusTypeDAL, SaleStatusType>(ids, EntityCacheInfo, SaleStatusTypeDAL.MultiGet);
	}

	public void Construct(SaleStatusTypeDAL dal)
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
