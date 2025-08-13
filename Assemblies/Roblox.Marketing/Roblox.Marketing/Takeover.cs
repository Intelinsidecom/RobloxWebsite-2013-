using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class Takeover : IRobloxEntity<int, TakeoverDAL>, ICacheableObject<int>, ICacheableObject
{
	private TakeoverDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(Takeover).ToString(), isNullCacheable: true);

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

	public byte TakeoverTypeID
	{
		get
		{
			return _EntityDAL.TakeoverTypeID;
		}
		set
		{
			_EntityDAL.TakeoverTypeID = value;
		}
	}

	public DateTime StartTime
	{
		get
		{
			return _EntityDAL.StartTime;
		}
		set
		{
			_EntityDAL.StartTime = value;
		}
	}

	public DateTime EndTime
	{
		get
		{
			return _EntityDAL.EndTime;
		}
		set
		{
			_EntityDAL.EndTime = value;
		}
	}

	public int? FrequencyCap
	{
		get
		{
			return _EntityDAL.FrequencyCap;
		}
		set
		{
			_EntityDAL.FrequencyCap = value;
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

	public Takeover()
	{
		_EntityDAL = new TakeoverDAL();
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

	public static Takeover CreateNew(string name, byte takeovertypeid, DateTime starttime, DateTime endtime, int? frequencyCap = null)
	{
		Takeover takeover = new Takeover();
		takeover.Name = name;
		takeover.TakeoverTypeID = takeovertypeid;
		takeover.StartTime = starttime;
		takeover.EndTime = endtime;
		takeover.FrequencyCap = frequencyCap;
		takeover.Save();
		return takeover;
	}

	public static Takeover Get(int id)
	{
		return EntityHelper.GetEntity<int, TakeoverDAL, Takeover>(EntityCacheInfo, id, () => TakeoverDAL.Get(id));
	}

	public static ICollection<Takeover> GetActiveTakeovers(DateTime currentTime)
	{
		string collectionId = "GetActiveTakeovers";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(TimeSpan.FromMinutes(5.0)), collectionId, () => TakeoverDAL.GetActiveTakeoverIDs(currentTime), Get);
	}

	public static ICollection<Takeover> GetTakeovers_Paged(int startIndex, int maxRows)
	{
		string collectionId = $"GetTakeovers_Paged_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => TakeoverDAL.GetTakeoverIDs_Paged(startIndex + 1, maxRows), Get);
	}

	public static int GetTotalNumberOfTakeovers()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), string.Empty, TakeoverDAL.GetTotalNumberOfTakeovers);
	}

	public void Construct(TakeoverDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("GetActiveTakeovers");
	}
}
