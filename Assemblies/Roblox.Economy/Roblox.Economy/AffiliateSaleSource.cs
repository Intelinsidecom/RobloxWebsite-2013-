using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class AffiliateSaleSource : IRobloxEntity<long, AffiliateSaleSourceDAL>, ICacheableObject<long>, ICacheableObject
{
	private AffiliateSaleSourceDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AffiliateSaleSource", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public byte SourceTypeID
	{
		get
		{
			return _EntityDAL.SourceTypeID;
		}
		set
		{
			_EntityDAL.SourceTypeID = value;
		}
	}

	public long SourceID
	{
		get
		{
			return _EntityDAL.SourceID;
		}
		set
		{
			_EntityDAL.SourceID = value;
		}
	}

	public DateTime Created
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

	public DateTime Updated
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

	public AffiliateSaleSource()
	{
		_EntityDAL = new AffiliateSaleSourceDAL();
	}

	public void Save()
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

	public static AffiliateSaleSource CreateNew(byte sourcetypeid, long sourceid)
	{
		AffiliateSaleSource affiliateSaleSource = new AffiliateSaleSource();
		affiliateSaleSource.SourceTypeID = sourcetypeid;
		affiliateSaleSource.SourceID = sourceid;
		affiliateSaleSource.Save();
		return affiliateSaleSource;
	}

	public static AffiliateSaleSource Get(long id)
	{
		return EntityHelper.GetEntity<long, AffiliateSaleSourceDAL, AffiliateSaleSource>(EntityCacheInfo, id, () => AffiliateSaleSourceDAL.Get(id));
	}

	public static AffiliateSaleSource GetOrCreate(long sourceId, byte sourceTypeId)
	{
		return EntityHelper.GetOrCreateEntity<long, AffiliateSaleSource>(EntityCacheInfo, $"SourceID:{sourceId}_SourceTypeID:{sourceTypeId}", () => DoGetOrCreate(sourceId, sourceTypeId));
	}

	private static AffiliateSaleSource DoGetOrCreate(long sourceId, byte sourceTypeId)
	{
		return EntityHelper.DoGetOrCreate<long, AffiliateSaleSourceDAL, AffiliateSaleSource>(() => AffiliateSaleSourceDAL.GetOrCreate(sourceId, sourceTypeId));
	}

	public void Construct(AffiliateSaleSourceDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"SourceID:{SourceID}_SourceTypeID:{SourceTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
