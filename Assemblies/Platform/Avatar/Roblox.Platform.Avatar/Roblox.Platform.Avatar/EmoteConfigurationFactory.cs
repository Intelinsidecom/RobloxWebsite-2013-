using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Locking;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

public class EmoteConfigurationFactory : IEmoteConfigurationFactory
{
	private readonly AvatarDomainFactories _AvatarDomainFactories;

	private readonly IRedisLeasedLockFactory _RedisLeasedLockFactory;

	public EmoteConfigurationFactory(AvatarDomainFactories avatarDomainFactories, IRedisLeasedLockFactory redisLeasedLockFactory)
	{
		_AvatarDomainFactories = avatarDomainFactories ?? throw new PlatformArgumentNullException("avatarDomainFactories");
		_RedisLeasedLockFactory = redisLeasedLockFactory ?? throw new PlatformArgumentNullException("redisLeasedLockFactory");
	}

	/// <inheritdoc />
	public void SetEmoteConfiguration(long userId, long assetId, byte position)
	{
		if (IsLockingProtocolEnabledForUser(userId))
		{
			ExecuteLockingWriteProtocol(userId, delegate
			{
				_AvatarDomainFactories.EmoteConfigurationEntityFactory.CreateOrUpdate(userId, assetId, position);
			});
			return;
		}
		IEmoteConfigurationEntity emoteConfiguration = _AvatarDomainFactories.EmoteConfigurationEntityFactory.CreateOrUpdate(userId, assetId, position);
		if (IsEmotesRedisCacheWritingEnabledForUser(userId))
		{
			TrySetEmoteConfigurationInRedisCache(emoteConfiguration);
		}
		else
		{
			TryClearEmoteConfigurationsRedisCacheForUserId(userId);
		}
	}

	/// <inheritdoc />
	public IEnumerable<Tuple<long, byte>> SetEmoteConfigurations(long userId, IEnumerable<Tuple<long, byte>> emotes)
	{
		if (IsLockingProtocolEnabledForUser(userId))
		{
			List<Tuple<long, byte>> invalidEmotes2 = new List<Tuple<long, byte>>();
			ExecuteLockingWriteProtocol(userId, delegate
			{
				foreach (Tuple<long, byte> current in emotes)
				{
					long item = current.Item1;
					byte item2 = current.Item2;
					if (_AvatarDomainFactories.AssetOwnershipAuthority.GetUserAssets(userId, item)?.FirstOrDefault() == null)
					{
						invalidEmotes2.Add(current);
					}
					else
					{
						_AvatarDomainFactories.EmoteConfigurationEntityFactory.CreateOrUpdate(userId, item, item2);
					}
				}
			});
			return invalidEmotes2;
		}
		bool isEmotesRedisCacheWritingEnabledForUser = IsEmotesRedisCacheWritingEnabledForUser(userId);
		List<Tuple<long, byte>> invalidEmotes = new List<Tuple<long, byte>>();
		foreach (Tuple<long, byte> emote in emotes)
		{
			long assetId = emote.Item1;
			byte position = emote.Item2;
			List<IEmoteConfigurationEntity> validEmoteConfigurations = new List<IEmoteConfigurationEntity>();
			if (_AvatarDomainFactories.AssetOwnershipAuthority.GetUserAssets(userId, assetId)?.FirstOrDefault() == null)
			{
				invalidEmotes.Add(emote);
			}
			else
			{
				IEmoteConfigurationEntity emoteConfiguration = _AvatarDomainFactories.EmoteConfigurationEntityFactory.CreateOrUpdate(userId, assetId, position);
				if (isEmotesRedisCacheWritingEnabledForUser)
				{
					TrySetEmoteConfigurationInRedisCache(emoteConfiguration);
				}
				validEmoteConfigurations.Add(emoteConfiguration);
			}
			if (isEmotesRedisCacheWritingEnabledForUser)
			{
				TrySetEmoteConfigurationsInRedisCacheForUserId(userId, validEmoteConfigurations);
			}
		}
		if (!isEmotesRedisCacheWritingEnabledForUser)
		{
			TryClearEmoteConfigurationsRedisCacheForUserId(userId);
		}
		return invalidEmotes;
	}

	/// <inheritdoc />
	public void DeleteEmoteConfiguration(long userId, byte position)
	{
		if (IsLockingProtocolEnabledForUser(userId))
		{
			ExecuteLockingWriteProtocol(userId, delegate
			{
				_AvatarDomainFactories.EmoteConfigurationEntityFactory.Delete(userId, position);
			});
		}
		else if (IsEmotesRedisCacheWritingEnabledForUser(userId))
		{
			TryDeleteEmoteConfigurationInRedisCacheByUserIdAndPosition(userId, position);
		}
		else
		{
			TryClearEmoteConfigurationsRedisCacheForUserId(userId);
		}
	}

	/// <inheritdoc />
	public void DeleteEmoteConfigurations(long userId, IEnumerable<byte> positions)
	{
		if (IsLockingProtocolEnabledForUser(userId))
		{
			ExecuteLockingWriteProtocol(userId, delegate
			{
				foreach (byte current in positions)
				{
					_AvatarDomainFactories.EmoteConfigurationEntityFactory.Delete(userId, current);
				}
			});
			return;
		}
		bool isEmotesRedisCacheWritingEnabledForUser = IsEmotesRedisCacheWritingEnabledForUser(userId);
		foreach (byte position in positions)
		{
			_AvatarDomainFactories.EmoteConfigurationEntityFactory.Delete(userId, position);
			if (isEmotesRedisCacheWritingEnabledForUser)
			{
				TryDeleteEmoteConfigurationInRedisCacheByUserIdAndPosition(userId, position);
			}
		}
		if (!isEmotesRedisCacheWritingEnabledForUser)
		{
			TryClearEmoteConfigurationsRedisCacheForUserId(userId);
		}
	}

	/// <inheritdoc />
	public List<EmoteConfiguration> GetAllEmoteConfigurations(long userId)
	{
		return (IsEmotesRedisCacheReadingEnabledForUser(userId) ? TryGetEmoteConfigurationsFromRedisCacheByUserId(userId) : EmoteConfigurationsGetter(userId)).Select((IEmoteConfigurationEntity emoteConfiguration) => new EmoteConfiguration(emoteConfiguration)).ToList();
	}

	private bool IsEmotesRedisCacheReadingEnabledForUser(long userId)
	{
		return userId % 100 < Settings.Default.IsEmotesRedisCacheReadingEnabledRolloutPercentage;
	}

	private bool IsEmotesRedisCacheWritingEnabledForUser(long userId)
	{
		return userId % 100 < Settings.Default.IsEmotesRedisCacheWritingEnabledRolloutPercentage;
	}

	private string GenerateLockKey(long userId)
	{
		return $"EmoteConfigurationsWritingLock_UserId:{userId}";
	}

	private bool IsLockingProtocolEnabledForUser(long userId)
	{
		return userId % 100 < Settings.Default.IsEmoteConfigurationsRedisLockingEnabledRolloutPercentage;
	}

	/// <summary>
	/// Tries to execute a write action through this protocol:
	/// 1. Take distributed lock
	/// 2. Clear cache
	/// 3. Write to database
	/// 4. Write to cache
	/// 5. Release distributed lock
	/// If any step 1-3 fails, then the method will throw
	/// </summary>
	/// <param name="userId">The user Id to take the lock with respect to</param>
	/// <param name="dbWriteAction">A delegate action to perform to write to the database. If this action throws, so will this method.</param>
	private void ExecuteLockingWriteProtocol(long userId, Action dbWriteAction)
	{
		string lockKey = GenerateLockKey(userId);
		using IRedisLeasedLock leasedLock = _RedisLeasedLockFactory.CreateLeasedLock(lockKey, Settings.Default.EmoteConfigurationsLockDuration);
		if (!leasedLock.TryAcquire())
		{
			throw new LeasedLockException($"Could not acquire lock with key {lockKey}");
		}
		try
		{
			if (Settings.Default.IsEmotesRedisCacheClearingEnabled)
			{
				_AvatarDomainFactories.EmoteConfigurationRedisCache.ClearEmoteConfigurationsForUserId(userId);
			}
			dbWriteAction();
			if (!IsEmotesRedisCacheWritingEnabledForUser(userId))
			{
				return;
			}
			try
			{
				ICollection<IEmoteConfigurationEntity> emoteConfigurations = EmoteConfigurationsGetter(userId);
				foreach (IEmoteConfigurationEntity emoteConfiguration in emoteConfigurations)
				{
					_AvatarDomainFactories.EmoteConfigurationRedisCache.SetEmoteConfiguration(emoteConfiguration);
				}
				_AvatarDomainFactories.EmoteConfigurationRedisCache.SetEmoteConfigurationsForUserId(userId, emoteConfigurations.ToList());
			}
			catch (Exception ex2)
			{
				_AvatarDomainFactories.Logger.Error(ex2);
			}
		}
		catch (Exception ex)
		{
			_AvatarDomainFactories.Logger.Error(ex);
			throw new PlatformException("Failed to perform write operation for emote configurations");
		}
	}

	private IEmoteConfigurationEntity EmoteConfigurationGetter(long id)
	{
		return _AvatarDomainFactories.EmoteConfigurationEntityFactory.Get(id);
	}

	private ICollection<IEmoteConfigurationEntity> EmoteConfigurationsGetter(long userId)
	{
		byte maxSlots = Settings.Default.EmoteConfigurationMaximumSlots;
		return _AvatarDomainFactories.EmoteConfigurationEntityFactory.GetByUserIdEnumerative(userId, maxSlots);
	}

	private void TryClearEmoteConfigurationsRedisCacheForUserId(long userId)
	{
		if (!Settings.Default.IsEmotesRedisCacheClearingEnabled)
		{
			return;
		}
		try
		{
			_AvatarDomainFactories.EmoteConfigurationRedisCache.ClearEmoteConfigurationsForUserId(userId);
		}
		catch (Exception ex)
		{
			_AvatarDomainFactories.Logger.Error(ex);
		}
	}

	private void TrySetEmoteConfigurationInRedisCache(IEmoteConfigurationEntity emoteConfiguration)
	{
		try
		{
			_AvatarDomainFactories.EmoteConfigurationRedisCache.SetEmoteConfiguration(emoteConfiguration);
		}
		catch (Exception ex)
		{
			_AvatarDomainFactories.Logger.Error(ex);
		}
	}

	private void TrySetEmoteConfigurationsInRedisCacheForUserId(long userId, IReadOnlyCollection<IEmoteConfigurationEntity> emoteConfigurations)
	{
		try
		{
			_AvatarDomainFactories.EmoteConfigurationRedisCache.SetEmoteConfigurationsForUserId(userId, emoteConfigurations);
		}
		catch (Exception ex)
		{
			_AvatarDomainFactories.Logger.Error(ex);
		}
	}

	private void TryDeleteEmoteConfigurationInRedisCacheByUserIdAndPosition(long userId, byte position)
	{
		try
		{
			_AvatarDomainFactories.EmoteConfigurationRedisCache.DeleteEmoteConfigurationByUserIdAndPosition(userId, position);
		}
		catch (Exception ex)
		{
			_AvatarDomainFactories.Logger.Error(ex);
		}
	}

	private ICollection<IEmoteConfigurationEntity> TryGetEmoteConfigurationsFromRedisCacheByUserId(long userId)
	{
		try
		{
			return _AvatarDomainFactories.EmoteConfigurationRedisCache.GetEmoteConfigurationsByUserId(userId, EmoteConfigurationsGetter, EmoteConfigurationGetter);
		}
		catch (Exception ex)
		{
			_AvatarDomainFactories.Logger.Error(ex);
			return EmoteConfigurationsGetter(userId);
		}
	}
}
