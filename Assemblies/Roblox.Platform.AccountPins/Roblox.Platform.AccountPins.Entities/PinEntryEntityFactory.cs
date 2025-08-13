using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching.Shared;
using Roblox.Platform.Core;

namespace Roblox.Platform.AccountPins.Entities;

/// <summary>
/// A platform implementation of <see cref="T:Roblox.Platform.AccountPins.Entities.IPinEntryEntityFactory" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.AccountPins.Entities.IPinEntryEntityFactory" />
[ExcludeFromCodeCoverage]
internal class PinEntryEntityFactory : IPinEntryEntityFactory
{
	private readonly ISharedCacheClient _SharedCacheClient;

	private readonly AccountPinsDomainFactories _DomainFactories;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.Entities.PinEntryEntityFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <param name="cacheClient">The cache client.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// </exception>
	internal PinEntryEntityFactory(AccountPinsDomainFactories domainFactories, ISharedCacheClient cacheClient)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		if (cacheClient == null)
		{
			throw new PlatformArgumentNullException("cacheClient");
		}
		_DomainFactories = domainFactories;
		_SharedCacheClient = cacheClient;
	}

	public IPinEntryEntity CreateNew(long accountId, string sessionString, long pinHashId)
	{
		Get(accountId, sessionString)?.Delete();
		PinEntryCachedEntity pinEntryCachedEntity = new PinEntryCachedEntity(_SharedCacheClient);
		pinEntryCachedEntity.PinHashId = pinHashId;
		pinEntryCachedEntity.AccountId = accountId;
		pinEntryCachedEntity.SessionString = sessionString;
		pinEntryCachedEntity.Created = DateTime.Now;
		pinEntryCachedEntity.Save();
		return pinEntryCachedEntity;
	}

	public IPinEntryEntity Get(long accountId, string sessionString)
	{
		return CalToCached(PinEntryCAL.Get(accountId, sessionString, _SharedCacheClient), _SharedCacheClient);
	}

	private static IPinEntryEntity CalToCached(PinEntryCAL cal, ISharedCacheClient cacheClient)
	{
		if (cal != null)
		{
			return new PinEntryCachedEntity(cacheClient)
			{
				PinHashId = cal.PinHashID,
				AccountId = cal.AccountID,
				SessionString = cal.SessionString,
				Created = cal.Created
			};
		}
		return null;
	}
}
