using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Roblox.ApiClientBase;
using Roblox.Configuration;
using Roblox.LeasedLocks.Client.Properties;

namespace Roblox.LeasedLocks.Client;

public class LeasedLocksClient : GuardedApiClientBase, ILeasedLocksClient
{
	private readonly Func<string> _ApiKeyGetter;

	private readonly Func<string> _ServiceEndpointGetter;

	[ExcludeFromCodeCoverage]
	protected override string ApiKey => _ApiKeyGetter();

	[ExcludeFromCodeCoverage]
	protected override string Endpoint => _ServiceEndpointGetter();

	public override string Name => "LeasedLocks";

	[ExcludeFromCodeCoverage]
	protected override TimeSpan Timeout => Settings.Default.RequestTimeout;

	[ExcludeFromCodeCoverage]
	public override Encoding Encoding => Encoding.UTF8;

	[ExcludeFromCodeCoverage]
	public LeasedLocksClient(Func<string> apiKeyGetter)
		: this(apiKeyGetter, () => RobloxEnvironment.GetApiEndpoint("leasedlocks"))
	{
	}

	[ExcludeFromCodeCoverage]
	internal LeasedLocksClient(Func<string> apiKeyGetter, Func<string> serviceEndpointGetter)
	{
		_ApiKeyGetter = apiKeyGetter ?? throw new ArgumentNullException("apiKeyGetter");
		_ServiceEndpointGetter = serviceEndpointGetter ?? throw new ArgumentNullException("serviceEndpointGetter");
	}

	public bool TryAcquire(LeasedLockType leasedLockType, string lockKey, Guid lockRequester, TimeSpan leaseDuration)
	{
		IEnumerable<KeyValuePair<string, object>> tryAcquireQueryParameters = GetTryAcquireQueryParameters(leasedLockType, lockKey, lockRequester, leaseDuration);
		return Post<bool>("/v1/LeasedLocks/TryAcquire", tryAcquireQueryParameters);
	}

	public Task<bool> TryAcquireAsync(LeasedLockType leasedLockType, string lockKey, Guid lockRequester, TimeSpan leaseDuration, CancellationToken token)
	{
		IEnumerable<KeyValuePair<string, object>> tryAcquireQueryParameters = GetTryAcquireQueryParameters(leasedLockType, lockKey, lockRequester, leaseDuration);
		return PostAsync<bool>("/v1/LeasedLocks/TryAcquire", token, tryAcquireQueryParameters);
	}

	public bool TryRelease(LeasedLockType leasedLockType, string lockKey, Guid lockHolder)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("leasedLockType", leasedLockType),
			new KeyValuePair<string, object>("lockKey", lockKey),
			new KeyValuePair<string, object>("lockHolder", lockHolder)
		};
		return Post<bool>("/v1/LeasedLocks/TryRelease", queryStringParameters);
	}

	public bool TryRenew(LeasedLockType leasedLockType, string lockKey, Guid lockRequester, TimeSpan leaseDuration)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[4]
		{
			new KeyValuePair<string, object>("leasedLockType", leasedLockType),
			new KeyValuePair<string, object>("lockKey", lockKey),
			new KeyValuePair<string, object>("lockRequester", lockRequester),
			new KeyValuePair<string, object>("leaseDuration", leaseDuration)
		};
		return Post<bool>("/v1/LeasedLocks/TryRenew", queryStringParameters);
	}

	private static IEnumerable<KeyValuePair<string, object>> GetTryAcquireQueryParameters(LeasedLockType leasedLockType, string lockKey, Guid lockRequester, TimeSpan leaseDuration)
	{
		yield return new KeyValuePair<string, object>("leasedLockType", leasedLockType);
		yield return new KeyValuePair<string, object>("lockKey", lockKey);
		yield return new KeyValuePair<string, object>("lockRequester", lockRequester);
		yield return new KeyValuePair<string, object>("leaseDuration", leaseDuration);
	}
}
