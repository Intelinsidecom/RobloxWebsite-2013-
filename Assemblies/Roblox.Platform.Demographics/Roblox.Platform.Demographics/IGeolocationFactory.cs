namespace Roblox.Platform.Demographics;

public interface IGeolocationFactory
{
	/// <summary>
	/// Get IGeolocation by ip address.
	/// </summary>
	/// <param name="ip">IP Address</param>
	/// <returns>IGeolocation if found or empty value of Geolocation</returns>
	IGeolocation GetGeolocation(string ip);

	/// <summary>
	/// Get geolocation by ip address. If not found, creates a new geo location entry in database.
	/// </summary>
	/// <param name="ip">IP Address</param>
	/// <returns>IGeolocation</returns>
	IGeolocation GetOrCreateGeolocation(string ip);
}
