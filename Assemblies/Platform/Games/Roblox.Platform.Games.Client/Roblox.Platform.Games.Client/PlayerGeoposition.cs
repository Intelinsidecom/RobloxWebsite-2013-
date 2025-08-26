namespace Roblox.Platform.Games.Clientpublic {
    class PlayerGeoposition

{
	public double Latitude { get; }

	public double Longitude { get; }

	public int? CountryId { get; }

	public PlayerGeoposition(double latitude, double longitude, int? countryId)
	{
		Latitude = latitude;
		Longitude = longitude;
		CountryId = countryId;
	}
}


}
