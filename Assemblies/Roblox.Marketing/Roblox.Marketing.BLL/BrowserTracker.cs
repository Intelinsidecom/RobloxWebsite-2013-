using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Data.Interfaces;
using Roblox.Marketing.DAL;
using Roblox.Marketing.Properties;

namespace Roblox.Marketing.BLL;

public class BrowserTracker : IRobloxEntity<long, BrowserTrackerDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private BrowserTrackerDAL _EntityDAL;

	private static readonly Random _Random = new Random(Guid.NewGuid().GetHashCode());

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.BrowserTrackerNew", isNullCacheable: true, null, new RemoteCachabilitySettings(Settings.Default.ToSingleSetting((Settings s) => s.MemcachedGroupName)), new MigrationCacheabilitySettings(Settings.Default.ToSingleSetting((Settings s) => s.MemcachedMigrationGroupName), Settings.Default.ToSingleSetting((Settings s) => s.MemcachedMigrationState)));

	public long ID => _EntityDAL.ID;

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

	public BrowserTracker()
		: this(new BrowserTrackerDAL())
	{
	}

	public BrowserTracker(BrowserTrackerDAL entityDAL)
	{
		_EntityDAL = entityDAL;
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

	public static BrowserTracker CreateNew()
	{
		BrowserTracker browserTracker = new BrowserTracker();
		browserTracker.Save();
		CreateNewDebugDump(browserTracker);
		return browserTracker;
	}

	public static BrowserTracker Get(long id)
	{
		return EntityHelper.GetEntity<long, BrowserTrackerDAL, BrowserTracker>(EntityCacheInfo, id, () => BrowserTrackerDAL.Get(id));
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Construct(BrowserTrackerDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static void CreateNewDebugDump(BrowserTracker entity)
	{
		if (!(Settings.Default.BrowserTrackerDebugDumpingPercentage > 0f) || !(_Random.NextDouble() < (double)Settings.Default.BrowserTrackerDebugDumpingPercentage))
		{
			return;
		}
		try
		{
			HttpRequest request = HttpContext.Current.Request;
			string userAgent = request.UserAgent;
			string ipAddress = HttpContext.Current.GetOriginIP();
			long? userId = User.GetCurrentID();
			int cookieCount = request.Cookies.Count;
			StringBuilder cookiesSb = new StringBuilder();
			cookiesSb.Append("{ ");
			string[] allKeys = request.Cookies.AllKeys;
			foreach (string cookieName in allKeys)
			{
				cookiesSb.Append(cookieName + ": " + request.Cookies[cookieName].Value + ", ");
			}
			cookiesSb.Append("}");
			bool supportsJavascript = request.Browser.EcmaScriptVersion.Major >= 1;
			bool supportsCookies = request.Browser.Cookies;
			string requestedResource = request.Url.ToString();
			string referrer = ((request.UrlReferrer == null) ? "" : request.UrlReferrer.ToString());
			string additionalData = $"JSSupport: {supportsJavascript}, CookieSupport: {supportsCookies}, CookieCount: {cookieCount}, Referrer: {referrer}, Cookies: {cookiesSb}";
			NewBrowserTrackerDmp.CreateNew(entity.ID, userAgent, ipAddress, userId, requestedResource, additionalData);
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
	}
}
