using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

[ExcludeFromCodeCoverage]
public class MembershipMigrationAuditLog : IRobloxEntity<long, MembershipMigrationAuditLogDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private MembershipMigrationAuditLogDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(MembershipMigrationAuditLog).ToString(), isNullCacheable: true);

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

	internal int OriginalProductID
	{
		get
		{
			return _EntityDAL.OriginalProductID;
		}
		set
		{
			_EntityDAL.OriginalProductID = value;
		}
	}

	internal int UpdatedProductID
	{
		get
		{
			return _EntityDAL.UpdatedProductID;
		}
		set
		{
			_EntityDAL.UpdatedProductID = value;
		}
	}

	internal decimal OriginalPrice
	{
		get
		{
			return _EntityDAL.OriginalPrice;
		}
		set
		{
			_EntityDAL.OriginalPrice = value;
		}
	}

	internal decimal UpdatedPrice
	{
		get
		{
			return _EntityDAL.UpdatedPrice;
		}
		set
		{
			_EntityDAL.UpdatedPrice = value;
		}
	}

	internal int RobuxGrantAmount
	{
		get
		{
			return _EntityDAL.RobuxGrantAmount;
		}
		set
		{
			_EntityDAL.RobuxGrantAmount = value;
		}
	}

	internal long SaleID
	{
		get
		{
			return _EntityDAL.SaleID;
		}
		set
		{
			_EntityDAL.SaleID = value;
		}
	}

	internal byte CurrencyTypeID
	{
		get
		{
			return _EntityDAL.CurrencyTypeID;
		}
		set
		{
			_EntityDAL.CurrencyTypeID = value;
		}
	}

	internal DateTime? LastRobuxDistributionDate
	{
		get
		{
			return _EntityDAL.LastRobuxDistributionDate;
		}
		set
		{
			_EntityDAL.LastRobuxDistributionDate = value;
		}
	}

	internal DateTime? UpdatedMembershipStartDate
	{
		get
		{
			return _EntityDAL.UpdatedMembershipStartDate;
		}
		set
		{
			_EntityDAL.UpdatedMembershipStartDate = value;
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

	public MembershipMigrationAuditLog()
	{
		_EntityDAL = new MembershipMigrationAuditLogDAL();
	}

	public MembershipMigrationAuditLog(MembershipMigrationAuditLogDAL entityDAL)
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
			_EntityDAL.Created = DateTime.UtcNow;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.UtcNow;
			_EntityDAL.Update();
		});
	}

	public static MembershipMigrationAuditLog CreateNew(long accountId, byte currencyTypeId, DateTime lastRobuxDistrubtionDate, int originalPremiumFeatureId, int updatedPremiumFeatureId, decimal originalPrice, decimal updatedPrice, int originalProductId, int updatedProductId, int robuxGrantAmount, long saleId, DateTime updatedMembershipStartDate)
	{
		MembershipMigrationAuditLog membershipMigrationAuditLog = new MembershipMigrationAuditLog();
		membershipMigrationAuditLog.AccountID = accountId;
		membershipMigrationAuditLog.CurrencyTypeID = currencyTypeId;
		membershipMigrationAuditLog.LastRobuxDistributionDate = lastRobuxDistrubtionDate;
		membershipMigrationAuditLog.OriginalPremiumFeatureID = originalPremiumFeatureId;
		membershipMigrationAuditLog.UpdatedPremiumFeatureID = updatedPremiumFeatureId;
		membershipMigrationAuditLog.OriginalPrice = originalPrice;
		membershipMigrationAuditLog.UpdatedPrice = updatedPrice;
		membershipMigrationAuditLog.OriginalProductID = originalProductId;
		membershipMigrationAuditLog.UpdatedProductID = updatedProductId;
		membershipMigrationAuditLog.RobuxGrantAmount = robuxGrantAmount;
		membershipMigrationAuditLog.SaleID = saleId;
		membershipMigrationAuditLog.UpdatedMembershipStartDate = updatedMembershipStartDate;
		membershipMigrationAuditLog.Save();
		return membershipMigrationAuditLog;
	}

	public static MembershipMigrationAuditLog GetByAccountId(long accountId)
	{
		return EntityHelper.GetEntity<long, MembershipMigrationAuditLogDAL, MembershipMigrationAuditLog>(EntityCacheInfo, accountId, () => MembershipMigrationAuditLogDAL.GetByAccountId(accountId));
	}

	internal static MembershipMigrationAuditLog Get(long id)
	{
		return EntityHelper.GetEntity<long, MembershipMigrationAuditLogDAL, MembershipMigrationAuditLog>(EntityCacheInfo, id, () => MembershipMigrationAuditLogDAL.Get(id));
	}

	private static ICollection<MembershipMigrationAuditLog> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, MembershipMigrationAuditLogDAL, MembershipMigrationAuditLog>(ids, EntityCacheInfo, MembershipMigrationAuditLogDAL.MultiGet);
	}

	public void Construct(MembershipMigrationAuditLogDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
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
