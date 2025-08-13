using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class AccountAddOnType : IRobloxEntity<byte, AccountAddOnTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private AccountAddOnTypeDAL _EntityDAL;

	public const string NoneValue = "None";

	public static readonly byte NoneID;

	public const string BuildersClubMembershipValue = "Builders Club Membership";

	public static readonly byte BuildersClubMembershipID;

	public const string TurboBuildersClubMembershipValue = "Turbo Builders Club Membership";

	public static readonly byte TurboBuildersClubMembershipID;

	public const string OutrageousBuildersClubMembershipValue = "Outrageous Builders Club Membership";

	public static readonly byte OutrageousBuildersClubMembershipID;

	public const string Subscription = "Subscription";

	public static readonly byte SubscriptionID;

	public const string Robux = "Robux";

	public static readonly byte RobuxID;

	internal static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		private set
		{
			_EntityDAL.Value = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountAddOnType()
	{
		_EntityDAL = new AccountAddOnTypeDAL();
	}

	static AccountAddOnType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountAddOnType", isNullCacheable: true);
		NoneID = GetByValue("None").ID;
		BuildersClubMembershipID = GetByValue("Builders Club Membership").ID;
		TurboBuildersClubMembershipID = GetByValue("Turbo Builders Club Membership").ID;
		OutrageousBuildersClubMembershipID = GetByValue("Outrageous Builders Club Membership").ID;
		SubscriptionID = GetByValue("Subscription").ID;
		RobuxID = GetByValue("Robux").ID;
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static AccountAddOnType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, AccountAddOnTypeDAL, AccountAddOnType>(EntityCacheInfo, id, () => AccountAddOnTypeDAL.Get(id));
	}

	internal static AccountAddOnType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static AccountAddOnType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, AccountAddOnTypeDAL, AccountAddOnType>(EntityCacheInfo, $"Value:{value}", () => AccountAddOnTypeDAL.GetByValue(value));
	}

	public void Construct(AccountAddOnTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Value:{Value}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
