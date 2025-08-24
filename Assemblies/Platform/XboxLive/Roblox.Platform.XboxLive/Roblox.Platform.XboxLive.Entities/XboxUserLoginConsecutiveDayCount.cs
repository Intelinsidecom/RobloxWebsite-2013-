using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.XboxLive.Entities;

internal class XboxUserLoginConsecutiveDayCount : IRobloxEntity<int, XboxUserLoginConsecutiveDayCountDAL>, ICacheableObject<int>, ICacheableObject
{
	private XboxUserLoginConsecutiveDayCountDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(XboxUserLoginConsecutiveDayCount).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
		}
	}

	internal int Count
	{
		get
		{
			return _EntityDAL.Count;
		}
		set
		{
			_EntityDAL.Count = value;
		}
	}

	internal DateTime? ClientLastSeen
	{
		get
		{
			return _EntityDAL.ClientLastSeen;
		}
		set
		{
			_EntityDAL.ClientLastSeen = value;
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

	public XboxUserLoginConsecutiveDayCount()
	{
		_EntityDAL = new XboxUserLoginConsecutiveDayCountDAL();
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

	internal static XboxUserLoginConsecutiveDayCount Get(int id)
	{
		return EntityHelper.GetEntity<int, XboxUserLoginConsecutiveDayCountDAL, XboxUserLoginConsecutiveDayCount>(EntityCacheInfo, id, () => XboxUserLoginConsecutiveDayCountDAL.Get(id));
	}

	public void Increment()
	{
		_EntityDAL.Increment();
		CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
	}

	internal static ICollection<XboxUserLoginConsecutiveDayCount> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, XboxUserLoginConsecutiveDayCountDAL, XboxUserLoginConsecutiveDayCount>(ids, EntityCacheInfo, XboxUserLoginConsecutiveDayCountDAL.MultiGet);
	}

	public static XboxUserLoginConsecutiveDayCount GetOrCreate(long userId)
	{
		return EntityHelper.GetOrCreateEntity<int, XboxUserLoginConsecutiveDayCount>(EntityCacheInfo, $"UserID:{userId}", () => DoGetOrCreate(userId));
	}

	private static XboxUserLoginConsecutiveDayCount DoGetOrCreate(long userId)
	{
		return EntityHelper.DoGetOrCreate<int, XboxUserLoginConsecutiveDayCountDAL, XboxUserLoginConsecutiveDayCount>(() => XboxUserLoginConsecutiveDayCountDAL.GetOrCreateXboxUserLoginConsecutiveDayCount(userId));
	}

	public static XboxUserLoginConsecutiveDayCount GetByUserID(long userId)
	{
		return EntityHelper.GetEntityByLookup<int, XboxUserLoginConsecutiveDayCountDAL, XboxUserLoginConsecutiveDayCount>(EntityCacheInfo, $"UserID:{userId}", () => XboxUserLoginConsecutiveDayCountDAL.GetXboxUserLoginConsecutiveDayCountByUserID(userId));
	}

	public void Construct(XboxUserLoginConsecutiveDayCountDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
