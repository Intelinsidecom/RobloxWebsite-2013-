namespace Roblox.Games.Client;

public class Player
{
	public long Id { get; }

	public double? Age { get; }

	public PlayerGeoposition GeoPosition { get; }

	public int? LanguageId { get; }

	public string IpAddress { get; }

	public int[] RoleSetIds { get; set; }

	public long[] BlockedPlayerIds { get; set; }

	public int? PolicyCountryId { get; }

	public Player(long id, double? age, PlayerGeoposition geoPosition, int? languageId, string ipAddress, int[] roleSetIds, long[] blockedPlayerIds, int? policyCountryId)
	{
		Id = id;
		Age = age;
		GeoPosition = geoPosition;
		LanguageId = languageId;
		IpAddress = ipAddress;
		RoleSetIds = roleSetIds;
		BlockedPlayerIds = blockedPlayerIds;
		PolicyCountryId = policyCountryId;
	}
}
