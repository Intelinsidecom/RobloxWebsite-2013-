using System;
using System.Threading;

namespace Roblox.Caching.Shared;

public sealed class DynamicSharedCacheClient : DynamicSharedCacheClientBase
{
	private volatile ISharedCacheClientProvider _SharedCacheClientProvider;

	private readonly IRemoteCachabilitySettings _RemoteCachabilitySettings;

	private readonly IMigrationCacheabilitySettings _MigrationCacheabilitySettings;

	private readonly string _MetricsIdentifier;

	protected override ISharedCacheClient Client => _SharedCacheClientProvider.GetCacheClientForSettings(_RemoteCachabilitySettings, _MigrationCacheabilitySettings, _MetricsIdentifier);

	public DynamicSharedCacheClient(ISharedCacheClientProvider sharedCacheClientProvider, IRemoteCachabilitySettings remoteCachabilitySettings, IMigrationCacheabilitySettings migrationCacheabilitySettings, string metricsIdentifier)
	{
		if (string.IsNullOrWhiteSpace(metricsIdentifier))
		{
			throw new ArgumentException("metricsIdentifier");
		}
		_SharedCacheClientProvider = sharedCacheClientProvider ?? throw new ArgumentNullException("sharedCacheClientProvider");
		_RemoteCachabilitySettings = remoteCachabilitySettings;
		_MigrationCacheabilitySettings = migrationCacheabilitySettings;
		_MetricsIdentifier = metricsIdentifier;
	}

	internal void SetSharedCacheClientProvider(ISharedCacheClientProvider sharedCacheClientProvider)
	{
		if (sharedCacheClientProvider == null)
		{
			throw new ArgumentNullException("sharedCacheClientProvider");
		}
		Interlocked.Exchange(ref _SharedCacheClientProvider, sharedCacheClientProvider);
	}
}
