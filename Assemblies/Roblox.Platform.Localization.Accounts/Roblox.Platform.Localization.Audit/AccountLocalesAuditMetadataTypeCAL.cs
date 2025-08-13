using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAuditMetadataTypeCAL : IRobloxEntity<byte, AccountLocalesAuditMetadataTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private AccountLocalesAuditMetadataTypeDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountLocalesAuditMetadataTypeCAL).ToString(), isNullCacheable: true);

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

	public AccountLocalesAuditMetadataTypeCAL()
	{
		_EntityDAL = new AccountLocalesAuditMetadataTypeDAL();
	}

	public AccountLocalesAuditMetadataTypeCAL(AccountLocalesAuditMetadataTypeDAL entityDAL)
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

	internal static AccountLocalesAuditMetadataTypeCAL Get(byte id)
	{
		return EntityHelper.GetEntity<byte, AccountLocalesAuditMetadataTypeDAL, AccountLocalesAuditMetadataTypeCAL>(EntityCacheInfo, id, () => AccountLocalesAuditMetadataTypeDAL.Get(id));
	}

	private static ICollection<AccountLocalesAuditMetadataTypeCAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, AccountLocalesAuditMetadataTypeDAL, AccountLocalesAuditMetadataTypeCAL>(ids, EntityCacheInfo, AccountLocalesAuditMetadataTypeDAL.MultiGet);
	}

	public static AccountLocalesAuditMetadataTypeCAL GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, AccountLocalesAuditMetadataTypeDAL, AccountLocalesAuditMetadataTypeCAL>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => AccountLocalesAuditMetadataTypeDAL.GetAccountLocalesAuditMetadataTypeByValue(value));
	}

	public static AccountLocalesAuditMetadataTypeCAL GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<byte, AccountLocalesAuditMetadataTypeCAL>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static AccountLocalesAuditMetadataTypeCAL DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<byte, AccountLocalesAuditMetadataTypeDAL, AccountLocalesAuditMetadataTypeCAL>(() => AccountLocalesAuditMetadataTypeDAL.GetOrCreateAccountLocalesAuditMetadataType(value));
	}

	public void Construct(AccountLocalesAuditMetadataTypeDAL dal)
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
