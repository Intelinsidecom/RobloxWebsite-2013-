using System;
using System.Collections.Generic;
using System.Threading;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Properties;

namespace Roblox;

public class IPAddress : IRobloxEntity<int, IPAddressDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private IPAddressDAL _EntityDAL;

	private static readonly char[] _AddressDelimiter = new char[1] { '.' };

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "IPAddress", isNullCacheable: true);

	public int ID
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

	public string Address
	{
		get
		{
			if (ReadWriteOnlyAsString(_EntityDAL.Address))
			{
				return _EntityDAL.Value;
			}
			return ToString(_EntityDAL.Address);
		}
	}

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

	public State State
	{
		get
		{
			PerformStateExpirationCheck(this);
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
			PerformStateExpirationCheck(this);
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
			PerformStateExpirationCheck(this);
			if (_EntityDAL.State == 2)
			{
				return _EntityDAL.Expiration > DateTime.Now;
			}
			return false;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static bool ReadWriteOnlyAsString(int ip)
	{
		int percentage = Settings.Default.ReadWriteIpAddressOnlyAsStringPercentage;
		if (percentage < 1)
		{
			return false;
		}
		if (percentage >= 100)
		{
			return true;
		}
		return ip % 100 < percentage;
	}

	public IPAddress()
	{
		_EntityDAL = new IPAddressDAL();
	}

	public IPAddress(IPAddressDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		if (Settings.Default.EnableRemoteCacheForIPAddress)
		{
			EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
		}
		else
		{
			EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		}
	}

	public void Save()
	{
		if (Settings.Default.EnableRemoteCacheForIPAddress)
		{
			EntityHelper.SaveEntityWithRemoteCache(this, delegate
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
		else
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
	}

	private static IPAddress DoGetOrCreate(string address)
	{
		if (address == "::1")
		{
			address = "127.0.0.1";
		}
		int addressInt = ToInt(address);
		return EntityHelper.DoGetOrCreate<int, IPAddressDAL, IPAddress>(() => IPAddressDAL.GetOrCreateIPAddress(addressInt, address));
	}

	private static void DoSave(IPAddress entity)
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

	private static void PerformStateExpirationCheck(IPAddress entity)
	{
		if (entity != null && entity._EntityDAL.State == 2 && entity._EntityDAL.Expiration.HasValue && DateTime.Now >= entity._EntityDAL.Expiration.Value)
		{
			entity.State = State.Open;
			entity.Expiration = null;
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				DoSave(entity);
			});
		}
	}

	public static IPAddress Get(int id)
	{
		return EntityHelper.GetEntity<int, IPAddressDAL, IPAddress>(EntityCacheInfo, id, () => IPAddressDAL.Get(id));
	}

	public static IPAddress Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static IPAddress GetByAddress(string address)
	{
		if (address == "::1")
		{
			address = "127.0.0.1";
		}
		int intIp = ToInt(address);
		Func<IPAddressDAL> getter = () => IPAddressDAL.GetIPAddressByAddress(intIp);
		if (ReadWriteOnlyAsString(intIp))
		{
			getter = () => IPAddressDAL.GetIPAddressByValue(address);
		}
		if (Settings.Default.EnableRemoteCacheForIPAddress && Settings.Default.EnableReadFromRemoteCacheForIPAddress)
		{
			return EntityHelper.GetEntityByLookupWithRemoteCache<int, IPAddressDAL, IPAddress>(EntityCacheInfo, GetLookupCacheKeyByAddress(address), getter, Get);
		}
		return EntityHelper.GetEntityByLookup<int, IPAddressDAL, IPAddress>(EntityCacheInfo, GetLookupCacheKeyByAddress(address), getter);
	}

	public static IPAddress GetOrCreate(string address)
	{
		if (address == "::1")
		{
			address = "127.0.0.1";
		}
		return EntityHelper.GetOrCreateEntityWithRemoteCache<int, IPAddress>(EntityCacheInfo, GetLookupCacheKeyByAddress(address), () => DoGetOrCreate(address), Get);
	}

	public static IPAddress MustGet(int id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public static ICollection<IPAddress> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, IPAddressDAL, IPAddress>(ids, EntityCacheInfo, IPAddressDAL.MultiGet);
	}

	public static int ToInt(string address)
	{
		if (address == "::1")
		{
			address = "127.0.0.1";
		}
		string[] numbers = address.Split(_AddressDelimiter);
		int result = 0;
		for (int i = 0; i < 4; i++)
		{
			result <<= 8;
			result |= Convert.ToByte(numbers[i]);
		}
		return result;
	}

	public static string ToString(int address)
	{
		return $"{(address >> 24) & 0xFF}.{(address >> 16) & 0xFF}.{(address >> 8) & 0xFF}.{address & 0xFF}";
	}

	public void Construct(IPAddressDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return GetLookupCacheKeyByAddress(Address);
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeyByAddress(string address)
	{
		return $"Address:{address}";
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
