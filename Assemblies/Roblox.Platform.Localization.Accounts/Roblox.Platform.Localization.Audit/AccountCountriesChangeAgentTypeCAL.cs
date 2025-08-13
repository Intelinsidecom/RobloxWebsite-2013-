using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesChangeAgentTypeCAL : IRobloxEntity<byte, AccountCountriesChangeAgentTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private AccountCountriesChangeAgentTypeDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountCountriesChangeAgentTypeCAL).ToString(), isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

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

	internal string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
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

	public AccountCountriesChangeAgentTypeCAL()
	{
		_EntityDAL = new AccountCountriesChangeAgentTypeDAL();
	}

	public AccountCountriesChangeAgentTypeCAL(AccountCountriesChangeAgentTypeDAL entityDAL)
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

	internal static AccountCountriesChangeAgentTypeCAL Get(byte id)
	{
		return EntityHelper.GetEntity<byte, AccountCountriesChangeAgentTypeDAL, AccountCountriesChangeAgentTypeCAL>(EntityCacheInfo, id, () => AccountCountriesChangeAgentTypeDAL.Get(id));
	}

	private static ICollection<AccountCountriesChangeAgentTypeCAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, AccountCountriesChangeAgentTypeDAL, AccountCountriesChangeAgentTypeCAL>(ids, EntityCacheInfo, AccountCountriesChangeAgentTypeDAL.MultiGet);
	}

	public static AccountCountriesChangeAgentTypeCAL GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, AccountCountriesChangeAgentTypeDAL, AccountCountriesChangeAgentTypeCAL>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => AccountCountriesChangeAgentTypeDAL.GetChangeAgentTypeByValue(value));
	}

	public static AccountCountriesChangeAgentTypeCAL GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<byte, AccountCountriesChangeAgentTypeCAL>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static AccountCountriesChangeAgentTypeCAL DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<byte, AccountCountriesChangeAgentTypeDAL, AccountCountriesChangeAgentTypeCAL>(() => AccountCountriesChangeAgentTypeDAL.GetOrCreateChangeAgentType(value));
	}

	public void Construct(AccountCountriesChangeAgentTypeDAL dal)
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

	private static string GetLookupCacheKeysByID(byte id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
