using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerSale : IRobloxEntity<long, PrivateServerSaleDAL>, ICacheableObject<long>, ICacheableObject
{
	private PrivateServerSaleDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PrivateServerSale).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PrivateServerID
	{
		get
		{
			return _EntityDAL.PrivateServerID;
		}
		set
		{
			_EntityDAL.PrivateServerID = value;
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

	public PrivateServerSale()
	{
		_EntityDAL = new PrivateServerSaleDAL();
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

	internal static PrivateServerSale CreateNew(long privateServerId, long saleId)
	{
		PrivateServerSale privateServerSale = new PrivateServerSale();
		privateServerSale.PrivateServerID = privateServerId;
		privateServerSale.SaleID = saleId;
		privateServerSale.Save();
		return privateServerSale;
	}

	internal static PrivateServerSale Get(long id)
	{
		return EntityHelper.GetEntity<long, PrivateServerSaleDAL, PrivateServerSale>(EntityCacheInfo, id, () => PrivateServerSaleDAL.Get(id));
	}

	internal static ICollection<PrivateServerSale> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PrivateServerSaleDAL, PrivateServerSale>(ids, EntityCacheInfo, PrivateServerSaleDAL.MultiGet);
	}

	public static PrivateServerSale GetBySaleID(long saleID)
	{
		return EntityHelper.GetEntityByLookup<long, PrivateServerSaleDAL, PrivateServerSale>(EntityCacheInfo, $"Sale:{saleID}", () => PrivateServerSaleDAL.GetPrivateServerSaleBySaleID(saleID));
	}

	internal static ICollection<PrivateServerSale> GetPrivateServerSalesByPrivateServerIDPaged(long privateServerID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetPrivateServerSalesByPrivateServerIDPaged_PrivateServerID:{privateServerID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"PrivateServerID:{privateServerID}"), collectionId, () => PrivateServerSaleDAL.GetPrivateServerSaleIDsByPrivateServerIDPaged(privateServerID, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static long GetTotalNumberOfPrivateServerSalesByPrivateServerId(long privateServerID)
	{
		string countId = $"GetTotalNumberOfPrivateServerSalesByPrivateServerId_PrivateServerID:{privateServerID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"PrivateServerID:{privateServerID}"), countId, () => PrivateServerSaleDAL.GetTotalNumberOfPrivateServerSalesByPrivateServerID(privateServerID));
	}

	public void Construct(PrivateServerSaleDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"SaleID:{SaleID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PrivateServerID:{PrivateServerID}");
	}
}
