using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Web;
using Roblox.Common;
using Roblox.FloodCheckers;
using Roblox.Instrumentation;
using Roblox.Marketing.BLL;
using Roblox.Marketing.BrowserTrackerMonitor;
using Roblox.Marketing.Cookies;
using Roblox.Marketing.Properties;
using Roblox.Marketing.Tracking;

namespace Roblox.Marketing;

public static class MarketingHelper
{
	/// <summary>
	/// Occurs on deletion of cookie
	/// </summary>
	/// <param name="cookieName">Name of the cookie.</param>
	/// <param name="cookieValue">The cookie value.</param>
	public delegate void BrowserTrackerV1CookieDeleted(string cookieName, string cookieValue);

	/// <summary>
	/// Occurs on conversion of cookie
	/// </summary>
	/// <param name="cookieName">Name of the cookie.</param>
	/// <param name="cookieValue">The cookie value.</param>
	/// <param name="newCookieName">New name of the cookie.</param>
	public delegate void BrowserTrackerV1ToV2CookieConverted(string cookieName, string cookieValue, string newCookieName);

	internal static readonly BrowserTrackerCookieMonitor BrowserTrackerCookieMonitor = new BrowserTrackerCookieMonitor(StaticCounterRegistry.Instance);

	public static bool BrowserTrackingEnabled => Settings.Default.TrackingBrowserIdentityEnabled;

	public static event Action<string> OnBrowserTrackerCreated;

	public static event BrowserTrackerV1CookieDeleted OnBrowserTrackerV1CookieDeleted;

	public static event BrowserTrackerV1ToV2CookieConverted OnBrowserTrackerV1ToV2CookieConverted;

	private static long? ExtractBrowserTrackerID(RobloxCookie cookie)
	{
		if (cookie == null)
		{
			return null;
		}
		if (long.TryParse(cookie.Values[BrowserTrackerCookie.BrowserTrackerIDKey], out var browserTrackerId))
		{
			return browserTrackerId;
		}
		return null;
	}

	private static long? ExtractAccountID(RobloxCookie cookie)
	{
		if (cookie == null)
		{
			return null;
		}
		if (long.TryParse(cookie.Values[BrowserTrackerCookie.PCICompliantAccountIDKey], out var accountId))
		{
			return accountId;
		}
		if (long.TryParse(cookie.Values[BrowserTrackerCookie.AccountIDKey], out accountId))
		{
			return accountId;
		}
		return null;
	}

	private static RobloxCookie UpdateCookie(RobloxCookie cookie, long? browserId, string requestUrl)
	{
		bool isBrowserTrackerCreated = false;
		#pragma warning disable CS0618 // Suppress obsolete API usage until WebAuthenticator available
		long? userId = User.GetCurrentID();
		#pragma warning restore CS0618
		long? accountId = (userId.HasValue ? new long?(User.Get(userId.Value).AccountID) : null);
		long browserTrackerId;
		if (browserId.HasValue)
		{
			browserTrackerId = browserId.Value;
		}
		else
		{
			browserTrackerId = BrowserTracker.CreateNew().ID;
			isBrowserTrackerCreated = true;
		}
		if (accountId.HasValue)
		{
			try
			{
				AccountBrowserTracker.GetOrCreate(accountId.Value, browserTrackerId).Save();
			}
			catch (SqlException ex2)
			{
				ExceptionHandler.LogException(ex2);
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex.InnerException ?? ex);
			}
		}
		cookie.Values["CreateDate"] = DateTime.Now.ToString();
		cookie.Values[BrowserTrackerCookie.PCICompliantAccountIDKey] = accountId.ToString();
		cookie.Values[BrowserTrackerCookie.BrowserTrackerIDKey] = browserTrackerId.ToString();
		if (cookie.Name == BrowserTrackerCookie.CookieNameV2)
		{
			cookie.Domain = Settings.Default.BrowserTrackerCookie_DomainSuffix;
		}
		cookie.Save(TimeSpan.FromDays(10000.0));
		if (isBrowserTrackerCreated && MarketingHelper.OnBrowserTrackerCreated != null)
		{
			MarketingHelper.OnBrowserTrackerCreated(requestUrl);
		}
		return cookie;
	}

	public static bool IsExcludedFromBrowserTracker(HttpContext context)
	{
		if (Settings.Default.UseCrawlerRegex)
		{
			if (!CrawlerChecker.IsCrawler(context.Request))
			{
				return !context.Request.Browser.Cookies;
			}
			return true;
		}
		return context.Request.Browser.Crawler;
	}

	public static bool DoTrafficRoutingRedirect(HttpContext context, out string redirectUrl, out string enrollmentScript)
	{
		redirectUrl = string.Empty;
		enrollmentScript = string.Empty;
		#pragma warning disable CS0618 // Suppress obsolete API usage until WebAuthenticator available
		User authenticatedUser = User.GetCurrent();
		#pragma warning restore CS0618
		if (Settings.Default.TrafficRoutingEnabled && !IsExcludedFromBrowserTracker(context) && authenticatedUser == null)
		{
			AcquisitionSource acquisitionSource = AcquisitionHelper.GetUserAcquisitionSource(context);
			string routingUrl = string.Empty;
			routingUrl = acquisitionSource switch
			{
				AcquisitionSource.WOM => Settings.Default.TrafficRoutingFreeURL, 
				AcquisitionSource.Google => Settings.Default.TrafficRoutingPaidGoogleURL, 
				AcquisitionSource.Shizmoo => Settings.Default.TrafficRoutingPaidShizmooURL, 
				AcquisitionSource.AddictingGames => Settings.Default.TrafficRoutingPaidAddictingGamesURL, 
				AcquisitionSource.Secco => Settings.Default.TrafficRoutingPaidSeccoURL, 
				_ => Settings.Default.TrafficRoutingPaidDefaultURL, 
			};
			if (!string.IsNullOrEmpty(routingUrl) && !routingUrl.ToLower().Equals(context.Request.Path.ToLower()))
			{
				routingUrl += context.Request.Url.Query;
				redirectUrl = routingUrl;
				return true;
			}
		}
		return false;
	}

	public static RobloxCookie GetOrCreateBrowserTrackerCookie(HttpContext context)
	{
		bool created;
		RobloxCookie cookie = GetOrCreateBrowserTrackerCookie(context, out created);
		if (created && !ExtractBrowserTrackerID(cookie).HasValue)
		{
			ExceptionHandler.LogException(new ApplicationException("No browser tracker ID found after creating tracking cookie"));
		}
		return cookie;
	}

	/// <summary>
	/// Gets the browsertracker cookie and verifies it contains a browsertracker id.  If not, returns null.
	/// </summary>
	/// <param name="context"></param>
	/// <returns></returns>
	private static RobloxCookie GetAndVerifyBrowserTrackerCookie(HttpContext context)
	{
		RobloxCookie cookieV2 = RobloxCookie.Get(context, BrowserTrackerCookie.CookieNameV2);
		RobloxCookie cookieV1 = RobloxCookie.Get(context, BrowserTrackerCookie.CookieName);
		if (!ExtractBrowserTrackerID(cookieV2).HasValue)
		{
			cookieV2 = null;
		}
		if (!ExtractBrowserTrackerID(cookieV1).HasValue)
		{
			cookieV1 = null;
		}
		if (cookieV1 != null && cookieV2 != null)
		{
			BrowserTrackerCookie.SetCanDeleteV1ThisRequest(context, canIDelete: true);
		}
		else
		{
			BrowserTrackerCookie.SetCanDeleteV1ThisRequest(context, canIDelete: false);
		}
		return cookieV2 ?? cookieV1;
	}

	private static RobloxCookie GetOrCreateBrowserTrackerCookie(HttpContext context, out bool created)
	{
		created = false;
		if (IsExcludedFromBrowserTracker(context))
		{
			return null;
		}
		RobloxCookie cookie = GetAndVerifyBrowserTrackerCookie(context);
		if (cookie == null)
		{
			BrowserTrackerCreationFloodChecker browserTrackerCreationFloodChecker = new BrowserTrackerCreationFloodChecker(context.GetOriginIP());
			if (browserTrackerCreationFloodChecker.IsFlooded())
			{
				return null;
			}
			if (System.Net.IPAddress.TryParse(context.Request.Url.Host, out var _))
			{
				return null;
			}
			cookie = RobloxCookie.GetOrCreate(context, BrowserTrackerCookie.CookieNameV2, TimeSpan.FromDays(10000.0));
			cookie = UpdateCookie(cookie, null, context.Request.Url.ToString());
			BrowserTrackerCookieMonitor.Increment(BrowserTrackerInstancesEnum.BrowserTrackerCreationRate.ToString());
			browserTrackerCreationFloodChecker.UpdateCount();
			created = true;
		}
		else
		{
			cookie = RobloxCookie.Get(context, BrowserTrackerCookie.CookieNameV2);
			if (cookie == null || !ExtractBrowserTrackerID(cookie).HasValue)
			{
				cookie = RobloxCookie.Get(context, BrowserTrackerCookie.CookieName);
				RobloxCookie cookieV2 = RobloxCookie.GetOrCreate(context, BrowserTrackerCookie.CookieNameV2, TimeSpan.FromDays(10000.0));
				created = true;
				cookieV2.Domain = Settings.Default.BrowserTrackerCookie_DomainSuffix;
				cookieV2.Values["CreateDate"] = cookie.Values["CreateDate"];
				cookieV2.Values[BrowserTrackerCookie.PCICompliantAccountIDKey] = cookie.Values[BrowserTrackerCookie.PCICompliantAccountIDKey];
				cookieV2.Values[BrowserTrackerCookie.BrowserTrackerIDKey] = cookie.Values[BrowserTrackerCookie.BrowserTrackerIDKey];
				MarketingHelper.OnBrowserTrackerV1ToV2CookieConverted?.Invoke(cookie.Name, cookie.Value, cookieV2.Name);
				cookie = cookieV2;
				cookie.Save(TimeSpan.FromDays(10000.0));
				BrowserTrackerCookieMonitor.Increment(BrowserTrackerInstancesEnum.BrowserTrackerV1toV2ConversionRate.ToString());
			}
			else
			{
				RobloxCookie cookieV1 = RobloxCookie.Get(context, BrowserTrackerCookie.CookieName);
				if (cookieV1 != null && BrowserTrackerCookie.CanDeleteV1ThisRequest(context, ExtractBrowserTrackerID(cookie)))
				{
					MarketingHelper.OnBrowserTrackerV1CookieDeleted?.Invoke(cookieV1.Name, cookieV1.Value);
					cookieV1.Delete();
					BrowserTrackerCookieMonitor.Increment(BrowserTrackerInstancesEnum.BrowserTrackerV1DeletionRate.ToString());
				}
			}
			if (cookie.Values[BrowserTrackerCookie.BrowserTrackerIDKey] == null)
			{
				cookie = UpdateCookie(cookie, null, context.Request.Url.ToString());
			}
			else
			{
				#pragma warning disable CS0618 // Suppress obsolete API usage until WebAuthenticator available
				long? accountId = Account.GetCurrentID(context);
				#pragma warning restore CS0618
				if (accountId.HasValue && ExtractAccountID(cookie) != accountId)
				{
					cookie = UpdateCookie(cookie, ExtractBrowserTrackerID(cookie), context.Request.Url.ToString());
				}
			}
		}
		return cookie;
	}

	private static RobloxCookie GetBrowserTrackerCookie(HttpContext context)
	{
		if (!context.Request.Browser.Cookies)
		{
			return null;
		}
		return GetAndVerifyBrowserTrackerCookie(context);
	}

	public static TimeSpan GetLifetimeOfUserFromDBOrCookie(HttpContext context, int? userId)
	{
		if (userId.HasValue)
		{
			User u = User.Get(userId.Value);
			if (u != null)
			{
				return DateTime.Now - u.Created;
			}
		}
		else
		{
			string value = GetOrCreateBrowserTrackerCookie(context).Values["CreateDate"];
			if (!string.IsNullOrEmpty(value))
			{
				return DateTime.Now - Convert.ToDateTime(value);
			}
		}
		return new TimeSpan(0L);
	}

	public static long? GetBrowserTrackerID(HttpContext context)
	{
		return ExtractBrowserTrackerID(GetOrCreateBrowserTrackerCookie(context));
	}

	public static long? GetBrowserTrackerIDWithoutCreatingOrUpdatingCookie(HttpContext context)
	{
		return ExtractBrowserTrackerID(GetBrowserTrackerCookie(context));
	}

	public static Dictionary<int, string> GetABTestVariationNamesDictionary(string v1, string v2)
	{
		return new Dictionary<int, string>
		{
			{ 0, v1 },
			{ 1, v2 }
		};
	}

	public static Dictionary<int, string> GetABTestVariationNamesDictionary(string v1, string v2, string v3)
	{
		return new Dictionary<int, string>
		{
			{ 0, v1 },
			{ 1, v2 },
			{ 2, v3 }
		};
	}
}
