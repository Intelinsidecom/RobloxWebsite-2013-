using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching.Shared;
using Roblox.Platform.Core;

namespace Roblox.Platform.AccountPins.Entities;

/// <summary>
/// A platform implementation of <see cref="T:Roblox.Platform.AccountPins.Entities.IPinEntryEntity" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.AccountPins.Entities.IPinEntryEntity" />
[ExcludeFromCodeCoverage]
internal class PinEntryCachedEntity : IPinEntryEntity
{
	private readonly ISharedCacheClient _SharedCacheClient;

	public long PinHashId { get; set; }

	public long AccountId { get; set; }

	public string SessionString { get; set; }

	public DateTime Created { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.Entities.PinEntryCachedEntity" /> class.
	/// </summary>
	/// <param name="cacheClient">The cache client.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"></exception>
	internal PinEntryCachedEntity(ISharedCacheClient cacheClient)
	{
		if (cacheClient == null)
		{
			throw new PlatformArgumentNullException("cacheClient");
		}
		_SharedCacheClient = cacheClient;
	}

	public void Save()
	{
		PinEntryCAL pinEntryCAL = new PinEntryCAL(_SharedCacheClient);
		pinEntryCAL.PinHashID = PinHashId;
		pinEntryCAL.AccountID = AccountId;
		pinEntryCAL.SessionString = SessionString;
		pinEntryCAL.Created = Created;
		pinEntryCAL.Save();
	}

	public void Delete()
	{
		PinEntryCAL.Get(AccountId, SessionString, _SharedCacheClient)?.Delete();
	}
}
