using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class GrantedItemTypeEntity : IRobloxEntity<byte, GrantedItemTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private GrantedItemTypeDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(GrantedItemTypeEntity).ToString(), isNullCacheable: true);

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

	public GrantedItemTypeEntity()
	{
		_EntityDAL = new GrantedItemTypeDAL();
	}

	public GrantedItemTypeEntity(GrantedItemTypeDAL entityDAL)
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
			_EntityDAL.Created = DateTime.UtcNow;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.UtcNow;
			_EntityDAL.Update();
		});
	}

	internal static GrantedItemTypeEntity Get(byte id)
	{
		return EntityHelper.GetEntity<byte, GrantedItemTypeDAL, GrantedItemTypeEntity>(EntityCacheInfo, id, () => GrantedItemTypeDAL.Get(id));
	}

	private static ICollection<GrantedItemTypeEntity> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, GrantedItemTypeDAL, GrantedItemTypeEntity>(ids, EntityCacheInfo, GrantedItemTypeDAL.MultiGet);
	}

	public static GrantedItemTypeEntity GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, GrantedItemTypeDAL, GrantedItemTypeEntity>(EntityCacheInfo, GetCacheQualifierByValue(value), () => GrantedItemTypeDAL.GetGrantedItemTypeByValue(value));
	}

	public void Construct(GrantedItemTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetCacheQualifierByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetCacheQualifierByID(byte id)
	{
		return $"ID:{id}";
	}

	private static string GetCacheQualifierByValue(string value)
	{
		return $"Value:{value}";
	}
}
