using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Demographics.Entities;

[ExcludeFromCodeCoverage]
internal class PhoneNumberCAL : IRobloxEntity<int, PhoneNumberDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private PhoneNumberDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PhoneNumberCAL).ToString(), isNullCacheable: true);

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

	internal short? PhoneNumberInternationalPrefixID
	{
		get
		{
			return _EntityDAL.PhoneNumberInternationalPrefixID;
		}
		set
		{
			_EntityDAL.PhoneNumberInternationalPrefixID = value;
		}
	}

	internal string NationalPhoneNumber
	{
		get
		{
			return _EntityDAL.NationalPhoneNumber;
		}
		set
		{
			_EntityDAL.NationalPhoneNumber = value;
		}
	}

	internal bool? IsBlacklisted
	{
		get
		{
			return _EntityDAL.IsBlacklisted;
		}
		set
		{
			_EntityDAL.IsBlacklisted = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PhoneNumberCAL()
	{
		_EntityDAL = new PhoneNumberDAL();
	}

	public PhoneNumberCAL(PhoneNumberDAL entityDAL)
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

	internal static PhoneNumberCAL Get(int id)
	{
		return EntityHelper.GetEntity<int, PhoneNumberDAL, PhoneNumberCAL>(EntityCacheInfo, id, () => PhoneNumberDAL.Get(id));
	}

	internal static ICollection<PhoneNumberCAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, PhoneNumberDAL, PhoneNumberCAL>(ids, EntityCacheInfo, PhoneNumberDAL.MultiGet);
	}

	public static PhoneNumberCAL GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, PhoneNumberDAL, PhoneNumberCAL>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => PhoneNumberDAL.GetPhoneNumberByValue(value));
	}

	public static PhoneNumberCAL GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, PhoneNumberCAL>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static PhoneNumberCAL DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, PhoneNumberDAL, PhoneNumberCAL>(() => PhoneNumberDAL.GetOrCreatePhoneNumber(value));
	}

	internal static ICollection<PhoneNumberCAL> GetPhoneNumbersByNationalPhoneNumber(string nationalPhoneNumber, int count, int? exclusiveStartId)
	{
		string collectionId = $"GetPhoneNumbersByNationalPhoneNumber_NationalPhoneNumber:{nationalPhoneNumber}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByNationalPhoneNumber(nationalPhoneNumber)), collectionId, () => PhoneNumberDAL.GetPhoneNumberIDsByNationalPhoneNumber(nationalPhoneNumber, count, exclusiveStartId), MultiGet);
	}

	public void Construct(PhoneNumberDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByNationalPhoneNumber(NationalPhoneNumber));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(int id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}

	private static string GetLookupCacheKeysByNationalPhoneNumber(string nationalPhoneNumber)
	{
		return $"NationalPhoneNumber:{nationalPhoneNumber}";
	}
}
