using System;
using Roblox.Caching.Shared;
using Roblox.Captcha.Entities;
using Roblox.Common;
using Roblox.Platform.Core;

namespace Roblox.Platform.Captcha;

internal class SuccessFactory : ISuccessFactory
{
	private readonly ISharedCacheClient _SharedCacheClient;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Captcha.SuccessFactory" /> class.
	/// </summary>
	/// <param name="sharedCacheClient"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="sharedCacheClient" /> is null.</exception>
	public SuccessFactory(ISharedCacheClient sharedCacheClient)
	{
		if (sharedCacheClient == null)
		{
			throw new PlatformArgumentNullException("sharedCacheClient");
		}
		_SharedCacheClient = sharedCacheClient;
	}

	public ISuccess Get(Identifier identifier, ActionType actionType, TimeSpan expiration)
	{
		if (identifier.Value == null)
		{
			throw new PlatformArgumentException("'Value' property of 'identifier' is null");
		}
		try
		{
			return Success.Get((byte)actionType, identifier.Serialize(), _SharedCacheClient, expiration);
		}
		catch (OperationUnavailableException e)
		{
			throw new PlatformOperationUnavailableException("Operation is not currently available", e);
		}
	}

	public ISuccess Create(TimeSpan expiration)
	{
		return new Success(_SharedCacheClient, expiration);
	}
}
