using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Avatar;

/// Cache schema:
///
/// * EmoteConfiguration - HashSet, stores the information for each individual emote configuration
/// Key          Data type   Description
/// Id           long        The Id of the emote configuration
/// AssetId      long        The Id of the associated asset
/// UserId       long        The Id of the associated user
/// Position     byte        The position of the configuration on the user's emote wheel
/// CreatedTicks long        The ticks in the DateTime of the Created field for the emote configuration
/// UpdatedTicks long        The ticks in the DateTime of the Updated field for the emote configuration
///
/// * EmoteConfigurations - HashSet, stores the Ids of each emote configuration equipped for a given user, indexed by position
/// Key          Data type   Description
/// [1-8]        long        The Id of the emote configuration stored at the position indicated by the given key
/// 255          long        The sentinel record, used to record that even an empty configurations list is not a cache miss
///             <summary>
///             A Redis-backed caching solution for emote configurations
///             </summary>
internal class EmoteConfigurationRedisCache : IEmoteConfigurationCache
{
	private const string _IDHashEntryName = "Id";

	private const string _AssetIDHashEntryName = "AssetId";

	private const string _UserIDHashEntryName = "UserId";

	private const string _PositionHashEntryName = "Position";

	private const string _CreatedHashEntryName = "CreatedTicks";

	private const string _UpdatedHashEntryName = "UpdatedTicks";

	private const byte _SentinelHashEntryName = byte.MaxValue;

	private const long _SentinelHashEntryValue = -1L;

	private readonly IRedisClient _RedisClient;

	internal event Action OnEmoteConfigurationCacheHit;

	internal event Action OnEmoteConfigurationCacheMiss;

	internal event Action OnEmoteConfigurationsForUserIdCacheHit;

	internal event Action OnEmoteConfigurationsForUserIdCacheMiss;

	/// <summary>
	/// Creates a new instance of the emote configuration redis cache
	/// </summary>
	/// <param name="redisClient">The client to use to execute Redis actions</param>
	public EmoteConfigurationRedisCache(IRedisClient redisClient)
	{
		_RedisClient = redisClient ?? throw new PlatformArgumentNullException("redisClient");
	}

	/// <inheritdoc />
	public void ClearEmoteConfigurationsForUserId(long userId)
	{
		string emoteConfigurationsByUserIdRedisKey = GetEmoteConfigurationsByUserIdKey(userId);
		if (!_RedisClient.Execute(emoteConfigurationsByUserIdRedisKey, (IDatabase db) => db.KeyExists(emoteConfigurationsByUserIdRedisKey)))
		{
			return;
		}
		HashEntry[] array = _RedisClient.Execute(emoteConfigurationsByUserIdRedisKey, (IDatabase db) => db.HashGetAll(emoteConfigurationsByUserIdRedisKey));
		for (int i = 0; i < array.Length; i++)
		{
			HashEntry hashEntry = array[i];
			if (!(hashEntry.Name == 255))
			{
				long emoteConfigurationId = (long)hashEntry.Value;
				string emoteConfigurationByIdRedisKey = GetEmoteConfigurationKey(emoteConfigurationId);
				_RedisClient.Execute(emoteConfigurationByIdRedisKey, (IDatabase db) => db.KeyDelete(emoteConfigurationByIdRedisKey));
			}
		}
		_RedisClient.Execute(emoteConfigurationsByUserIdRedisKey, (IDatabase db) => db.KeyDelete(emoteConfigurationsByUserIdRedisKey));
	}

	/// <inheritdoc />
	public void DeleteEmoteConfigurationByUserIdAndPosition(long userId, byte position)
	{
		string emoteConfigurationsByUserIdRedisKey = GetEmoteConfigurationsByUserIdKey(userId);
		RedisValue redisValue = _RedisClient.Execute(emoteConfigurationsByUserIdRedisKey, (IDatabase db) => db.HashGet(emoteConfigurationsByUserIdRedisKey, position));
		if (!(redisValue == RedisValue.Null))
		{
			_RedisClient.Execute(emoteConfigurationsByUserIdRedisKey, (IDatabase db) => db.HashDelete(emoteConfigurationsByUserIdRedisKey, position));
			long id = (long)redisValue;
			string emoteConfigurationByIdRedisKey = GetEmoteConfigurationKey(id);
			_RedisClient.Execute(emoteConfigurationByIdRedisKey, (IDatabase db) => db.KeyDelete(emoteConfigurationByIdRedisKey));
		}
	}

	/// <inheritdoc />
	public IEmoteConfigurationEntity GetEmoteConfiguration(long id, Func<long, IEmoteConfigurationEntity> emoteConfigurationGetter)
	{
		string redisKey = GetEmoteConfigurationKey(id);
		HashEntry[] hashEntries = _RedisClient.Execute(redisKey, (IDatabase db) => db.HashGetAll(redisKey));
		Dictionary<RedisValue, RedisValue> dictionary = hashEntries.ToDictionary();
		if (IsHashEntriesDictionaryValid(dictionary))
		{
			this.OnEmoteConfigurationCacheHit?.Invoke();
		}
		else
		{
			this.OnEmoteConfigurationCacheMiss?.Invoke();
			IEmoteConfigurationEntity entity = emoteConfigurationGetter(id);
			if (entity == null)
			{
				return null;
			}
			hashEntries = GetHashEntriesForEmoteConfiguration(entity);
			dictionary = hashEntries.ToDictionary();
			_RedisClient.Execute(redisKey, delegate(IDatabase db)
			{
				db.HashSet(redisKey, hashEntries);
			});
		}
		return FromRedisValuesDictionary(dictionary);
	}

	/// <inheritdoc />
	public IEmoteConfigurationEntity GetEmoteConfigurationByUserIdAndPosition(long userId, byte position, Func<long, ICollection<IEmoteConfigurationEntity>> emoteConfigurationsGetter, Func<long, IEmoteConfigurationEntity> emoteConfigurationGetter)
	{
		string redisKey = GetEmoteConfigurationsByUserIdKey(userId);
		RedisValue redisValue = _RedisClient.Execute(redisKey, (IDatabase db) => db.HashGet(redisKey, position));
		if (redisValue == RedisValue.Null)
		{
			return GetEmoteConfigurationsByUserId(userId, emoteConfigurationsGetter, emoteConfigurationGetter).FirstOrDefault((IEmoteConfigurationEntity x) => x.Position == position);
		}
		return GetEmoteConfiguration((long)redisValue, emoteConfigurationGetter);
	}

	/// <inheritdoc />
	public ICollection<IEmoteConfigurationEntity> GetEmoteConfigurationsByUserId(long userId, Func<long, ICollection<IEmoteConfigurationEntity>> emoteConfigurationsGetter, Func<long, IEmoteConfigurationEntity> emoteConfigurationGetter)
	{
		string redisKey = GetEmoteConfigurationsByUserIdKey(userId);
		HashEntry[] hashEntries = _RedisClient.Execute(redisKey, (IDatabase db) => db.HashGetAll(redisKey));
		ICollection<IEmoteConfigurationEntity> emoteConfigurations = new List<IEmoteConfigurationEntity>();
		if (hashEntries.Any())
		{
			this.OnEmoteConfigurationsForUserIdCacheHit?.Invoke();
			HashEntry[] array = hashEntries;
			for (int i = 0; i < array.Length; i++)
			{
				HashEntry hashEntry = array[i];
				if ((int)hashEntry.Name != 255)
				{
					long entryValue = (long)hashEntry.Value;
					IEmoteConfigurationEntity cachedEntity = GetEmoteConfiguration(entryValue, emoteConfigurationGetter);
					if (cachedEntity != null)
					{
						emoteConfigurations.Add(cachedEntity);
					}
				}
			}
		}
		else
		{
			this.OnEmoteConfigurationsForUserIdCacheMiss?.Invoke();
			emoteConfigurations = emoteConfigurationsGetter(userId);
			if (emoteConfigurations == null)
			{
				return new List<IEmoteConfigurationEntity>();
			}
			HashEntry[] newHashEntries = GetHashEntriesForEmoteConfigurationsList((IReadOnlyCollection<IEmoteConfigurationEntity>)emoteConfigurations);
			_RedisClient.Execute(redisKey, delegate(IDatabase db)
			{
				db.HashSet(redisKey, newHashEntries);
			});
		}
		return emoteConfigurations;
	}

	/// <inheritdoc />
	public void SetEmoteConfiguration(IEmoteConfigurationEntity emoteConfiguration)
	{
		if (emoteConfiguration == null)
		{
			throw new PlatformArgumentNullException("emoteConfiguration");
		}
		string emoteConfigurationByIdRedisKey = GetEmoteConfigurationKey(emoteConfiguration.Id);
		HashEntry[] hashEntries = GetHashEntriesForEmoteConfiguration(emoteConfiguration);
		_RedisClient.Execute(emoteConfigurationByIdRedisKey, delegate(IDatabase db)
		{
			db.HashSet(emoteConfigurationByIdRedisKey, hashEntries);
		});
		string emoteConfigurationsByUserIdRedisKey = GetEmoteConfigurationsByUserIdKey(emoteConfiguration.UserId);
		if (_RedisClient.Execute(emoteConfigurationsByUserIdRedisKey, (IDatabase db) => db.KeyExists(emoteConfigurationsByUserIdRedisKey)))
		{
			_RedisClient.Execute(emoteConfigurationsByUserIdRedisKey, (IDatabase db) => db.HashSet(emoteConfigurationsByUserIdRedisKey, emoteConfiguration.Position, emoteConfiguration.Id));
		}
	}

	/// <inheritdoc />
	public void SetEmoteConfigurationsForUserId(long userId, IReadOnlyCollection<IEmoteConfigurationEntity> emoteConfigurations)
	{
		if (emoteConfigurations == null)
		{
			throw new PlatformArgumentNullException("emoteConfigurations");
		}
		string redisKey = GetEmoteConfigurationsByUserIdKey(userId);
		HashEntry[] newHashEntries = GetHashEntriesForEmoteConfigurationsList(emoteConfigurations);
		_RedisClient.Execute(redisKey, delegate(IDatabase db)
		{
			db.HashSet(redisKey, newHashEntries);
		});
		foreach (IEmoteConfigurationEntity emoteConfiguration in emoteConfigurations)
		{
			SetEmoteConfiguration(emoteConfiguration);
		}
	}

	private IEmoteConfigurationEntity FromRedisValuesDictionary(IReadOnlyDictionary<RedisValue, RedisValue> dictionary)
	{
		if (!IsHashEntriesDictionaryValid(dictionary))
		{
			return null;
		}
		long id = (long)dictionary["Id"];
		long assetId = (long)dictionary["AssetId"];
		long userId = (long)dictionary["UserId"];
		byte position = (byte)(int)dictionary["Position"];
		DateTime createdUtc = new DateTime((long)dictionary["CreatedTicks"], DateTimeKind.Utc);
		DateTime updatedUtc = new DateTime((long)dictionary["UpdatedTicks"], DateTimeKind.Utc);
		return new EmoteConfigurationCachedMssqlEntity
		{
			Id = id,
			AssetId = assetId,
			UserId = userId,
			Position = position,
			Created = createdUtc,
			Updated = updatedUtc
		};
	}

	private bool IsHashEntriesDictionaryValid(IReadOnlyDictionary<RedisValue, RedisValue> dictionary)
	{
		if (dictionary == null)
		{
			return false;
		}
		if (dictionary.ContainsKey("Id") && dictionary.ContainsKey("AssetId") && dictionary.ContainsKey("UserId") && dictionary.ContainsKey("Position") && dictionary.ContainsKey("CreatedTicks"))
		{
			return dictionary.ContainsKey("UpdatedTicks");
		}
		return false;
	}

	private HashEntry[] GetHashEntriesForEmoteConfiguration(IEmoteConfigurationEntity entity)
	{
		if (entity == null)
		{
			return null;
		}
		return new HashEntry[6]
		{
			new HashEntry("Id", entity.Id),
			new HashEntry("AssetId", entity.AssetId),
			new HashEntry("UserId", entity.UserId),
			new HashEntry("Position", entity.Position),
			new HashEntry("CreatedTicks", entity.Created.Ticks),
			new HashEntry("UpdatedTicks", entity.Updated.Ticks)
		};
	}

	private HashEntry[] GetHashEntriesForEmoteConfigurationsList(IReadOnlyCollection<IEmoteConfigurationEntity> cachedEntities)
	{
		List<HashEntry> hashEntries = new List<HashEntry>(new HashEntry[1]
		{
			new HashEntry(255, -1L)
		});
		if (cachedEntities == null)
		{
			return hashEntries.ToArray();
		}
		foreach (IEmoteConfigurationEntity cachedEntity in cachedEntities)
		{
			if (cachedEntity != null)
			{
				hashEntries.Add(new HashEntry(cachedEntity.Position, cachedEntity.Id));
			}
		}
		return hashEntries.ToArray();
	}

	private string GetEmoteConfigurationKey(long id)
	{
		return $"EmoteConfiguration_Id:{id}";
	}

	private string GetEmoteConfigurationsByUserIdKey(long userId)
	{
		return $"EmoteConfigurations_UserId:{userId}";
	}
}
