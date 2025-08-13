using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetChangeTypeCAL : IRobloxEntity<byte, AssetChangeTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private AssetChangeTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AssetChangeTypeCAL).ToString(), isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

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

	internal string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	internal DateTime Created
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

	internal DateTime Updated
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

	public AssetChangeTypeCAL()
	{
		_EntityDAL = new AssetChangeTypeDAL();
	}

	public AssetChangeTypeCAL(AssetChangeTypeDAL entityDAL)
	{
		_EntityDAL = entityDAL;
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static AssetChangeTypeCAL Get(byte id)
	{
		return EntityHelper.GetEntity<byte, AssetChangeTypeDAL, AssetChangeTypeCAL>(EntityCacheInfo, id, () => AssetChangeTypeDAL.Get(id));
	}

	internal static ICollection<AssetChangeTypeCAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, AssetChangeTypeDAL, AssetChangeTypeCAL>(ids, EntityCacheInfo, AssetChangeTypeDAL.MultiGet);
	}

	public static AssetChangeTypeCAL GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, AssetChangeTypeDAL, AssetChangeTypeCAL>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => AssetChangeTypeDAL.GetAssetChangeTypeByValue(value));
	}

	public void Construct(AssetChangeTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(byte id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
