namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides a common interface for an object that produces <see cref="T:Roblox.Platform.Demographics.IAddress" />es.
/// </summary>
public interface IAddressFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.IAddress" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.IAddress" /> with the given ID, or null if none existed.</returns>
	IAddress Get(int id);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Demographics.IAddress" /> with the given information.
	/// </summary>
	/// <param name="line1">The first line.</param>
	/// <param name="line2">The second line.</param>
	/// <param name="city">The city.</param>
	/// <param name="stateProvince">The state province.</param>
	/// <param name="country">The identifier of the country that the address is in.</param>
	/// <param name="zipPostal">The zip code.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.IAddress" /> with the given information.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="line1" />
	///     or
	///     <paramref name="line2" />
	///     or
	///     <paramref name="city" />
	///     or
	///     <paramref name="stateProvince" />
	///     or
	///     <paramref name="country" />
	///     or
	///     <paramref name="zipPostal" />
	/// </exception>
	IAddress GetOrCreate(string line1, string line2, string city, string stateProvince, ICountryIdentifier country, string zipPostal);
}
