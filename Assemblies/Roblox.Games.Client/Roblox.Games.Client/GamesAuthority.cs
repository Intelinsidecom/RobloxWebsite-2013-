using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Roblox.ApiClientBase;
using Roblox.Configuration;
using Roblox.Games.Client.Properties;

namespace Roblox.Games.Client;

public class GamesAuthority : GuardedApiClientBase, IGamesAuthority
{
	private readonly Func<string> _ApiKeyGetter;

	private readonly Func<string> _ServiceUrlGetter;

	public override Encoding Encoding => null;

	protected override string ApiKey => _ApiKeyGetter();

	protected override string Endpoint => _ServiceUrlGetter();

	public override string Name => "GamesV3";

	protected override TimeSpan Timeout => SettingsV3.Default.GamesClientTimeout;

	public GamesAuthority(Func<string> apiKeyGetter)
		: this(apiKeyGetter, () => RobloxEnvironment.GetApiEndpoint("games"))
	{
	}

	public GamesAuthority(Func<string> apiKeyGetter, Func<string> serviceUrlGetter)
	{
		_ApiKeyGetter = apiKeyGetter;
		_ServiceUrlGetter = serviceUrlGetter;
	}

	public void Close(long placeId, CloseGameReasonType closeGameReasonType, int[] excludedMatchmakingContextIds = null, ReplacementConfiguration replacementConfiguration = null)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("closeGameReasonType", closeGameReasonType)
		};
		if (replacementConfiguration != null)
		{
			list.Add(new KeyValuePair<string, object>("replaceClosedGames", true));
			list.Add(new KeyValuePair<string, object>("placeVersion", replacementConfiguration.PlaceVersion));
			list.Add(new KeyValuePair<string, object>("creatorId", replacementConfiguration.CreatorId));
			list.Add(new KeyValuePair<string, object>("creatorType", replacementConfiguration.CreatorType));
		}
		if (excludedMatchmakingContextIds != null)
		{
			list.Add(new KeyValuePair<string, object>("excludedMatchmakingContextIds", excludedMatchmakingContextIds));
		}
		Post("/v1.0/Close", list);
	}

	public void ClosePrivateServers(long placeId, CloseGameReasonType closeGameReasonType)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("closeGameReasonType", closeGameReasonType)
		};
		Post("/v1.0/ClosePrivateServers", queryStringParameters);
	}

	public void Close(long placeId, Guid gameId, CloseGameReasonType closeGameReasonType, int[] excludedMatchmakingContextIds = null)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("gameId", gameId),
			new KeyValuePair<string, object>("closeGameReasonType", closeGameReasonType)
		};
		if (excludedMatchmakingContextIds != null)
		{
			list.Add(new KeyValuePair<string, object>("excludedMatchmakingContextIds", excludedMatchmakingContextIds));
		}
		Post("/v1.0/CloseSpecificGame", list);
	}

	public SummaryResult GetSummary()
	{
		return Get<SummaryResult>("/v1.0/GetSummary");
	}

	public IDictionary<int, SummaryResult> GetSummaryByMatchmakingContextIds(int[] matchmakingContextIds)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
		if (matchmakingContextIds != null)
		{
			list.Add(new KeyValuePair<string, object>("matchmakingContextIds", matchmakingContextIds));
		}
		return Get<IDictionary<int, SummaryResult>>("/v1.0/GetSummaryByMatchmakingContextIds", list);
	}

	public void Evict(long placeId, Guid gameId, long playerId)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("gameId", gameId),
			new KeyValuePair<string, object>("playerId", playerId)
		};
		Post("/v1.0/Evict", queryStringParameters);
	}

	public ReservationResult Reserve(long placeId, int placeVersion, int gameCapacity, Guid? gameCode, long universeId, int preferredPlayerCapacity, IEnumerable<long> preferredPlayerIds, int matchmakingContextId, bool isCloudEdit, IReadOnlyCollection<Player> players, int? matchmakingAlgorithmVariation, long creatorId = 0L, string creatorType = null, long? vipOwnerId = null, bool shouldLogVerboseLogs = false)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[13]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("gameCapacity", gameCapacity),
			new KeyValuePair<string, object>("gameCode", gameCode.HasValue ? gameCode.ToString() : string.Empty),
			new KeyValuePair<string, object>("universeId", universeId),
			new KeyValuePair<string, object>("preferredPlayerCapacity", preferredPlayerCapacity),
			new KeyValuePair<string, object>("matchmakingContextId", matchmakingContextId),
			new KeyValuePair<string, object>("isCloudEdit", isCloudEdit),
			new KeyValuePair<string, object>("matchmakingVariation", matchmakingAlgorithmVariation),
			new KeyValuePair<string, object>("creatorId", creatorId),
			new KeyValuePair<string, object>("creatorType", creatorType),
			new KeyValuePair<string, object>("placeVersion", placeVersion),
			new KeyValuePair<string, object>("vipOwnerId", vipOwnerId),
			new KeyValuePair<string, object>("shouldLogVerboseLogs", shouldLogVerboseLogs)
		};
		string jsonPostData = JsonConvert.SerializeObject(new ReservePostDataModel
		{
			PreferredPlayerIds = preferredPlayerIds,
			Players = players
		});
		return PostJson<ReservationResult>("/v1.0/Reserve", queryStringParameters, null, jsonPostData);
	}

	public ReservationResult ReserveSpecificGame(long placeId, int placeVersion, Guid gameId, int gameCapacity, int preferredPlayerCapacity, IReadOnlyCollection<Player> players, long creatorId = 0L, string creatorType = null, long? vipOwnerId = null)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[8]
		{
			new KeyValuePair<string, object>("placeId", placeId),
			new KeyValuePair<string, object>("gameId", gameId),
			new KeyValuePair<string, object>("gameCapacity", gameCapacity),
			new KeyValuePair<string, object>("preferredPlayerCapacity", preferredPlayerCapacity),
			new KeyValuePair<string, object>("creatorId", creatorId),
			new KeyValuePair<string, object>("creatorType", creatorType),
			new KeyValuePair<string, object>("placeVersion", placeVersion),
			new KeyValuePair<string, object>("vipOwnerId", vipOwnerId)
		};
		string jsonPostData = JsonConvert.SerializeObject(new ReserveSpecificPostDataModel
		{
			Players = players
		});
		return PostJson<ReservationResult>("/v1.0/ReserveSpecificGame", queryStringParameters, null, jsonPostData);
	}

	public async Task<IReadOnlyCollection<RankedServer>> GetGameServerStatsAsync(bool sortedAndRanked = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("sortedAndRanked", sortedAndRanked)
		};
		return await GetAsync<IReadOnlyCollection<RankedServer>>("/v1.0/GetGameServerStats", cancellationToken, queryStringParameters).ConfigureAwait(continueOnCapturedContext: false);
	}

	public IReadOnlyCollection<RankedServer> GetGameServerStats(bool sortedAndRanked = false, int? datacenterId = null)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("sortedAndRanked", sortedAndRanked)
		};
		if (datacenterId.HasValue)
		{
			list.Add(new KeyValuePair<string, object>("datacenterId", datacenterId.Value));
		}
		return Get<IReadOnlyCollection<RankedServer>>("/v1.0/GetGameServerStats", list);
	}

	public async Task<IDictionary<string, ServerLastUpdateInfo>> GetLastUpdatedTimeForServersAsync(string[] serverIps, CancellationToken cancellationToken = default(CancellationToken))
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("serverIps", serverIps)
		};
		return await GetAsync<IDictionary<string, ServerLastUpdateInfo>>("/v1.0/GetLastUpdatedTimeForServers", cancellationToken, queryStringParameters).ConfigureAwait(continueOnCapturedContext: false);
	}

	public IDictionary<string, ServerLastUpdateInfo> GetLastUpdatedTimeForServers(string[] serverIps)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("serverIps", serverIps)
		};
		return Get<IDictionary<string, ServerLastUpdateInfo>>("/v1.0/GetLastUpdatedTimeForServers", queryStringParameters);
	}
}
