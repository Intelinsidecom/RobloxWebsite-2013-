using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarBodyTypeEntity : IRobloxEntity<byte, UniverseAvatarBodyTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private UniverseAvatarBodyTypeDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UniverseAvatarBodyType).ToString(), isNullCacheable: true);

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

	public UniverseAvatarBodyTypeEntity()
	{
		_EntityDAL = new UniverseAvatarBodyTypeDAL();
	}

	public UniverseAvatarBodyTypeEntity(UniverseAvatarBodyTypeDAL entityDAL)
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

	internal static UniverseAvatarBodyTypeEntity Get(byte id)
	{
		return EntityHelper.GetEntity<byte, UniverseAvatarBodyTypeDAL, UniverseAvatarBodyTypeEntity>(EntityCacheInfo, id, () => UniverseAvatarBodyTypeDAL.Get(id));
	}

	internal static ICollection<UniverseAvatarBodyTypeEntity> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, UniverseAvatarBodyTypeDAL, UniverseAvatarBodyTypeEntity>(ids, EntityCacheInfo, UniverseAvatarBodyTypeDAL.MultiGet);
	}

	public static UniverseAvatarBodyTypeEntity GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, UniverseAvatarBodyTypeDAL, UniverseAvatarBodyTypeEntity>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => UniverseAvatarBodyTypeDAL.GetUniverseAvatarBodyTypeByValue(value));
	}

	public void Construct(UniverseAvatarBodyTypeDAL dal)
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
