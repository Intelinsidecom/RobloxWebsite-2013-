using System;
using System.Collections.Generic;
using Roblox.Billing.Data_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Business_Logic_Layer;

public class InCommCardProduct : IRobloxEntity<short, InCommCardProductDAL>, ICacheableObject<short>, ICacheableObject
{
	private InCommCardProductDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.InCommCardProduct", isNullCacheable: true);

	public short ID => _EntityDAL.ID;

	public short InCommCardID
	{
		get
		{
			return _EntityDAL.InCommCardID;
		}
		set
		{
			_EntityDAL.InCommCardID = value;
		}
	}

	public byte AccountAddonTypeID
	{
		get
		{
			return _EntityDAL.AccountAddonTypeID;
		}
		set
		{
			_EntityDAL.AccountAddonTypeID = value;
		}
	}

	public int ProductID
	{
		get
		{
			return _EntityDAL.ProductID;
		}
		set
		{
			_EntityDAL.ProductID = value;
		}
	}

	public bool AccountAddonIsRenewal
	{
		get
		{
			return _EntityDAL.AccountAddonIsRenewal;
		}
		set
		{
			_EntityDAL.AccountAddonIsRenewal = value;
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

	public InCommCardProduct()
	{
		_EntityDAL = new InCommCardProductDAL();
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

	public static InCommCardProduct CreateNew(short inCommCardID, byte accountAddonTypeID, int productID, bool accountAddonIsRenewal)
	{
		InCommCardProduct inCommCardProduct = new InCommCardProduct();
		inCommCardProduct.InCommCardID = inCommCardID;
		inCommCardProduct.AccountAddonTypeID = accountAddonTypeID;
		inCommCardProduct.ProductID = productID;
		inCommCardProduct.AccountAddonIsRenewal = accountAddonIsRenewal;
		inCommCardProduct.Save();
		return inCommCardProduct;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static InCommCardProduct Get(short id)
	{
		return EntityHelper.GetEntity<short, InCommCardProductDAL, InCommCardProduct>(EntityCacheInfo, id, () => InCommCardProductDAL.Get(id));
	}

	public static ICollection<InCommCardProduct> GetInCommCardProductsByInCommCardID(short inCommCardID)
	{
		string collectionId = $"GetInCommCardProductsByInCommCardID_InCommCardID:{inCommCardID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"InCommCardID:{inCommCardID}"), collectionId, () => InCommCardProductDAL.GetInCommCardProductIDsByInCommCardID(inCommCardID), Get);
	}

	public void Construct(InCommCardProductDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"InCommCardID:{InCommCardID}");
	}
}
