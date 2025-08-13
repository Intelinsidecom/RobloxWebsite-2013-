using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class DurationType : IRobloxEntity<byte, DurationTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private DurationTypeDAL _EntityDAL;

	public const string NoneValue = "None";

	public static readonly byte NoneID;

	public const string OneMonthValue = "1 Month";

	public static readonly byte OneMonthID;

	public const string FortyFiveDaysValue = "45 Days";

	public static readonly byte FortyFiveDaysID;

	public const string SixMonthsValue = "6 Months";

	public static readonly byte SixMonthsID;

	public const string TwelveMonthsValue = "12 Months";

	public static readonly byte TwelveMonthsID;

	public const string LifetimeValue = "Lifetime";

	public static readonly byte LifetimeID;

	internal static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	internal string Value
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

	internal long Amount
	{
		get
		{
			return _EntityDAL.Amount;
		}
		set
		{
			_EntityDAL.Amount = value;
		}
	}

	public TimeSpan AmountTimeSpan => TimeSpan.FromTicks(Amount);

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public DurationType()
	{
		_EntityDAL = new DurationTypeDAL();
	}

	static DurationType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "DurationType", isNullCacheable: true);
		NoneID = GetByValue("None").ID;
		OneMonthID = GetByValue("1 Month").ID;
		SixMonthsID = GetByValue("6 Months").ID;
		TwelveMonthsID = GetByValue("12 Months").ID;
		LifetimeID = GetByValue("Lifetime").ID;
		FortyFiveDaysID = GetByValue("45 Days").ID;
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

	public static DurationType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, DurationTypeDAL, DurationType>(EntityCacheInfo, id, () => DurationTypeDAL.Get(id));
	}

	internal static DurationType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static DurationType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, DurationTypeDAL, DurationType>(EntityCacheInfo, $"Value:{value}", () => DurationTypeDAL.GetByValue(value));
	}

	public void Construct(DurationTypeDAL dal)
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
