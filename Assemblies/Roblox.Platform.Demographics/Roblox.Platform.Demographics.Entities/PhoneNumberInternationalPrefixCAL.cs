using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Demographics.Entities;

[ExcludeFromCodeCoverage]
internal class PhoneNumberInternationalPrefixCAL : IRobloxEntity<short, PhoneNumberInternationalPrefixDAL>, ICacheableObject<short>, ICacheableObject, IRemoteCacheableObject
{
	private PhoneNumberInternationalPrefixDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PhoneNumberInternationalPrefixCAL).ToString(), isNullCacheable: true);

	public short ID => _EntityDAL.ID;

	internal int CountryID
	{
		get
		{
			return _EntityDAL.CountryID;
		}
		set
		{
			_EntityDAL.CountryID = value;
		}
	}

	internal string InternationalPrefix
	{
		get
		{
			return _EntityDAL.InternationalPrefix;
		}
		set
		{
			_EntityDAL.InternationalPrefix = value;
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

	public PhoneNumberInternationalPrefixCAL()
	{
		_EntityDAL = new PhoneNumberInternationalPrefixDAL();
	}

	public PhoneNumberInternationalPrefixCAL(PhoneNumberInternationalPrefixDAL entityDAL)
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

	internal static PhoneNumberInternationalPrefixCAL Get(short id)
	{
		return EntityHelper.GetEntity<short, PhoneNumberInternationalPrefixDAL, PhoneNumberInternationalPrefixCAL>(EntityCacheInfo, id, () => PhoneNumberInternationalPrefixDAL.Get(id));
	}

	private static ICollection<PhoneNumberInternationalPrefixCAL> MultiGet(ICollection<short> ids)
	{
		return EntityHelper.MultiGetEntity<short, PhoneNumberInternationalPrefixDAL, PhoneNumberInternationalPrefixCAL>(ids, EntityCacheInfo, PhoneNumberInternationalPrefixDAL.MultiGet);
	}

	public static PhoneNumberInternationalPrefixCAL GetOrCreate(int countryId, string internationalPrefix)
	{
		return EntityHelper.GetOrCreateEntity<short, PhoneNumberInternationalPrefixCAL>(EntityCacheInfo, GetLookupCacheKeysByCountryIDInternationalPrefix(countryId, internationalPrefix), () => DoGetOrCreate(countryId, internationalPrefix));
	}

	private static PhoneNumberInternationalPrefixCAL DoGetOrCreate(int countryId, string internationalPrefix)
	{
		return EntityHelper.DoGetOrCreate<short, PhoneNumberInternationalPrefixDAL, PhoneNumberInternationalPrefixCAL>(() => PhoneNumberInternationalPrefixDAL.GetOrCreatePhoneNumberInternationalPrefix(countryId, internationalPrefix));
	}

	internal static ICollection<PhoneNumberInternationalPrefixCAL> GetPhoneNumberInternationalPrefixesByIsActive(bool isActive, int count, short? exclusiveStartPhoneNumberInternationalPrefixId)
	{
		string collectionId = $"GetPhoneNumberInternationalPrefixesByIsActive_IsActive:{isActive}_Count:{count}_ExclusiveStartPhoneNumberInternationalPrefixID:{exclusiveStartPhoneNumberInternationalPrefixId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByIsActive(isActive)), collectionId, () => PhoneNumberInternationalPrefixDAL.GetPhoneNumberInternationalPrefixIDsByIsActive(isActive, count, exclusiveStartPhoneNumberInternationalPrefixId), MultiGet);
	}

	public static PhoneNumberInternationalPrefixCAL GetByCountryIDAndInternationalPrefix(int countryId, string internationalPrefix)
	{
		return EntityHelper.GetEntityByLookup<short, PhoneNumberInternationalPrefixDAL, PhoneNumberInternationalPrefixCAL>(EntityCacheInfo, GetLookupCacheKeysByCountryIDInternationalPrefix(countryId, internationalPrefix), () => PhoneNumberInternationalPrefixDAL.GetPhoneNumberInternationalPrefixByCountryIDAndInternationalPrefix(countryId, internationalPrefix));
	}

	internal static ICollection<PhoneNumberInternationalPrefixCAL> GetPhoneNumberInternationalPrefixesByCountryID(int countryId, int count, short? exclusiveStartPhoneNumberInternationalPrefixId)
	{
		string collectionId = $"GetPhoneNumberInternationalPrefixesByCountryID_CountryID:{countryId}_Count:{count}_ExclusiveStartPhoneNumberInternationalPrefixID:{exclusiveStartPhoneNumberInternationalPrefixId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByCountryID(countryId)), collectionId, () => PhoneNumberInternationalPrefixDAL.GetPhoneNumberInternationalPrefixIDsByCountryID(countryId, count, exclusiveStartPhoneNumberInternationalPrefixId), MultiGet);
	}

	public void Construct(PhoneNumberInternationalPrefixDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByCountryIDInternationalPrefix(CountryID, InternationalPrefix);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByIsActive(IsActive));
		yield return new StateToken(GetLookupCacheKeysByCountryID(CountryID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(short id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByCountryIDInternationalPrefix(int countryId, string internationalPrefix)
	{
		return $"CountryID:{countryId}_InternationalPrefix:{internationalPrefix}";
	}

	private static string GetLookupCacheKeysByIsActive(bool isActive)
	{
		return $"IsActive:{isActive}";
	}

	private static string GetLookupCacheKeysByCountryID(int countryId)
	{
		return $"CountryID:{countryId}";
	}
}
