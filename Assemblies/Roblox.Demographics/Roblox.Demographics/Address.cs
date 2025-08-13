using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Demographics;

public class Address : IRobloxEntity<int, AddressDAL>, ICacheableObject<int>, ICacheableObject
{
	private AddressDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Address).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string AddressLine1
	{
		get
		{
			return _EntityDAL.AddressLine1;
		}
		set
		{
			_EntityDAL.AddressLine1 = value;
		}
	}

	public string AddressLine2
	{
		get
		{
			return _EntityDAL.AddressLine2;
		}
		set
		{
			_EntityDAL.AddressLine2 = value;
		}
	}

	public string City
	{
		get
		{
			return _EntityDAL.City;
		}
		set
		{
			_EntityDAL.City = value;
		}
	}

	public string StateProvince
	{
		get
		{
			return _EntityDAL.StateProvince;
		}
		set
		{
			_EntityDAL.StateProvince = value;
		}
	}

	public byte CountryID
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

	public string ZipPostal
	{
		get
		{
			return _EntityDAL.ZipPostal;
		}
		set
		{
			_EntityDAL.ZipPostal = value;
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

	public Address()
	{
		_EntityDAL = new AddressDAL();
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

	public static Address Get(int id)
	{
		return EntityHelper.GetEntity<int, AddressDAL, Address>(EntityCacheInfo, id, () => AddressDAL.Get(id));
	}

	public static Address GetByAddress1Address2CityStateProvinceCountryIDZipPostal(string address1, string address2, string city, string stateProvince, int countryId, string zipPostal)
	{
		if (string.IsNullOrEmpty(address1) || string.IsNullOrEmpty(address2) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(stateProvince) || string.IsNullOrEmpty(zipPostal) || countryId == 0)
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<int, AddressDAL, Address>(EntityCacheInfo, $"Address1:{address1}_Address2:{address2}_City:{city}_StateProvince:{stateProvince}_CountryId:{countryId}_ZipPostal{zipPostal}", () => AddressDAL.GetByAddress1Address2CityStateProvinceCountryIDZipPostal(address1, address2, city, stateProvince, countryId, zipPostal));
	}

	public static Address GetOrCreateAddress(string address1, string address2, string city, string stateProvince, int countryId, string zipPostal)
	{
		return EntityHelper.GetOrCreateEntity<int, Address>(EntityCacheInfo, $"Address1:{address1}_Address2:{address2}_City:{city}_StateProvince:{stateProvince}_CountryId:{countryId}_ZipPostal{zipPostal}", () => DoGetOrCreate(address1, address2, city, stateProvince, countryId, zipPostal));
	}

	private static Address DoGetOrCreate(string address1, string address2, string city, string stateProvince, int countryId, string zipPostal)
	{
		return EntityHelper.DoGetOrCreate<int, AddressDAL, Address>(() => AddressDAL.GetOrCreateAddress(address1, address2, city, stateProvince, countryId, zipPostal));
	}

	public void Construct(AddressDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Address1:{AddressLine1}_Address2:{AddressLine2}_City:{City}_StateProvince:{StateProvince}_CountryId:{CountryID}_ZipPostal{ZipPostal}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
