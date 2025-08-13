using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class ShowcaseAllotmentType : IRobloxEntity<byte, ShowcaseAllotmentTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ShowcaseAllotmentTypeDAL _EntityDAL;

	public const string NoneValue = "None";

	public static readonly byte NoneID;

	public const string TenValue = "10";

	public static readonly byte TenID;

	public const string TwentyFiveValue = "25";

	public static readonly byte TwentyFiveID;

	public const string OneHundredValue = "100";

	public static readonly byte OneHundredID;

	public static readonly byte MaximumNumberOfShowcases;

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

	public byte Amount
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

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ShowcaseAllotmentType()
	{
		_EntityDAL = new ShowcaseAllotmentTypeDAL();
	}

	static ShowcaseAllotmentType()
	{
		MaximumNumberOfShowcases = byte.MaxValue;
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "ShowcaseAllotmentType", isNullCacheable: true);
		NoneID = GetByValue("None").ID;
		TenID = GetByValue("10").ID;
		TwentyFiveID = GetByValue("25").ID;
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

	public static ShowcaseAllotmentType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ShowcaseAllotmentTypeDAL, ShowcaseAllotmentType>(EntityCacheInfo, id, () => ShowcaseAllotmentTypeDAL.Get(id));
	}

	internal static ShowcaseAllotmentType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static ShowcaseAllotmentType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, ShowcaseAllotmentTypeDAL, ShowcaseAllotmentType>(EntityCacheInfo, $"Value:{value}", () => ShowcaseAllotmentTypeDAL.GetByValue(value));
	}

	public void Construct(ShowcaseAllotmentTypeDAL dal)
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
