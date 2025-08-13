using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Core.Entities;

internal class NotificationSourceType : IRobloxEntity<short, NotificationSourceTypeDAL>, ICacheableObject<short>, ICacheableObject
{
	private const int _MaxSmallIntValue = 32767;

	private NotificationSourceTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(NotificationSourceType).ToString(), isNullCacheable: true);

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

	public NotificationSourceType()
	{
		_EntityDAL = new NotificationSourceTypeDAL();
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

	internal static NotificationSourceType Get(short id)
	{
		if (id > short.MaxValue)
		{
			throw new ArgumentException("id exceeds the maximum value of smallint: " + id);
		}
		return EntityHelper.GetEntity<short, NotificationSourceTypeDAL, NotificationSourceType>(EntityCacheInfo, id, () => NotificationSourceTypeDAL.Get(id));
	}

	private static ICollection<NotificationSourceType> MultiGet(ICollection<short> ids)
	{
		return EntityHelper.MultiGetEntity<short, NotificationSourceTypeDAL, NotificationSourceType>(ids, EntityCacheInfo, NotificationSourceTypeDAL.MultiGet);
	}

	public static NotificationSourceType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<short, NotificationSourceTypeDAL, NotificationSourceType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => NotificationSourceTypeDAL.GetNotificationSourceTypeByValue(value));
	}

	public void Construct(NotificationSourceTypeDAL dal)
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
