using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Push.Entities.BLL;

internal class ApplicationType : IRobloxEntity<int, ApplicationTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private ApplicationTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ApplicationType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	internal static ApplicationType Get(int id)
	{
		return EntityHelper.GetEntity<int, ApplicationTypeDAL, ApplicationType>(EntityCacheInfo, id, () => ApplicationTypeDAL.Get(id));
	}

	public static ApplicationType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, ApplicationTypeDAL, ApplicationType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => ApplicationTypeDAL.GetApplicationTypeByValue(value));
	}

	public static ApplicationType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, ApplicationType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static ApplicationType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, ApplicationTypeDAL, ApplicationType>(() => ApplicationTypeDAL.GetOrCreateApplicationType(value));
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
		yield break;
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
