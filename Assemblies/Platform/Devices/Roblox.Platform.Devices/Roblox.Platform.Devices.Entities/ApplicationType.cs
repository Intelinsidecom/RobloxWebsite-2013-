using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataV2.Core;

namespace Roblox.Platform.Devices.Entities;

internal class ApplicationType : IRobloxEntity<byte, ApplicationTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private ApplicationTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ApplicationType).ToString(), isNullCacheable: true);

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

	public ApplicationType()
	{
		_EntityDAL = new ApplicationTypeDAL();
	}

	public ApplicationType(ApplicationTypeDAL entityDAL)
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

	internal static ApplicationType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ApplicationTypeDAL, ApplicationType>(EntityCacheInfo, id, () => ApplicationTypeDAL.Get(id));
	}

	private static ICollection<ApplicationType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, ApplicationTypeDAL, ApplicationType>(ids, EntityCacheInfo, ApplicationTypeDAL.MultiGet);
	}

	public static ApplicationType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, ApplicationTypeDAL, ApplicationType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => ApplicationTypeDAL.GetApplicationTypeByValue(value));
	}

	public static ICollection<ApplicationType> GetApplicationTypes(byte? exclusiveStartId, int count, SortOrder sortOrder)
	{
		string collectionId = $"GetApplicationType_ExclusiveStartID:{exclusiveStartId}_Count:{count}_SortOrder:{sortOrder}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysAll()), collectionId, () => ApplicationTypeDAL.GetApplicationTypeIDs(exclusiveStartId, count, sortOrder), MultiGet);
	}

	public void Construct(ApplicationTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysAll());
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}

	private static string GetLookupCacheKeysAll()
	{
		return "GetAll";
	}
}
