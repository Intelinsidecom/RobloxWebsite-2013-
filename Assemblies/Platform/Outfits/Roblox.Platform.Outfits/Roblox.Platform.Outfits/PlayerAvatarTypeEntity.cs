using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Outfits;

internal class PlayerAvatarTypeEntity : IRobloxEntity<byte, PlayerAvatarTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PlayerAvatarTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.PlayerAvatarType.PlayerAvatarType", isNullCacheable: true);

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

	public PlayerAvatarTypeEntity()
	{
		_EntityDAL = new PlayerAvatarTypeDAL();
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

	internal static PlayerAvatarTypeEntity Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PlayerAvatarTypeDAL, PlayerAvatarTypeEntity>(EntityCacheInfo, id, () => PlayerAvatarTypeDAL.Get(id));
	}

	private static ICollection<PlayerAvatarTypeEntity> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, PlayerAvatarTypeDAL, PlayerAvatarTypeEntity>(ids, EntityCacheInfo, PlayerAvatarTypeDAL.MultiGet);
	}

	public static PlayerAvatarTypeEntity GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, PlayerAvatarTypeDAL, PlayerAvatarTypeEntity>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => PlayerAvatarTypeDAL.GetPlayerAvatarTypeByValue(value));
	}

	public void Construct(PlayerAvatarTypeDAL dal)
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
