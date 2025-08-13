using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.PremiumFeatures.Properties;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class MembershipMigrationStatusEntity : IRobloxEntity<long, MembershipMigrationStatusDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private MembershipMigrationStatusDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(MembershipMigrationStatusEntity).ToString(), isNullCacheable: true);

	private static bool _IsMembershipMigrationStatusEntityRemoteCacheEnabled => Settings.Default.IsMembershipMigrationStatusEntityRemoteCacheEnabled;

	public long ID => _EntityDAL.ID;

	internal long AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		set
		{
			_EntityDAL.AccountID = value;
		}
	}

	internal int OriginalPremiumFeatureID
	{
		get
		{
			return _EntityDAL.OriginalPremiumFeatureID;
		}
		set
		{
			_EntityDAL.OriginalPremiumFeatureID = value;
		}
	}

	internal int UpdatedPremiumFeatureID
	{
		get
		{
			return _EntityDAL.UpdatedPremiumFeatureID;
		}
		set
		{
			_EntityDAL.UpdatedPremiumFeatureID = value;
		}
	}

	internal DateTime? PremiumStartDate
	{
		get
		{
			return _EntityDAL.PremiumStartDate;
		}
		set
		{
			_EntityDAL.PremiumStartDate = value;
		}
	}

	internal int RobuxDistributionAmount
	{
		get
		{
			return _EntityDAL.RobuxDistributionAmount;
		}
		set
		{
			_EntityDAL.RobuxDistributionAmount = value;
		}
	}

	internal int MigrationStateID
	{
		get
		{
			return _EntityDAL.MigrationStateID;
		}
		set
		{
			_EntityDAL.MigrationStateID = value;
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

	public MembershipMigrationStatusEntity()
	{
		_EntityDAL = new MembershipMigrationStatusDAL();
	}

	public MembershipMigrationStatusEntity(MembershipMigrationStatusDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		if (_IsMembershipMigrationStatusEntityRemoteCacheEnabled)
		{
			EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
		}
		else
		{
			EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		}
	}

	internal void Save()
	{
		if (_IsMembershipMigrationStatusEntityRemoteCacheEnabled)
		{
			EntityHelper.SaveEntityWithRemoteCache(this, delegate
			{
				_EntityDAL.Created = DateTime.UtcNow;
				_EntityDAL.Updated = _EntityDAL.Created;
				_EntityDAL.Insert();
			}, delegate
			{
				_EntityDAL.Updated = DateTime.UtcNow;
				_EntityDAL.Update();
			});
		}
		else
		{
			EntityHelper.SaveEntity(this, delegate
			{
				_EntityDAL.Created = DateTime.UtcNow;
				_EntityDAL.Updated = _EntityDAL.Created;
				_EntityDAL.Insert();
			}, delegate
			{
				_EntityDAL.Updated = DateTime.UtcNow;
				_EntityDAL.Update();
			});
		}
	}

	public static MembershipMigrationStatusEntity GetOrCreate(long accountId, int originalPremiumFeatureId, int updatedPremiumFeatureId, DateTime? premiumStartDate, int robuxDistributionAmount, int migrationStateId)
	{
		if (_IsMembershipMigrationStatusEntityRemoteCacheEnabled)
		{
			return EntityHelper.GetOrCreateEntityWithRemoteCache<long, MembershipMigrationStatusEntity>(EntityCacheInfo, GetLookupCacheKeysByAccountId(accountId), () => DoGetOrCreate(accountId, originalPremiumFeatureId, updatedPremiumFeatureId, premiumStartDate, robuxDistributionAmount, migrationStateId), Get);
		}
		return EntityHelper.GetOrCreateEntity<long, MembershipMigrationStatusEntity>(EntityCacheInfo, GetLookupCacheKeysByAccountId(accountId), () => DoGetOrCreate(accountId, originalPremiumFeatureId, updatedPremiumFeatureId, premiumStartDate, robuxDistributionAmount, migrationStateId));
	}

	internal static MembershipMigrationStatusEntity CreateNew(long accountId, int membershipMigrationStateId)
	{
		MembershipMigrationStatusEntity membershipMigrationStatusEntity = new MembershipMigrationStatusEntity();
		membershipMigrationStatusEntity.AccountID = accountId;
		membershipMigrationStatusEntity.MigrationStateID = membershipMigrationStateId;
		membershipMigrationStatusEntity.Save();
		return membershipMigrationStatusEntity;
	}

	internal static MembershipMigrationStatusEntity Get(long id)
	{
		return EntityHelper.GetEntity<long, MembershipMigrationStatusDAL, MembershipMigrationStatusEntity>(EntityCacheInfo, id, () => MembershipMigrationStatusDAL.Get(id));
	}

	internal static MembershipMigrationStatusEntity GetByAccountId(long accountId)
	{
		if (_IsMembershipMigrationStatusEntityRemoteCacheEnabled)
		{
			return EntityHelper.GetEntityByLookupWithRemoteCache<long, MembershipMigrationStatusDAL, MembershipMigrationStatusEntity>(EntityCacheInfo, GetLookupCacheKeysByAccountId(accountId), () => MembershipMigrationStatusDAL.GetByAccountId(accountId), Get);
		}
		return EntityHelper.GetEntityByLookup<long, MembershipMigrationStatusDAL, MembershipMigrationStatusEntity>(EntityCacheInfo, GetLookupCacheKeysByAccountId(accountId), () => MembershipMigrationStatusDAL.GetByAccountId(accountId));
	}

	private static ICollection<MembershipMigrationStatusEntity> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, MembershipMigrationStatusDAL, MembershipMigrationStatusEntity>(ids, EntityCacheInfo, MembershipMigrationStatusDAL.MultiGet);
	}

	public void Construct(MembershipMigrationStatusDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetCacheQualifierById(ID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetCacheQualifierById(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByAccountId(long accountId)
	{
		return $"AccountID:{accountId}";
	}

	private static MembershipMigrationStatusEntity DoGetOrCreate(long accountId, int originalPremiumFeatureId, int updatedPremiumFeatureId, DateTime? premiumStartDate, int robuxDistributionAmount, int migrationStateId)
	{
		return EntityHelper.DoGetOrCreate<long, MembershipMigrationStatusDAL, MembershipMigrationStatusEntity>(() => MembershipMigrationStatusDAL.GetOrCreateMembershipMigrationStatus(accountId, originalPremiumFeatureId, updatedPremiumFeatureId, premiumStartDate, robuxDistributionAmount, migrationStateId));
	}
}
