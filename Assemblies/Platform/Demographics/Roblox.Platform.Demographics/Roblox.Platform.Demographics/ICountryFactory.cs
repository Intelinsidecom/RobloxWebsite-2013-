using System.Collections.Generic;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides a common interface for an object that produces <see cref="T:Roblox.Platform.Demographics.ICountry" />s.
/// </summary>
public interface ICountryFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.ICountry" /> by its ID.
	/// </summary>
	/// <param name="countryId">The country identifier.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.ICountry" /> with the given ID, or null if none existed.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="countryId" /></exception>
	ICountry Get(ICountryIdentifier countryId);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.ICountry" /> by its ID.
	/// </summary>
	/// <param name="countryId">The country identifier.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.ICountry" /> with the given ID, or null if none existed.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="countryId" /></exception>
	ICountry Get(int countryId);

	/// <summary>
	/// Returns all the countries that are active
	/// </summary>
	ICollection<ICountry> GetAllActive();

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.ICountry" /> by its code.
	/// </summary>
	/// <param name="code">The code.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.ICountry" /> with the given code, or null if none existed.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="code" /></exception>
	ICountry GetByCode(string code);
}
