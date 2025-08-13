using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarAnimationTypeEntity : IRobloxEntity<byte, UniverseAvatarAnimationTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private UniverseAvatarAnimationTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UniverseAvatarAnimationTypeEntity).ToString(), isNullCacheable: true);

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

	public UniverseAvatarAnimationTypeEntity()
	{
		_EntityDAL = new UniverseAvatarAnimationTypeDAL();
	}

	public UniverseAvatarAnimationTypeEntity(UniverseAvatarAnimationTypeDAL entityDAL)
	{
		_EntityDAL = new UniverseAvatarAnimationTypeDAL();
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

	internal static UniverseAvatarAnimationTypeEntity Get(byte id)
	{
		return EntityHelper.GetEntity<byte, UniverseAvatarAnimationTypeDAL, UniverseAvatarAnimationTypeEntity>(EntityCacheInfo, id, () => UniverseAvatarAnimationTypeDAL.Get(id));
	}

	private static ICollection<UniverseAvatarAnimationTypeEntity> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, UniverseAvatarAnimationTypeDAL, UniverseAvatarAnimationTypeEntity>(ids, EntityCacheInfo, UniverseAvatarAnimationTypeDAL.MultiGet);
	}

	public static UniverseAvatarAnimationTypeEntity GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, UniverseAvatarAnimationTypeDAL, UniverseAvatarAnimationTypeEntity>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => UniverseAvatarAnimationTypeDAL.GetUniverseAvatarAnimationTypeByValue(value));
	}

	public void Construct(UniverseAvatarAnimationTypeDAL dal)
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

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
