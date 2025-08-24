using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class Language : IRobloxEntity<int, LanguageDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private LanguageDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Language).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	internal string LanguageCode
	{
		get
		{
			return _EntityDAL.LanguageCode;
		}
		set
		{
			_EntityDAL.LanguageCode = value;
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

	public Language()
	{
		_EntityDAL = new LanguageDAL();
	}

	public Language(LanguageDAL entityDAL)
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

	internal static Language Get(int id)
	{
		return EntityHelper.GetEntity<int, LanguageDAL, Language>(EntityCacheInfo, id, () => LanguageDAL.Get(id));
	}

	private static ICollection<Language> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, LanguageDAL, Language>(ids, EntityCacheInfo, LanguageDAL.MultiGet);
	}

	public static Language GetByName(string name)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<int, LanguageDAL, Language>(EntityCacheInfo, GetLookupCacheKeysByName(name), () => LanguageDAL.GetLanguageByName(name), Get);
	}

	public static Language GetByLanguageCode(string languageCode)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<int, LanguageDAL, Language>(EntityCacheInfo, GetLookupCacheKeysByLanguageCode(languageCode), () => LanguageDAL.GetLanguageByLanguageCode(languageCode), Get);
	}

	public static Language Create(string name, string nativeName, string languageCode)
	{
		Language language = new Language();
		language.Name = name;
		language.NativeName = nativeName;
		language.LanguageCode = languageCode;
		language.Save();
		return language;
	}

	public void Construct(LanguageDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByName(Name);
		yield return GetLookupCacheKeysByLanguageCode(LanguageCode);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysAll());
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByName(string name)
	{
		return $"Name:{name}";
	}

	private static string GetLookupCacheKeysByLanguageCode(string languageCode)
	{
		return $"LanguageCode:{languageCode}";
	}

	private static string GetLookupCacheKeysAll()
	{
		return "GetAll";
	}
}
