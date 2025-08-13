using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class SaleMetadata : IRobloxEntity<long, SaleMetadataDAL>, ICacheableObject<long>, ICacheableObject
{
	private SaleMetadataDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: false, hasUnqualifiedCollections: false), "Roblox.Economy.SaleMetadata", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long SaleID
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

	public byte PlatformTypeID
	{
		get
		{
			return _EntityDAL.PlatformTypeID;
		}
		set
		{
			_EntityDAL.PlatformTypeID = value;
		}
	}

	public byte SaleLocationTypeID
	{
		get
		{
			return _EntityDAL.SaleLocationTypeID;
		}
		set
		{
			_EntityDAL.SaleLocationTypeID = value;
		}
	}

	public long? SaleLocationID
	{
		get
		{
			return _EntityDAL.SaleLocationID;
		}
		set
		{
			_EntityDAL.SaleLocationID = value;
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

	public DateTime? Updated
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

	public string RecurringTransactionProfileID
	{
		get
		{
			return _EntityDAL.RecurringTransactionProfileID;
		}
		set
		{
			_EntityDAL.RecurringTransactionProfileID = value;
		}
	}

	public bool? RecurringTransactionIsActive
	{
		get
		{
			return _EntityDAL.RecurringTransactionIsActive;
		}
		set
		{
			_EntityDAL.RecurringTransactionIsActive = value;
		}
	}

	public long? RecurrenceEventCallbackLocationID
	{
		get
		{
			return _EntityDAL.RecurrenceEventCallbackLocationID;
		}
		set
		{
			_EntityDAL.RecurrenceEventCallbackLocationID = value;
		}
	}

	public long? ProductInstanceTargetID
	{
		get
		{
			return _EntityDAL.ProductInstanceTargetID;
		}
		set
		{
			_EntityDAL.ProductInstanceTargetID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public SaleMetadata()
	{
		_EntityDAL = new SaleMetadataDAL();
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

	public static SaleMetadata CreateNew(long saleId, byte platformTypeId, byte saleLocationTypeId, long? saleLocationId = null, string recurringTransactionProfileID = null, bool? recurringTransactionIsActive = null, long? recurrenceEventCallbackLocationID = null, long? productInstanceTargetID = null)
	{
		SaleMetadata saleMetadata = new SaleMetadata();
		saleMetadata.SaleID = saleId;
		saleMetadata.PlatformTypeID = platformTypeId;
		saleMetadata.SaleLocationTypeID = saleLocationTypeId;
		saleMetadata.SaleLocationID = saleLocationId;
		saleMetadata.RecurringTransactionProfileID = recurringTransactionProfileID;
		saleMetadata.RecurringTransactionIsActive = recurringTransactionIsActive;
		saleMetadata.RecurrenceEventCallbackLocationID = recurrenceEventCallbackLocationID;
		saleMetadata.ProductInstanceTargetID = productInstanceTargetID;
		saleMetadata.Save();
		return saleMetadata;
	}

	public static SaleMetadata Get(long id)
	{
		return EntityHelper.GetEntity<long, SaleMetadataDAL, SaleMetadata>(EntityCacheInfo, id, () => SaleMetadataDAL.Get(id));
	}

	public static SaleMetadata GetBySaleID(long saleID)
	{
		return EntityHelper.GetEntityByLookup<long, SaleMetadataDAL, SaleMetadata>(EntityCacheInfo, $"SaleID:{saleID}", () => SaleMetadataDAL.GetSaleMetadataBySaleID(saleID));
	}

	public static SaleMetadata GetByRecurringTransactionProfileID(string recurringTransactionProfileID)
	{
		return EntityHelper.GetEntityByLookup<long, SaleMetadataDAL, SaleMetadata>(EntityCacheInfo, $"RecurringTransactionProfileID:{recurringTransactionProfileID}", () => SaleMetadataDAL.GetSaleMetadataByRecurringTransactionProfileID(recurringTransactionProfileID));
	}

	public static ICollection<SaleMetadata> GetSaleMetadatasByProductInstanceTargetIDPaged(long productInstanceTargetId, long startIndex, long maxRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"productInstanceTargetId:{productInstanceTargetId}"), $"SaleMetadata_GetSaleMetadataIDsByProductInstanceTargetID_Paged:{productInstanceTargetId}", () => SaleMetadataDAL.GetSaleMetadataIDsByProductInstanceTargetIDPaged(productInstanceTargetId, startIndex + 1, maxRows), Get);
	}

	internal static ICollection<SaleMetadata> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, SaleMetadataDAL, SaleMetadata>(ids, EntityCacheInfo, SaleMetadataDAL.MultiGet);
	}

	public void Construct(SaleMetadataDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"SaleID:{SaleID}";
		yield return $"RecurringTransactionProfileID:{RecurringTransactionProfileID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
