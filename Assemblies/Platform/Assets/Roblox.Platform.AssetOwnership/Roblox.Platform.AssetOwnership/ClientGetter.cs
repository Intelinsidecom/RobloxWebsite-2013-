using System;
using System.Linq.Expressions;
using Roblox.Caching.Interfaces;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Ownership.Client;
using Roblox.Platform.AssetOwnership.Properties;

namespace Roblox.Platform.AssetOwnership;

internal class ClientGetter : IClientGetter
{
	private readonly ILogger _Logger;

	private readonly IRequestCache _RequestCache;

	public IOwnershipAuthority Client { get; private set; }

	/// <summary>
	/// Monitors the ov1 apiKey and keeps a fresh copy of the ov1 client.
	/// </summary>
	public ClientGetter(Expression<Func<ISettings, string>> apiKeyGetter, ILogger logger, IRequestCache requestCache)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_RequestCache = requestCache;
		Settings.Default.ReadValueAndMonitorChanges(apiKeyGetter, UserAssetShimApiKeyChanged);
	}

	private void UserAssetShimApiKeyChanged(string apiKey)
	{
		_Logger.Info(() => "Ov1UserAssetShimApiKey Changed - ClientGetter recreating the client.");
		Client = OwnershipAuthorityFactory.Singleton.GetOwnershipAuthority(apiKey, _RequestCache);
	}
}
