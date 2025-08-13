using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using Newtonsoft.Json;
using Roblox.ApiClientBase;
using Roblox.Caching.Shared;
using Roblox.Configuration;
using Roblox.GameInstances.Client;
using Roblox.Hashing;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Devices;
using Roblox.Platform.GameInstances.Properties;

namespace Roblox.Platform.GameInstances;

/// <summary>
/// The default implmentation of <see cref="T:Roblox.Platform.GameInstances.IGameInstanceFactory" />.
/// </summary>
public class GameInstanceFactory : IGameInstanceFactory
{
	private readonly GameInstancesClient _Client;

	private readonly IPlatformFactory _PlatformFactory;

	private readonly ISharedCacheClient _MemcachedClient;

	private static int[] _ExcludedMatchmakingContextIds;

	static GameInstanceFactory()
	{
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.ExcludedMatchmakingContextIdsCsv, delegate(string val)
		{
			int[] array = MultiValueSettingParser.TryParseCommaDelimitedListString(val, int.Parse).ToArray();
			if (array.Length == 0)
			{
				_ExcludedMatchmakingContextIds = null;
			}
			else
			{
				_ExcludedMatchmakingContextIds = array;
			}
		});
	}

	/// <summary>
	/// The default constructor for <see cref="T:Roblox.Platform.GameInstances.GameInstanceFactory" />.
	/// </summary>
	/// <param name="client"><see cref="T:Roblox.GameInstances.Client.GameInstancesClient" />.</param>
	/// <param name="platformFactory"><see cref="T:Roblox.Platform.Devices.IPlatformFactory" />.</param>
	public GameInstanceFactory(GameInstancesClient client, IPlatformFactory platformFactory)
	{
		_Client = client;
		_PlatformFactory = platformFactory;
		_MemcachedClient = SharedCacheWebClient.GetSingleton();
	}

	public IGameInstance GetGameInstance(long placeId, Guid gameInstanceId)
	{
		string key = "GameInstances:GetGameInstance:placeId:" + placeId + "gameInstanceId:" + gameInstanceId;
		return FetchItem(key, Settings.Default.CacheDuration, delegate
		{
			Game game = _Client.GetGame(placeId, gameInstanceId);
			return (game == null) ? null : new GameInstance(game);
		});
	}

	public ICollection<IGameInstance> GetGameInstancesByIds(long placeId, IEnumerable<Guid> gameInstanceIds)
	{
		Guid[] instanceIds = (gameInstanceIds as Guid[]) ?? gameInstanceIds.ToArray();
		string hashedGameInstanceIdsString = SHA256Hasher.BuildSHA256HashString(string.Join("|", instanceIds.OrderBy((Guid ids) => ids)));
		string key = $"GameInstances:GetGameInstancesByIds:placeId:{placeId}hashedGameInstanceIds:{hashedGameInstanceIdsString}";
		return FetchItem(key, Settings.Default.CacheDuration, () => Translate(_Client.GetGameInstancesByIds(placeId, instanceIds.ToArray())));
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.GameInstances.IGameInstanceFactory.GetGameInstanceIdentifiersByUniverse(System.Int64,System.Int32,System.Int32)" />
	/// </summary>
	public IEnumerable<IGameInstanceIdentifier> GetGameInstanceIdentifiersByUniverse(long universeId, int startRowIndex, int maximumRows)
	{
		return from gi in _Client.GetInstancesByUniverse(universeId, startRowIndex, maximumRows)
			select new GameInstanceIdentifier(gi);
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.GameInstances.IGameInstanceFactory.GetPaged(System.Int64,System.Int32,System.Int32)" />
	/// </summary>
	public ICollection<IGameInstance> GetPaged(long placeId, int startRowIndex, int maximumRows)
	{
		string key = "GameInstances:GetPaged:placeId:" + placeId + "startRowIndex:" + startRowIndex + "maximumRows:" + maximumRows;
		return FetchItem(key, Settings.Default.CacheDuration, () => Translate(_Client.GetByPlace(placeId, startRowIndex, maximumRows)));
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.GameInstances.IGameInstanceFactory.GetAllPaged(System.Int64,System.Int32,System.Int32)" />
	/// </summary>
	public ICollection<IGameInstance> GetAllPaged(long placeId, int startRowIndex, int maximumRows)
	{
		string key = "GameInstances:GetAllPaged:placeId:" + placeId + "startRowIndex:" + startRowIndex + "maximumRows:" + maximumRows;
		return FetchItem(key, Settings.Default.CacheDuration, () => Translate(_Client.GetAllByPlace(placeId, startRowIndex, maximumRows)));
	}

	public ICollection<IGameInstance> GetGameInstances(long placeId, bool includePrivateInstances, Guid[] gameCodes, int? matchmakingContextId, int startRowIndex, int maximumRows)
	{
		string gameCodesString = ((gameCodes != null) ? string.Join("|", gameCodes) : "null");
		string matchmakingContextString = (matchmakingContextId.HasValue ? matchmakingContextId.ToString() : "null");
		string key = "GameInstances:GetGameInstances:placeId:" + placeId + "includePrivateInstances:" + includePrivateInstances.ToString() + "gameCodes:" + gameCodesString + "matchmakingContextId:" + matchmakingContextString + "startRowIndex:" + startRowIndex + "maximumRows:" + maximumRows;
		return FetchItem(key, Settings.Default.CacheDuration, () => Translate(_Client.GetGameInstances(placeId, includePrivateInstances, gameCodes, matchmakingContextId, startRowIndex, maximumRows)));
	}

	public PlatformPageResponse<long, IGameInstance> GetGameInstances(long placeId, bool includePrivateInstances, Guid[] gameCodes, int? matchmakingContextId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		if (!exclusiveStartKeyInfo.TryGetExclusiveStartKey(out var startIndex))
		{
			startIndex = exclusiveStartKeyInfo.GetDefaultExclusiveStartId();
		}
		return new PlatformPageResponse<long, IGameInstance>(GetGameInstances(placeId, includePrivateInstances, gameCodes, matchmakingContextId, (int)startIndex, exclusiveStartKeyInfo.Count).ToArray(), exclusiveStartKeyInfo, (IGameInstance game) => game.PlaceId);
	}

	public int GetCount(long placeId)
	{
		string key = "GameInstances:GetCount:placeId:" + placeId;
		return FetchItem(key, Settings.Default.CacheDuration, (Func<int?>)(() => _Client.GetCount(placeId))).GetValueOrDefault();
	}

	public int GetPlayerCount(long placeId)
	{
		return GetPlaceSummary(placeId)?.PlayerCount ?? 0;
	}

	public int GetPlayerCount(long placeId, DeviceType deviceType)
	{
		IPlaceSummary placeSummary = GetPlaceSummary(placeId);
		if (placeSummary == null || placeSummary.PlayerCountByPlatformId == null)
		{
			return 0;
		}
		return GetPlayerCountByDeviceType(placeSummary.PlayerCountByPlatformId, deviceType);
	}

	public int GetUniversePlayerCount(long universeId)
	{
		return GetUniverseSummary(universeId)?.PlayerCount ?? 0;
	}

	public int GetUniversePlayerCount(long universeId, DeviceType deviceType)
	{
		IUniverseSummary universeSummary = GetUniverseSummary(universeId);
		if (universeSummary == null || universeSummary.PlayerCountByPlatformId == null)
		{
			return 0;
		}
		return GetPlayerCountByDeviceType(universeSummary.PlayerCountByPlatformId, deviceType);
	}

	private int GetPlayerCountByDeviceType(IDictionary<int, int> playerCountByPlatformId, DeviceType deviceType)
	{
		int count = 0;
		foreach (int platformId in playerCountByPlatformId.Keys)
		{
			DeviceType deviceTypeForPlatform = _PlatformFactory.GetById((byte)platformId)?.DeviceType ?? DeviceType.Computer;
			if (deviceType == deviceTypeForPlatform)
			{
				count += playerCountByPlatformId[platformId];
			}
		}
		return count;
	}

	public IPlaceSummary GetPlaceSummary(long placeId)
	{
		try
		{
			string key = "GameInstances:GetPlaceSummary:placeId:" + placeId;
			if (_ExcludedMatchmakingContextIds != null)
			{
				key = key + "excludedMatchmakingContextIds:" + string.Join(",", _ExcludedMatchmakingContextIds);
			}
			return FetchItem(key, Settings.Default.PlaceSummaryCacheDuration, () => new PlaceSummary(_Client.GetPlaceSummary(placeId, _ExcludedMatchmakingContextIds)));
		}
		catch (ApiClientException)
		{
			return null;
		}
	}

	public IUniverseSummary GetUniverseSummary(long universeId)
	{
		try
		{
			string key = "GameInstances:GetUniverseSummary:universeId:" + universeId;
			if (_ExcludedMatchmakingContextIds != null)
			{
				key = key + "excludedMatchmakingContextIds:" + string.Join(",", _ExcludedMatchmakingContextIds);
			}
			return FetchItem(key, Settings.Default.UniverseSummaryCacheDuration, () => new UniverseSummary(_Client.GetUniverseSummary(universeId, _ExcludedMatchmakingContextIds)));
		}
		catch (ApiClientException)
		{
			return null;
		}
	}

	public Dictionary<int, Dictionary<int, int>> GetUniversePlayerCountByCountryIdAndMappedPlatformId(long universeId, HashValuePair<Dictionary<int, int>> hashValuePairPlatformMappings)
	{
		try
		{
			Dictionary<int, int> platformMappings = null;
			string platformMappingsHashCode = null;
			hashValuePairPlatformMappings?.GetValueWithHashCode(out platformMappings, out platformMappingsHashCode);
			string key = $"GameInstances:GetUniversePlayerCountByCountryIdAndMappedPlatformId:uid:{universeId}:pm:{platformMappingsHashCode}";
			return FetchItem(key, Settings.Default.UniverseSummaryCacheDuration, () => _Client.GetUniversePlayerCountByCountryIdAndMappedPlatformId(universeId, platformMappings));
		}
		catch (ApiClientException)
		{
			return null;
		}
	}

	public ICollection<IGameInstance> GetAll()
	{
		return Translate(_Client.GetAll());
	}

	public IReadOnlyCollection<IGameInstance> GetByPlaceAndGameCodes(long placeId, IEnumerable<Guid> gameCodes)
	{
		List<Game> games = new List<Game>();
		List<Guid> lookupGameCodes = new List<Guid>();
		foreach (Guid code in gameCodes)
		{
			string key2 = "GameInstances:GetByPlaceAndGameCodes:gameCode:" + code;
			object cacheResult = HttpRuntime.Cache.Get(key2);
			if (cacheResult == null)
			{
				lookupGameCodes.Add(code);
			}
			else
			{
				games.Add((Game)cacheResult);
			}
		}
		if (lookupGameCodes.Count > 0)
		{
			IEnumerable<Game> byPlaceAndGameCodes = _Client.GetByPlaceAndGameCodes(placeId, lookupGameCodes);
			Dictionary<Guid, Game> gamesDictionary = new Dictionary<Guid, Game>();
			foreach (Game game2 in byPlaceAndGameCodes)
			{
				if (game2.GameCode.HasValue && (!gamesDictionary.TryGetValue(game2.GameCode.Value, out var existingGame) || existingGame.GameTime >= game2.GameTime))
				{
					gamesDictionary[game2.GameCode.Value] = game2;
				}
			}
			DateTime absoluteExpiration = DateTime.Now + Settings.Default.CacheDuration;
			foreach (Game game in gamesDictionary.Values)
			{
				games.Add(game);
				string key = "GameInstances:GetByPlaceAndGameCodes:gameCode:" + game.GameCode;
				HttpRuntime.Cache.Insert(key, game, null, absoluteExpiration, Cache.NoSlidingExpiration);
			}
		}
		return (IReadOnlyCollection<IGameInstance>)(object)Translate(games);
	}

	private static GameInstance[] Translate(IEnumerable<Game> allGames)
	{
		return allGames.Select((Game g) => new GameInstance(g)).ToArray();
	}

	private T FetchItem<T>(string key, TimeSpan cacheDuration, Func<T> getter)
	{
		T result = (T)HttpRuntime.Cache.Get(key);
		if (result != null)
		{
			return result;
		}
		bool useMemcached = Settings.Default.UseMemcachedForGameInstances;
		if (useMemcached && _MemcachedClient.Query(key, out var resultJson2))
		{
			result = JsonConvert.DeserializeObject<T>(resultJson2);
			AddToLocalCache(key, cacheDuration, result);
			return result;
		}
		result = getter();
		if (result != null)
		{
			AddToLocalCache(key, cacheDuration, result);
			if (useMemcached)
			{
				string resultJson = JsonConvert.SerializeObject(result);
				_MemcachedClient.Set(key, resultJson, cacheDuration);
			}
		}
		return result;
	}

	private static void AddToLocalCache(string key, TimeSpan cacheDuration, object item)
	{
		DateTime absoluteExpiration = DateTime.Now + cacheDuration;
		HttpRuntime.Cache.Insert(key, item, null, absoluteExpiration, Cache.NoSlidingExpiration);
	}
}
