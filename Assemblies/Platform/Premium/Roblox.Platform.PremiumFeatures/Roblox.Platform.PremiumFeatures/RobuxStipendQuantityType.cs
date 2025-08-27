using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class RobuxStipendQuantityType : IRobloxEntity<byte, RobuxStipendQuantityTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private RobuxStipendQuantityTypeDAL _EntityDAL;

	public const string NoneValue = "None";

	public static readonly byte NoneID;

	public const string FifteenValue = "15";

	public static readonly byte FifteenID;

	public const string ThirtyFiveValue = "35";

	public static readonly byte ThirtyFiveID;

	public const string SixtyValue = "60";

	public static readonly byte SixtyID;

	public const string OneHundredValue = "100";

	public static readonly byte OneHundredID;

	internal static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		private set
		{
			_EntityDAL.Value = value;
		}
	}

	public long Amount
	{
		get
		{
			return _EntityDAL.Amount;
		}
		private set
		{
			_EntityDAL.Amount = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public RobuxStipendQuantityType()
	{
		_EntityDAL = new RobuxStipendQuantityTypeDAL();
	}

	static RobuxStipendQuantityType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "RobuxStipendQuantityType", isNullCacheable: true);
		NoneID = GetByValue("None").ID;
		FifteenID = GetByValue("15").ID;
		ThirtyFiveID = GetByValue("35").ID;
		SixtyID = GetByValue("60").ID;
		OneHundredID = GetByValue("100").ID;
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

	public static RobuxStipendQuantityType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, RobuxStipendQuantityTypeDAL, RobuxStipendQuantityType>(EntityCacheInfo, id, () => RobuxStipendQuantityTypeDAL.Get(id));
	}

	internal static RobuxStipendQuantityType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static RobuxStipendQuantityType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, RobuxStipendQuantityTypeDAL, RobuxStipendQuantityType>(EntityCacheInfo, $"Value:{value}", () => RobuxStipendQuantityTypeDAL.GetByValue(value));
	}

	public void Construct(RobuxStipendQuantityTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Value:{Value}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
