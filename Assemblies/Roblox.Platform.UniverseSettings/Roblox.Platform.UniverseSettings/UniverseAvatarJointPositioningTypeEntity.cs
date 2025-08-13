using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarJointPositioningTypeEntity : IRobloxEntity<byte, UniverseAvatarJointPositioningTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private UniverseAvatarJointPositioningTypeDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UniverseAvatarJointPositioningTypeEntity).ToString(), isNullCacheable: true);

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

	public UniverseAvatarJointPositioningTypeEntity()
	{
		_EntityDAL = new UniverseAvatarJointPositioningTypeDAL();
	}

	public UniverseAvatarJointPositioningTypeEntity(UniverseAvatarJointPositioningTypeDAL entityDAL)
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

	internal static UniverseAvatarJointPositioningTypeEntity Get(byte id)
	{
		return EntityHelper.GetEntity<byte, UniverseAvatarJointPositioningTypeDAL, UniverseAvatarJointPositioningTypeEntity>(EntityCacheInfo, id, () => UniverseAvatarJointPositioningTypeDAL.Get(id));
	}

	internal static ICollection<UniverseAvatarJointPositioningTypeEntity> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, UniverseAvatarJointPositioningTypeDAL, UniverseAvatarJointPositioningTypeEntity>(ids, EntityCacheInfo, UniverseAvatarJointPositioningTypeDAL.MultiGet);
	}

	public static UniverseAvatarJointPositioningTypeEntity GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, UniverseAvatarJointPositioningTypeDAL, UniverseAvatarJointPositioningTypeEntity>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => UniverseAvatarJointPositioningTypeDAL.GetUniverseAvatarJointPositioningTypeByValue(value));
	}

	public void Construct(UniverseAvatarJointPositioningTypeDAL dal)
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
