using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class ProductOption : IEquatable<ProductOption>, IRobloxEntity<long, ProductOptionDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public enum MembershipTypeMinLevel
	{
		All,
		BuildersClub,
		TurboBuildersClub,
		OutrageousBuildersClub
	}

	public delegate void EntityCreatedEventHandler(ProductOption sender, EventArgs e);

	public delegate void EntityDeletedEventHandler(ProductOption sender, EventArgs e);

	public delegate void EntityUpdatedEventHandler(ProductOption sender, EventArgs e);

	private ProductOptionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "ProductOption", isNullCacheable: true);

	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	public long ProductID
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

	public bool IsLimitedEdition
	{
		get
		{
			return _EntityDAL.IsLimitedEdition;
		}
		set
		{
			_EntityDAL.IsLimitedEdition = value;
		}
	}

	public bool IsResellable
	{
		get
		{
			return _EntityDAL.IsResellable;
		}
		set
		{
			_EntityDAL.IsResellable = value;
		}
	}

	public long? TotalAvailable
	{
		get
		{
			return _EntityDAL.TotalAvailable;
		}
		set
		{
			_EntityDAL.TotalAvailable = value;
		}
	}

	public long? NumberRemaining
	{
		get
		{
			return _EntityDAL.NumberRemaining;
		}
		set
		{
			_EntityDAL.NumberRemaining = value;
		}
	}

	public MembershipTypeMinLevel MinMembershipType
	{
		get
		{
			return (MembershipTypeMinLevel)_EntityDAL.MinMembershipType;
		}
		set
		{
			_EntityDAL.MinMembershipType = (byte)value;
		}
	}

	public DateTime? OffSaleDeadline
	{
		get
		{
			return _EntityDAL.OffSaleDeadline;
		}
		set
		{
			_EntityDAL.OffSaleDeadline = value;
		}
	}

	public bool HasOffSaleDeadline => OffSaleDeadline.HasValue;

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event EntityCreatedEventHandler EntityCreated;

	public static event EntityDeletedEventHandler EntityDeleted;

	public static event EntityUpdatedEventHandler EntityUpdated;

	public ProductOption()
	{
		_EntityDAL = new ProductOptionDAL();
	}

	public ProductOption(ProductOptionDAL dal)
	{
		_EntityDAL = dal;
	}

	public void Increment()
	{
		NumberRemaining++;
		Save();
	}

	public void Save()
	{
		bool num = ID == 0;
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
		if (num)
		{
			OnEntityCreated(this, EventArgs.Empty);
		}
		else
		{
			OnEntityUpdated(this, EventArgs.Empty);
		}
	}

	public bool TryDecrement()
	{
		bool num = _EntityDAL.TryDecrementNumberAvailable();
		if (num)
		{
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
			OnEntityUpdated(this, EventArgs.Empty);
		}
		return num;
	}

	private static ProductOption DoGetOrCreate(long productId, out bool createdNewEntity)
	{
		bool created = false;
		ProductOption result = EntityHelper.DoGetOrCreate<long, ProductOptionDAL, ProductOption>(delegate
		{
			EntityHelper.GetOrCreateDALWrapper<ProductOptionDAL> orCreate = ProductOptionDAL.GetOrCreate(productId);
			created = orCreate.CreatedNewEntity;
			return orCreate;
		});
		createdNewEntity = created;
		return result;
	}

	public static ProductOption Get(long id)
	{
		return EntityHelper.GetEntity<long, ProductOptionDAL, ProductOption>(EntityCacheInfo, id, () => ProductOptionDAL.Get(id));
	}

	public static ProductOption GetByProductID(long productId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, ProductOptionDAL, ProductOption>(EntityCacheInfo, "ProductID:" + productId, () => ProductOptionDAL.GetByProductID(productId), Get);
	}

	public static ProductOption GetOrCreate(long productId)
	{
		bool createdNewEntity = false;
		ProductOption entity = EntityHelper.GetOrCreateEntityWithRemoteCache<long, ProductOption>(EntityCacheInfo, "ProductID:" + productId, () => DoGetOrCreate(productId, out createdNewEntity), Get);
		if (createdNewEntity)
		{
			OnEntityCreated(entity, EventArgs.Empty);
		}
		return entity;
	}

	public void Construct(ProductOptionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "ProductID:" + ProductID;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public bool Equals(ProductOption other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	private static void OnEntityCreated(ProductOption entity, EventArgs e)
	{
		if (ProductOption.EntityCreated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				ProductOption.EntityCreated(entity, e);
			});
		}
	}

	private static void OnEntityDeleted(ProductOption entity, EventArgs e)
	{
		if (ProductOption.EntityDeleted != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				ProductOption.EntityDeleted(entity, e);
			});
		}
	}

	private static void OnEntityUpdated(ProductOption entity, EventArgs e)
	{
		if (ProductOption.EntityUpdated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				ProductOption.EntityUpdated(entity, e);
			});
		}
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
