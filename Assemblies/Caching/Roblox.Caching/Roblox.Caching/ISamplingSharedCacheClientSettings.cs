using System;

namespace Roblox.Caching;

internal interface ISamplingSharedCacheClientSettings
{
	uint SampleRatePerThousand { get; }

	TimeSpan SampleLogExpiration { get; }

	string InfluxUrl { get; }

	string InfluxDatabase { get; }

	int SampleStackTraceSubstringLength { get; }
}
