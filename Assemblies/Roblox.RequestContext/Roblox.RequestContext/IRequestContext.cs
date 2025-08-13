using System.Collections.Generic;

namespace Roblox.RequestContext;

public interface IRequestContext
{
	long? AuthenticatedUserID { get; }

	long? AccountID { get; }

	string RequestIPAddress { get; }

	string UserAgent { get; }

	AgeBracket? AgeBracket { get; }

	string RequestCountryCode { get; }

	string AccountCountryCode { get; }

	string PlatformType { get; }

	string EnvironmentAbbreviation { get; }

	ICollection<Policy> ApplicablePolicies { get; }

	string TencentOpenId { get; }

	string TencentAccessToken { get; }

	long? BrowserTrackerID { get; }

	DistributorType DistributorType { get; }

	string this[string key] { get; }

	ICollection<KeyValuePair<string, string>> ToKeyValuePairs();
}
