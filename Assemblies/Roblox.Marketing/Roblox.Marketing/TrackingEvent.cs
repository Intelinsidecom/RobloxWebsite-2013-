using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class TrackingEvent : IRobloxEntity<int, TrackingEventDAL>, ICacheableObject<int>, ICacheableObject
{
	private TrackingEventDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(TrackingEvent).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public TrackingEvent()
	{
		_EntityDAL = new TrackingEventDAL();
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

	private static TrackingEvent CreateNew(string name)
	{
		TrackingEvent trackingEvent = new TrackingEvent();
		trackingEvent.Name = name;
		trackingEvent.Save();
		return trackingEvent;
	}

	public static TrackingEvent Get(int id)
	{
		return EntityHelper.GetEntity<int, TrackingEventDAL, TrackingEvent>(EntityCacheInfo, id, () => TrackingEventDAL.Get(id));
	}

	public static TrackingEvent GetTrackingEventByName(string name)
	{
		return EntityHelper.GetEntityByLookup<int, TrackingEventDAL, TrackingEvent>(EntityCacheInfo, $"Name:{name}", () => TrackingEventDAL.GetByName(name));
	}

	public void Construct(TrackingEventDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Name:{Name}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
