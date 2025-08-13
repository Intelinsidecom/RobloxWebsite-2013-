using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class AdvertisingSuppressionType : IRobloxEntity<byte, AdvertisingSuppressionTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private AdvertisingSuppressionTypeDAL _EntityDAL;

	public const string NoneValue = "None";

	public static readonly byte NoneID;

	public const string ExternalValue = "External";

	public static readonly byte ExternalID;

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

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AdvertisingSuppressionType()
	{
		_EntityDAL = new AdvertisingSuppressionTypeDAL();
	}

	static AdvertisingSuppressionType()
	{
		NoneID = 0;
		ExternalID = 0;
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AdvertisingSuppressionType", isNullCacheable: true);
		NoneID = GetByValue("None").ID;
		ExternalID = GetByValue("External").ID;
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

	public static AdvertisingSuppressionType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, AdvertisingSuppressionTypeDAL, AdvertisingSuppressionType>(EntityCacheInfo, id, () => AdvertisingSuppressionTypeDAL.Get(id));
	}

	internal static AdvertisingSuppressionType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static AdvertisingSuppressionType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, AdvertisingSuppressionTypeDAL, AdvertisingSuppressionType>(EntityCacheInfo, $"Value:{value}", () => AdvertisingSuppressionTypeDAL.GetByValue(value));
	}

	public void Construct(AdvertisingSuppressionTypeDAL dal)
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
