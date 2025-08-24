using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class SponsoredPageSectionType : IRobloxEntity<byte, SponsoredPageSectionTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private SponsoredPageSectionTypeDAL _EntityDAL;

	public static string IntroSectionValue = "Intro";

	public static string GameSectionValue = "Game";

	public static string VideoSectionValue = "Video";

	public static string LeaderboardSectionValue = "Leaderboard";

	public static string AdSectionValue = "Ad";

	public static string IFrameSectionValue = "iFrame";

	public static string ItemSectionValue = "Item";

	public static string CustomSectionValue = "Custom";

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(SponsoredPageSectionType).ToString(), isNullCacheable: true);

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

	public static SponsoredPageSectionType IntroSection => GetOrCreate(IntroSectionValue);

	public static SponsoredPageSectionType ItemSection => GetOrCreate(ItemSectionValue);

	public static SponsoredPageSectionType GameSection => GetOrCreate(GameSectionValue);

	public static SponsoredPageSectionType VideoSection => GetOrCreate(VideoSectionValue);

	public static SponsoredPageSectionType LeaderboardSection => GetOrCreate(LeaderboardSectionValue);

	public static SponsoredPageSectionType AdSection => GetOrCreate(AdSectionValue);

	public static SponsoredPageSectionType IFrameSection => GetOrCreate(IFrameSectionValue);

	public static SponsoredPageSectionType CustomSection => GetOrCreate(CustomSectionValue);

	public CacheInfo CacheInfo => EntityCacheInfo;

	public SponsoredPageSectionType()
	{
		_EntityDAL = new SponsoredPageSectionTypeDAL();
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

	public static SponsoredPageSectionType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, SponsoredPageSectionTypeDAL, SponsoredPageSectionType>(EntityCacheInfo, id, () => SponsoredPageSectionTypeDAL.Get(id));
	}

	private static SponsoredPageSectionType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<byte, SponsoredPageSectionTypeDAL, SponsoredPageSectionType>(() => SponsoredPageSectionTypeDAL.GetOrCreate(value));
	}

	public static SponsoredPageSectionType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<byte, SponsoredPageSectionType>(EntityCacheInfo, $"Value:{value}", () => DoGetOrCreate(value));
	}

	public static SponsoredPageSectionType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, SponsoredPageSectionTypeDAL, SponsoredPageSectionType>(EntityCacheInfo, $"Value:{value}", () => SponsoredPageSectionTypeDAL.GetSponsoredPageSectionTypeByValue(value));
	}

	public void Construct(SponsoredPageSectionTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
