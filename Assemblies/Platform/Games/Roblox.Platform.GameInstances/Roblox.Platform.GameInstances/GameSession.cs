using System;
using Newtonsoft.Json;

namespace Roblox.Platform.GameInstances;

public class GameSession : IGameSession
{
	public Guid SessionId { get; }

	public Guid GameId { get; }

	public long PlaceId { get; }

	public string ClientIpAddress { get; }

	public byte PlatformTypeId { get; }

	public DateTime SessionStarted { get; }

	public long BrowserTrackerId { get; }

	public Guid? PartyId { get; }

	public double? Age { get; }

	public double? Latitude { get; }

	public double? Longitude { get; set; }

	public int? CountryId { get; set; }

	public int? PolicyCountryId { get; }

	public int? LanguageId { get; set; }

	public long[] BlockedPlayerIds { get; set; }

	public string JoinType { get; set; }

	public GameSession(Guid sessionId, Guid gameId, long placeId, string clientIpAddress, byte platformTypeId, DateTime sessionStarted, long browserTrackerId, Guid? partyId, double? age, double? latitude, double? longitude, int? countryId, int? languageId, long[] blockedPlayerIds, int? policyCountryId, string joinType)
	{
		SessionStarted = sessionStarted;
		PlatformTypeId = platformTypeId;
		ClientIpAddress = clientIpAddress;
		PlaceId = placeId;
		GameId = gameId;
		SessionId = sessionId;
		BrowserTrackerId = browserTrackerId;
		PartyId = partyId;
		Age = age;
		Latitude = latitude;
		Longitude = longitude;
		CountryId = countryId;
		PolicyCountryId = policyCountryId;
		LanguageId = languageId;
		BlockedPlayerIds = blockedPlayerIds;
		JoinType = joinType;
	}

	public string GetGameSessionString()
	{
		return JsonConvert.SerializeObject(this);
	}
}
