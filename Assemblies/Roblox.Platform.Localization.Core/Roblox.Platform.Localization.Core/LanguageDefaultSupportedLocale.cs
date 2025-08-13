using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class LanguageDefaultSupportedLocale : IRobloxEntity<int, LanguageDefaultSupportedLocaleDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private LanguageDefaultSupportedLocaleDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(LanguageDefaultSupportedLocale).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal int LanguageID
	{
		get
		{
			return _EntityDAL.LanguageID;
		}
		set
		{
			_EntityDAL.LanguageID = value;
		}
	}

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

	public LanguageDefaultSupportedLocale()
	{
		_EntityDAL = new LanguageDefaultSupportedLocaleDAL();
	}

	public LanguageDefaultSupportedLocale(LanguageDefaultSupportedLocaleDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
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

	internal static LanguageDefaultSupportedLocale Get(int id)
	{
		return EntityHelper.GetEntity<int, LanguageDefaultSupportedLocaleDAL, LanguageDefaultSupportedLocale>(EntityCacheInfo, id, () => LanguageDefaultSupportedLocaleDAL.Get(id));
	}

	private static ICollection<LanguageDefaultSupportedLocale> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, LanguageDefaultSupportedLocaleDAL, LanguageDefaultSupportedLocale>(ids, EntityCacheInfo, LanguageDefaultSupportedLocaleDAL.MultiGet);
	}

	public static LanguageDefaultSupportedLocale GetByLanguageID(int languageId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<int, LanguageDefaultSupportedLocaleDAL, LanguageDefaultSupportedLocale>(EntityCacheInfo, GetLookupCacheKeysByLanguageID(languageId), () => LanguageDefaultSupportedLocaleDAL.GetLanguageDefaultSupportedLocaleByLanguageID(languageId), Get);
	}

	public static LanguageDefaultSupportedLocale Create(int languageId, int supportedLocaleId)
	{
		LanguageDefaultSupportedLocale languageDefaultSupportedLocale = new LanguageDefaultSupportedLocale();
		languageDefaultSupportedLocale.LanguageID = languageId;
		languageDefaultSupportedLocale.SupportedLocaleID = supportedLocaleId;
		languageDefaultSupportedLocale.Save();
		return languageDefaultSupportedLocale;
	}

	public void Construct(LanguageDefaultSupportedLocaleDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByLanguageID(LanguageID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByLanguageID(int languageId)
	{
		return $"LanguageID:{languageId}";
	}
}
