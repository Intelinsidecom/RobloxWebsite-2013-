using System;
using System.Collections.Generic;
using System.Threading;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class MACAddress : IRobloxEntity<long, MACAddressDAL>, ICacheableObject<long>, ICacheableObject
{
	private MACAddressDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "MACAddress", isNullCacheable: true);

	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	public string Address => _EntityDAL.MACAddress;

	public State State
	{
		get
		{
			PerformStateExpirationCheck();
			return (State)_EntityDAL.State;
		}
		set
		{
			_EntityDAL.State = (byte)value;
		}
	}

	public DateTime? Expiration
	{
		get
		{
			PerformStateExpirationCheck();
			return _EntityDAL.Expiration;
		}
		set
		{
			_EntityDAL.Expiration = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public bool IsBanned
	{
		get
		{
			PerformStateExpirationCheck();
			return _EntityDAL.State == 2;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public MACAddress()
	{
		_EntityDAL = new MACAddressDAL();
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

	private static MACAddress DoGetOrCreate(string address)
	{
		return EntityHelper.DoGetOrCreate<long, MACAddressDAL, MACAddress>(() => MACAddressDAL.GetOrCreate(address));
	}

	private static void DoSave(MACAddress entity)
	{
		try
		{
			entity.Save();
		}
		catch (ThreadAbortException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			ExceptionHandler.LogException(ex2);
		}
	}

	private void PerformStateExpirationCheck()
	{
		if (_EntityDAL.State == 2 && _EntityDAL.Expiration.HasValue && !(DateTime.Now < _EntityDAL.Expiration.Value))
		{
			State = State.Open;
			Expiration = null;
			DoSave(this);
		}
	}

	public static MACAddress Get(long id)
	{
		MACAddress entity = EntityHelper.GetEntity<long, MACAddressDAL, MACAddress>(EntityCacheInfo, id, () => MACAddressDAL.Get(id));
		entity.PerformStateExpirationCheck();
		return entity;
	}

	public static MACAddress Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static MACAddress GetByAddress(string address)
	{
		return EntityHelper.GetEntityByLookup<long, MACAddressDAL, MACAddress>(EntityCacheInfo, $"MACAddress:{address}", () => MACAddressDAL.GetByAddress(address));
	}

	public static MACAddress GetOrCreate(string address)
	{
		return EntityHelper.GetOrCreateEntity<long, MACAddress>(EntityCacheInfo, $"MACAddress:{address}", () => DoGetOrCreate(address));
	}

	public static MACAddress MustGet(long id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public void Construct(MACAddressDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "MACAddress:" + Address;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
