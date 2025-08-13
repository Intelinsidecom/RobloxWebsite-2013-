using System;
using System.Linq;
using System.Linq.Expressions;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Web.Properties;

namespace Roblox.Web;

public class CorsOriginValidator
{
	private static string[] _AllowedOrigins;

	private static string[] _BlackListedOrigins;

	private static string _PerformanceCategory = "Roblox.Web.CorsOriginValidator";

	private ILogger _Logger;

	internal IRateOfCountsPerSecondCounter CorsReferrerHeaderUsedCounter { get; set; }

	public CorsOriginValidator(ICounterRegistry counterRegistry, ILogger logger = null)
		: this(counterRegistry, logger, Settings.Default)
	{
	}

	internal CorsOriginValidator(ICounterRegistry counterRegistry, ILogger logger, ISettings settings)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		Settings.Default.ReadValueAndMonitorChanges((Expression<Func<Settings, string>>)((Settings s) => s.RobloxEnableCorsAllowedOrigins), (Action<string>)delegate
		{
			_AllowedOrigins = MultiValueSettingParser.ParseCommaDelimitedListStringMaintainOrdering(settings.RobloxEnableCorsAllowedOrigins).ToArray();
		});
		Settings.Default.ReadValueAndMonitorChanges((Expression<Func<Settings, string>>)((Settings s) => s.CorsBlacklistedOrigins), (Action<string>)delegate
		{
			_BlackListedOrigins = MultiValueSettingParser.ParseCommaDelimitedListStringMaintainOrdering(settings.CorsBlacklistedOrigins).ToArray();
		});
		_Logger = logger;
		try
		{
			CorsReferrerHeaderUsedCounter = counterRegistry.GetRateOfCountsPerSecondCounter(_PerformanceCategory, "ReferrerUsedForCors");
		}
		catch (Exception ex)
		{
			_Logger?.Error(ex);
		}
	}

	/// <summary>
	///     Checks if the origin domain is included in the blacklisted origins
	/// </summary>
	/// <param name="originDomain"></param>
	/// <returns>Boolean if domain belongs to blacklist</returns>
	private bool IncludedInBlacklist(string originDomain)
	{
		string[] blackListedOrigins = _BlackListedOrigins;
		foreach (string blacklistedOrigin in blackListedOrigins)
		{
			if (originDomain.EndsWith(blacklistedOrigin))
			{
				return true;
			}
		}
		return false;
	}

	/// <summary>
	///     Gives the origin domain that needs to be added back in the HTTP response
	/// </summary>
	/// <param name="urlReferrer"></param>
	/// <param name="headerOrigin"></param>
	/// <returns>Origin to be added to HTTP response</returns>
	public string GetValidatedOriginToAdd(Uri urlReferrer = null, string headerOrigin = null)
	{
		string originDomain = string.Empty;
		if (!string.IsNullOrEmpty(headerOrigin))
		{
			if (!headerOrigin.StartsWith(Uri.UriSchemeHttps))
			{
				return null;
			}
			originDomain = headerOrigin;
		}
		else if (urlReferrer != null)
		{
			if (urlReferrer.Scheme != Uri.UriSchemeHttps)
			{
				return null;
			}
			originDomain = urlReferrer.Scheme + Uri.SchemeDelimiter + urlReferrer.Host;
			CorsReferrerHeaderUsedCounter?.Increment();
		}
		string originToAdd = null;
		string[] allowedOrigins = _AllowedOrigins;
		foreach (string allowedOrigin in allowedOrigins)
		{
			if (allowedOrigin.StartsWith("*"))
			{
				if (allowedOrigin == "*")
				{
					originToAdd = originDomain;
					break;
				}
				string restOfAllowedOrigin = allowedOrigin.Substring(1);
				if (originDomain.EndsWith(restOfAllowedOrigin))
				{
					if (!IncludedInBlacklist(originDomain))
					{
						originToAdd = originDomain;
					}
					break;
				}
			}
			else if (allowedOrigin == originDomain)
			{
				originToAdd = originDomain;
				break;
			}
		}
		return originToAdd;
	}
}
