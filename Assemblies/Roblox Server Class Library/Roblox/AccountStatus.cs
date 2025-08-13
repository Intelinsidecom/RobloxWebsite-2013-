using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.Moderation;

namespace Roblox;

[Serializable]
public class AccountStatus : IAccountStatus, IRobloxEntity<byte, AccountStatusDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private AccountStatusDAL _EntityDAL;

	private static readonly LazyWithRetry<AccountStatus> _OkLazy = LazyGetter("OK");

	public const string OkValue = "OK";

	private static readonly LazyWithRetry<AccountStatus> _SuppressedLazy = LazyGetter("Suppressed");

	public const string SuppressedValue = "Suppressed";

	private static readonly LazyWithRetry<AccountStatus> _DeletedLazy = LazyGetter("Deleted");

	public const string DeletedValue = "Deleted";

	private static readonly LazyWithRetry<AccountStatus> _PoisonedLazy = LazyGetter("Poisoned");

	public const string PoisonedValue = "Poisoned";

	private static readonly LazyWithRetry<AccountStatus> _MustValidateEmailLazy = LazyGetter("Must Validate Email");

	public const string MustValidateEmailValue = "Must Validate Email";

	private static readonly LazyWithRetry<AccountStatus> _ForgottenLazy = LazyGetter("Forgotten");

	public const string ForgottenValue = "Forgotten";

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountStatus", isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

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

	public string Description
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

	public string Abbreviation
	{
		get
		{
			return _EntityDAL.Abbreviation;
		}
		set
		{
			_EntityDAL.Abbreviation = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public static byte OkId => _OkLazy.Value.ID;

	public static byte SuppressedId => _SuppressedLazy.Value.ID;

	public static byte DeletedId => _DeletedLazy.Value.ID;

	public static byte PoisonedId => _PoisonedLazy.Value.ID;

	public static byte MustValidateEmailId => _MustValidateEmailLazy.Value.ID;

	public static byte ForgottenId => _ForgottenLazy.Value.ID;

	public CacheInfo CacheInfo => EntityCacheInfo;

	private static LazyWithRetry<AccountStatus> LazyGetter(string value)
	{
		return new LazyWithRetry<AccountStatus>(() => Get(value));
	}

	public AccountStatus(AccountStatusDAL dal)
	{
		_EntityDAL = dal;
	}

	public AccountStatus()
	{
		_EntityDAL = new AccountStatusDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		if (_EntityDAL == null)
		{
			throw new ApplicationException("Required object not provided: EntityDAL.");
		}
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

	public static AccountStatus Get(byte id)
	{
		return EntityHelper.GetEntity<byte, AccountStatusDAL, AccountStatus>(EntityCacheInfo, id, () => AccountStatusDAL.Get(id));
	}

	public static AccountStatus Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, AccountStatusDAL, AccountStatus>(EntityCacheInfo, $"Value:{value}", () => AccountStatusDAL.Get(value));
	}

	public static ICollection<AccountStatus> GetAccountStatuses()
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetAccountStatuses", AccountStatusDAL.GetAccountStatusIDs, Get);
	}

	public static AccountStatus MustGet(byte id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public static AccountStatus Register(string value, string description, string abbreviation)
	{
		AccountStatus obj = Get(value) ?? new AccountStatus();
		obj.Value = value;
		obj.Description = description;
		obj.Abbreviation = abbreviation;
		obj.Save();
		return obj;
	}

	public void Construct(AccountStatusDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
