using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Events;

internal class EventCallbackLocationType : IRobloxEntity<byte, EventCallbackLocationTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private EventCallbackLocationTypeDAL _EntityDAL;

	public static EventCallbackLocationType AmazonSns;

	public static EventCallbackLocationType AmazonSqs;

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

	static EventCallbackLocationType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(EventCallbackLocationType).ToString(), isNullCacheable: true);
		AmazonSns = GetByValue("Amazon SNS");
		AmazonSqs = GetByValue("Amazon SQS");
	}

	public EventCallbackLocationType()
	{
		_EntityDAL = new EventCallbackLocationTypeDAL();
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

	internal static EventCallbackLocationType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, EventCallbackLocationTypeDAL, EventCallbackLocationType>(EntityCacheInfo, id, () => EventCallbackLocationTypeDAL.Get(id));
	}

	internal static ICollection<EventCallbackLocationType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, EventCallbackLocationTypeDAL, EventCallbackLocationType>(ids, EntityCacheInfo, EventCallbackLocationTypeDAL.MultiGet);
	}

	public static EventCallbackLocationType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, EventCallbackLocationTypeDAL, EventCallbackLocationType>(EntityCacheInfo, $"Value:{value}", () => EventCallbackLocationTypeDAL.GetEventCallbackLocationTypeByValue(value));
	}

	public void Construct(EventCallbackLocationTypeDAL dal)
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
