using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Core.Entities;

internal class ReceiverType : IRobloxEntity<int, ReceiverTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private ReceiverTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ReceiverType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public ReceiverType()
	{
		_EntityDAL = new ReceiverTypeDAL();
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

	internal static ReceiverType Get(int id)
	{
		return EntityHelper.GetEntity<int, ReceiverTypeDAL, ReceiverType>(EntityCacheInfo, id, () => ReceiverTypeDAL.Get(id));
	}

	private static ICollection<ReceiverType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, ReceiverTypeDAL, ReceiverType>(ids, EntityCacheInfo, ReceiverTypeDAL.MultiGet);
	}

	public static ReceiverType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, ReceiverTypeDAL, ReceiverType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => ReceiverTypeDAL.GetReceiverTypeByValue(value));
	}

	public static ReceiverType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, ReceiverType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static ReceiverType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, ReceiverTypeDAL, ReceiverType>(() => ReceiverTypeDAL.GetOrCreateReceiverType(value));
	}

	public void Construct(ReceiverTypeDAL dal)
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
