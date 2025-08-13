using System;
using System.Collections.Generic;
using Roblox.Billing.Data_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Business_Logic_Layer;

public class GiftCardThemeType : IRobloxEntity<byte, GiftCardThemeTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private GiftCardThemeTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.GiftCardThemeType", isNullCacheable: true);

	public static GiftCardThemeType Classic => GetByName("Classic");

	public static GiftCardThemeType Christmas => GetByName("Christmas");

	public static GiftCardThemeType JustForYou1 => GetOrCreateByName("JustForYou1");

	public static GiftCardThemeType JustForYou2 => GetOrCreateByName("JustForYou2");

	public static GiftCardThemeType JustForYouRadcliff => GetOrCreateByName("JustForYouRadcliff");

	public static GiftCardThemeType JustForYouSamurai => GetOrCreateByName("JustForYouSamurai");

	public static GiftCardThemeType Congrats => GetOrCreateByName("Congrats");

	public static GiftCardThemeType CongratsSteelMan => GetOrCreateByName("CongratsSteelMan");

	public static GiftCardThemeType HappyBirthdaySpace => GetOrCreateByName("HappyBirthdaySpace");

	public static GiftCardThemeType HappyBirthdaySteel => GetOrCreateByName("HappyBirthdaySteel");

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

	public GiftCardThemeType()
	{
		_EntityDAL = new GiftCardThemeTypeDAL();
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

	public static GiftCardThemeType CreateNew(string name)
	{
		GiftCardThemeType giftCardThemeType = new GiftCardThemeType();
		giftCardThemeType.Name = name;
		giftCardThemeType.Save();
		return giftCardThemeType;
	}

	public static GiftCardThemeType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, GiftCardThemeTypeDAL, GiftCardThemeType>(EntityCacheInfo, id, () => GiftCardThemeTypeDAL.Get(id));
	}

	public static GiftCardThemeType GetByName(string name)
	{
		return EntityHelper.GetEntityByLookup<byte, GiftCardThemeTypeDAL, GiftCardThemeType>(EntityCacheInfo, $"Name:{name}", () => GiftCardThemeTypeDAL.GetByName(name));
	}

	public static GiftCardThemeType GetOrCreateByName(string name)
	{
		return EntityHelper.GetOrCreateEntity<byte, GiftCardThemeType>(EntityCacheInfo, $"Name:{name}", () => DoGetOrCreate(name));
	}

	private static GiftCardThemeType DoGetOrCreate(string name)
	{
		return EntityHelper.DoGetOrCreate<byte, GiftCardThemeTypeDAL, GiftCardThemeType>(() => GiftCardThemeTypeDAL.GetOrCreateByName(name));
	}

	public void Construct(GiftCardThemeTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Name:{Name}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
