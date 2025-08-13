using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Analytics;

public class DoubleDataItem : IRobloxEntity<long, DoubleDataItemDAL>, ICacheableObject<long>, ICacheableObject
{
	private DoubleDataItemDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: false, idLookupsAreCacheable: false), "DoubleDataItem", isNullCacheable: false);

	public long ID => _EntityDAL.ID;

	internal long MeasurementID
	{
		get
		{
			return _EntityDAL.MeasurementID;
		}
		set
		{
			_EntityDAL.MeasurementID = value;
		}
	}

	internal Measurement Measurement
	{
		get
		{
			return Measurement.Get(MeasurementID);
		}
		set
		{
			if (value == null)
			{
				MeasurementID = 0L;
			}
			else
			{
				MeasurementID = value.ID;
			}
		}
	}

	internal long KeyExpressionID
	{
		get
		{
			return _EntityDAL.KeyExpressionID;
		}
		set
		{
			_EntityDAL.KeyExpressionID = value;
		}
	}

	internal Expression Key
	{
		get
		{
			return Expression.Get(KeyExpressionID);
		}
		set
		{
			if (value == null)
			{
				KeyExpressionID = 0L;
			}
			else
			{
				KeyExpressionID = value.ID;
			}
		}
	}

	internal double Value
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public DoubleDataItem()
	{
		_EntityDAL = new DoubleDataItemDAL();
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

	internal static DoubleDataItem CreateNew(Measurement measurement, Expression key, double value)
	{
		DoubleDataItem doubleDataItem = new DoubleDataItem();
		doubleDataItem.Measurement = measurement;
		doubleDataItem.Key = key;
		doubleDataItem.Value = value;
		doubleDataItem.Save();
		return doubleDataItem;
	}

	internal static DoubleDataItem Get(long id)
	{
		return EntityHelper.GetEntity<long, DoubleDataItemDAL, DoubleDataItem>(EntityCacheInfo, id, () => DoubleDataItemDAL.Get(id));
	}

	internal static DoubleDataItem Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public void Construct(DoubleDataItemDAL dal)
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
