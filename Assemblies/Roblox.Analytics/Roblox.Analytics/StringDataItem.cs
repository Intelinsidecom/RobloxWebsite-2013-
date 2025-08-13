using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Analytics;

public class StringDataItem : IRobloxEntity<long, StringDataItemDAL>, ICacheableObject<long>, ICacheableObject
{
	private StringDataItemDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: false, idLookupsAreCacheable: false), "StringDataItem", isNullCacheable: false);

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

	internal long ValueExpressionID
	{
		get
		{
			return _EntityDAL.ValueExpressionID;
		}
		set
		{
			_EntityDAL.ValueExpressionID = value;
		}
	}

	internal Expression Value
	{
		get
		{
			return Expression.Get(ValueExpressionID);
		}
		set
		{
			if (value == null)
			{
				ValueExpressionID = 0L;
			}
			else
			{
				ValueExpressionID = value.ID;
			}
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public StringDataItem()
	{
		_EntityDAL = new StringDataItemDAL();
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

	internal static StringDataItem CreateNew(Measurement measurement, string key, string value)
	{
		Expression i = Expression.GetOrCreate(key);
		Expression v = Expression.GetOrCreate(value);
		return CreateNew(measurement, i, v);
	}

	internal static StringDataItem CreateNew(Measurement measurement, Expression key, Expression value)
	{
		StringDataItem stringDataItem = new StringDataItem();
		stringDataItem.Measurement = measurement;
		stringDataItem.Key = key;
		stringDataItem.Value = value;
		stringDataItem.Save();
		return stringDataItem;
	}

	internal static StringDataItem Get(long id)
	{
		return EntityHelper.GetEntity<long, StringDataItemDAL, StringDataItem>(EntityCacheInfo, id, () => StringDataItemDAL.Get(id));
	}

	internal static StringDataItem Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public void Construct(StringDataItemDAL dal)
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
