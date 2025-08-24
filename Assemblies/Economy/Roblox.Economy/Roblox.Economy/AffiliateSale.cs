using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class AffiliateSale : IRobloxEntity<long, AffiliateSaleDAL>, ICacheableObject<long>, ICacheableObject
{
	private AffiliateSaleDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AffiliateSale", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AffiliateID
	{
		get
		{
			return _EntityDAL.AffiliateID;
		}
		set
		{
			_EntityDAL.AffiliateID = value;
		}
	}

	public long ProductCreatorID
	{
		get
		{
			return _EntityDAL.ProductCreatorID;
		}
		set
		{
			_EntityDAL.ProductCreatorID = value;
		}
	}

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

	public long AffiliateFee
	{
		get
		{
			return _EntityDAL.AffiliateFee;
		}
		set
		{
			_EntityDAL.AffiliateFee = value;
		}
	}

	public int AffiliateFeeCurrencyID
	{
		get
		{
			return _EntityDAL.AffiliateFeeCurrencyTypeID;
		}
		set
		{
			_EntityDAL.AffiliateFeeCurrencyTypeID = value;
		}
	}

	public long SourceID
	{
		get
		{
			return _EntityDAL.SourceID;
		}
		set
		{
			_EntityDAL.SourceID = value;
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

	public AffiliateSale()
	{
		_EntityDAL = new AffiliateSaleDAL();
	}

	public void Save()
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

	public static AffiliateSale CreateNew(long affiliateid, long productcreatorid, long saleid, long affiliatefee, int affiliatefeecurrencytypeid, long sourceid)
	{
		AffiliateSale affiliateSale = new AffiliateSale();
		affiliateSale.AffiliateID = affiliateid;
		affiliateSale.ProductCreatorID = productcreatorid;
		affiliateSale.SaleID = saleid;
		affiliateSale.AffiliateFee = affiliatefee;
		affiliateSale.AffiliateFeeCurrencyID = affiliatefeecurrencytypeid;
		affiliateSale.SourceID = sourceid;
		affiliateSale.Save();
		return affiliateSale;
	}

	public static AffiliateSale Get(long id)
	{
		return EntityHelper.GetEntity<long, AffiliateSaleDAL, AffiliateSale>(EntityCacheInfo, id, () => AffiliateSaleDAL.Get(id));
	}

	public static ICollection<AffiliateSale> GetAffiliateSalesByAffiliateID_Paged(long affiliateId, int startRowIndex, int maxRows)
	{
		if (affiliateId == 0L)
		{
			throw new ApplicationException("Required value affiliateId not supplied: " + affiliateId);
		}
		string collectionId = $"GetAffiliateSalesByAffiliateID_AffiliateID:{affiliateId}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AffiliateID:{affiliateId}"), collectionId, () => AffiliateSaleDAL.GetAffiliateSaleIDsByAffiliateID_Paged(affiliateId, startRowIndex, maxRows), Get);
	}

	public static long GetTotalNumberOfAffiliateSalesByAffiliateID(long affiliateId)
	{
		if (affiliateId == 0L)
		{
			throw new ApplicationException("Required value affiliateId not supplied: " + affiliateId);
		}
		string countId = $"GetTotalNumberOfAffiliateSalesByAffiliateID_AffiliateID:{affiliateId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AffiliateID:{affiliateId}"), countId, () => AffiliateSaleDAL.GetTotalNumberOfAffiliateSalesByAffiliateID(affiliateId));
	}

	public static ICollection<AffiliateSale> GetAffiliateSalesByProductCreatorID_Paged(long productCreatorId, int startRowIndex, int maxRows)
	{
		if (productCreatorId == 0L)
		{
			throw new ApplicationException("Required value affiliateId not supplied: " + productCreatorId);
		}
		string collectionId = $"GetAffiliateSalesByProductCreatorID_ProductCreatorID:{productCreatorId}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ProductCreatorID:{productCreatorId}"), collectionId, () => AffiliateSaleDAL.GetAffiliateSaleIDsByProductCreatorID_Paged(productCreatorId, startRowIndex, maxRows), Get);
	}

	public static long GetTotalNumberOfAffiliateSalesByProductCreatorID(long productCreatorId)
	{
		if (productCreatorId == 0L)
		{
			throw new ApplicationException("Required value affiliateId not supplied: " + productCreatorId);
		}
		string countId = $"GetTotalNumberOfAffiliateSalesByProductCreatorID_ProductCreatorID:{productCreatorId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ProductCreatorID:{productCreatorId}"), countId, () => AffiliateSaleDAL.GetTotalNumberOfAffiliateSalesByProductCreatorID(productCreatorId));
	}

	public static AffiliateSale GetAffiliateSaleBySaleID(long saleID)
	{
		return EntityHelper.GetEntityByLookup<long, AffiliateSaleDAL, AffiliateSale>(EntityCacheInfo, $"SaleID:{saleID}", () => AffiliateSaleDAL.GetAffiliateSaleBySaleID(saleID));
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Construct(AffiliateSaleDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"SaleID:{SaleID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AffiliateID:{AffiliateID}");
		yield return new StateToken($"ProductCreatorID:{ProductCreatorID}");
	}
}
