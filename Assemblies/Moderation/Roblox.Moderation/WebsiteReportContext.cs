using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class WebsiteReportContext : IRobloxEntity<long, WebsiteReportContextDAL>, ICacheableObject<long>, ICacheableObject, IWebsiteReportContext, IReportContext
{
	private WebsiteReportContextDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(WebsiteReportContext).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public string ContextUrl
	{
		get
		{
			return _EntityDAL.ContextUrl;
		}
		set
		{
			_EntityDAL.ContextUrl = value;
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

	public WebsiteReportContext()
	{
		_EntityDAL = new WebsiteReportContextDAL();
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

	public static WebsiteReportContext CreateNew(string contextUrl)
	{
		WebsiteReportContext websiteReportContext = new WebsiteReportContext();
		websiteReportContext.ContextUrl = contextUrl;
		websiteReportContext.Save();
		return websiteReportContext;
	}

	public static WebsiteReportContext Get(long id)
	{
		return EntityHelper.GetEntity<long, WebsiteReportContextDAL, WebsiteReportContext>(EntityCacheInfo, id, () => WebsiteReportContextDAL.Get(id));
	}

	public static WebsiteReportContext GetOrCreate(string contextUrl)
	{
		return EntityHelper.GetOrCreateEntity<long, WebsiteReportContext>(EntityCacheInfo, "ContextUrl:" + contextUrl, () => DoGetOrCreate(contextUrl));
	}

	private static WebsiteReportContext DoGetOrCreate(string contextUrl)
	{
		return EntityHelper.DoGetOrCreate<long, WebsiteReportContextDAL, WebsiteReportContext>(() => WebsiteReportContextDAL.GetOrCreate(contextUrl));
	}

	public void Construct(WebsiteReportContextDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "ContextUrl:" + ContextUrl;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
