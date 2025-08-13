using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics.Entities;

/// <summary>
/// An interface for the factory producing PhoneNumberInternationalPrefixEntity
/// </summary>
internal interface IPhoneNumberInternationalPrefixEntityFactory : IDomainFactory<DemographicsDomainFactories>, IDomainObject<DemographicsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberInternationalPrefixEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberInternationalPrefixEntity" /> with the given ID, or null if none existed.</returns>
	IPhoneNumberInternationalPrefixEntity Get(short id);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberInternationalPrefixEntity" /> with the given country and international prefix
	/// </summary>
	IPhoneNumberInternationalPrefixEntity GetOrCreate(int countryId, string internationalPrefix);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberInternationalPrefixEntity" />s that are active
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	IEnumerable<IPhoneNumberInternationalPrefixEntity> GetByIsActiveEnumerative(bool isActive, int count, short? exclusiveStartPhoneNumberInternationalPrefixId);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberInternationalPrefixEntity" /> with the given country id and prefix
	/// </summary>
	IPhoneNumberInternationalPrefixEntity GetByCountryIdAndInternationalPrefix(int countryId, string internationalPrefix);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberInternationalPrefixEntity" />s by their country id
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	IEnumerable<IPhoneNumberInternationalPrefixEntity> GetByCountryIdEnumerative(int countryId, int count, short? exclusiveStartPhoneNumberInternationalPrefixId);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Demographics.Entities.IPhoneNumberInternationalPrefixEntity" /> with the given prefix and <see cref="T:Roblox.Platform.Demographics.ICountry">country</see> id.
	/// </summary>
	IPhoneNumberInternationalPrefixEntity GetByInternationalPrefixAndCountryId(string internationalPrefix, int countryId);
}
