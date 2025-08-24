using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class SupportedLocale : IRobloxEntity<int, SupportedLocaleDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private SupportedLocaleDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(SupportedLocale).ToString(), isNullCacheable: true);

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

	internal string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

	internal string NativeName
	{
		get
		{
			return _EntityDAL.NativeName;
		}
		set
		{
			_EntityDAL.NativeName = value;
		}
	}

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

	public SupportedLocale()
	{
		_EntityDAL = new SupportedLocaleDAL();
	}

	public SupportedLocale(SupportedLocaleDAL entityDAL)
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

	internal static SupportedLocale Get(int id)
	{
		return EntityHelper.GetEntity<int, SupportedLocaleDAL, SupportedLocale>(EntityCacheInfo, id, () => SupportedLocaleDAL.Get(id));
	}

	private static ICollection<SupportedLocale> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, SupportedLocaleDAL, SupportedLocale>(ids, EntityCacheInfo, SupportedLocaleDAL.MultiGet);
	}

	public static SupportedLocale GetByLocale(string locale)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<int, SupportedLocaleDAL, SupportedLocale>(EntityCacheInfo, GetLookupCacheKeysByLocale(locale), () => SupportedLocaleDAL.GetSupportedLocaleByLocale(locale), Get);
	}

	public static SupportedLocale Create(string locale, string name, string nativeName, int languageId)
	{
		SupportedLocale supportedLocale = new SupportedLocale();
		supportedLocale.Locale = locale;
		supportedLocale.Name = name;
		supportedLocale.NativeName = nativeName;
		supportedLocale.Save();
		return supportedLocale;
	}

	public static ICollection<SupportedLocale> GetSupportedLocalesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetSupportedLocalesPaged_SupportedLocales_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysAll()), collectionId, () => SupportedLocaleDAL.GetSupportedLocaleIDsPaged(startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(SupportedLocaleDAL dal)
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

	private static string GetLookupCacheKeysAll()
	{
		return "GetAll";
	}

	private static string GetLookupCacheKeysByLocale(string locale)
	{
		return $"Locale:{locale}";
	}
}
