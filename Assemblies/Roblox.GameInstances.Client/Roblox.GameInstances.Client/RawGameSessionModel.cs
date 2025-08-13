using System;
using Newtonsoft.Json;
using Roblox.GameInstances.Interfaces;

namespace Roblox.GameInstances.Client;

public class RawGameSessionModel : IRawGameSessionModel
{
	private class GameSessionModel
	{
		public Guid SessionId { get; set; }

		public Guid GameId { get; set; }

		public long PlaceId { get; set; }

		public string ClientIpAddress { get; set; }

		public byte PlatformTypeId { get; set; }

		public DateTime SessionStarted { get; set; }

		public long BrowserTrackerId { get; set; }

		public Guid? PartyId { get; set; }

		public double? Age { get; set; }

		public double? Latitude { get; set; }

		public double? Longitude { get; set; }

		public int? CountryId { get; set; }

		public int? PolicyCountryId { get; set; }

		public int? LanguageId { get; set; }

		public string JoinType { get; set; }

		public long PlaySessionFlags { get; set; }
	}

	private static bool _ReadDetailedBotCheckStatus;

	public long UserId { get; set; }

	public bool IsVr { get; set; }

	public double GameTimeWhenJoined { get; set; }

	public string GameSessionId { get; set; }

	public string BotCheckStatus { get; set; } = "Undefined";


	public DetailedBotCheckSignals DetailedBotCheckSignals { get; set; }

	public RawGameSessionModel(long playerId, bool isVr, double gameTimeWhenJoined, int? countryId, long placeId, Guid? partyId, int? languageId, Guid gameId, long browserTrackerId, double? age, string clientIpAddress, double? latitude, double? longitude, byte platformTypeId, Guid sessionId, DateTime sessionStarted, int? policyCountryId, PlaySessionFlags playSessionFlags, string botCheckStatus = "Undefined", DetailedBotCheckSignals detailedBotCheckSignals = null)
	{
		UserId = playerId;
		IsVr = isVr;
		GameTimeWhenJoined = gameTimeWhenJoined;
		BotCheckStatus = botCheckStatus ?? "Undefined";
		DetailedBotCheckSignals = detailedBotCheckSignals;
		GameSessionId = JsonConvert.SerializeObject(new GameSessionModel
		{
			CountryId = countryId,
			PlaceId = placeId,
			PartyId = partyId,
			LanguageId = languageId,
			GameId = gameId,
			BrowserTrackerId = browserTrackerId,
			Age = age,
			ClientIpAddress = clientIpAddress,
			Latitude = latitude,
			Longitude = longitude,
			PlatformTypeId = platformTypeId,
			SessionId = sessionId,
			SessionStarted = sessionStarted,
			PolicyCountryId = policyCountryId,
			PlaySessionFlags = (long)playSessionFlags
		});
	}
}
