using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class TakeoverAge : IRobloxEntity<int, TakeoverAgeDAL>, ICacheableObject<int>, ICacheableObject
{
	private TakeoverAgeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(TakeoverAge).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal int TakeoverID
	{
		get
		{
			return _EntityDAL.TakeoverID;
		}
		set
		{
			_EntityDAL.TakeoverID = value;
		}
	}

	public byte? MinAgeInYears
	{
		get
		{
			return _EntityDAL.MinAgeInYears;
		}
		set
		{
			_EntityDAL.MinAgeInYears = value;
		}
	}

	public byte? MaxAgeInYears
	{
		get
		{
			return _EntityDAL.MaxAgeInYears;
		}
		set
		{
			_EntityDAL.MaxAgeInYears = value;
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

	public TakeoverAge()
	{
		_EntityDAL = new TakeoverAgeDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static TakeoverAge CreateNew(int takeoverid, byte? minageinyears, byte? maxageinyears)
	{
		TakeoverAge takeoverAge = new TakeoverAge();
		takeoverAge.TakeoverID = takeoverid;
		takeoverAge.MinAgeInYears = minageinyears;
		takeoverAge.MaxAgeInYears = maxageinyears;
		takeoverAge.Save();
		return takeoverAge;
	}

	internal static TakeoverAge Get(int id)
	{
		return EntityHelper.GetEntity<int, TakeoverAgeDAL, TakeoverAge>(EntityCacheInfo, id, () => TakeoverAgeDAL.Get(id));
	}

	public static TakeoverAge GetByTakeoverID(int TakeoverID)
	{
		return EntityHelper.GetEntityByLookup<int, TakeoverAgeDAL, TakeoverAge>(EntityCacheInfo, $"TakeoverID:{TakeoverID}", () => TakeoverAgeDAL.GetByTakeoverID(TakeoverID));
	}

	public void Construct(TakeoverAgeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"TakeoverID:{TakeoverID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
