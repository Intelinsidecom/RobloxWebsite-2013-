using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Users.DAL;

namespace Roblox.Users;

public class LanguageType : IRobloxEntity<short, LanguageTypeDAL>, ICacheableObject<short>, ICacheableObject
{
	private LanguageTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Users.LanguageType", isNullCacheable: true);

	public static LanguageType DefaultLanguageType => GetByValue("English");

	public short ID => _EntityDAL.ID;

	public string Value
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

	public string NativeName
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

	public string Code
	{
		get
		{
			return _EntityDAL.Code;
		}
		set
		{
			_EntityDAL.Code = value;
		}
	}

	public bool Active
	{
		get
		{
			return _EntityDAL.Active;
		}
		set
		{
			_EntityDAL.Active = value;
		}
	}

	public DateTime Created
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

	public DateTime Updated
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

	public LanguageType()
	{
		_EntityDAL = new LanguageTypeDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static LanguageType CreateNew(string value, string nativename, string code, bool active)
	{
		LanguageType languageType = new LanguageType();
		languageType.Value = value;
		languageType.NativeName = nativename;
		languageType.Code = code;
		languageType.Active = active;
		languageType.Save();
		return languageType;
	}

	public static LanguageType Get(short id)
	{
		return EntityHelper.GetEntity<short, LanguageTypeDAL, LanguageType>(EntityCacheInfo, id, () => LanguageTypeDAL.Get(id));
	}

	public static LanguageType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<short, LanguageTypeDAL, LanguageType>(EntityCacheInfo, $"Value:{value}", () => LanguageTypeDAL.GetByValue(value));
	}

	public static LanguageType GetByCode(string code)
	{
		return EntityHelper.GetEntityByLookup<short, LanguageTypeDAL, LanguageType>(EntityCacheInfo, $"Code:{code}", () => LanguageTypeDAL.GetByCode(code));
	}

	public static ICollection<LanguageType> GetActiveLanguageTypes()
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(), "ActiveLanguageTypes", LanguageTypeDAL.GetActiveLanguageTypeIDs, Get);
	}

	public static bool IsLanguageCodeActive(string languageCode)
	{
		if (string.IsNullOrEmpty(languageCode) || languageCode.Length > 2)
		{
			return false;
		}
		return GetByCode(languageCode)?.Active ?? false;
	}

	public void Construct(LanguageTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
		yield return $"Code:{Code}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
