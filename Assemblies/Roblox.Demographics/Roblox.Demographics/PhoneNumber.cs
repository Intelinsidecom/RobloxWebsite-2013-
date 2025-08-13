using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Demographics;

[Obsolete("Use Platform.Demographics.PhoneNumberFactory")]
public class PhoneNumber : IRobloxEntity<int, PhoneNumberDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private PhoneNumberDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PhoneNumber).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public short? PhoneNumberInternationalPrefixID
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

	public string NationalPhoneNumber
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

	public bool? IsBlacklisted
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

	public PhoneNumber()
	{
		_EntityDAL = new PhoneNumberDAL();
	}

	public PhoneNumber(PhoneNumberDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
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

	public static PhoneNumber Get(int id)
	{
		return EntityHelper.GetEntity<int, PhoneNumberDAL, PhoneNumber>(EntityCacheInfo, id, () => PhoneNumberDAL.Get(id));
	}

	public static ICollection<PhoneNumber> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, PhoneNumberDAL, PhoneNumber>(ids, EntityCacheInfo, PhoneNumberDAL.MultiGet);
	}

	public static PhoneNumber GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, PhoneNumberDAL, PhoneNumber>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => PhoneNumberDAL.GetPhoneNumberByValue(value));
	}

	public static PhoneNumber GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, PhoneNumber>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static PhoneNumber DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, PhoneNumberDAL, PhoneNumber>(() => PhoneNumberDAL.GetOrCreatePhoneNumber(value));
	}

	public static PhoneNumber GetByPhoneNumberInternationalPrefixIDAndNationalPhoneNumber(short? phoneNumberInternationalPrefixId, string nationalPhoneNumber)
	{
		return EntityHelper.GetEntityByLookup<int, PhoneNumberDAL, PhoneNumber>(EntityCacheInfo, GetLookupCacheKeysByPhoneNumberInternationalPrefixIDNationalPhoneNumber(phoneNumberInternationalPrefixId, nationalPhoneNumber), () => PhoneNumberDAL.GetPhoneNumberByPhoneNumberInternationalPrefixIDAndNationalPhoneNumber(phoneNumberInternationalPrefixId, nationalPhoneNumber));
	}

	public void Construct(PhoneNumberDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
		yield return GetLookupCacheKeysByPhoneNumberInternationalPrefixIDNationalPhoneNumber(PhoneNumberInternationalPrefixID, NationalPhoneNumber);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}

	private static string GetLookupCacheKeysByPhoneNumberInternationalPrefixIDNationalPhoneNumber(short? phoneNumberInternationalPrefixId, string nationalPhoneNumber)
	{
		return $"PhoneNumberInternationalPrefixID:{phoneNumberInternationalPrefixId}_NationalPhoneNumber:{nationalPhoneNumber}";
	}
}
