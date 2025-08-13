using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Roblox.RequestContext;

public class RobloxRequestContext : IRequestContext
{
	private const char _FactSplitCharacter = ';';

	private readonly IDictionary<string, string> _ContextItems;

	private static readonly Regex _UserAgentParseRegex = new Regex("RobloxApp/(?<version>[\\d\\.]+)\\s+\\((?<facts>[^\\)]*)\\)", RegexOptions.Compiled);

	private static readonly IReadOnlyDictionary<string, DistributorType> _DistributorTypesByRawValues = new Dictionary<string, DistributorType>
	{
		{
			"GlobalDist",
			DistributorType.Global
		},
		{
			"CJVDist",
			DistributorType.ChinaJointVenture
		}
	};

	internal static string AuthenticatedUserIdItemKey => string.Format("{0}authenticated-userid", "robloxctx-");

	internal static string AccountIdItemKey => string.Format("{0}account-id", "robloxctx-");

	internal static string RequestIPAddressItemKey => string.Format("{0}request-ip-address", "robloxctx-");

	internal static string UserAgentItemKey => string.Format("{0}user-agent", "robloxctx-");

	internal static string AgeBracketItemKey => string.Format("{0}age-bracket", "robloxctx-");

	internal static string RequestCountryCodeItemKey => string.Format("{0}request-country-code", "robloxctx-");

	internal static string AccountCountryCodeItemKey => string.Format("{0}account-country-code", "robloxctx-");

	internal static string PlatformTypeItemKey => string.Format("{0}platform-type", "robloxctx-");

	internal static string EnvironmentAbbreviationItemKey => string.Format("{0}environment-abbreviation", "robloxctx-");

	internal static string ApplicablePoliciesItemKey => string.Format("{0}applicable-policies", "robloxctx-");

	internal static string TencentOpenIdItemKey => string.Format("{0}tencent-open-id", "robloxctx-");

	internal static string TencentAccessTokenItemKey => string.Format("{0}tencent-access-token", "robloxctx-");

	internal static string BrowserTrackerIdItemKey => string.Format("{0}browser-tracker-id", "robloxctx-");

	internal static string DistributorTypeItemKey => string.Format("{0}distributor-type", "robloxctx-");

	public long? AuthenticatedUserID { get; private set; }

	public long? AccountID { get; private set; }

	public string RequestIPAddress => this[RequestIPAddressItemKey];

	public string UserAgent => this[UserAgentItemKey];

	public AgeBracket? AgeBracket { get; private set; }

	public string RequestCountryCode => this[RequestCountryCodeItemKey];

	public string AccountCountryCode => this[AccountCountryCodeItemKey];

	public string PlatformType => this[PlatformTypeItemKey];

	public string EnvironmentAbbreviation => this[EnvironmentAbbreviationItemKey];

	public ICollection<Policy> ApplicablePolicies { get; } = new List<Policy>();


	public string TencentOpenId => this[TencentOpenIdItemKey];

	public string TencentAccessToken => this[TencentAccessTokenItemKey];

	public long? BrowserTrackerID { get; private set; }

	public DistributorType DistributorType { get; private set; }

	public string this[string key]
	{
		get
		{
			if (!_ContextItems.ContainsKey(key))
			{
				return null;
			}
			return _ContextItems[key];
		}
	}

	public RobloxRequestContext(long? authenticatedUserID = null, string requestIPAddress = null, string userAgent = null, AgeBracket? ageBracket = null, string requestCountryCode = null, string accountCountryCode = null, string platformType = null, string environmentAbbreviation = null, ICollection<Policy> applicablePolicies = null, ICollection<KeyValuePair<string, string>> additionalItems = null, string tencentOpenId = null, string tencentAccessToken = null, long? browserTrackerID = null, long? accountId = null)
	{
		AuthenticatedUserID = authenticatedUserID;
		AgeBracket = ageBracket;
		ApplicablePolicies = applicablePolicies ?? new List<Policy>();
		BrowserTrackerID = browserTrackerID;
		AccountID = accountId;
		DistributorType = GetDistributorTypeFromUserAgent(userAgent);
		string value = string.Join(",", ApplicablePolicies);
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{
				AuthenticatedUserIdItemKey,
				authenticatedUserID?.ToString()
			},
			{
				AccountIdItemKey,
				accountId?.ToString()
			},
			{ RequestIPAddressItemKey, requestIPAddress },
			{ UserAgentItemKey, userAgent },
			{
				AgeBracketItemKey,
				ageBracket?.ToString()
			},
			{ RequestCountryCodeItemKey, requestCountryCode },
			{ AccountCountryCodeItemKey, accountCountryCode },
			{ PlatformTypeItemKey, platformType },
			{ EnvironmentAbbreviationItemKey, environmentAbbreviation },
			{ ApplicablePoliciesItemKey, value },
			{ TencentOpenIdItemKey, tencentOpenId },
			{ TencentAccessTokenItemKey, tencentAccessToken },
			{
				BrowserTrackerIdItemKey,
				browserTrackerID?.ToString()
			},
			{
				DistributorTypeItemKey,
				DistributorType.ToString()
			}
		};
		if (additionalItems != null)
		{
			foreach (KeyValuePair<string, string> additionalItem in additionalItems)
			{
				dictionary[additionalItem.Key] = additionalItem.Value;
			}
		}
		_ContextItems = dictionary;
	}

	public RobloxRequestContext(IDictionary<string, string> contextItems)
	{
		_ContextItems = contextItems ?? throw new ArgumentNullException("contextItems");
		LoadProperties();
	}

	private void LoadProperties()
	{
		if (!_ContextItems.Any())
		{
			return;
		}
		if (_ContextItems.ContainsKey(AuthenticatedUserIdItemKey) && _ContextItems[AuthenticatedUserIdItemKey] != null && long.TryParse(_ContextItems[AuthenticatedUserIdItemKey], out var result))
		{
			AuthenticatedUserID = result;
		}
		if (_ContextItems.ContainsKey(AccountIdItemKey) && _ContextItems[AccountIdItemKey] != null && long.TryParse(_ContextItems[AccountIdItemKey], out var result2))
		{
			AccountID = result2;
		}
		if (_ContextItems.ContainsKey(AgeBracketItemKey) && _ContextItems[AgeBracketItemKey] != null && Enum.TryParse<AgeBracket>(_ContextItems[AgeBracketItemKey], out var result3))
		{
			AgeBracket = result3;
		}
		if (_ContextItems.ContainsKey(BrowserTrackerIdItemKey) && _ContextItems[BrowserTrackerIdItemKey] != null && long.TryParse(_ContextItems[BrowserTrackerIdItemKey], out var result4))
		{
			BrowserTrackerID = result4;
		}
		if (_ContextItems.ContainsKey(DistributorTypeItemKey) && _ContextItems[DistributorTypeItemKey] != null && Enum.TryParse<DistributorType>(_ContextItems[DistributorTypeItemKey], out var result5))
		{
			DistributorType = result5;
		}
		if (!_ContextItems.ContainsKey(ApplicablePoliciesItemKey) || _ContextItems[ApplicablePoliciesItemKey] == null)
		{
			return;
		}
		string[] array = _ContextItems[ApplicablePoliciesItemKey].Split(new char[1] { ',' });
		for (int i = 0; i < array.Length; i++)
		{
			if (Enum.TryParse<Policy>(array[i], out var result6))
			{
				ApplicablePolicies.Add(result6);
			}
		}
	}

	public ICollection<KeyValuePair<string, string>> ToKeyValuePairs()
	{
		return _ContextItems.Select((KeyValuePair<string, string> x) => x).ToArray();
	}

	private DistributorType GetDistributorTypeFromUserAgent(string userAgent)
	{
		IReadOnlyCollection<string> userAgentFacts = GetUserAgentFacts(userAgent);
		if (!userAgentFacts.Any())
		{
			return DistributorType.Unknown;
		}
		foreach (string item in userAgentFacts)
		{
			if (_DistributorTypesByRawValues.ContainsKey(item))
			{
				return _DistributorTypesByRawValues[item];
			}
		}
		return DistributorType.Unknown;
	}

	private IReadOnlyCollection<string> GetUserAgentFacts(string userAgent)
	{
		if (string.IsNullOrWhiteSpace(userAgent))
		{
			return (IReadOnlyCollection<string>)(object)new string[0];
		}
		Match match = _UserAgentParseRegex.Match(userAgent);
		if (!match.Success)
		{
			return (IReadOnlyCollection<string>)(object)new string[0];
		}
		return (IReadOnlyCollection<string>)(object)(from v in match.Groups["facts"].Value.Split(new char[1] { ';' })
			select v.Trim()).ToArray();
	}
}
