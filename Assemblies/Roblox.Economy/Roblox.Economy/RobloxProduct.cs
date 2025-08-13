using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class RobloxProduct : IRobloxEntity<int, RobloxProductDAL>, ICacheableObject<int>, ICacheableObject
{
	private RobloxProductDAL _EntityDAL;

	/// <summary>
	/// The ad is a traditional horizontal banner ad.
	/// </summary>
	public static RobloxProduct UserAd_728x90;

	/// <summary>
	/// The ad is a traditional vertical skyscraper ad.
	/// </summary>
	public static RobloxProduct UserAd_160x600;

	/// <summary>
	/// The ad is a traditional square ad.
	/// </summary>
	public static RobloxProduct UserAd_300x250;

	/// <summary>
	/// The ad is a promoted universe for desktop.
	/// </summary>
	public static RobloxProduct UserAd_PromotedUniverseDesktop;

	/// <summary>
	/// The ad is a promoted universe for tablet.
	/// </summary>
	public static RobloxProduct UserAd_PromotedUniverseTablet;

	/// <summary>
	/// The ad is a promoted universe for phone.
	/// </summary>
	public static RobloxProduct UserAd_PromotedUniversePhone;

	/// <summary>
	/// The ad is a promoted universe for console.
	/// </summary>
	public static RobloxProduct UserAd_PromotedUniverseConsole;

	public static RobloxProduct Group;

	public static RobloxProduct Badge;

	public static RobloxProduct GroupRoleSet;

	public static RobloxProduct YouTubeMediaItem;

	public static RobloxProduct ImageMediaItem;

	public static RobloxProduct GamePass;

	public static RobloxProduct CashOut;

	public static RobloxProduct Audio;

	public static RobloxProduct UsernameChange;

	public static RobloxProduct Animation;

	public static RobloxProduct Clan;

	public static RobloxProduct PrivateServer;

	public static RobloxProduct AudioShortSoundEffect;

	public static RobloxProduct AudioLongSoundEffect;

	public static RobloxProduct AudioMusic;

	public static RobloxProduct AudioLongMusic;

	public static CacheInfo EntityCacheInfo;

	public int ID => _EntityDAL.ID;

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

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public RobloxProduct()
	{
		_EntityDAL = new RobloxProductDAL();
	}

	static RobloxProduct()
	{
		UserAd_728x90 = null;
		UserAd_160x600 = null;
		UserAd_300x250 = null;
		UserAd_PromotedUniverseDesktop = null;
		UserAd_PromotedUniverseTablet = null;
		UserAd_PromotedUniversePhone = null;
		UserAd_PromotedUniverseConsole = null;
		Group = null;
		Badge = null;
		GroupRoleSet = null;
		YouTubeMediaItem = null;
		ImageMediaItem = null;
		GamePass = null;
		CashOut = null;
		Audio = null;
		UsernameChange = null;
		Animation = null;
		Clan = null;
		PrivateServer = null;
		AudioShortSoundEffect = null;
		AudioLongSoundEffect = null;
		AudioMusic = null;
		AudioLongMusic = null;
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "RobloxProduct", isNullCacheable: true);
		UserAd_728x90 = Get("User Ad: 728x90");
		UserAd_160x600 = Get("User Ad: 160x600");
		UserAd_300x250 = Get("User Ad: 300x250");
		UserAd_PromotedUniverseDesktop = Get("UserAd: PromotedUniverseDesktop");
		UserAd_PromotedUniverseTablet = Get("UserAd: PromotedUniverseTablet");
		UserAd_PromotedUniversePhone = Get("UserAd: PromotedUniversePhone");
		UserAd_PromotedUniverseConsole = Get("UserAd: PromotedUniverseConsole");
		Group = Get("Group");
		Badge = Get("Badge");
		GroupRoleSet = Get("GroupRoleSet");
		YouTubeMediaItem = Get("YouTubeMediaItem");
		ImageMediaItem = Get("ImageMediaItem");
		GamePass = Get("Game Pass");
		CashOut = Get("Cash Out");
		Audio = Get("Audio");
		UsernameChange = Get("Username Change");
		Animation = Get("Animation");
		Clan = Get("Clan");
		PrivateServer = Get("PrivateServer");
		AudioShortSoundEffect = Get("Audio: Short Sound Effect");
		AudioLongSoundEffect = Get("Audio: Long Sound Effect");
		AudioMusic = Get("Audio: Music");
		AudioLongMusic = Get("Audio: Long Music");
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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

	private static RobloxProduct DoGet(int id)
	{
		return EntityHelper.DoGet<int, RobloxProductDAL, RobloxProduct>(() => RobloxProductDAL.Get(id), id);
	}

	private static RobloxProduct DoGet(string name)
	{
		return EntityHelper.DoGetByLookup<int, RobloxProductDAL, RobloxProduct>(() => RobloxProductDAL.Get(name), name);
	}

	public static RobloxProduct Get(int id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static RobloxProduct Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static RobloxProduct Get(string name)
	{
		return EntityHelper.GetEntityByLookupOld<int, RobloxProduct>(EntityCacheInfo, name, () => DoGet(name));
	}

	public void Construct(RobloxProductDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Name;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
