using System;
using Roblox.Platform.AccountPins.Entities;
using Roblox.Platform.AccountPins.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.AccountPins;

internal class PinEntry : IPinEntry
{
	private readonly AccountPinsDomainFactories _DomainFactories;

	internal virtual TimeSpan DefaultExpiration => Settings.Default.PinEntryExpiration;

	public long PinHashId { get; }

	public long AccountId { get; }

	private string SessionString { get; }

	public DateTime Created { get; }

	public DateTime UnlockedUntil => Created.Add(DefaultExpiration);

	public double SecondsUnlockedUntil => UnlockedUntil.Subtract(GetNow()).TotalSeconds;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.PinEntry" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <param name="entity">The entity.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// </exception>
	public PinEntry(AccountPinsDomainFactories domainFactories, IPinEntryEntity entity)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		_DomainFactories = domainFactories;
		PinHashId = entity.PinHashId;
		AccountId = entity.AccountId;
		SessionString = entity.SessionString;
		Created = entity.Created;
	}

	public void Delete()
	{
		(_DomainFactories.PinEntryEntityFactory.Get(AccountId, SessionString) ?? throw new PlatformDataIntegrityException("Cannot delete an un-persisted entry")).Delete();
	}

	internal virtual DateTime GetNow()
	{
		return DateTime.Now;
	}
}
