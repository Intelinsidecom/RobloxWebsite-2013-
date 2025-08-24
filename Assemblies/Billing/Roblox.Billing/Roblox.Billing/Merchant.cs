using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class Merchant : IRobloxEntity<byte, MerchantDAL>, ICacheableObject<byte>, ICacheableObject
{
	private MerchantDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.Merchant", isNullCacheable: true);

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

	public bool Active
	{
		get
		{
			return _EntityDAL.Active;
		}
		set
		{
			_EntityDAL.Active = value;
		}
	}

	public bool IsHidden
	{
		get
		{
			return _EntityDAL.IsHidden;
		}
		set
		{
			_EntityDAL.IsHidden = value;
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

	public Merchant()
	{
		_EntityDAL = new MerchantDAL();
	}

	public static Merchant GetFromInCommMerchantKey(string incommKey)
	{
		Merchant merchant = Get(incommKey);
		if (merchant != null)
		{
			return merchant;
		}
		return Get("SevenEleven");
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

	public static Merchant CreateNew(string name, bool active)
	{
		Merchant merchant = new Merchant();
		merchant.Name = name;
		merchant.Active = active;
		merchant.Save();
		return merchant;
	}

	public static Merchant Get(string name)
	{
		return EntityHelper.GetEntityByLookupOld<byte, Merchant>(EntityCacheInfo, $"Name:{name}", () => DoGet(name));
	}

	private static Merchant DoGet(string name)
	{
		return EntityHelper.DoGetByLookup<byte, MerchantDAL, Merchant>(() => MerchantDAL.Get(name), $"Name:{name}");
	}

	public static Merchant Get(byte id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	private static Merchant DoGet(byte id)
	{
		return EntityHelper.DoGet<byte, MerchantDAL, Merchant>(() => MerchantDAL.Get(id), id);
	}

	public static int GetTotalNumberOfMerchants()
	{
		return MerchantDAL.GetTotalNumberOfMerchants();
	}

	public static ICollection<Merchant> GetAllMerchantsPaged(int startRowIndex, int maximumRows)
	{
		List<Merchant> merchants = new List<Merchant>();
		foreach (byte ID in MerchantDAL.GetMerchantIDsPaged(startRowIndex, maximumRows))
		{
			merchants.Add(Get(ID));
		}
		return merchants;
	}

	public static ICollection<Merchant> GetAllMerchants()
	{
		List<Merchant> merchants = new List<Merchant>();
		foreach (byte ID in MerchantDAL.GetMerchantIDsPaged(0, 32767))
		{
			merchants.Add(Get(ID));
		}
		return merchants;
	}

	public void Construct(MerchantDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Name:{Name}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
