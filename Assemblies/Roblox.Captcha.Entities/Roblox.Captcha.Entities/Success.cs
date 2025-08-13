using System;
using Roblox.Caching.Shared;
using Roblox.Common;

namespace Roblox.Captcha.Entities;

[Serializable]
internal class Success : ISuccess
{
	[NonSerialized]
	private readonly ISharedCacheClient _SharedCacheClient;

	[NonSerialized]
	private readonly TimeSpan _Expiration;

	public byte ActionTypeId { get; set; }

	public string Identifier { get; set; }

	public DateTime TimeStamp { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Captcha.Entities.Success" /> class.
	/// </summary>
	/// <param name="sharedCacheClient">The <see cref="T:Roblox.Caching.Shared.SharedCacheClient" /> to use to save and delete the <see cref="T:Roblox.Captcha.Entities.Success" />.</param>
	/// <param name="expiration">The time until the entity expires in the cache.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="sharedCacheClient" /> is null.</exception>
	public Success(ISharedCacheClient sharedCacheClient, TimeSpan expiration)
	{
		_SharedCacheClient = sharedCacheClient ?? throw new ArgumentNullException("sharedCacheClient");
		_Expiration = expiration;
	}

	public void Save()
	{
		if (Identifier == null)
		{
			throw new InvalidOperationException("'Identifier' cannot be null");
		}
		try
		{
			string key = GetKey(ActionTypeId, Identifier);
			if (!_SharedCacheClient.Set(key, this, _Expiration))
			{
				throw new OperationUnavailableException("Failed to set value in shared cache");
			}
		}
		catch (ArgumentException e2)
		{
			throw new InvalidOperationException("Could not save the Success in its current state", e2);
		}
		catch (Exception e)
		{
			throw new OperationUnavailableException("Failed to set the value in shared cache", e);
		}
	}

	public void Delete()
	{
		if (Identifier == null)
		{
			return;
		}
		try
		{
			_SharedCacheClient.Delete(GetKey(ActionTypeId, Identifier));
		}
		catch (ArgumentException)
		{
		}
		catch (Exception e)
		{
			throw new OperationUnavailableException("Failed to delete value in shared cache", e);
		}
	}

	/// <summary>
	/// Gets the key that identifies the <see cref="T:Roblox.Captcha.Entities.Success" /> in the shared cache with the given values.
	/// </summary>
	/// <param name="actionTypeId"></param>
	/// <param name="identifier"></param>
	/// <returns>The key identifying the <see cref="T:Roblox.Captcha.Entities.Success" /> in the shared cache.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="identifier" /> is null.</exception>
	private static string GetKey(byte actionTypeId, string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		return $"Roblox.Captcha.Entities.Success_ActionTypeID:{actionTypeId}_Identifier:{identifier}";
	}

	/// <summary>
	/// Gets a <see cref="T:Roblox.Captcha.Entities.Success" /> by its action type ID and identifier.
	/// </summary>
	/// <param name="actionTypeId">The ID of the action type that was successfully passed.</param>
	/// <param name="identifier">A string that identifies the target that passed captcha.</param>
	/// <param name="sharedCacheClient">The <see cref="T:Roblox.Caching.Shared.ISharedCacheClient" /> to use to get the data.</param>
	/// <param name="expiration">The time until the entity expires in the cache.</param>
	/// <returns>The <see cref="T:Roblox.Captcha.Entities.Success" /> with the given action type ID and identifier.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="identifier" /> or <paramref name="sharedCacheClient" /> is null.</exception>
	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Thrown if the operation is not currently available.</exception>
	public static Success Get(byte actionTypeId, string identifier, ISharedCacheClient sharedCacheClient, TimeSpan expiration)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (sharedCacheClient == null)
		{
			throw new ArgumentNullException("sharedCacheClient");
		}
		try
		{
			string key = GetKey(actionTypeId, identifier);
			sharedCacheClient.Query(key, out Success value);
			return (value == null) ? null : new Success(sharedCacheClient, expiration)
			{
				ActionTypeId = value.ActionTypeId,
				Identifier = value.Identifier,
				TimeStamp = value.TimeStamp
			};
		}
		catch (ArgumentException)
		{
			return null;
		}
		catch (Exception e)
		{
			throw new OperationUnavailableException("Could not get a success at this time", e);
		}
	}
}
