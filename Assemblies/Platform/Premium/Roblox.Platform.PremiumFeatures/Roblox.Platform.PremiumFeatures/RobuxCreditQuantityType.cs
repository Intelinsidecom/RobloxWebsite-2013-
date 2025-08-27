using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class RobuxCreditQuantityType : IRobloxEntity<byte, RobuxCreditQuantityTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private RobuxCreditQuantityTypeDAL _EntityDAL;

	internal const string NoneValue = "None";

	public static readonly byte NoneID;

	internal static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
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

	public long Amount
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

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public RobuxCreditQuantityType()
	{
		_EntityDAL = new RobuxCreditQuantityTypeDAL();
	}

	static RobuxCreditQuantityType()
	{
		NoneID = 0;
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "RobuxCreditQuantityType", isNullCacheable: true);
		NoneID = GetByValue("None").ID;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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

	public static RobuxCreditQuantityType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, RobuxCreditQuantityTypeDAL, RobuxCreditQuantityType>(EntityCacheInfo, id, () => RobuxCreditQuantityTypeDAL.Get(id));
	}

	internal static RobuxCreditQuantityType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static RobuxCreditQuantityType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, RobuxCreditQuantityTypeDAL, RobuxCreditQuantityType>(EntityCacheInfo, $"Value:{value}", () => RobuxCreditQuantityTypeDAL.GetByValue(value));
	}

	public void Construct(RobuxCreditQuantityTypeDAL dal)
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
