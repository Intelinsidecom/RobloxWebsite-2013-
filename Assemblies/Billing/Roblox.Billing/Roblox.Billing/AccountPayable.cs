using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class AccountPayable : IRobloxEntity<int, AccountPayableDAL>, ICacheableObject<int>, ICacheableObject
{
	private AccountPayableDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(AccountPayable).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string FirstName
	{
		get
		{
			return _EntityDAL.FirstName;
		}
		set
		{
			_EntityDAL.FirstName = value;
		}
	}

	public string LastName
	{
		get
		{
			return _EntityDAL.LastName;
		}
		set
		{
			_EntityDAL.LastName = value;
		}
	}

	public int? PhoneNumberID
	{
		get
		{
			return _EntityDAL.PhoneNumberID;
		}
		set
		{
			_EntityDAL.PhoneNumberID = value;
		}
	}

	public int? AddressID
	{
		get
		{
			return _EntityDAL.AddressID;
		}
		set
		{
			_EntityDAL.AddressID = value;
		}
	}

	public int PaypalEmailAddressID
	{
		get
		{
			return _EntityDAL.PaypalEmailAddressID;
		}
		set
		{
			_EntityDAL.PaypalEmailAddressID = value;
		}
	}

	public int IPAddressID
	{
		get
		{
			return _EntityDAL.IPAddressID;
		}
		set
		{
			_EntityDAL.IPAddressID = value;
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

	public AccountPayable()
	{
		_EntityDAL = new AccountPayableDAL();
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

	public static AccountPayable CreateNew(string firstName, string lastName, int IPAddressId, int paypalEmailId)
	{
		AccountPayable accountPayable = new AccountPayable();
		accountPayable.FirstName = firstName;
		accountPayable.LastName = lastName;
		accountPayable.PaypalEmailAddressID = paypalEmailId;
		accountPayable.IPAddressID = IPAddressId;
		accountPayable.Save();
		return accountPayable;
	}

	public static AccountPayable Get(int id)
	{
		return EntityHelper.GetEntity<int, AccountPayableDAL, AccountPayable>(EntityCacheInfo, id, () => AccountPayableDAL.Get(id));
	}

	public static AccountPayable GetOrCreateAccountPayable(string firstName, string lastName, int IPAddressId, int paypalEmailId)
	{
		return EntityHelper.GetOrCreateEntity<int, AccountPayable>(EntityCacheInfo, $"FirstName:{firstName}_LastName:{lastName}_IPAddressID:{IPAddressId}_PaypalEmailAddressID{paypalEmailId}", () => DoGetOrCreate(firstName, lastName, IPAddressId, paypalEmailId));
	}

	private static AccountPayable DoGetOrCreate(string firstName, string lastName, int IPAddressId, int paypalEmailId)
	{
		return EntityHelper.DoGetOrCreate<int, AccountPayableDAL, AccountPayable>(() => AccountPayableDAL.GetOrCreateAccountPayable(firstName, lastName, IPAddressId, paypalEmailId));
	}

	public void Construct(AccountPayableDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"FirstName:{FirstName}_LastName:{LastName}_IPAddressID:{IPAddressID}_PaypalEmailAddressID{PaypalEmailAddressID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
