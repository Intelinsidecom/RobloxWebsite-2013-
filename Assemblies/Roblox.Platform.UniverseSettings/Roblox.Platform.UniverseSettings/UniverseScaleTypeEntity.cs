using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseScaleTypeEntity : IRobloxEntity<byte, UniverseScaleTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private UniverseScaleTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UniverseScaleTypeEntity).ToString(), isNullCacheable: true);

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

	public UniverseScaleTypeEntity()
	{
		_EntityDAL = new UniverseScaleTypeDAL();
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

	internal static UniverseScaleTypeEntity Get(byte id)
	{
		return EntityHelper.GetEntity<byte, UniverseScaleTypeDAL, UniverseScaleTypeEntity>(EntityCacheInfo, id, () => UniverseScaleTypeDAL.Get(id));
	}

	private static ICollection<UniverseScaleTypeEntity> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, UniverseScaleTypeDAL, UniverseScaleTypeEntity>(ids, EntityCacheInfo, UniverseScaleTypeDAL.MultiGet);
	}

	public static UniverseScaleTypeEntity GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, UniverseScaleTypeDAL, UniverseScaleTypeEntity>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => UniverseScaleTypeDAL.GetUniverseScaleTypeByValue(value));
	}

	public void Construct(UniverseScaleTypeDAL dal)
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

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
