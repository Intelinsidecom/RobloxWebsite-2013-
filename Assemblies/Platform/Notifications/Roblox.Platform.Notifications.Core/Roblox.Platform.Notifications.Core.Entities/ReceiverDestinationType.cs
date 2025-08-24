using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Core.Entities;

internal class ReceiverDestinationType : IRobloxEntity<short, ReceiverDestinationTypeDAL>, ICacheableObject<short>, ICacheableObject
{
	private const int _MaxSmallIntValue = 32767;

	private ReceiverDestinationTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ReceiverDestinationType).ToString(), isNullCacheable: true);

	public short ID => _EntityDAL.ID;

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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ReceiverDestinationType()
	{
		_EntityDAL = new ReceiverDestinationTypeDAL();
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
			_EntityDAL.Insert();
		}, _EntityDAL.Update);
	}

	internal static ReceiverDestinationType Get(short id)
	{
		if (id > short.MaxValue)
		{
			throw new ArgumentException("id exceeds the maximum value of smallint: " + id);
		}
		return EntityHelper.GetEntity<short, ReceiverDestinationTypeDAL, ReceiverDestinationType>(EntityCacheInfo, id, () => ReceiverDestinationTypeDAL.Get(id));
	}

	private static ICollection<ReceiverDestinationType> MultiGet(ICollection<short> ids)
	{
		return EntityHelper.MultiGetEntity<short, ReceiverDestinationTypeDAL, ReceiverDestinationType>(ids, EntityCacheInfo, ReceiverDestinationTypeDAL.MultiGet);
	}

	public static ReceiverDestinationType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<short, ReceiverDestinationTypeDAL, ReceiverDestinationType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => ReceiverDestinationTypeDAL.GetReceiverDestinationTypeByValue(value));
	}

	public void Construct(ReceiverDestinationTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
