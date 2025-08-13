using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class SaleLocationType : IRobloxEntity<byte, SaleLocationTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private SaleLocationTypeDAL _EntityDAL;

	public static readonly byte WebsiteSaleLocationTypeID;

	public static readonly string WebsiteSaleLocationTypeValue;

	public static readonly byte GameSaleLocationTypeID;

	public static readonly string GameSaleLocationTypeValue;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	static SaleLocationType()
	{
		WebsiteSaleLocationTypeValue = "Website";
		GameSaleLocationTypeValue = "Game";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.Economy.SaleLocationType", isNullCacheable: true);
		SaleLocationType websiteSaleLocationType = GetByValue(WebsiteSaleLocationTypeValue);
		if (websiteSaleLocationType == null)
		{
			try
			{
				websiteSaleLocationType = CreateNew(WebsiteSaleLocationTypeValue);
			}
			catch
			{
				websiteSaleLocationType = GetByValue(WebsiteSaleLocationTypeValue);
			}
		}
		SaleLocationType gameSaleLocationType = GetByValue(GameSaleLocationTypeValue);
		if (gameSaleLocationType == null)
		{
			try
			{
				gameSaleLocationType = CreateNew(GameSaleLocationTypeValue);
			}
			catch
			{
				gameSaleLocationType = GetByValue(GameSaleLocationTypeValue);
			}
		}
		WebsiteSaleLocationTypeID = websiteSaleLocationType.ID;
		GameSaleLocationTypeID = gameSaleLocationType.ID;
	}

	public SaleLocationType()
	{
		_EntityDAL = new SaleLocationTypeDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	public static SaleLocationType CreateNew(string value)
	{
		SaleLocationType saleLocationType = new SaleLocationType();
		saleLocationType.Value = value;
		saleLocationType.Save();
		return saleLocationType;
	}

	public static SaleLocationType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, SaleLocationTypeDAL, SaleLocationType>(EntityCacheInfo, id, () => SaleLocationTypeDAL.Get(id));
	}

	public static SaleLocationType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, SaleLocationTypeDAL, SaleLocationType>(EntityCacheInfo, "Value:" + value, () => SaleLocationTypeDAL.GetByValue(value));
	}

	public void Construct(SaleLocationTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return "Value:" + Value;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
