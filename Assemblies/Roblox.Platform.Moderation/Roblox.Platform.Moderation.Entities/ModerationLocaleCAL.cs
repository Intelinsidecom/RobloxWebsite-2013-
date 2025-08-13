using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Moderation.Entities;

[ExcludeFromCodeCoverage]
internal class ModerationLocaleCAL : IRobloxEntity<int, ModerationLocaleDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private ModerationLocaleDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(ModerationLocaleCAL).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal int SupportedLocaleID
	{
		get
		{
			return _EntityDAL.SupportedLocaleID;
		}
		set
		{
			_EntityDAL.SupportedLocaleID = value;
		}
	}

	internal bool IsActive
	{
		get
		{
			return _EntityDAL.IsActive;
		}
		set
		{
			_EntityDAL.IsActive = value;
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

	public ModerationLocaleCAL()
	{
		_EntityDAL = new ModerationLocaleDAL();
	}

	public ModerationLocaleCAL(ModerationLocaleDAL entityDAL)
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

	internal static ModerationLocaleCAL Get(int id)
	{
		return EntityHelper.GetEntity<int, ModerationLocaleDAL, ModerationLocaleCAL>(EntityCacheInfo, id, () => ModerationLocaleDAL.Get(id));
	}

	internal static ICollection<ModerationLocaleCAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, ModerationLocaleDAL, ModerationLocaleCAL>(ids, EntityCacheInfo, ModerationLocaleDAL.MultiGet);
	}

	public static ModerationLocaleCAL GetBySupportedLocaleID(int supportedLocaleId)
	{
		return EntityHelper.GetEntityByLookup<int, ModerationLocaleDAL, ModerationLocaleCAL>(EntityCacheInfo, GetLookupCacheKeysBySupportedLocaleID(supportedLocaleId), () => ModerationLocaleDAL.GetModerationLocaleBySupportedLocaleID(supportedLocaleId));
	}

	internal static ICollection<ModerationLocaleCAL> GetModerationLocalesByIsActive(bool isActive, int count, int exclusiveStartId)
	{
		string collectionId = $"GetModerationLocalesByIsActive_IsActive:{isActive}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => ModerationLocaleDAL.GetModerationLocaleIDsByIsActive(isActive, count, exclusiveStartId), MultiGet);
	}

	public static ModerationLocaleCAL GetOrCreate(int supportedLocaleId)
	{
		return EntityHelper.GetOrCreateEntity<int, ModerationLocaleCAL>(EntityCacheInfo, GetLookupCacheKeysBySupportedLocaleID(supportedLocaleId), () => DoGetOrCreate(supportedLocaleId));
	}

	private static ModerationLocaleCAL DoGetOrCreate(int supportedLocaleId)
	{
		return EntityHelper.DoGetOrCreate<int, ModerationLocaleDAL, ModerationLocaleCAL>(() => ModerationLocaleDAL.GetOrCreateModerationLocale(supportedLocaleId));
	}

	public void Construct(ModerationLocaleDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysBySupportedLocaleID(SupportedLocaleID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByIsActive(IsActive));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(int id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysBySupportedLocaleID(int supportedLocaleId)
	{
		return $"SupportedLocaleID:{supportedLocaleId}";
	}

	private static string GetLookupCacheKeysByIsActive(bool isActive)
	{
		return $"IsActive:{isActive}";
	}
}
