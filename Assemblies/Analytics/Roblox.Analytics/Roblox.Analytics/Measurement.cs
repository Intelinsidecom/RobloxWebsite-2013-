using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Analytics;

public class Measurement : IRobloxEntity<long, MeasurementDAL>, ICacheableObject<long>, ICacheableObject
{
	private MeasurementDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: false, idLookupsAreCacheable: false), "Measurement", isNullCacheable: false);

	public long ID => _EntityDAL.ID;

	internal int MeasurementTypeID
	{
		get
		{
			return _EntityDAL.MeasurementTypeID;
		}
		set
		{
			_EntityDAL.MeasurementTypeID = value;
		}
	}

	internal MeasurementType Type
	{
		get
		{
			return MeasurementType.Get(MeasurementTypeID);
		}
		set
		{
			if (value == null)
			{
				MeasurementTypeID = 0;
			}
			else
			{
				MeasurementTypeID = value.ID;
			}
		}
	}

	internal int? FilterID
	{
		get
		{
			return _EntityDAL.FilterID;
		}
		set
		{
			_EntityDAL.FilterID = value;
		}
	}

	internal Filter Filter
	{
		get
		{
			return Filter.Get(FilterID);
		}
		set
		{
			if (value == null)
			{
				FilterID = null;
			}
			else
			{
				FilterID = value.ID;
			}
		}
	}

	internal int? SecondaryFilterID
	{
		get
		{
			return _EntityDAL.SecondaryFilterID;
		}
		set
		{
			_EntityDAL.SecondaryFilterID = value;
		}
	}

	internal Filter SecondaryFilter
	{
		get
		{
			return Filter.Get(SecondaryFilterID);
		}
		set
		{
			if (value == null)
			{
				SecondaryFilterID = null;
			}
			else
			{
				SecondaryFilterID = value.ID;
			}
		}
	}

	internal DateTime MeasurementDateTime
	{
		get
		{
			return _EntityDAL.MeasurementDateTime;
		}
		set
		{
			_EntityDAL.MeasurementDateTime = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Measurement()
	{
		_EntityDAL = new MeasurementDAL();
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
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static Measurement CreateNew(MeasurementType type, DateTime measurementDateTime, Filter filter, Filter secondaryFilter)
	{
		Measurement measurement = new Measurement();
		measurement.Type = type;
		measurement.MeasurementDateTime = measurementDateTime;
		measurement.Filter = filter;
		measurement.SecondaryFilter = secondaryFilter;
		measurement.Save();
		return measurement;
	}

	internal static Measurement Get(long id)
	{
		return EntityHelper.GetEntity<long, MeasurementDAL, Measurement>(EntityCacheInfo, id, () => MeasurementDAL.Get(id));
	}

	internal static Measurement Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public void Construct(MeasurementDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
