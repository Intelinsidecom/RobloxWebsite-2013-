using System;
using System.Collections.Generic;
using Roblox.Billing.Data_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Business_Logic_Layer;

public class CurrencyType : IRobloxEntity<byte, CurrencyTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private CurrencyTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.CurrencyType", isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

	public string Code
	{
		get
		{
			return _EntityDAL.Code;
		}
		set
		{
			_EntityDAL.Code = value;
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

	public string Symbol
	{
		get
		{
			return _EntityDAL.Symbol;
		}
		set
		{
			_EntityDAL.Symbol = value;
		}
	}

	public static byte GetUSDCurrencyTypeID => GetByCode("USD").ID;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public CurrencyType()
	{
		_EntityDAL = new CurrencyTypeDAL();
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
			throw new NotImplementedException("Update is not supported for Currency Types");
		});
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static CurrencyType CreateNew(string name, string code, string symbol = null)
	{
		CurrencyType currencyType = new CurrencyType();
		currencyType.Name = name;
		currencyType.Code = code;
		currencyType.Symbol = symbol;
		currencyType.Save();
		return currencyType;
	}

	public static CurrencyType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, CurrencyTypeDAL, CurrencyType>(EntityCacheInfo, id, () => CurrencyTypeDAL.Get(id));
	}

	public static CurrencyType GetByCode(string code)
	{
		return EntityHelper.GetEntityByLookup<byte, CurrencyTypeDAL, CurrencyType>(EntityCacheInfo, $"Code:{code}", () => CurrencyTypeDAL.GetByCode(code));
	}

	public static ICollection<CurrencyType> GetAllCurrencyTypes()
	{
		return GetCurrencyTypesPaged(0, byte.MaxValue);
	}

	public static ICollection<CurrencyType> GetCurrencyTypesPaged(byte startRowIndex, byte maximumRows)
	{
		string collectionId = $"GetCurrencyTypes_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => CurrencyTypeDAL.GetCurrencyTypesByID_Paged((byte)(startRowIndex + 1), maximumRows), Get);
	}

	public void Construct(CurrencyTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Code:{Code}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
