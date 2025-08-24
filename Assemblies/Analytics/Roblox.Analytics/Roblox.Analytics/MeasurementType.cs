using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Analytics;

public class MeasurementType : IRobloxEntity<int, MeasurementTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private MeasurementTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "MeasurementType", isNullCacheable: true);

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

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public MeasurementType()
	{
		_EntityDAL = new MeasurementTypeDAL();
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static MeasurementType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, MeasurementTypeDAL, MeasurementType>(() => MeasurementTypeDAL.GetOrCreate(value));
	}

	internal static MeasurementType Get(int id)
	{
		return EntityHelper.GetEntity<int, MeasurementTypeDAL, MeasurementType>(EntityCacheInfo, id, () => MeasurementTypeDAL.Get(id));
	}

	internal static MeasurementType Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static MeasurementType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, MeasurementType>(EntityCacheInfo, value, () => DoGetOrCreate(value));
	}

	public void Construct(MeasurementTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add(Value);
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
