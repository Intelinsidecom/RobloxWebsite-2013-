using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class ObservedLocale : IRobloxEntity<int, ObservedLocaleDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private ObservedLocaleDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ObservedLocale).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal string Locale
	{
		get
		{
			return _EntityDAL.Locale;
		}
		set
		{
			_EntityDAL.Locale = value;
		}
	}

	internal int? LanguageID
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

	internal int? SupportedLocaleID
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

	public ObservedLocale()
	{
		_EntityDAL = new ObservedLocaleDAL();
	}

	public ObservedLocale(ObservedLocaleDAL entityDAL)
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

	internal static ObservedLocale Get(int id)
	{
		return EntityHelper.GetEntity<int, ObservedLocaleDAL, ObservedLocale>(EntityCacheInfo, id, () => ObservedLocaleDAL.Get(id));
	}

	private static ICollection<ObservedLocale> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, ObservedLocaleDAL, ObservedLocale>(ids, EntityCacheInfo, ObservedLocaleDAL.MultiGet);
	}

	public static ObservedLocale GetByLocale(string locale)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<int, ObservedLocaleDAL, ObservedLocale>(EntityCacheInfo, GetLookupCacheKeysByLocale(locale), () => ObservedLocaleDAL.GetObservedLocaleByLocale(locale), Get);
	}

	public static ObservedLocale Create(string locale, int? languageId = null, int? supportedLocaleId = null)
	{
		ObservedLocale observedLocale = new ObservedLocale();
		observedLocale.Locale = locale;
		observedLocale.LanguageID = languageId;
		observedLocale.SupportedLocaleID = supportedLocaleId;
		observedLocale.Save();
		return observedLocale;
	}

	public void Construct(ObservedLocaleDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByLocale(Locale);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByLocale(string locale)
	{
		return $"Locale:{locale}";
	}
}
