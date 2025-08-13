using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Games.Client;

public interface IGamesAuthority
{
	void Close(long placeId, CloseGameReasonType closeGameReasonType, int[] excludedMatchmakingContextIds = null, ReplacementConfiguration replacementConfiguration = null);

	void ClosePrivateServers(long placeId, CloseGameReasonType closeGameReasonType);

	void Close(long placeId, Guid gameId, CloseGameReasonType closeGameReasonType, int[] excludedMatchmakingContextIds = null);

	SummaryResult GetSummary();

	IDictionary<int, SummaryResult> GetSummaryByMatchmakingContextIds(int[] matchmakingContextIds);

	void Evict(long placeId, Guid gameId, long playerId);

	ReservationResult Reserve(long placeId, int placeVersion, int gameCapacity, Guid? gameCode, long universeId, int preferredPlayerCapacity, IEnumerable<long> preferredPlayerIds, int matchmakingContextId, bool isCloudEdit, IReadOnlyCollection<Player> players, int? matchmakingAlgorithmVariation, long creatorId = 0L, string creatorType = null, long? vipOwnerId = null, bool shouldLogVerboseLogs = false);

	ReservationResult ReserveSpecificGame(long placeId, int placeVersion, Guid gameId, int gameCapacity, int preferredPlayerCapacity, IReadOnlyCollection<Player> players, long creatorId = 0L, string creatorType = null, long? vipOwnerId = null);

	Task<IReadOnlyCollection<RankedServer>> GetGameServerStatsAsync(bool sortedAndRanked = false, CancellationToken cancellationToken = default(CancellationToken));

	IReadOnlyCollection<RankedServer> GetGameServerStats(bool sortedAndRanked = false, int? datacenterId = null);

	Task<IDictionary<string, ServerLastUpdateInfo>> GetLastUpdatedTimeForServersAsync(string[] serverIps, CancellationToken cancellationToken = default(CancellationToken));

	IDictionary<string, ServerLastUpdateInfo> GetLastUpdatedTimeForServers(string[] serverIps);
}
