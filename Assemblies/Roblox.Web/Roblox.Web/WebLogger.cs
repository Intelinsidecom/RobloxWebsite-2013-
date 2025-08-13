using System;
using System.Text;
using System.Web;
using Roblox.Common;
using Roblox.EventLog.Windows;

namespace Roblox.Web;

/// <summary>
/// The WebLogger class inherits the ExtendedLogger
/// Extends functionality for web projects needs
/// </summary>
public class WebLogger : ExtendedLogger
{
	/// <summary>
	/// Calls the ExtendedLogger's corresponding constructor 
	/// (This constructor takes a delegate that returns the max log level as a string)
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="maxLogLevel">maximal log level delegate</param>
	/// <param name="logThreadID">should thread id be logged</param>
	/// <param name="monitorPerformance">should monitor performance metrics for specified source</param>
	public WebLogger(string source, Func<string> maxLogLevel, Func<bool> monitorPerformance, bool logThreadID = false)
		: base(source, new LogExtensionsConfig(new Func<string>[1] { GenerateHttpContextInfoMessage }), maxLogLevel, monitorPerformance, logThreadID)
	{
	}

	/// <summary>
	/// Calls the ExtendedLogger's corresponding constructor 
	/// (This constructor takes a delegate that returns the max log level as a string)
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="maxLogLevel">maximal log level delegate</param>
	/// <param name="logThreadID">should thread id be logged</param>
	public WebLogger(string source, Func<string> maxLogLevel, bool logThreadID = false)
		: base(source, new LogExtensionsConfig(new Func<string>[1] { GenerateHttpContextInfoMessage }), maxLogLevel, () => false, logThreadID)
	{
	}

	/// <summary>
	/// Collects data from HttpContext (if available) and combines to formatted message
	/// </summary>
	/// <returns>Formatted message with data from Http Context</returns>
	private static string GenerateHttpContextInfoMessage()
	{
		HttpContext httpContext = HttpContext.Current;
		try
		{
			if (httpContext == null || httpContext.Request == null)
			{
				return string.Empty;
			}
		}
		catch (Exception ex)
		{
			return $"\r\n[No HttpContext data: {ex.Message}]\r\n";
		}
		StringBuilder message = new StringBuilder();
		HttpRequest httpRequest = httpContext.Request;
		message.AppendFormat("\r\nUrl: {0}\r\nMethod: {1}\r\nIP: {2}\r\nUserAgent: {3}\r\n", httpRequest.Url, httpRequest.HttpMethod, httpContext.GetOriginIP(), httpRequest.UserAgent);
		string xForwardedForHeader = httpRequest.Headers["X-Forwarded-For"];
		if (!string.IsNullOrEmpty(xForwardedForHeader))
		{
			message.AppendFormat("X-Forwarded-For: {0}\r\n", xForwardedForHeader);
		}
		string referer = httpRequest.Headers["Referer"];
		if (!string.IsNullOrEmpty(referer))
		{
			message.AppendFormat("Referer: {0}\r\n", referer);
		}
		message.AppendFormat("Identity: {0}\r\n", CrawlerChecker.IsCrawler() ? "Crawler" : ((HttpContext.Current.User == null) ? "undefined" : (HttpContext.Current.User.Identity?.Name ?? "null")));
		return message.ToString();
	}
}
