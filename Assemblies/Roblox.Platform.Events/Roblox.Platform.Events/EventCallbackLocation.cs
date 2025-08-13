using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Events;

internal class EventCallbackLocation : IRobloxEntity<long, EventCallbackLocationDAL>, ICacheableObject<long>, ICacheableObject
{
	private EventCallbackLocationDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(EventCallbackLocation).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	internal byte EventCallbackLocationTypeID
	{
		get
		{
			return _EntityDAL.EventCallbackLocationTypeID;
		}
		set
		{
			_EntityDAL.EventCallbackLocationTypeID = value;
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

	public EventCallbackLocation()
	{
		_EntityDAL = new EventCallbackLocationDAL();
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

	internal static EventCallbackLocation Get(long id)
	{
		return EntityHelper.GetEntity<long, EventCallbackLocationDAL, EventCallbackLocation>(EntityCacheInfo, id, () => EventCallbackLocationDAL.Get(id));
	}

	internal static ICollection<EventCallbackLocation> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, EventCallbackLocationDAL, EventCallbackLocation>(ids, EntityCacheInfo, EventCallbackLocationDAL.MultiGet);
	}

	public static EventCallbackLocation GetByValueAndEventCallbackLocationTypeID(string value, byte eventCallbackLocationTypeID)
	{
		return EntityHelper.GetEntityByLookup<long, EventCallbackLocationDAL, EventCallbackLocation>(EntityCacheInfo, $"Value:{value}_EventCallbackLocationTypeID:{eventCallbackLocationTypeID}", () => EventCallbackLocationDAL.GetEventCallbackLocationByValueAndEventCallbackLocationTypeID(value, eventCallbackLocationTypeID));
	}

	public static EventCallbackLocation GetOrCreate(string value, byte eventCallbackLocationTypeID)
	{
		return EntityHelper.GetOrCreateEntity<long, EventCallbackLocation>(EntityCacheInfo, $"Value:{value}_EventCallbackLocationTypeID:{eventCallbackLocationTypeID}", () => DoGetOrCreate(value, eventCallbackLocationTypeID));
	}

	private static EventCallbackLocation DoGetOrCreate(string value, byte eventCallbackLocationTypeID)
	{
		return EntityHelper.DoGetOrCreate<long, EventCallbackLocationDAL, EventCallbackLocation>(() => EventCallbackLocationDAL.GetOrCreateEventCallbackLocation(value, eventCallbackLocationTypeID));
	}

	public void Construct(EventCallbackLocationDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}_EventCallbackLocationTypeID:{EventCallbackLocationTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
