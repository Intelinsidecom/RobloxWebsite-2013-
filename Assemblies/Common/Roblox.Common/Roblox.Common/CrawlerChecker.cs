using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Web;
using Roblox.Common.Properties;

namespace Roblox.Common;

public class CrawlerChecker
{
	private static Regex reusableRegex;

	public static string CrawlerUserAgentRegexString => Settings.Default.CrawlerUserAgentRegex;

	public static bool ReuseCrawlerUserAgentRegex => Settings.Default.ReuseCrawlerUserAgentRegex;

	static CrawlerChecker()
	{
		Settings.Default.PropertyChanged += SettingsChanged;
	}

	public static void SettingsChanged(object sender, PropertyChangedEventArgs e)
	{
		reusableRegex = null;
	}

	public static bool IsCrawler(HttpRequest request)
	{
		bool isCrawler = request.Browser.Crawler;
		if (!isCrawler)
		{
			if (string.IsNullOrEmpty(request.UserAgent))
			{
				isCrawler = true;
			}
			else if (ReuseCrawlerUserAgentRegex)
			{
				if (reusableRegex == null)
				{
					try
					{
						reusableRegex = new Regex(CrawlerUserAgentRegexString);
						isCrawler = reusableRegex.IsMatch(request.UserAgent);
					}
					catch (ArgumentException)
					{
						HttpContext current = HttpContext.Current;
						HttpContext.Current = null;
						ExceptionHandler.LogException("Regex parse error in CrawlerUserAgentRegexString.  Skipped regex crawler check.");
						HttpContext.Current = current;
					}
				}
				else
				{
					isCrawler = reusableRegex.IsMatch(request.UserAgent);
				}
			}
			else
			{
				try
				{
					isCrawler = new Regex(CrawlerUserAgentRegexString).Match(request.UserAgent).Success;
				}
				catch (ArgumentException)
				{
					HttpContext current2 = HttpContext.Current;
					HttpContext.Current = null;
					ExceptionHandler.LogException("Regex parse error in CrawlerUserAgentRegexString.  Skipped regex crawler check.");
					HttpContext.Current = current2;
				}
			}
		}
		return isCrawler;
	}

	public static bool IsCrawler()
	{
		return IsCrawler(HttpContext.Current.Request);
	}
}
