using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class EmailAddress : IRobloxEntity<int, EmailAddressDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private EmailAddressDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "EmailAddress", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string Address
	{
		get
		{
			return _EntityDAL.Address;
		}
		set
		{
			_EntityDAL.Address = value;
		}
	}

	public bool IsBlacklisted => _EntityDAL.IsBlacklisted;

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public bool IsApproved => _EntityDAL.IsApproved;

	public bool IsReviewed => _EntityDAL.IsReviewed;

	public DateTime ReviewedUtc => _EntityDAL.ReviewedUtc;

	public DateTime CreatedUtc => _EntityDAL.CreatedUtc;

	public DateTime UpdatedUtc => _EntityDAL.UpdatedUtc;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public EmailAddress()
	{
		_EntityDAL = new EmailAddressDAL();
	}

	public EmailAddress(EmailAddressDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	public void Blacklist()
	{
		_EntityDAL.IsBlacklisted = true;
		Save();
		foreach (AccountEmailAddress validAccountEmailAddress in AccountEmailAddress.GetValidAccountEmailAddresses(ID))
		{
			validAccountEmailAddress.IsValid = false;
			validAccountEmailAddress.Save();
		}
	}

	public void RemoveBlacklist()
	{
		_EntityDAL.IsBlacklisted = false;
		Save();
	}

	public void SetReviewed(bool isValidEmailAddress)
	{
		_EntityDAL.IsApproved = isValidEmailAddress;
		_EntityDAL.IsReviewed = true;
		_EntityDAL.ReviewedUtc = DateTime.UtcNow;
		Save();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.CreatedUtc = DateTime.UtcNow;
			_EntityDAL.UpdatedUtc = CreatedUtc;
			_EntityDAL.Created = CreatedUtc.ToLocalTime();
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			if (CreatedUtc == DateTime.MinValue)
			{
				_EntityDAL.CreatedUtc = Created.ToUniversalTime();
			}
			_EntityDAL.UpdatedUtc = DateTime.UtcNow;
			_EntityDAL.Updated = UpdatedUtc.ToLocalTime();
			_EntityDAL.Update();
		});
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	private static EmailAddress DoGetOrCreate(string address)
	{
		return EntityHelper.DoGetOrCreate<int, EmailAddressDAL, EmailAddress>(() => EmailAddressDAL.GetOrCreate(address));
	}

	public static EmailAddress Get(string address)
	{
		return EntityHelper.GetEntityByLookup<int, EmailAddressDAL, EmailAddress>(EntityCacheInfo, address, () => EmailAddressDAL.Get(address));
	}

	public static EmailAddress Get(int id)
	{
		return EntityHelper.GetEntity<int, EmailAddressDAL, EmailAddress>(EntityCacheInfo, id, () => EmailAddressDAL.Get(id));
	}

	public static EmailAddress Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<EmailAddress> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, EmailAddressDAL, EmailAddress>(ids, EntityCacheInfo, EmailAddressDAL.MultiGet);
	}

	public static EmailAddress GetOrCreate(string address)
	{
		address = address?.Trim();
		return EntityHelper.GetOrCreateEntityWithRemoteCache<int, EmailAddress>(EntityCacheInfo, address, () => DoGetOrCreate(address), Get);
	}

	public static ICollection<EmailAddress> GetBlacklistedEmailAddressesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetBlacklistedEmailAddressesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => EmailAddressDAL.GetBlacklistedEmailAddressIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfBlacklistedEmailAddresses()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfBlacklistedEmailAddresses", EmailAddressDAL.GetTotalNumberOfBlacklistedEmailAddresses);
	}

	public static EmailAddress MustGet(int id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public void Construct(EmailAddressDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Address;
		}
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
