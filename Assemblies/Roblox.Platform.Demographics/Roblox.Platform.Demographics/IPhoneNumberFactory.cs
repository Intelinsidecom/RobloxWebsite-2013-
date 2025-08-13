using System;
using System.Collections.Generic;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides a common interface for an object that produces <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" />s.
/// </summary>
public interface IPhoneNumberFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> by its identifier.
	/// </summary>
	/// <param name="phoneNumberId">The phone number identifier.</param>
	/// <returns>
	///     The <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> with the given identifier, or null if none existed.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="phoneNumberId" />
	/// </exception>
	IPhoneNumber Get(IPhoneNumberIdentifier phoneNumberId);

	/// <summary>
	/// Gets a collection of <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" />s by their IDs.
	/// </summary>
	ICollection<IPhoneNumber> GetPhoneNumbers(ICollection<int> phoneNumberIds);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> with the given value.
	/// </summary>
	/// <param name="phoneNumber">The phone number value.</param>
	/// <returns>
	///     The <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> with the given value.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="phoneNumber" />
	/// </exception>
	[Obsolete("Use GetOrCreate(international prefix number, national phone number, two-letter country abbreviation code)")]
	IPhoneNumber GetOrCreate(string phoneNumber);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> with the given value.
	/// </summary>
	/// <param name="internationalPrefixNumber">The international prefix portion of the full telephone number.</param>
	/// <param name="nationalPhoneNumber">The "national" part of the full telephone number.</param>
	/// <param name="countryAbbreviationCode">The two-letter code designating the country or region.</param>
	/// <returns>
	///     The <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> with the given value.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="nationalPhoneNumber" />
	/// </exception>
	IPhoneNumber GetOrCreate(string internationalPrefixNumber, string nationalPhoneNumber, string countryAbbreviationCode);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> by phone number if it exists.
	/// </summary>
	/// <param name="internationalPrefixNumber">The international prefix portion of the full telephone number.</param>
	/// <param name="nationalPhoneNumber">The "national" part of the full telephone number.</param>
	/// <param name="countryAbbreviationCode">The two-letter code designating the country or region.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> or null</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="nationalPhoneNumber" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Demographics.PlatformInvalidPhoneNumberException">
	///     If the phone is not valid
	/// </exception>
	IPhoneNumber GetByPhoneNumber(string internationalPrefixNumber, string nationalPhoneNumber, string countryAbbreviationCode);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> by phone number if it exists.
	/// </summary>
	/// <param name="phoneNumber">The phone number.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> or null</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	///     <paramref name="phoneNumber" /> was null or empty.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Demographics.PlatformInvalidPhoneNumberException">
	///     If the phone is not valid.
	/// </exception>
	IPhoneNumber GetByPhoneNumber(string phoneNumber);

	/// <summary>
	/// Gets a collection of <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> by national phone number.
	/// </summary>
	/// <param name="nationalPhoneNumber">The national phone number.</param>
	/// <param name="count">The maximum number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive start identifier.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	///     Thrown if <paramref name="count" /> is non-positive.
	///     Thrown if <paramref name="nationalPhoneNumber" /> is null or whitespace.
	/// </exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" />s.</returns>
	ICollection<IPhoneNumber> GetByNationalPhoneNumber(string nationalPhoneNumber, int count, int? exclusiveStartId = null);
}
