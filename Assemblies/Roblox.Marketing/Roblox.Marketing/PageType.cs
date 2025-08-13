using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class PageType : IRobloxEntity<byte, PageTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PageTypeDAL _EntityDAL;

	public static string SponsoredPageValue = "Sponsored";

	public static string EventPageValue = "Event";

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(PageType).ToString(), isNullCacheable: true);

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

	public static PageType SponsoredPage => GetOrCreate(SponsoredPageValue);

	public static PageType EventPage => GetOrCreate(EventPageValue);

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PageType()
	{
		_EntityDAL = new PageTypeDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static PageType CreateNew(string value)
	{
		PageType pageType = new PageType();
		pageType.Value = value;
		pageType.Save();
		return pageType;
	}

	public static PageType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PageTypeDAL, PageType>(EntityCacheInfo, id, () => PageTypeDAL.Get(id));
	}

	private static PageType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<byte, PageTypeDAL, PageType>(() => PageTypeDAL.GetOrCreate(value));
	}

	public static PageType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<byte, PageType>(EntityCacheInfo, $"Value:{value}", () => DoGetOrCreate(value));
	}

	public static ICollection<PageType> GetActionTypesPaged(byte startRowIndex, byte maximumRows)
	{
		string collectionId = $"GetPageTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => PageTypeDAL.GetPageTypeIDsPaged((byte)(startRowIndex + 1), maximumRows), Get);
	}

	public void Construct(PageTypeDAL dal)
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
