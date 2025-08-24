using System;
using System.Threading;
using Roblox.EventLog;

namespace Roblox.Platform.Notifications.Push;

internal class PushServiceClientFactory
{
	private readonly ILogger _Logger;

	private readonly Lazy<IPushServiceClient> _AmazonSnsMobilePushClient;

	private readonly Lazy<IPushServiceClient> _MozillaPushServiceClient;

	public PushServiceClientFactory(ILogger logger)
	{
		_Logger = logger;
		_AmazonSnsMobilePushClient = new Lazy<IPushServiceClient>(() => new AmazonSnsMobilePushClient(_Logger), LazyThreadSafetyMode.ExecutionAndPublication);
		_MozillaPushServiceClient = new Lazy<IPushServiceClient>(() => new MozillaPushServiceClient(_Logger), LazyThreadSafetyMode.ExecutionAndPublication);
	}

	public IPushServiceClient GetSharedAmazonSnsMobilePushClient()
	{
		return _AmazonSnsMobilePushClient.Value;
	}

	public IPushServiceClient GetSharedMozillaPushServiceClient()
	{
		return _MozillaPushServiceClient.Value;
	}
}
