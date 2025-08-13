using System;
using System.Collections.Generic;
using Roblox.Billing.Data_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Business_Logic_Layer;

public class InCommCard : IRobloxEntity<short, InCommCardDAL>, ICacheableObject<short>, ICacheableObject
{
	private InCommCardDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.InCommCard", isNullCacheable: true);

	public short ID => _EntityDAL.ID;

	public byte MerchantID
	{
		get
		{
			return _EntityDAL.MerchantID;
		}
		set
		{
			_EntityDAL.MerchantID = value;
		}
	}

	public byte CurrencyTypeID
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

	public decimal Value
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

	public InCommCard()
	{
		_EntityDAL = new InCommCardDAL();
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

	public static InCommCard CreateNew(byte merchantID, byte currencyTypeID, decimal value)
	{
		InCommCard inCommCard = new InCommCard();
		inCommCard.MerchantID = merchantID;
		inCommCard.CurrencyTypeID = currencyTypeID;
		inCommCard.Value = value;
		inCommCard.Save();
		return inCommCard;
	}

	public static InCommCard Get(short id)
	{
		return EntityHelper.GetEntity<short, InCommCardDAL, InCommCard>(EntityCacheInfo, id, () => InCommCardDAL.Get(id));
	}

	public static InCommCard GetByMerchantIDAndValue(byte merchantID, decimal value)
	{
		return EntityHelper.GetEntityByLookup<short, InCommCardDAL, InCommCard>(EntityCacheInfo, $"MerchantID:{merchantID}_Value{value}", () => InCommCardDAL.GetByMerchantIDAndValue(merchantID, value));
	}

	public static InCommCard GetByMerchantIDCurrencyTypeIDAndValue(byte merchantID, byte currencyTypeID, decimal value)
	{
		return EntityHelper.GetEntityByLookup<short, InCommCardDAL, InCommCard>(EntityCacheInfo, $"MerchantID:{merchantID}_CurrencyTypeID:{currencyTypeID}_Value{value}", () => InCommCardDAL.GetByMerchantIDCurrencyTypeIDAndValue(merchantID, currencyTypeID, value));
	}

	public static ICollection<InCommCard> GetInCommCardsByMerchantID(byte merchantID)
	{
		string collectionId = $"GetInCommCardsByMerchantID_MerchantID:{merchantID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"MerchantID:{merchantID}"), collectionId, () => InCommCardDAL.GetInCommCardIDsByMerchantID(merchantID), Get);
	}

	public static ICollection<InCommCard> GetAllInCommCards()
	{
		return GetInCommCardsPaged(0, short.MaxValue);
	}

	public static ICollection<InCommCard> GetInCommCardsPaged(short startRowIndex, short maximumRows)
	{
		string collectionId = $"GetInCommCardsPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => InCommCardDAL.GetInCommCardIDsPaged((short)(startRowIndex + 1), maximumRows), Get);
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Construct(InCommCardDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"MerchantID:{MerchantID}_Value{Value}";
		yield return $"MerchantID:{MerchantID}_CurrencyTypeID:{CurrencyTypeID}_Value{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"MerchantID:{MerchantID}");
	}
}
