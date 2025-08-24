using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ProtoBuf;
using Roblox.ApiClientBase;
using Roblox.Configuration;
using Roblox.GameInstances.Client.Properties;
using Roblox.GameInstances.Interfaces;
using Roblox.Http;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;

namespace Roblox.GameInstances.Client;

public class GameInstancesClient : GuardedApiClientBase
{
	private const string _ProtobufContentType = "application/vnd.google.protobuf";

	private readonly IHttpClient _HttpClient;

	private readonly IHttpRequestBuilder _HttpRequestBuilder;

	private readonly Func<string> _ServiceUrlGetter;

	private readonly Func<TimeSpan> _TimeoutGetter;

	private readonly Func<string> _ApiKeyGetter;

	public override string Name => "GameInstancesClient";

	protected override string ApiKey => _ApiKeyGetter();

	protected override string Endpoint => _ServiceUrlGetter();

	protected override TimeSpan Timeout => _TimeoutGetter();

	public GameInstancesClient(Func<string> apiKeyGetter)
		: this(apiKeyGetter, () => RobloxEnvironment.GetApiEndpoint("gameinstances"))
	{
	}

	public GameInstancesClient(Func<string> apiKeyGetter, Func<string> serviceUrlGetter)
		: this(apiKeyGetter, serviceUrlGetter, () => Settings.Default.GameInstancesServiceTimeout)
	{
	}

	public GameInstancesClient(Func<string> apiKeyGetter, Func<string> serviceUrlGetter, Func<TimeSpan> timeoutGetter)
	{
		_ServiceUrlGetter = serviceUrlGetter;
		_TimeoutGetter = timeoutGetter;
		_ApiKeyGetter = apiKeyGetter;
		GameInstancesClientSettings gameInstancesClientSettings = new GameInstancesClientSettings(serviceUrlGetter);
		Roblox.Http.ServiceClient.HttpClientBuilder httpClientBuilder = new Roblox.Http.ServiceClient.HttpClientBuilder(gameInstancesClientSettings, StaticCounterRegistry.Instance, apiKeyGetter);
		_HttpClient = httpClientBuilder.Build();
		_HttpRequestBuilder = new HttpRequestBuilder(gameInstancesClientSettings.Endpoint);
	}

	public IEnumerable<Game> GetAll()
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("includePlaySessions", false)
		};
		return Get<Game[]>("/v1/GetAll", queryStringParameters);
	}

	public int GetPartitionCount()
	{
		return Get<int>("/v1/GetPartitionCount");
	}

	public IEnumerable<Game> GetAllByPartition(int partition, bool includePlaySessions, bool useProtobuf = false)
	{
		if (useProtobuf)
		{
			(string, string)[] queryParams = new(string, string)[2]
			{
				("partition", partition.ToString()),
				("includePlaySessions", includePlaySessions.ToString())
			};
			return GetProtobuf<GameCollectionPayload>("/v1/GetAllByPartition", queryParams).Data;
		}
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("partition", partition),
			new KeyValuePair<string, object>("includePlaySessions", includePlaySessions)
		};
		return Get<Game[]>("/v1/GetAllByPartition", queryStringParameters);
	}

	public IEnumerable<Game> GetByPlace(long placeId, int startRowIndex, int maximumRows)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[4]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("startRowIndex", startRowIndex),
			new KeyValuePair<string, object>("maximumRows", maximumRows),
			new KeyValuePair<string, object>("includePlaySessions", false)
		};
		return Get<Game[]>("/v1/GetByPlace", queryStringParameters);
	}

	public Game GetGame(long placeId, Guid gameId, bool includePlaySessions = false)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("gameId", gameId),
			new KeyValuePair<string, object>("includePlaySessions", includePlaySessions)
		};
		return Get<Game>("/v1/GetGame", queryStringParameters);
	}

	public IEnumerable<Game> GetGameInstancesByIds(long placeId, IEnumerable<Guid> gameInstanceIds)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("includePlaySessions", false)
		};
		var postObject = new
		{
			GameInstanceIds = gameInstanceIds.ToArray()
		};
		return PostObjectJson<Game[]>("/v1/GetGameInstancesByIds", postObject, queryStringParameters);
	}

	public IEnumerable<Game> GetAllByPlace(long placeId, int startRowIndex, int maximumRows, bool includePlaySessions = false)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[4]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("startRowIndex", startRowIndex),
			new KeyValuePair<string, object>("maximumRows", maximumRows),
			new KeyValuePair<string, object>("includePlaySessions", includePlaySessions)
		};
		return Get<Game[]>("/v1/GetAllByPlace", queryStringParameters);
	}

	public IEnumerable<GameIdentifier> GetInstancesByUniverse(long universeId, int startRowIndex, int maximumRows)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("universeId", universeId),
			new KeyValuePair<string, object>("startRowIndex", startRowIndex),
			new KeyValuePair<string, object>("maximumRows", maximumRows)
		};
		return Get<GameIdentifier[]>("/v1/GetInstancesByUniverse", queryStringParameters);
	}

	public IEnumerable<Game> GetByPlaceAndGameCodes(long placeId, IEnumerable<Guid> gameCodes)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("gameCodes", gameCodes),
			new KeyValuePair<string, object>("includePlaySessions", false)
		};
		return Get<Game[]>("/v1/GetByPlaceAndGameCodes", queryStringParameters);
	}

	public IEnumerable<Game> GetGameInstances(long placeId, bool includePrivateInstances, Guid[] gameCodes, int? matchmakingContextId, int startRowIndex, int maximumRows)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>(new KeyValuePair<string, object>[6]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("includePrivateInstances", includePrivateInstances),
			new KeyValuePair<string, object>("matchmakingContextId", matchmakingContextId),
			new KeyValuePair<string, object>("startRowIndex", startRowIndex),
			new KeyValuePair<string, object>("maximumRows", maximumRows),
			new KeyValuePair<string, object>("includePlaySessions", false)
		});
		if (gameCodes != null && gameCodes.Length != 0)
		{
			list.Add(new KeyValuePair<string, object>("gameCodes", gameCodes));
		}
		return Get<Game[]>("/v1/GetGameInstances", list);
	}

	public int GetCount(long placeId)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("placeId", placeId)
		};
		return Get<int>("/v1/GetCount", queryStringParameters);
	}

	public PlaceSummary GetPlaceSummary(long placeId, int[] excludedMatchmakingContextIds, bool? useCache = null, bool? dedupePlayers = null)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>(new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("placeId", placeId)
		});
		if (excludedMatchmakingContextIds != null && excludedMatchmakingContextIds.Length != 0)
		{
			list.Add(new KeyValuePair<string, object>("excludedMatchmakingContextIds", excludedMatchmakingContextIds));
			if (useCache.HasValue)
			{
				list.Add(new KeyValuePair<string, object>("useCache", useCache));
			}
			if (dedupePlayers.HasValue)
			{
				list.Add(new KeyValuePair<string, object>("dedupePlayers", dedupePlayers));
			}
		}
		return Get<PlaceSummary>("/v1/GetPlaceSummary", list);
	}

	public UniverseSummary GetUniverseSummary(long universeId, int[] excludedMatchmakingContextIds, bool? useCache = null, bool? dedupePlayers = null)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>(new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("universeId", universeId)
		});
		if (excludedMatchmakingContextIds != null && excludedMatchmakingContextIds.Length != 0)
		{
			list.Add(new KeyValuePair<string, object>("excludedMatchmakingContextIds", excludedMatchmakingContextIds));
			if (useCache.HasValue)
			{
				list.Add(new KeyValuePair<string, object>("useCache", useCache));
			}
			if (dedupePlayers.HasValue)
			{
				list.Add(new KeyValuePair<string, object>("dedupePlayers", dedupePlayers));
			}
		}
		return Get<UniverseSummary>("/v1/GetUniverseSummary", list);
	}

	public Dictionary<int, Dictionary<int, int>> GetUniversePlayerCountByCountryIdAndMappedPlatformId(long universeId, Dictionary<int, int> platformMappings)
	{
		GetUniversePlayerCountByCountryIdAndMappedPlatformIdRequestModel postObject = new GetUniversePlayerCountByCountryIdAndMappedPlatformIdRequestModel
		{
			UniverseId = universeId,
			PlatformMappings = platformMappings
		};
		return PostObjectJson<Dictionary<int, Dictionary<int, int>>>("/v1/GetUniversePlayerCountByCountryIdAndMappedPlatformId", postObject);
	}

	public IReadOnlyCollection<CustomPlayerCountResult> GetCustomPlayerCountsByCustomKey(GetCustomPlayerCountsByCustomKeyRequestModel model)
	{
		return PostObjectJson<IReadOnlyCollection<CustomPlayerCountResult>>("/v1/GetCustomPlayerCountsByCustomKey", model);
	}

	public bool VerifyPlaySession(long placeId, Guid gameId, long playerId, Guid sessionId)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[4]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("gameId", gameId),
			new KeyValuePair<string, object>("playerId", playerId),
			new KeyValuePair<string, object>("sessionId", sessionId)
		};
		return Get<bool>("/v1/VerifyPlaySession", queryStringParameters);
	}

	public PlaySession StartPlaySession(long universeId, long placeId, Guid gameId, long playerId, Guid sessionId, string ipAddress, int platformId, long browserTrackerId, Guid? partyId, double? age, double? latitude, double? longitude, int? countryId, int? policyCountryId, string joinType, PlaySessionFlags playSessionFlags)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[16]
		{
			new KeyValuePair<string, object>("universeId", universeId),
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("gameId", gameId),
			new KeyValuePair<string, object>("playerId", playerId),
			new KeyValuePair<string, object>("sessionId", sessionId),
			new KeyValuePair<string, object>("ipAddress", ipAddress),
			new KeyValuePair<string, object>("platformId", platformId),
			new KeyValuePair<string, object>("browserTrackerId", browserTrackerId),
			new KeyValuePair<string, object>("partyId", partyId),
			new KeyValuePair<string, object>("age", age),
			new KeyValuePair<string, object>("latitude", latitude),
			new KeyValuePair<string, object>("longitude", longitude),
			new KeyValuePair<string, object>("countryId", countryId),
			new KeyValuePair<string, object>("policyCountryId", policyCountryId),
			new KeyValuePair<string, object>("joinType", joinType),
			new KeyValuePair<string, object>("playSessionFlags", (long)playSessionFlags)
		};
		return Post<PlaySession>("/v1/StartPlaySession", queryStringParameters);
	}

	public void CreateOrUpdate(long placeId, Guid gameId, byte gameCapacity, IReadOnlyCollection<IRawGameSessionModel> rawGameSessionModels, double fps, int ping, string ipAddress, int port, int gameTime, long universeId, Guid? gameCode, int matchmakingContextId, double heartbeatRate, bool isStreamingEnabled, double cpuUsage, long usedMemoryBytes, long sequenceNumber)
	{
		Dictionary<string, IEnumerable<IRawGameSessionModel>> postObject = new Dictionary<string, IEnumerable<IRawGameSessionModel>> { ["GameSessions"] = rawGameSessionModels };
		PostObjectJson("/v2/CreateOrUpdate", postObject, new KeyValuePair<string, object>[16]
		{
			new KeyValuePair<string, object>("matchmakingContextId", matchmakingContextId),
			new KeyValuePair<string, object>("ping", ping),
			new KeyValuePair<string, object>("fps", fps),
			new KeyValuePair<string, object>("gameCapacity", gameCapacity),
			new KeyValuePair<string, object>("gameCode", gameCode),
			new KeyValuePair<string, object>("gameTime", gameTime),
			new KeyValuePair<string, object>("heartbeatRate", heartbeatRate),
			new KeyValuePair<string, object>("gameId", gameId),
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("ipAddress", ipAddress),
			new KeyValuePair<string, object>("port", port),
			new KeyValuePair<string, object>("universeId", universeId),
			new KeyValuePair<string, object>("isStreamingEnabled", isStreamingEnabled),
			new KeyValuePair<string, object>("cpuUsage", cpuUsage),
			new KeyValuePair<string, object>("usedMemoryBytes", usedMemoryBytes),
			new KeyValuePair<string, object>("sequenceNumber", sequenceNumber)
		});
	}

	public IDictionary<long, int> GetPlayerCountsByTopUniverses(int maxResultsPerPartition)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("maxResultsPerPartition", maxResultsPerPartition)
		};
		return Get<Dictionary<long, int>>("/v1/GetPlayerCountsByTopUniverses", queryStringParameters);
	}

	private T GetProtobuf<T>(string actionPath, IEnumerable<(string Key, string Value)> queryParams)
	{
		IHttpRequest request = BuildHttpRequestForProtobuf<T>(actionPath, queryParams);
		IHttpResponse httpResponse = _HttpClient.Send(request);
		return ParseProtobuf<T>(httpResponse.Body);
	}

	private async Task<T> GetProtobufAsync<T>(string actionPath, IEnumerable<(string Key, string Value)> queryParams, CancellationToken cancellationToken)
	{
		IHttpRequest request = BuildHttpRequestForProtobuf<T>(actionPath, queryParams);
		return ParseProtobuf<T>((await _HttpClient.SendAsync(request, cancellationToken)).Body);
	}

	private IHttpRequest BuildHttpRequestForProtobuf<T>(string actionPath, IEnumerable<(string Key, string Value)> queryParams)
	{
		IHttpRequest httpRequest = _HttpRequestBuilder.BuildRequest(Roblox.Http.HttpMethod.Get, actionPath, queryParams);
		httpRequest.Headers.Add("Accept", "application/vnd.google.protobuf");
		return httpRequest;
	}

	private T ParseProtobuf<T>(byte[] bytes)
	{
		return Serializer.Deserialize<T>((Stream)new MemoryStream(bytes));
	}
}
