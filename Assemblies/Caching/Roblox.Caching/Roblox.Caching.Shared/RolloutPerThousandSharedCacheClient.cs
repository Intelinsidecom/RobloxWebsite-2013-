using System;
using System.Threading;

namespace Roblox.Caching.Shared;

internal class RolloutPerThousandSharedCacheClient : DynamicSharedCacheClientBase
{
	private static int _RolloutQualifier;

	private readonly Func<int> _RolloutPerThousandGetter;

	private readonly ISharedCacheClient _SourceCacheClient;

	private readonly ISharedCacheClient _DestinationCacheClient;

	private const int _PerThousand = 1000;

	protected override ISharedCacheClient Client => GetCacheClientToUseForRollout();

	public RolloutPerThousandSharedCacheClient(ISharedCacheClient sourceCacheClient, ISharedCacheClient destinationCacheClient, Func<int> rolloutPerThousandGetter)
	{
		_SourceCacheClient = sourceCacheClient ?? throw new ArgumentNullException("sourceCacheClient");
		_DestinationCacheClient = destinationCacheClient ?? throw new ArgumentNullException("destinationCacheClient");
		_RolloutPerThousandGetter = rolloutPerThousandGetter ?? throw new ArgumentNullException("rolloutPerThousandGetter");
	}

	private ISharedCacheClient GetCacheClientToUseForRollout()
	{
		int num = _RolloutPerThousandGetter();
		if (num <= 0)
		{
			return _SourceCacheClient;
		}
		if (num >= 1000)
		{
			return _DestinationCacheClient;
		}
		if (Math.Abs(Interlocked.Increment(ref _RolloutQualifier) % 1000) < num)
		{
			return _DestinationCacheClient;
		}
		return _SourceCacheClient;
	}
}
