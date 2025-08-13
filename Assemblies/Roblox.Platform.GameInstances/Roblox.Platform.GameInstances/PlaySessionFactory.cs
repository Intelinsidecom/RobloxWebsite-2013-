using System;
using Roblox.GameInstances.Client;
using Roblox.Instrumentation;

namespace Roblox.Platform.GameInstances;

public class PlaySessionFactory
{
	private readonly GameInstancesClient _Client;

	private readonly JoinTypePerformanceMonitor _JoinTypePerformanceMonitor;

	public PlaySessionFactory(GameInstancesClient client, ICounterRegistry counterRegistry)
	{
		_Client = client;
		_JoinTypePerformanceMonitor = new JoinTypePerformanceMonitor(counterRegistry);
	}

	public IPlaySession StartPlaySession(long universeId, long placeId, Guid gameId, long playerId, Guid sessionId, string ipAddress, int platformId, long browserTrackerId, Guid? partyId, double? age, double? latitude, double? longitude, int? countryId, int? policyCountryId, string joinType)
	{
		Roblox.GameInstances.Client.PlaySession clientPlaySession = _Client.StartPlaySession(universeId, placeId, gameId, playerId, sessionId, ipAddress, platformId, browserTrackerId, partyId, age, latitude, longitude, countryId, policyCountryId, joinType);
		PlaySession result = new PlaySession
		{
			Id = clientPlaySession.Id,
			Started = clientPlaySession.Started
		};
		_JoinTypePerformanceMonitor.OnPlaySessionStart(joinType);
		return result;
	}

	public bool VerifyPlaySession(long placeId, Guid gameId, long playerId, Guid sessionId)
	{
		return _Client.VerifyPlaySession(placeId, gameId, playerId, sessionId);
	}
}
