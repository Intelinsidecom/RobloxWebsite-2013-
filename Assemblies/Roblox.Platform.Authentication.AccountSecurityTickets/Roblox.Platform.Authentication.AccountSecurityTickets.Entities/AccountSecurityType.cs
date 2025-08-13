using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Authentication.AccountSecurityTickets.Entities;

internal class AccountSecurityType : IRobloxEntity<short, AccountSecurityTypeDAL>, ICacheableObject<short>, ICacheableObject, IRemoteCacheableObject
{
	private AccountSecurityTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountSecurityType).ToString(), isNullCacheable: true);

	public short ID => _EntityDAL.ID;

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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountSecurityType()
	{
		_EntityDAL = new AccountSecurityTypeDAL();
	}

	public AccountSecurityType(AccountSecurityTypeDAL entityDAL)
	{
		_EntityDAL = new AccountSecurityTypeDAL();
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

	internal static AccountSecurityType Get(short id)
	{
		return EntityHelper.GetEntity<short, AccountSecurityTypeDAL, AccountSecurityType>(EntityCacheInfo, id, () => AccountSecurityTypeDAL.Get(id));
	}

	private static ICollection<AccountSecurityType> MultiGet(ICollection<short> ids)
	{
		return EntityHelper.MultiGetEntity<short, AccountSecurityTypeDAL, AccountSecurityType>(ids, EntityCacheInfo, AccountSecurityTypeDAL.MultiGet);
	}

	public static AccountSecurityType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<short, AccountSecurityTypeDAL, AccountSecurityType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => AccountSecurityTypeDAL.GetAccountSecurityTypeByValue(value));
	}

	public void Construct(AccountSecurityTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
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
}
