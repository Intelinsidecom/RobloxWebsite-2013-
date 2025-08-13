using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.UniverseSettings.Entities;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarTypeEntity : IRobloxEntity<byte, UniverseAvatarTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private UniverseAvatarTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.UniverseAvatarTypes.UniverseAvatarType", isNullCacheable: true);

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

	public UniverseAvatarTypeEntity()
	{
		_EntityDAL = new UniverseAvatarTypeDAL();
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

	internal static UniverseAvatarTypeEntity Get(byte id)
	{
		return EntityHelper.GetEntity<byte, UniverseAvatarTypeDAL, UniverseAvatarTypeEntity>(EntityCacheInfo, id, () => UniverseAvatarTypeDAL.Get(id));
	}

	private static ICollection<UniverseAvatarTypeEntity> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, UniverseAvatarTypeDAL, UniverseAvatarTypeEntity>(ids, EntityCacheInfo, UniverseAvatarTypeDAL.MultiGet);
	}

	public static UniverseAvatarTypeEntity GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, UniverseAvatarTypeDAL, UniverseAvatarTypeEntity>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => UniverseAvatarTypeDAL.GetUniverseAvatarTypeByValue(value));
	}

	public void Construct(UniverseAvatarTypeDAL dal)
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
