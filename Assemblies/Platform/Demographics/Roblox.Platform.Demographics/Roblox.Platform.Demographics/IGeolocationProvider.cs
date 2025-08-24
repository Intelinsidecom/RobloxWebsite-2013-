using Roblox.Platform.Membership;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Interface for a provider of <see cref="T:Roblox.Platform.Demographics.IGeolocation" />s. Clients of this interface provide an
/// IP address or user ID.
/// </summary>
public interface IGeolocationProvider
{
	/// <summary>
	/// Looks up geolocation information for a given IUser.
	/// </summary>
	/// <param name="user">IUser: User that needs to be looked up.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Demographics.IGeolocation" /> corresponding to the user.</returns>
	IGeolocation GetGeolocationByUser(IUser user);
}
