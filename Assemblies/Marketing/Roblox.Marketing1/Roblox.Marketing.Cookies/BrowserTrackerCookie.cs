using System;
using System.Collections.Specialized;
using System.Net;
using System.Web;
using Roblox.Libraries.Cookies;
using Roblox.Marketing.BLL;
using Roblox.Marketing.BrowserTrackerMonitor;
using Roblox.Marketing.Properties;

namespace Roblox.Marketing.Cookies;

public class BrowserTrackerCookie : RobloxCookieBase
{
	private static readonly string _Name = "RBXEventTracker";

	private static readonly string _NameV2 = "RBXEventTrackerV2";

	private static readonly RobloxCookieIdentifier _CookieIdentifier = new RobloxCookieIdentifier(_Name);

	private static readonly RobloxCookieIdentifier _CookieIdentifierV2 = new RobloxCookieIdentifier(_NameV2);

	public static readonly string BrowserTrackerIDKey = "browserid";

	public static readonly string AccountIDKey = "accountid";

	public static readonly string PCICompliantAccountIDKey = "rbxid";

	public static string CookieName => _Name;

	public static string CookieNameV2 => _NameV2;

	protected override string Name => _Name;

	protected override TimeSpan? _ExpirationLength => TimeSpan.FromDays(10000.0);

	public long BrowserTrackerID { get; set; }

	public long? AccountID { get; set; }

	public DateTime CreateDate { get; set; }

	public static event Action<string> OnBrowserTrackerCreated;

	public static void SetCanDeleteV1ThisRequest(HttpContext context, bool canIDelete)
	{
		if (context.Items["CanWeDeleteV1"] == null)
		{
			context.Items["CanWeDeleteV1"] = canIDelete;
		}
	}

	public static bool CanDeleteV1ThisRequest(HttpContext context, long? browserTrackerId)
	{
		if (browserTrackerId.HasValue && browserTrackerId % 100 < Settings.Default.DeleteBrowserTrackerV1Percentage)
		{
			object canDelete = context.Items["CanWeDeleteV1"];
			if (canDelete != null)
			{
				return (bool)canDelete;
			}
			return false;
		}
		return false;
	}

	public override void DoDeSerializeValues(NameValueCollection keyValues)
	{
		if (long.TryParse(keyValues[BrowserTrackerIDKey], out var browserTrackerId))
		{
			BrowserTrackerID = browserTrackerId;
		}
		else
		{
			BrowserTrackerID = 0L;
		}
		if (long.TryParse(keyValues[PCICompliantAccountIDKey], out var accountId))
		{
			AccountID = accountId;
		}
		else if (long.TryParse(keyValues[AccountIDKey], out accountId))
		{
			AccountID = accountId;
		}
		else
		{
			AccountID = null;
		}
		if (DateTime.TryParse(keyValues["CreateDate"], out var created))
		{
			CreateDate = created;
		}
		else
		{
			CreateDate = DateTime.MinValue;
		}
	}

	public override NameValueCollection DoSerializeValues()
	{
		return new NameValueCollection
		{
			{
				BrowserTrackerIDKey,
				BrowserTrackerID.ToString()
			},
			{
				PCICompliantAccountIDKey,
				AccountID.ToString()
			},
			{
				"CreateDate",
				CreateDate.ToString()
			}
		};
	}

	public static BrowserTrackerCookie GetOrCreate(int? authenticatedAccountId)
	{
		bool dummy;
		return GetOrCreate(authenticatedAccountId, out dummy);
	}

	public static BrowserTrackerCookie GetOrCreate(int? authenticatedAccountId, out bool isBrowserTrackerCreated)
	{
		isBrowserTrackerCreated = false;
		HttpContext context = HttpContext.Current;
		bool needsSave = false;
		if (MarketingHelper.IsExcludedFromBrowserTracker(context))
		{
			return null;
		}
		BrowserTrackerCookie cookie = RobloxCookieHelper.Get<BrowserTrackerCookie>(_CookieIdentifierV2);
		if (cookie != null && cookie.BrowserTrackerID == 0L)
		{
			cookie = null;
		}
		if (cookie != null && CanDeleteV1ThisRequest(context, cookie.BrowserTrackerID))
		{
			BrowserTrackerCookie cookieV1 = RobloxCookieHelper.Get<BrowserTrackerCookie>(_CookieIdentifier);
			if (cookieV1 != null)
			{
				cookieV1.Delete();
				MarketingHelper.BrowserTrackerCookieMonitor.Increment(BrowserTrackerInstancesEnum.BrowserTrackerV1DeletionRate.ToString());
			}
		}
		if (cookie == null)
		{
			cookie = RobloxCookieHelper.Get<BrowserTrackerCookie>(_CookieIdentifier);
			if (cookie != null && cookie.BrowserTrackerID == 0L)
			{
				cookie = null;
			}
			if (cookie != null)
			{
				BrowserTrackerCookie orCreate = RobloxCookieHelper.GetOrCreate<BrowserTrackerCookie>(_CookieIdentifierV2);
				orCreate.Domain = Settings.Default.BrowserTrackerCookie_DomainSuffix;
				orCreate.AccountID = cookie.AccountID;
				orCreate.BrowserTrackerID = cookie.BrowserTrackerID;
				orCreate.CreateDate = cookie.CreateDate;
				cookie = orCreate;
				MarketingHelper.BrowserTrackerCookieMonitor.Increment(BrowserTrackerInstancesEnum.BrowserTrackerV1toV2ConversionRate.ToString());
				needsSave = true;
			}
		}
		if (cookie == null)
		{
			if (System.Net.IPAddress.TryParse(context.Request.Url.Host, out var _))
			{
				return null;
			}
			cookie = RobloxCookieHelper.GetOrCreate<BrowserTrackerCookie>(_CookieIdentifierV2);
			cookie.Domain = Settings.Default.BrowserTrackerCookie_DomainSuffix;
			MarketingHelper.BrowserTrackerCookieMonitor.Increment(BrowserTrackerInstancesEnum.BrowserTrackerCreationRate.ToString());
			isBrowserTrackerCreated = true;
		}
		if (authenticatedAccountId.HasValue && cookie.AccountID != authenticatedAccountId)
		{
			cookie.AccountID = authenticatedAccountId;
			needsSave = true;
		}
		if (cookie.BrowserTrackerID == 0L)
		{
			cookie.BrowserTrackerID = BrowserTracker.CreateNew().ID;
			needsSave = true;
		}
		if (cookie.CreateDate == DateTime.MinValue)
		{
			cookie.CreateDate = DateTime.Now;
			needsSave = true;
		}
		if (needsSave)
		{
			if (cookie.AccountID.HasValue)
			{
				AccountBrowserTracker.GetOrCreate(cookie.AccountID.Value, cookie.BrowserTrackerID).Save();
			}
			cookie.Save();
		}
		if (isBrowserTrackerCreated && BrowserTrackerCookie.OnBrowserTrackerCreated != null)
		{
			BrowserTrackerCookie.OnBrowserTrackerCreated(context.Request.Url.ToString());
		}
		return cookie;
	}

	public override void Save()
	{
		if (Name == _NameV2)
		{
			Domain = Settings.Default.BrowserTrackerCookie_DomainSuffix;
		}
		base.Save();
	}
}
